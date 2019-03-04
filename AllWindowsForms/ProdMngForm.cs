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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            pnlDetails.Visible = true;

           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //products table
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

            //need edit products supplier table as well



            //if success saved, hide input controls
            pnlDetails.Visible = false;
        }


    }
}
