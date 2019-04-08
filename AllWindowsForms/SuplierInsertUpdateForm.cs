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
    /// <summary>
    /// Hoora - April 2019
    /// a from to insert or update supplier objects
    /// </summary>
    
    public partial class SuplierInsertUpdateForm : Form
    {
        public bool addSupplier; // indicates whether the action is Insert or Update
        public Suppliers supplier; // the inserted or updated supplier in the form


        public SuplierInsertUpdateForm()
        {
            InitializeComponent();
        }


        //when the form loads:
        private void SuplierInsertUpdateForm_Load(object sender, EventArgs e)
        {
            if (addSupplier) // if the action is adding a new supplier
            {
                this.Text = "Add Supplier"; // give a proper title to the form's window based on the action
            }
            else
            {
                this.Text = "Edit Supplier"; // give a proper title to the form's window based on the action
                this.DisplaySupplier(); // if the purpose is to update an existing supplier, show it in the window
            }
        }


        // a method to show the values for the supplier's properties:
        private void DisplaySupplier() 
        {
            if (supplier.SupName == null) // the name property of a supplier is nullable 
                txtSupName.Text = ""; // if it is null, leave its text box empty
            else
                txtSupName.Text = supplier.SupName; // otherwise, show its value in the text box
        }


        // after clicking the accept button
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addSupplier) // if the action is insertion a new supplier
            {
                Suppliers supplier = new Suppliers(); // make an empty supplier object
                this.PutSupData(supplier); // call the method to get the inserted data from the text box and use it for the supplier object

                try
                {
                    // call a DB function to insert the supplier to the DB
                    supplier.SupplierId = SuppliersDB.InsertSupplier(supplier);
                    // send the Id of the newly added supplier to the main form
                    SuppliersMngForm.addedOrEditedSupplierId = supplier.SupplierId; 

                    this.DialogResult = DialogResult.OK; // the result of the dialog box for this action is OK
                }
                catch (Exception ex) // there is a problem with the data insertion
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
                }
            }
            else // if the action is updating a supplier
            {
                Suppliers newsupplier = new Suppliers(); // make an empty supplier object
                newsupplier.SupplierId = supplier.SupplierId; // keep the Id of the supplier even after editing it
                PutSupData(newsupplier); // call the method to get the changed data from the text box and use it for editing the supplier

                try
                {
                    if (SuppliersDB.UpdateSuplier(supplier, newsupplier) == 0) // call the update function and check if it was successful
                    {
                        // showing an error message including the reason if the update was not successful-concurrency error
                        MessageBox.Show("Another user has updated or deleted that supplier.", "Database Error");
                        this.DialogResult = DialogResult.Retry; // the result of the dialog box for this action is retry
                    }
                    else // if it was successfully updated
                    {
                        supplier = newsupplier; // replace the new supplier with the old one (the public object of this form)
                        this.DialogResult = DialogResult.OK; // the result of the dialog box for this action is OK
                    }
                }
                catch (Exception ex) // there is a problem with the data update in database
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
                }
            }
        }


        // a method to get the inserted data from the text box and use it for a supplier object
        private void PutSupData(Suppliers supplier)
        {
            if (txtSupName.Text == "") // if nothing is provided by the user
                supplier.SupName = null;
            else
                supplier.SupName = txtSupName.Text; // if user provided the name
        }


        // if the user cancels the process of editing or inserting
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
