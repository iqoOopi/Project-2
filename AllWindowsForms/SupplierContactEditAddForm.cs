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
    /// a from to add or edit supplier contact objects
    /// </summary>
    
    public partial class SupplierContactEditAddForm : Form
    {
        public SupplierContacts supplierContact; // the added or edited supplier contact in the form
        public bool addContact; // indicates whether the action is Add or Edit
        
        public SupplierContactEditAddForm()
        {
            InitializeComponent();
        }


        //when the form loads:
        private void SupplierEditAddForm_Load(object sender, EventArgs e)
        {
            this.LoadAffCmb(); // load the affiliation combo box
            this.LoadSupCmb(); // load the supplier combo box

            if (addContact) // if the action is adding a new supplier contact
            {
                this.Text = "Add Contact"; // give a proper title to the form's window based on the action
                // if it is adding, no affiliation is still assigned to the the contact
                cmbAffiliationID.SelectedIndex = -1;
                // if it is adding, no supplier is still assigned to the the contact
                cmbSupplierId.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Edit Contact"; // give a proper title to the form's window based on the action
                this.DisplayContact(); // if the purpose is to edit an existing contact, show it in the window
            }
        }


        // a method to show the values for the contact's properties:
        private void DisplayContact() 
        {
            if (supplierContact.SupConFirstName == null) // the first name property of a contact is nullable 
                txtSupConFirstName.Text = ""; // if it is null, leave its text box empty
            else
                txtSupConFirstName.Text = supplierContact.SupConFirstName; // otherwise, show its value in the text box

            if (supplierContact.SupConLastName == null)
                txtSupConLastName.Text = "";
            else
                txtSupConLastName.Text = supplierContact.SupConLastName;

            if (supplierContact.SupConCompany == null)
                txtSupConCompany.Text = "";
            else
                txtSupConCompany.Text = supplierContact.SupConCompany;

            if (supplierContact.SupConAddress == null)
                txtSupConAddress.Text = "";
            else
                txtSupConAddress.Text = supplierContact.SupConAddress;

            if (supplierContact.SupConCity == null)
                txtSupConCity.Text = "";
            else
                txtSupConCity.Text = supplierContact.SupConCity;

            if (supplierContact.SupConProv == null)
                txtSupConProv.Text = "";
            else
                txtSupConProv.Text = supplierContact.SupConProv;

            if (supplierContact.SupConPostal == null)
                txtSupConPostal.Text = "";
            else
                txtSupConPostal.Text = supplierContact.SupConPostal;

            if (supplierContact.SupConCountry == null)
                txtSupConCountry.Text = "";
            else
                txtSupConCountry.Text = supplierContact.SupConCountry;

            if (supplierContact.SupConBusPhone == null)
                txtSupConBusPhone.Text = "";
            else
                txtSupConBusPhone.Text = supplierContact.SupConBusPhone;

            if (supplierContact.SupConFax == null)
                txtSupConFax.Text = "";
            else
                txtSupConFax.Text = supplierContact.SupConFax;

            if (supplierContact.SupConEmail == null)
                txtSupConEmail.Text = "";
            else
                txtSupConEmail.Text = supplierContact.SupConEmail;

            if (supplierContact.SupConURL == null)
                txtSupConURL.Text = "";
            else
                txtSupConURL.Text = supplierContact.SupConURL;

            if (supplierContact.AffiliationID == null) // the affiliation ID property of a contact is nullable 
                cmbAffiliationID.SelectedItem = null; // if it is null, leave its combo box unselected
            else
                cmbAffiliationID.SelectedValue = supplierContact.AffiliationID; // otherwise, show its value in the combo box

            if (supplierContact.SupplierId == null)
                cmbSupplierId.SelectedItem = null;
            else
                cmbSupplierId.SelectedValue = supplierContact.SupplierId;
        }


        // a method to load the supplier list in its combo box
        private void LoadSupCmb()
        {
            List<Suppliers> suppliers = new List<Suppliers>(); // make an emty list of suppliers
            try
            {
                suppliers = SuppliersDB.GetSup(); // get all suppliers from DB and save them in the empty list
                cmbSupplierId.DataSource = suppliers; // use the ready list as the source of the combo box
                cmbSupplierId.DisplayMember = "SupplierName"; // display members of the combo box are the names
                cmbSupplierId.ValueMember = "SupplierId"; // and value members of the combo box are the IDs
            }
            catch (Exception ex) // there is a problem with the data reading
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
            }
        }


        // a method to load the affiliation list in its combo box
        private void LoadAffCmb()
        {
            List<Affiliations> affiliations = new List<Affiliations>(); // make an emty list of affiliations
            try
            {
                affiliations = AffiliationsDB.GetAffs(); // get all affiliations from DB and save them in the empty list
                cmbAffiliationID.DataSource = affiliations; // use the ready list as the source of the combo box
                cmbAffiliationID.DisplayMember = "AffiliationName"; // display members of the combo box are the names
                cmbAffiliationID.ValueMember = "AffiliationId"; // and value members of the combo box are the IDs
            }
            catch (Exception ex) // there is a problem with the data reading
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
            }
        }


        // after clicking the accept button
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addContact) // if the action is insertion a new contact
            {
                supplierContact = new SupplierContacts(); // make an empty contact object
                // call the method to get the added data from the text box and use it for the contact object
                this.PutContactData(supplierContact);

                try
                {
                    // call a DB function to insert the supplier contact to the DB
                    supplierContact.SupplierContactId = SupplierContactsDB.AddContact(supplierContact);
                    // send the Id of the newly added contact to the main form
                    SuppliersMngForm.insertedOrUpdatedSupplierId = Convert.ToInt32(supplierContact.SupplierId);
                    this.DialogResult = DialogResult.OK; // the result of the dialog box for this action is OK
                }
                catch (Exception ex) // there is a problem with the data insertion
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
                }
            }
            else // if the action is updating a contact
            {
                SupplierContacts newSupplierContact = new SupplierContacts(); // make an empty contact object
                 // keep the Id of the contact even after editing it
                newSupplierContact.SupplierContactId = supplierContact.SupplierContactId;
                // call the method to get the changed data from the text box and use it for editing the contact
                this.PutContactData(newSupplierContact);

                try
                {
                    // call the update function and check if it was successful
                    if (SupplierContactsDB.UpdateContact(supplierContact, newSupplierContact) == 0)
                    {
                        // showing an error message including the reason if the update was not successful-concurrency error
                        MessageBox.Show("Another user has updated or deleted that contact.", "Database Error");
                        this.DialogResult = DialogResult.Retry; // the result of the dialog box for this action is retry
                    }
                    else // if it was successfully updated
                    {
                        supplierContact = newSupplierContact; // replace the new contact with the old one (the public object of this form)
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex) // there is a problem with the data update in database
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString()); // showing an error message including the reason
                }
            }
        }


        // a method to get the inserted data from the text box and use it for a contact object
        private void PutContactData(SupplierContacts supplierContact)
        {
            if (txtSupConFirstName.Text == "") // if nothing is provided by the user
                supplierContact.SupConFirstName = null;
            else 
                supplierContact.SupConFirstName = txtSupConFirstName.Text; // if user provided the name

            if (txtSupConLastName.Text == "")
                supplierContact.SupConLastName = null;
            else
                supplierContact.SupConLastName = txtSupConLastName.Text;

            if (txtSupConCompany.Text == "")
                supplierContact.SupConCompany = null;
            else
                supplierContact.SupConCompany = txtSupConCompany.Text;

            if (txtSupConAddress.Text == "")
                supplierContact.SupConAddress = null;
            else
                supplierContact.SupConAddress = txtSupConAddress.Text;

            if (txtSupConCity.Text == "")
                supplierContact.SupConCity = null;
            else
                supplierContact.SupConCity = txtSupConCity.Text;

            if (txtSupConProv.Text == "")
                supplierContact.SupConProv = null;
            else
                supplierContact.SupConProv = txtSupConProv.Text;

            if (txtSupConPostal.Text == "")
                supplierContact.SupConPostal = null;
            else
                supplierContact.SupConPostal = txtSupConPostal.Text;

            if (txtSupConCountry.Text == "")
                supplierContact.SupConCountry = null;
            else
                supplierContact.SupConCountry = txtSupConCountry.Text;

            if (txtSupConBusPhone.Text == "")
                supplierContact.SupConBusPhone = null;
            else
                supplierContact.SupConBusPhone = txtSupConBusPhone.Text;

            if (txtSupConFax.Text == "")
                supplierContact.SupConFax = null;
            else
                supplierContact.SupConFax = txtSupConFax.Text;

            if (txtSupConEmail.Text == "")
                supplierContact.SupConEmail = null;
            else
                supplierContact.SupConEmail = txtSupConEmail.Text;

            if (txtSupConURL.Text == "")
                supplierContact.SupConURL = null;
            else
                supplierContact.SupConURL = txtSupConURL.Text;

            if (cmbAffiliationID.SelectedItem == null)
                supplierContact.AffiliationID = null;
            else
                supplierContact.AffiliationID = cmbAffiliationID.SelectedValue.ToString();
                        
            if (cmbSupplierId.SelectedItem == null) // if nothing is selected by the user
                supplierContact.SupplierId = null;
            else
                supplierContact.SupplierId = Convert.ToInt32(cmbSupplierId.SelectedValue); // if user selected the name
        }


        // if the user cancels the process of editing or inserting
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
