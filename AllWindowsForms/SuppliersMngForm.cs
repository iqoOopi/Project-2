using ClassDB;
using ClassLibary;
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
    public partial class SuppliersMngForm : Form
    {
        public Suppliers supplier;
        public int supplierId;
        // string affiliationId;


        public SuppliersMngForm()
        {
            InitializeComponent();
        }



        private void SuppliersMngForm_Load(object sender, EventArgs e)
        {
            DisplaySuppliers();
            supplierId = 69; ////////////////////////////////////////////////******************************************************
            DisplaySupConAff(supplierId);
            //affiliationId = "ACTAPGY";
            //DisplayAffiliation(affiliationId);
        }



        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supNameComboBox.SelectedItem != null)
            {
                GetId();
                DisplaySupConAff(supplierId);
            }
        }



        private void GetId()
        {
            if (supNameComboBox.SelectedItem != null)
            {
                supplier = (Suppliers)supNameComboBox.SelectedItem;
                supplierId = supplier.SupplierId;
            }
        }



        //private void DisplayAffiliation(string affiliationId)
        //{
        //    Affiliations affiliation = new Affiliations();
        //    AffiliationsDB.GetAff(affiliationId);
        //    affiliationsBindingSource.DataSource = affiliation;
        //}



        private void DisplaySupConAff(int supId)
        {
            List<SupConAff> supConAff = new List<SupConAff>();
            supConAff = SupConAffDB.GetSupConAffs(supId);
            supplierContactDataGridView.DataSource = supConAff;
            //supplierContactsBindingSource.DataSource = supConAff;
        }



        private void DisplaySuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            suppliers = SuppliersDB.GetSup();
            suppliersBindingSource.DataSource = suppliers;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SupplierContacts SupCon = null;
            int selectedRowCount = supplierContactDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);


            if (selectedRowCount > 0)
            {
                int index = (int)supplierContactDataGridView.SelectedRows[0].Cells[1].Value;
                //System.Console.WriteLine("Index: " + index);
                SupCon = SupplierContactsDB.GetSupCont(index);


                DialogResult result = MessageBox.Show("Do you want to delete supplier contact with Id = " + SupCon.SupplierContactId + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!SupplierContactsDB.DeleteSupCont(SupCon)) // optimistic concurrency violation
                        {
                            MessageBox.Show("Another user has updated or deleted that supplier contact.", "Database Error");

                            DisplaySupConAff(supplierId);
                        }
                        DisplaySupConAff(supplierId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            SupplierContacts SupCon = null;
            int selectedRowCount = supplierContactDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);


            if (selectedRowCount > 0)
            {
                int index = (int)supplierContactDataGridView.SelectedRows[0].Cells[1].Value;
                //System.Console.WriteLine("Index: " + index);
                SupCon = SupplierContactsDB.GetSupCont(index);

                //supplierContact = null;

                // creating an object of the form
                SupplierEditAddForm supplierEditForm = new SupplierEditAddForm();
                supplierEditForm.addContact = false;
                // passing the current contact to the second form
                supplierEditForm.supplierContact = SupCon;
                // opening the form
                DialogResult result = supplierEditForm.ShowDialog();

                // setting up the first form to show the proper data
                DisplaySuppliers();
                supplierId = 69; ////////////////////////////////////////////////******************************************************
                DisplaySupConAff(supplierId);
            }
        }
        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierEditAddForm supplierAddForm = new SupplierEditAddForm();
            supplierAddForm.addContact = true;

            DialogResult result = supplierAddForm.ShowDialog();

            DisplaySuppliers();
            supplierId = 69;
            DisplaySupConAff(supplierId);
        }
    }
}
