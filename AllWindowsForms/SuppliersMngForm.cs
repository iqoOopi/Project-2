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
        public static int addOrEditedSupplierId;
        private Suppliers supplier;
        public int supplierId;
        // string affiliationId;


        public SuppliersMngForm()
        {
            InitializeComponent();
        }
        

        private void SuppliersMngForm_Load(object sender, EventArgs e)
        {
            FirstDisplaySuppliers();
            DisplaySupConAff(supplierId);
        }


        private void FirstDisplaySuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            suppliers = SuppliersDB.GetSup();
            supplierId = suppliers[0].SupplierId;
            supplier = suppliers[0];
            suppliersBindingSource.DataSource = suppliers;
        }


        private void DisplaySuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            suppliers = SuppliersDB.GetSup();
            suppliersBindingSource.DataSource = suppliers;
        }


        private void DisplaySupConAff(int supId)
        {
            List<SupConAff> supConAff = new List<SupConAff>();
            supConAff = SupConAffDB.GetSupConAffs(supId);
            supplierContactDataGridView.DataSource = supConAff;
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
                SupCon = SupplierContactsDB.GetSupCont(index);
                
                // creating an object of the form
                SupplierContactEditAddForm supplierEditForm = new SupplierContactEditAddForm();
                supplierEditForm.addContact = false;
                // passing the current contact to the second form
                supplierEditForm.supplierContact = SupCon;
                // opening the form
                DialogResult result = supplierEditForm.ShowDialog();

                SupCon = supplierEditForm.supplierContact;

                supplierId = Convert.ToInt32(SupCon.SupplierId);

                DisplaySupConAff(supplierId);
                DisplaySuppliers();
            }
        }
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierContactEditAddForm supplierAddForm = new SupplierContactEditAddForm();
            supplierAddForm.addContact = true;

            DialogResult result = supplierAddForm.ShowDialog();

            supplierId = Convert.ToInt32(supplierAddForm.supplierContact.SupplierId);
            DisplaySuppliers();
            //supNameComboBox.SelectedValue = sup; // *************************** how to change the selected value in the main form after adding an itme
            DisplaySupConAff(supplierId);
        }
               

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SuplierInsertUpdateForm supplierUpdateForm = new SuplierInsertUpdateForm();
            supplierUpdateForm.addSupplier = false;
            supplierUpdateForm.supplier = supplier;

            DialogResult result = supplierUpdateForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.supplier = null;
                this.supplier = supplierUpdateForm.supplier;
                supplierId = supplier.SupplierId;
                                
                DisplaySupConAff(supplierId);

                DisplaySuppliers();
            }
            else if (result == DialogResult.Retry)
            {
                DisplaySuppliers();
                DisplaySupConAff(supplierId);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            SuplierInsertUpdateForm supplierInsertForm = new SuplierInsertUpdateForm();
            supplierInsertForm.addSupplier = true;

            DialogResult result = supplierInsertForm.ShowDialog();

            //this.supplier = supplierInsertForm.supplier;

            FirstDisplaySuppliers();
            supNameComboBox.SelectedValue = addOrEditedSupplierId;
            //supNameComboBox.SelectedValue = supplier.SupplierId;
            // *************************** how to change the selected value in the main form after adding an itme

            DisplaySuppliers();
            DisplaySupConAff(supplierId);

        }
    }
}
