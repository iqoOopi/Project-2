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
    public partial class SupplierContactEditAddForm : Form
    {
        public SupplierContacts supplierContact;
        public bool addContact; // indicates whether it is Add or Edit
        

        public SupplierContactEditAddForm()
        {
            InitializeComponent();
        }


        private void SupplierEditAddForm_Load(object sender, EventArgs e)
        {
            this.LoadAffCmb();
            this.LoadSupCmb();

            if (addContact)
            {
                this.Text = "Add Contact";
                cmbAffiliationID.SelectedIndex = -1;
                cmbSupplierId.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Edit Contact";
                this.DisplayContact();
            }
        }


        private void DisplayContact() 
        {
            if (supplierContact.SupConFirstName == null)
                txtSupConFirstName.Text = "";
            else
                txtSupConFirstName.Text = supplierContact.SupConFirstName;

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

            if (supplierContact.AffiliationID == null)
                cmbAffiliationID.SelectedItem = null;
            else
                cmbAffiliationID.SelectedValue = supplierContact.AffiliationID;

            if (supplierContact.SupplierId == null)
                cmbSupplierId.SelectedItem = null;
            else
                cmbSupplierId.SelectedValue = supplierContact.SupplierId;

        }


        private void LoadSupCmb()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            try
            {
                suppliers = SuppliersDB.GetSup();
                cmbSupplierId.DataSource = suppliers;
                cmbSupplierId.DisplayMember = "SupplierName";
                cmbSupplierId.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void LoadAffCmb()
        {
            List<Affiliations> affiliations = new List<Affiliations>();
            try
            {
                affiliations = AffiliationsDB.GetAffs();
                cmbAffiliationID.DataSource = affiliations;
                cmbAffiliationID.DisplayMember = "AffiliationName";
                cmbAffiliationID.ValueMember = "AffiliationId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {

                if (addContact)
                {
                    supplierContact = new SupplierContacts();
                    this.PutContactData(supplierContact);
                    try
                    {
                        supplierContact.SupplierContactId = SupplierContactsDB.AddContact(supplierContact);
                        SuppliersMngForm.insertedOrUpdatedSupplierId = Convert.ToInt32(supplierContact.SupplierId);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // modify
                {
                    SupplierContacts newSupplierContact = new SupplierContacts();
                    newSupplierContact.SupplierContactId = supplierContact.SupplierContactId;
                    this.PutContactData(newSupplierContact);
                    try
                    {
                        if (SupplierContactsDB.UpdateContact(supplierContact, newSupplierContact) == 0)
                        {
                            MessageBox.Show("Another user has updated or deleted that contact.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else // successfully updated
                        {
                            supplierContact = newSupplierContact;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }


        private void PutContactData(SupplierContacts supplierContact)
        {
            if (txtSupConFirstName.Text == "")
                supplierContact.SupConFirstName = null;
            else 
                supplierContact.SupConFirstName = txtSupConFirstName.Text;

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

            // how can i get the id ***************************************************************************************
            if (cmbSupplierId.SelectedItem == null)
                supplierContact.SupplierId = null;
            else
                supplierContact.SupplierId = Convert.ToInt32(cmbSupplierId.SelectedValue);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
