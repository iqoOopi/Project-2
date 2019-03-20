using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SHOWS THE CONNECTION BETWEEN TABLES
            select P.PkgName,PDE.ProdName from Packages P
inner join Packages_Products_Suppliers PS on P.PackageId = PS.PackageId
inner join Products_Suppliers PSP on PS.ProductSupplierId = PSP.ProductSupplierId
inner join Products PDE on PSP.ProductId = PDE.ProductId
*/

        }
    }
}
