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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Form newForm = new ProdMngForm();
            newForm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Form newForm = new SuppliersMngForm();
            newForm.Show();

        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            Form M_Form = new Form1();
            M_Form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
