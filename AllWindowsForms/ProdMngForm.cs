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

        //Init List of DataTransfer Object products, products_suppliers
        List<Products> products = new List<Products>();
        List<ProductsSuppliers> allProductsSuppliers = new List<ProductsSuppliers>();
        List<ProductsSuppliers> relatedProductsSuppliers;
        List<Suppliers> allSuppliers = new List<Suppliers>();
        List<Suppliers> relatedSuppliers;
        Products selectedProduct;//user selected product also be used as oldProduct when update
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
            relatedProductsSuppliers = new List<ProductsSuppliers>();//reset the list
            relatedSuppliers = new List<Suppliers>();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            //check selection and display related supplier info.
            if (listViewProducts.SelectedItems.Count > 0)
            {
                selectedIndex = listViewProducts.SelectedIndices[0];
                selectedProduct = products[selectedIndex];
                int selectedProductId = selectedProduct.ProductId;
                foreach (ProductsSuppliers prodSup in allProductsSuppliers)
                {
                    if (selectedProductId == prodSup.ProductId)
                    {
                        relatedProductsSuppliers.Add(prodSup);
                    }
                }
                productsSuppliersDataGridView.DataSource = relatedProductsSuppliers;
                foreach (DataGridViewRow row in productsSuppliersDataGridView.Rows)
                {
                   int id= (int)row.Cells["SupplierId"].Value;
                    foreach  (Suppliers item in allSuppliers)
                    {
                        if (item.SupplierId==id)
                        {
                            row.Cells["SupplierName"].Value = item.SupName;
                            relatedSuppliers.Add(item);
                        }
                    }
                    
                }
            }
        }

        /// <summary>
        /// Show Input area to edit existing data
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            mode = 1;

            
           

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
            if (!validator.IsProvided(txtProdName, "Product Name"))
                
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
                        //check duplication, will allow the edited product has the same name as selectedProduct
                        //this is for situation that user doesn't change anything or only changed supplier
                        if (validator.checkNoDuplicate<Products>(products, newProduct, selectedProduct))
                        {
                            //assign old productId to the edited product
                            newProduct.ProductId = selectedProduct.ProductId;
                            //update DB
                            try
                            {
                                //execute the query and get result
                                int result = GenericDB.GenericUpdate<Products>("Products", selectedProduct, newProduct);
                                if (result==1)
                                {
                                    success = true;
                                }
                                else
                                {
                                    MessageBox.Show("Data has been changed during your editing, please try again!");
                                } 
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                                                  
                        }

                        break;
                    }
                case 2://add new record.
                    {
                        //check duplication, new product can not have the same name as existing products
                        if (validator.checkNoDuplicate<Products>(products, newProduct))
                        {
                            //commit to products table
                            try
                            {
                                int result=GenericDB.GenericInsert<Products>("Products", newProduct);
                                if (result > 0)
                                {
                                    success = true;
                                }
                                else
                                {
                                    MessageBox.Show("Other users ");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        break;
                    }
                default:
                    break;
            }

            //update the list
            LoadAndDisplayData();
            //reset the input
            if (success)
            {
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

            //remoe from DB
            try
            {
                //might code to a way that it can delete all the related supplier 
                GenericDB.GenericDelete<Products>("Products", selectedProduct);
            }
            catch
            {
                MessageBox.Show("The record has been modified or deleted already, please try agian!");
            }
            

            LoadAndDisplayData();
            //disable delete button to prevent false delete
            PrepareForNextOperation();
 
        }


        /// <summary>
        /// clear input
        /// </summary>
        private void ClearInput()
        {
            txtProdName.Text = "";
        }

        /// <summary>
        /// prepare the button status and internal variable for next operation
        /// </summary>
        private void PrepareForNextOperation()
        {
            selectedIndex = -1;//none is selected in listview
            mode = 0;//no edit,no add
            ClearInput();//clear the textbox,combobox ************maybe need to be changed later when have supplier class
            pnlDetails.Visible = false; //hide input area
            btnDelete.Enabled = false; //disable delete button
            btnEdit.Enabled = false; //disable edit button
        }

        private void LoadAndDisplayData()
        {
            //load data from DB
            products = GenericDB.GenericRead<Products>("Products");
            allProductsSuppliers = GenericDB.GenericRead<ProductsSuppliers>("Products_Suppliers");
            allSuppliers = GenericDB.GenericRead<Suppliers>("Suppliers");
            //load listview to show the data
            Display();
        }


        private void Display()
        {
            listViewProducts.Clear();
            //List<ListViewItem> arrayItems = new List<ListViewItem>();
            listViewProducts.Columns.Add("Product Name:", -2, HorizontalAlignment.Left);
            foreach (Products prod in products)
            {
                ListViewItem item = new ListViewItem(prod.ProdName);
                listViewProducts.Items.Add(item);
            }
            listViewProducts.Columns[0].Width = listViewProducts.Width- SystemInformation.VerticalScrollBarWidth-4;
        }



        //----------------------------------------------------------------------------------------------------
        //below is right side of the form for changing related suppliers
        Suppliers selectedSuppliers;
        ProductsSuppliers selectedProdSup;
        int supMode = 0;//1 for edit, 2 for add
        private void productsSuppliersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SupPrepareForNextOperation();
            btnSupEdit.Enabled = true;
            btnSupDel.Enabled = true;
            comboxSup.DataSource = allSuppliers;
            if(productsSuppliersDataGridView.SelectedRows.Count>0)
            {
                int index = productsSuppliersDataGridView.SelectedRows[0].Index;
                if (relatedSuppliers.Count > 0)
                {
                    selectedSuppliers = relatedSuppliers[index];
                    selectedProdSup = relatedProductsSuppliers[index];
                }
             
            }
        }

        private void btnSupEdit_Click(object sender, EventArgs e)
        {
            pnlSupInfo.Visible = true;
            supMode = 1;
            comboxSup.SelectedValue = selectedSuppliers.SupplierId;
        }


        private void SupPrepareForNextOperation()
        {
            supMode = 0;//no edit,no add
            pnlSupInfo.Visible = false;
        }

        private void btnSupDel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                //if no, clear selection and prepare for next operation
                SupPrepareForNextOperation();
                return;
            }
            try
            {
                GenericDB.GenericDelete("Products_Suppliers", selectedProdSup);
                LoadAndDisplayData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupAdd_Click(object sender, EventArgs e)
        {
            pnlSupInfo.Visible = true;
            supMode = 2;
        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {
            bool success = false;
            switch (supMode)
            {
                case 1:// in edit
                    {

                        break;
                    }
                case 2://in add
                    {
                        ProductsSuppliers temProdSup = new ProductsSuppliers(); 
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
