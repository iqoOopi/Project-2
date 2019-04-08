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
    /// <summary>
    /// Hoora - March 2019
    /// a from to show suppliers and their related contacts, deleting selected contacts,
    /// and access to the forms for inserting/ updating supplier and contact objects
    /// </summary>
    public partial class SuppliersMngForm : Form
    {
        // a pre-determined Id for a newly added contact in the child form (SupplierContactEditAddForm)
        public static int addedOrEditedSupplierId = 0;
        // a pre-determined Id for a newly added supplier in the child form(SuplierInsertUpdateForm)
        public static int insertedOrUpdatedSupplierId = 0;
        private Suppliers supplier; // current supplier of the form
        public int supplierId; // the Id of the current supplier of the form


        public SuppliersMngForm()
        {
            InitializeComponent();
        }

        //when the form loads:
        private void SuppliersMngForm_Load(object sender, EventArgs e)
        {
            List<Suppliers> suppliers = new List<Suppliers>(); // make an empty supplier object
            suppliers = SuppliersDB.GetSup(); // get all suppliers from DB and save them in the empty list
            // use the ready list as the source of the binder - the binder is connected to the combo box
            suppliersBindingSource.DataSource = suppliers;
            // select the first supplier in the list as the current supplier of the form (to show its info using a method)
            supplier = suppliers[0]; 
            supplierId = supplier.SupplierId; // pick its Id as the Id of the current supplier of the form
            DisplaySupConAff(supplierId); // call a method to show the contacts of this supplier in the grid view
        }
        
        // a method to show the contacts of a supplier in the grid view by passing its Id
        private void DisplaySupConAff(int supId)
        {
            // make an empty list of ConAff (contact's info including its affiliation info) objects
            List<SupConAff> supConAff = new List<SupConAff>(); 
            supConAff = SupConAffDB.GetSupConAffs(supId); // get all contacts from DB and save them in the empty list
            // use the ready list as the source of the binder - the binder is connected to the grid view
            supConAffBindingSource.DataSource = supConAff; 
        }

        // when the user change the supplier in the combo box
        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supNameComboBox.SelectedItem != null) // check to see if something is selected or not
            {
                GetId(); // call a method to get the Id of the selected supplier
                DisplaySupConAff(supplierId); // call a method to show the contacts of this supplier in the grid view
            }
        }

        // a method to get the Id of a selected supplier from combo box
        private void GetId()
        {
            if (supNameComboBox.SelectedItem != null)  // check to see if something is selected or not
            {
                supplier = (Suppliers)supNameComboBox.SelectedItem; // get the supplier
                supplierId = supplier.SupplierId; // get its Id
            }
        }
               
        // closing the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // after clicking the delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SupplierContacts SupCon = null; // make a null contact
            // the number of selected rows in the grid view  
            int selectedRowCount = supplierContactDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            // check if any row is selected
            if (selectedRowCount > 0)
            {
                // pick the value of the first row and the second column which is Id of the contact
                int index = (int)supplierContactDataGridView.SelectedRows[0].Cells[1].Value;                
                SupCon = SupplierContactsDB.GetSupCont(index); // get the contact from DB by passing its Id
                if (SupCon != null) // if the contact could be read from DB
                {
                    // making sure if the user really wants to delete the contact
                    DialogResult result = MessageBox.Show("Do you want to delete supplier contact with Id = " + SupCon.SupplierContactId + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // if the user confirms the deletion process
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //  if the deletion was not successful because of optimistic concurrency violation
                            if (!SupplierContactsDB.DeleteSupCont(SupCon))
                            {
                                // showing an error message including the reason if the deletion was not successful-concurrency error
                                MessageBox.Show("Another user has updated or deleted that supplier contact.", "Database Error");
                            }
                            // otherwise deletion will be done automatically
                        }
                        catch (Exception ex) // there is a problem with the deletion from database
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
                        }
                    }
                }
                else // if the contact could not be read from DB
                {
                    // showing an error message including the reason if the reading from DB was not successful-concurrency error
                    MessageBox.Show("Another user has updated or deleted that supplier contact.", "Database Error");
                }
                DisplaySupConAff(supplierId); // call a method to show the contacts of the current supplier of the fomr in the grid view
            }
        }

        // after clicking the edit button (for contacts objects)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SupplierContacts SupCon = null; // make a null contact
            // the number of selected rows in the grid view  
            int selectedRowCount = supplierContactDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            // check if any row is selected
            if (selectedRowCount > 0)
            {
                // pick the value of the first row and the second column which is Id of the contact
                int index = (int)supplierContactDataGridView.SelectedRows[0].Cells[1].Value;
                SupCon = SupplierContactsDB.GetSupCont(index); // get the contact from DB by passing its Id

                // creating an object of the SupplierContactEditAddForm
                SupplierContactEditAddForm supplierEditForm = new SupplierContactEditAddForm();
                supplierEditForm.addContact = false; // put its addContact property false

                // passing the current contact to the child form (SupplierContactEditAddForm)
                supplierEditForm.supplierContact = SupCon; // send the selected contact to the child form                
                DialogResult result = supplierEditForm.ShowDialog(); // opening the form

                SupCon = supplierEditForm.supplierContact; // send the edited contact from the child form to the parent form

                supplierId = Convert.ToInt32(SupCon.SupplierId); // get its Id
            }
            DisplaySuppliers(); // call a method to load all suppliers in the combo obx
            DisplaySupConAff(supplierId); // call a method to show the contacts of this supplier in the grid view
            supNameComboBox.SelectedValue = supplierId; // set this supplier as the selected value of the combo box
        }
        

        // a method to load all suppliers in the combo obx
        private void DisplaySuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>(); // make an emty list of suppliers
            suppliers = SuppliersDB.GetSup(); // get all suppliers from DB and save them in the empty list
            suppliersBindingSource.DataSource = suppliers; // use the ready list as the source of the combo box
        }

        // after clicking the add button (for contacts objects)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // creating an object of the SupplierContactEditAddForm (child form)
            SupplierContactEditAddForm supplierAddForm = new SupplierContactEditAddForm();
            supplierAddForm.addContact = true; // put its addContact property true

            DialogResult result = supplierAddForm.ShowDialog(); // opening the form

            if(insertedOrUpdatedSupplierId != 0) // if any contact was added in the child form (its supplier Id is not zero as the default value)
            {
                DisplaySuppliers(); // call a method to load all suppliers in the combo box
                // pick the supplier of the added contact as the selected supplier in the combo box
                supNameComboBox.SelectedValue = insertedOrUpdatedSupplierId;
                DisplaySupConAff(insertedOrUpdatedSupplierId); // call a method to show the contacts of this supplier in the grid view
            }
        }

        // after clicking the update button (for suppliers objects)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // creating an object of the SuplierInsertUpdateForm
            SuplierInsertUpdateForm supplierUpdateForm = new SuplierInsertUpdateForm();
            supplierUpdateForm.addSupplier = false;  // put its addSupplier property false            
            supplierUpdateForm.supplier = supplier; // passing the current supplier to the child form (SuplierInsertUpdateForm)

            DialogResult result = supplierUpdateForm.ShowDialog(); // opening the form

            DisplaySuppliers(); // call a method to load all suppliers in the combo obx
            supplierId = supplier.SupplierId; // pick the Id of the new supplier as the Id of the current supplier of the form
            supNameComboBox.SelectedValue = supplierId; // set this supplier as the selected value of the combo box
            DisplaySupConAff(supplierId); // call a method to show the contacts of this supplier in the grid view

        }

        // after clicking the insert button (for contacts objects)
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // creating an object of the SuplierInsertUpdateForm (child form)
            SuplierInsertUpdateForm supplierInsertForm = new SuplierInsertUpdateForm();
            supplierInsertForm.addSupplier = true; // put its addSupplier property true

            DialogResult result = supplierInsertForm.ShowDialog(); // opening the form


            if (addedOrEditedSupplierId != 0) // if any supplier was added in the child form (the supplier Id is not zero as the default value)
            {
                DisplaySuppliers(); // call a method to load all suppliers in the combo box
                // pick the added supplier as the selected supplier in the combo box
                supNameComboBox.SelectedValue = addedOrEditedSupplierId;
                DisplaySupConAff(addedOrEditedSupplierId); // call a method to show the contacts of this supplier in the grid view
            }
        }
    }
}
