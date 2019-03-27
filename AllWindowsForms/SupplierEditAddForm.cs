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
    public partial class SupplierEditAddForm : Form
    {
        public SupplierContacts supplierContact;
        public bool addContact; // indicates whether it is Add or Edit
        

        public SupplierEditAddForm()
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
            txtSupConFirstName.Text = supplierContact.SupConFirstName;
            txtSupConLastName.Text = supplierContact.SupConLastName;
            txtSupConCompany.Text = supplierContact.SupConCompany;
            txtSupConAddress.Text = supplierContact.SupConAddress;
            txtSupConCity.Text = supplierContact.SupConCity;
            txtSupConProv.Text = supplierContact.SupConProv;
            txtSupConPostal.Text = supplierContact.SupConPostal;
            txtSupConCountry.Text = supplierContact.SupConCountry;
            txtSupConBusPhone.Text = supplierContact.SupConBusPhone;
            txtSupConFax.Text = supplierContact.SupConFax;
            txtSupConEmail.Text = supplierContact.SupConEmail;
            txtSupConURL.Text = supplierContact.SupConURL;
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
                        if (!SupplierContactsDB.UpdateContact(supplierContact, newSupplierContact))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that customer.", "Database Error");
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
            supplierContact.SupConFirstName = txtSupConFirstName.Text;
            supplierContact.SupConLastName = txtSupConLastName.Text;
            supplierContact.SupConCompany = txtSupConCompany.Text;
            supplierContact.SupConAddress = txtSupConAddress.Text;
            supplierContact.SupConCity = txtSupConCity.Text;
            supplierContact.SupConProv = txtSupConProv.Text;
            supplierContact.SupConPostal = txtSupConPostal.Text;
            supplierContact.SupConCountry = txtSupConCountry.Text;
            supplierContact.SupConBusPhone = txtSupConBusPhone.Text;
            supplierContact.SupConFax = txtSupConFax.Text;
            supplierContact.SupConEmail = txtSupConEmail.Text;
        }
    }
}
