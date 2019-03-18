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
    public partial class SuppliersMngForm : Form
    {
        Suppliers supplier;
        int supplierId;
        // string affiliationId;


        public SuppliersMngForm()
        {
            InitializeComponent();
        }


        private void SuppliersMngForm_Load(object sender, EventArgs e)
        {
            DisplaySuppliers();
            supplierId = 69;
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
            supConAff = SupConAffDB.GetSupConAff(supId);
            supplierContactsDataGridView.DataSource = supConAff;
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

    }
}
