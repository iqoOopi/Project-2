﻿using ClassLibrary;
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
        //1 for edit, 2 for add new. 
        int mode = 0;
        //hold the index of the existing product,-1 means none selected
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
            //read from DB for products, suppliers.

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
            mode = 1;
            //this button will be enabled once selected 1 porudct in the list box
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
                            products[selectedIndex] = newProduct;
                            success = true;
                        }

                        break;
                    }
                case 2://add new record.
                    {
                        //check duplication, new product can not have the same name as existing products
                        if (validator.checkNoDuplicate<Products>(products, newProduct))
                        {
                            products.Add(newProduct);
                            success = true;
                        }
                        break;
                    }
                default:
                    break;
            }

            if (success)
            {
                //commit to products table
                //commit to products_supplier table as well

                //if success saved to DB,then add to display and hide input area
                display();
                clearInput();
                pnlDetails.Visible = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }

        }

        /// <summary>
        /// clear all the input and hide the input area
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearInput();
            pnlDetails.Visible = false;
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
            selectedIndex = listViewProducts.SelectedIndices[0];
            products.RemoveAt(selectedIndex);
            //disable delete button to prevent false delete
            btnDelete.Enabled = false;
            //update display
            display();
        }

        private void display()
        {
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
            //This is to fix Microsoft's bug of -2 doesn't auto work on first column, it will force first column to take all space cause it won't resize when added new coloum
            //this is stupid.
            listViewProducts.Columns[0].Width = -2;


        }
    }
}
