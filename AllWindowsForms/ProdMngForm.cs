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
        //1 for edit, 2 for add new. 
        int mode = 0;
        //hold the index of the existing product,-1 means none selected
        int selectedIndex=-1;
        //Init List of DataTransfer Object products, products_suppliers,suppliers
        List<Products> products = new List<Products>();
        public ProdMngForm()
        {
            InitializeComponent();
        }

        private void ProdMngForm_Load(object sender, EventArgs e)
        {
            //read from DB for products, suppliers.

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

            //set selected product name and supplier name to textbox and combobox. 

            txtProdName.Text = products[selectedIndex].prodName;
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
            //validate input
            //Check both required field are not empty
            if (!validator.IsProvided(txtProdName, "Product Name")||
                !validator.IsProvided(comboBoxSupplier,"Supplier"))
            {
                return;
            }


            //varchar(50), check input lenght <=50
            if(!validator.IsValidLength(txtProdName,"Product Name", 50))
            {
                return;
            }

            Products product = new Products(txtProdName.Text);
            //check mode is edit or add?
            switch (mode)
            {
                case 1://edit existing record
                    {
                        break;
                    }
                case 2://add new record.
                    {
                        break;
                    }
                default:
                    break;
            }
            //check duplication depends on different mode

            //commit to products table
            

            //commit to products_supplier table as well



            //if success saved to DB,then add to display then hide input area

            pnlDetails.Visible = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedIndex = listViewProducts.SelectedIndices[0];
        }
    }
}
