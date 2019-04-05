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
        public static int addedOrEditedSupplierId = 0;
        public static int insertedOrUpdatedSupplierId = 0;
        private Suppliers supplier;
        public int supplierId;


        public SuppliersMngForm()
        {
            InitializeComponent();
        }
        

        private void SuppliersMngForm_Load(object sender, EventArgs e)
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            suppliers = SuppliersDB.GetSup();
            suppliersBindingSource.DataSource = suppliers;
            supplier = suppliers[0];
            supplierId = supplier.SupplierId;
            DisplaySupConAff(supplierId);
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
            supConAffBindingSource.DataSource = supConAff;
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
                
                SupCon = SupplierContactsDB.GetSupCont(index);

                if (SupCon != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete supplier contact with Id = " + SupCon.SupplierContactId + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            if (!SupplierContactsDB.DeleteSupCont(SupCon)) // optimistic concurrency violation
                            {
                                MessageBox.Show("Another user has updated or deleted that supplier contact.", "Database Error");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Another user has updated or deleted that supplier contact.", "Database Error");
                }
                DisplaySupConAff(supplierId);
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
            }
            DisplaySuppliers();
            DisplaySupConAff(supplierId);
            supNameComboBox.SelectedValue = supplierId;
        }
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierContactEditAddForm supplierAddForm = new SupplierContactEditAddForm();
            supplierAddForm.addContact = true;

            DialogResult result = supplierAddForm.ShowDialog();

            if(addedOrEditedSupplierId != 0)
            {
                DisplaySuppliers();
                supNameComboBox.SelectedValue = addedOrEditedSupplierId;
                DisplaySupConAff(insertedOrUpdatedSupplierId);
            }
        }
               

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SuplierInsertUpdateForm supplierUpdateForm = new SuplierInsertUpdateForm();
            supplierUpdateForm.addSupplier = false;
            supplierUpdateForm.supplier = supplier;

            DialogResult result = supplierUpdateForm.ShowDialog();
            
            DisplaySuppliers();
            supplierId = supplier.SupplierId;
            supNameComboBox.SelectedValue = supplierId;
            DisplaySupConAff(supplierId);

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            SuplierInsertUpdateForm supplierInsertForm = new SuplierInsertUpdateForm();
            supplierInsertForm.addSupplier = true;

            DialogResult result = supplierInsertForm.ShowDialog();

            
            if (addedOrEditedSupplierId != 0)
            {
                DisplaySuppliers();
                supNameComboBox.SelectedValue = addedOrEditedSupplierId;
                DisplaySupConAff(addedOrEditedSupplierId);
            }

        }
    }
}
