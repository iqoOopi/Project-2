using ClassDB;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllWindowsForms
{
    public partial class ProdMngForm : Form
    {
        //1 for edit, 2 for add new, else do nothing. 
        int mode = 0;
        //hold the index of the selected existing product,-1 means none selected
        int selectedIndex = -1;

        //Init List of DataTransfer Object products, products_suppliers,suppliers
        List<Products> products = new List<Products>();
        Products selectedProduct;
        public ProdMngForm()
        {
            InitializeComponent();
        }

        private void ProdMngForm_Load(object sender, EventArgs e)
        {
            //load data from DB
            LoadAndDisplayData();
        }

        private void ProdMngForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //write to DB for products, suppliers, products_suppliers
        }

        /// <summary>
        /// Enable Edit button once selected 1 product from the list.
        /// </summary>
        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        /// <summary>
        /// Show Input area to edit existing data
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            mode = 1;
            //this button will only be enabled once selected 1 porudct in the list box
            //so no need to check selected or not

            selectedIndex = listViewProducts.SelectedIndices[0];
            selectedProduct = products[selectedIndex];

            //set selected product name and supplier name to textbox and combobox. 

            txtProdName.Text = selectedProduct.ProdName;
            //in order to show supplier name for selected product, need a loop search in products_supplier class 

            //show input area
            pnlDetails.Visible = true;
        }



        /// <summary>
        /// Show data input area.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PrepareForNextOperation();
            mode = 2;
            pnlDetails.Visible = true;

        }

        /// <summary>
        /// Validate new data, then commit to DB,then add to display
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = false;
            //validate input
            //Check both required field are not empty
            if (!validator.IsProvided(txtProdName, "Product Name") ||
                !validator.IsProvided(comboBoxSupplier, "Supplier"))
            {
                return;
            }


            //varchar(50), check input lenght <=50
            if (!validator.IsValidLength(txtProdName, "Product Name", 50))
            {
                return;
            }

            //since key is auto incremental, only set ID when in edit mode, leave ID to NULL when add new product 
            Products newProduct = new Products(txtProdName.Text);

            //check mode is edit or add?
            switch (mode)
            {
                case 1://edit existing record
                    {
                        //update results, 1 for success
                        int proTblUpdResult = 0;
                        int prod_supTblUpdResult = 0;
                       
                        //check duplication, will allow the edited product has the same name as selectedProduct
                        //this is for situation that user doesn't change anything or only changed supplier
                        if (validator.checkNoDuplicate<Products>(products, newProduct, selectedProduct))
                        {
                            //assign old productId to the edited product
                            newProduct.ProductId = selectedProduct.ProductId;

                            //since we gonna update 2 tables, use transcation here
                            using (SqlConnection connection = TravelExpertDB.GetConnection())
                            {
                                connection.Open();
                                SqlTransaction transaction = connection.BeginTransaction();
                                try
                                {
                                    //update products table
                                    proTblUpdResult = GenericDB.GenericUpdate<Products>("Products", selectedProduct, newProduct, connection, transaction);
                                    //update products_supplier table as well
                                    prod_supTblUpdResult = 1;//setting for test updating products table
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    transaction.Rollback();
                                }
                                
                                //if both update are succeed, commit the change otherwise rollback
                                if(prod_supTblUpdResult==1 && proTblUpdResult==1)
                                {
                                    transaction.Commit();
                                    success = true;
                                }
                                else
                                {
                                    transaction.Rollback();
                                }
                                
                            }

                            //update the list
                            LoadAndDisplayData();
                            
                        }

                        break;
                    }
                case 2://add new record.
                    {
                        //check duplication, new product can not have the same name as existing products
                        if (validator.checkNoDuplicate<Products>(products, newProduct))
                        {
                            
                            //add new product to list                 
                            products.Add(newProduct);
                            
                            //commit to products table

                            success = true;

                        }
                        break;
                    }
                default:
                    break;
            }

            if (success)
            {
                //if success saved to DB,then refresh the display and hide input area
                PrepareForNextOperation();
            }

        }

        /// <summary>
        /// clear all the input and hide the input area
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            PrepareForNextOperation();
        }


        /// <summary>
        /// Clear all the input field
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        /// <summary>
        /// Delete seleted product record.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ask for confirmation before delete
            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                //if no, clear selection and prepare for next operation
                PrepareForNextOperation();
                return;
            }

            selectedIndex = listViewProducts.SelectedIndices[0];
            selectedProduct = products[selectedIndex];
            //remoe from DB

            products.RemoveAt(selectedIndex);
            //disable delete button to prevent false delete

            PrepareForNextOperation();
 
        }


        /// <summary>
        /// clear input
        /// </summary>
        private void ClearInput()
        {
            txtProdName.Text = "";
            comboBoxSupplier.Text = "";
        }

        /// <summary>
        /// prepare the button status and internal variable for next operation
        /// </summary>
        private void PrepareForNextOperation()
        {
            selectedIndex = -1;//none is selected in listview
            mode = 0;//no edit,no add
            Display();//refresh the display
            ClearInput();//clear the textbox,combobox ************maybe need to be changed later when have supplier class
            pnlDetails.Visible = false; //hide input area
            btnDelete.Enabled = false; //disable delete button
            btnEdit.Enabled = false; //disable edit button
        }

        private void LoadAndDisplayData()
        {
            //load data from DB
            products = GenericDB.GenericRead<Products>("Products");

            //load listview to show the data
            Display();
        }


        private void Display()
        {
            listViewProducts.Clear();
            //List<ListViewItem> arrayItems = new List<ListViewItem>();
            listViewProducts.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Supplier", -2, HorizontalAlignment.Left);
            foreach (Products prod in products)
            {
                ListViewItem item = new ListViewItem(prod.ProdName);
                //
                item.SubItems.Add("supplier name go here");
                listViewProducts.Items.Add(item);
            }
            //This is to fix Microsoft's design fraud of -2 doesn't auto work on first column, it will force first column to take all space cause it won't resize when added new coloum
            //this is stupid.
            listViewProducts.Columns[0].Width = -2;
            listViewProducts.Columns[1].Width = -2;
        }
    }
}
