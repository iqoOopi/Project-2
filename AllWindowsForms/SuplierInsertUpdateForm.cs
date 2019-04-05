using ClassDB;
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
    public partial class SuplierInsertUpdateForm : Form
    {
        public bool addSupplier; // indicates whether it is Add or Edit
        public Suppliers supplier;


        public SuplierInsertUpdateForm()
        {
            InitializeComponent();
        }


        private void SuplierInsertUpdateForm_Load(object sender, EventArgs e)
        {
            if (addSupplier)
            {
                this.Text = "Add Supplier";
            }
            else
            {
                this.Text = "Edit Supplier";
                this.DisplaySupplier();
            }
        }


        private void DisplaySupplier()
        {
            if (supplier.SupName == null)
                txtSupName.Text = "";
            else
                txtSupName.Text = supplier.SupName;
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addSupplier)
            {
                Suppliers supplier = new Suppliers();
                this.PutSupData(supplier);
                try
                {
                    supplier.SupplierId = SuppliersDB.InsertSupplier(supplier);
                    SuppliersMngForm.addedOrEditedSupplierId = supplier.SupplierId;

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else // modify
            {
                Suppliers newsupplier = new Suppliers();
                newsupplier.SupplierId = supplier.SupplierId;
                PutSupData(newsupplier);
                try
                {
                    if (SuppliersDB.UpdateSuplier(supplier, newsupplier) == 0)
                    {
                        MessageBox.Show("Another user has updated or deleted that supplier.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else // successfully updated
                    {
                        supplier = newsupplier;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }


        private void PutSupData(Suppliers supplier)
        {
            if (txtSupName.Text == "")
                supplier.SupName = null;
            else
                supplier.SupName = txtSupName.Text;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
