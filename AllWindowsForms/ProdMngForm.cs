using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        //hold the DB key identity, should +1 to get the new auto incremented productID before each add executed, nothing happened when delete or edit.
        //since the products list only get synced with DB once when form loaded,
        //this is required when new products are added, to calulate the productID for commit to supplier_product table without resync with DB.
        //also required in some rare situation, such as user added one new product then deleted it, need the productID to delete from DB.

         //still have bug when user add one new record, then deleted it then close the program and reopen the program. the keyidentity key won't be the same one as in DB
         //can be solved with output when excute commit. I will explain later.
        int productsDBKeyIdentity;

        //Init List of DataTransfer Object products, products_suppliers,suppliers
        List<Products> products = new List<Products>();
        Products selectedProduct;
        public ProdMngForm()
        {
            InitializeComponent();
        }

        private void ProdMngForm_Load(object sender, EventArgs e)
        {
            //data for testing
            products.Add(new Products(123, "test1"));
            products.Add(new Products(234, "test2"));



            //read from DB for products, suppliers.

            //since the products table Key:ID is auto incremental，this will get the KeyIdentity. +1 will give you the ID of next new record. 
            //as mentioned, this is not the correct method. Will use output during commit 
            productsDBKeyIdentity = products.Last().productId;
            display();
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

            txtProdName.Text = selectedProduct.prodName;
            //in order to show supplier name for selected product, need a loop search in products_supplier class 

            //show input area
            pnlDetails.Visible = true;
        }



        /// <summary>
        /// Show data input area.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            prepareForNextOperation();
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
                        //check duplication, will allow the edited product has the same name as selectedProduct
                        //this is for situation that user doesn't change anything or only changed supplier
                        if (validator.checkNoDuplicate<Products>(products, newProduct, selectedProduct))
                        {
                            //assign old productId to the edited product
                            newProduct.productId = selectedProduct.productId;
                            //update the list
                            products[selectedIndex] = newProduct;

                            //commit to products table
                            //commit to products_supplier table as well
                            success = true;
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

                            //commit to products_supplier table as well
                            //get the productID for the new added product, which is needed when commit to products_supplier table
                            //not correct, will change to output when commit
                            productsDBKeyIdentity++;

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
                prepareForNextOperation();
            }

        }

        /// <summary>
        /// clear all the input and hide the input area
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            prepareForNextOperation();
        }


        /// <summary>
        /// Clear all the input field
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
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
                prepareForNextOperation();
                return;
            }

            selectedIndex = listViewProducts.SelectedIndices[0];
            selectedProduct = products[selectedIndex];
            //remoe from DB

            products.RemoveAt(selectedIndex);
            //disable delete button to prevent false delete

            prepareForNextOperation();
 
        }

        private void display()
        {
            listViewProducts.Clear();
            //List<ListViewItem> arrayItems = new List<ListViewItem>();
            listViewProducts.Columns.Add("Name",-2,HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Supplier",-2,HorizontalAlignment.Left);
            foreach (Products prod in products)
            {
                ListViewItem item = new ListViewItem(prod.prodName);
                //
                item.SubItems.Add("supplier name go here");
                listViewProducts.Items.Add(item);
            }
            //This is to fix Microsoft's design fraud of -2 doesn't auto work on first column, it will force first column to take all space cause it won't resize when added new coloum
            //this is stupid.
            listViewProducts.Columns[0].Width = -2;
            listViewProducts.Columns[1].Width = -2;
        }

        /// <summary>
        /// clear input
        /// </summary>
        private void clearInput()
        {
            txtProdName.Text = "";
            comboBoxSupplier.Text = "";
        }

        /// <summary>
        /// prepare the button status and internal variable for next operation
        /// </summary>
        private void prepareForNextOperation()
        {
            selectedIndex = -1;//none is selected in listview
            mode = 0;//no edit,no add
            display();//refresh the display
            clearInput();//clear the textbox,combobox ************maybe need to be changed later when have supplier class
            pnlDetails.Visible = false; //hide input area
            btnDelete.Enabled = false; //disable delete button
            btnEdit.Enabled = false; //disable edit button
        }
    }
}
