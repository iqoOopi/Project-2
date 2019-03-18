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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void prodForm_Click(object sender, EventArgs e)
        {
            ProdMngForm prodMngFormInstant = new ProdMngForm();
            prodMngFormInstant.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuppliersMngForm suppliersMngFormInstant = new SuppliersMngForm();
            suppliersMngFormInstant.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
