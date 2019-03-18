using ClassDB;
using Project_2;
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
        Suppliers supplier;
        int supplierId;
        string affiliationId;


        public SuppliersMngForm()
        {
            InitializeComponent();
        }


        private void SuppliersMngForm_Load(object sender, EventArgs e)
        {
            DisplaySuppliers();
            supplierId = 69;
            DisplaySupContacts(supplierId);
            affiliationId = "ACTAPGY";
            DisplayAffiliation(affiliationId);
        }


        private void DisplayAffiliation(string affiliationId)
        {
            Affiliations affiliation = new Affiliations();
            AffiliationsDB.GetAff(affiliationId);
            affiliationsBindingSource.DataSource = affiliation;
        }


        private void DisplaySupContacts(int supId)
        {
            List<SupplierContacts> SupContacts = new List<SupplierContacts>();
            SupContacts = SupplierContactsDB.GetSupCont(supId);
            supplierContactsBindingSource.DataSource = SupContacts;
        }


        private void DisplaySuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            suppliers = SuppliersDB.GetSup();
            suppliersBindingSource.DataSource = suppliers;
        }
    }
}
