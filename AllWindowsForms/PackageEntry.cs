using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ClassDB;
using ClassLibrary;
using AllWindowsForms;


namespace AllWindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            PkgName.Text = "";
            PkgStart.Text = "";
            PkgEnd.Text = "";
            PkgDesc.Text = "";
            PkgBase.Text = "";
            PkgCom.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*SHOWS THE CONNECTION BETWEEN TABLES
           select P.PkgName,PDE.ProdName from Packages P
inner join Packages_Products_Suppliers PS on P.PackageId = PS.PackageId
inner join Products_Suppliers PSP on PS.ProductSupplierId = PSP.ProductSupplierId
inner join Products PDE on PSP.ProductId = PDE.ProductId
*/
            ErrName.Visible = false;
            ErrStart.Visible = false;
            ErrEnd.Visible = false;
            ErrDesc.Visible = false;
            ErrBase.Visible = false;
            ErrAgency.Visible = false;
            ErrTotal.Visible = false;
            ErrDate.Visible = false;

            decimal ValidBase = 0;
            decimal ValidCom = 0;
            bool Base = decimal.TryParse(PkgBase.Text, out ValidBase);
            bool Com = decimal.TryParse(PkgCom.Text, out ValidCom);

            bool pass = true;
            //Date validation
            Regex rx = new Regex(@"^\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])$");//confirms its in correct format-via reguler expression
            string[] remT1 = PkgStart.Text.Split(' ');
            string[] remT2 = PkgEnd.Text.Split(' ');

            string Date1 = remT1[0];
            string Date2 = remT2[0];

            Match result1 = rx.Match(Date1);
            Match result2 = rx.Match(Date2);

            DateTime ValidStrt;
            DateTime ValidEnd;
            bool Start = DateTime.TryParse(PkgStart.Text, out ValidStrt);
            bool End = DateTime.TryParse(PkgEnd.Text, out ValidEnd);

            bool nullcheck1 = false;
            bool nullcheck2 = false;




            if (PkgName.Text == "")
            {
                ErrName.Visible = true;
            }
            //////////////////////////////
            if (PkgStart.Text == "")
            {
                nullcheck1 = true;
            }
            else if (pass == true)
            {
                if (result1.Success)
                {
                    //correct format date
                    pass = true;
                }
                else
                {
                    ErrStart.Visible = true;
                }
            }




            if (PkgEnd.Text == "")
            {
                //null allowed
                nullcheck2 = true;

            }
            else if (pass == true)
            {
                if (result2.Success)
                {
                    //correct format date
                    if (PkgStart.Text == "")
                    {
                        //   StartBox.Text = "";
                    }
                    else
                    {
                        //compare dates but need to divide them
                        string[] CompDate1 = Date1.Split('-');
                        string[] CompDate2 = Date2.Split('-');

                        if (Convert.ToInt32(CompDate1[0]) > Convert.ToInt32(CompDate2[0]))
                        {
                            //err
                            ErrDate.Visible = true;
                        }
                        if (Convert.ToInt32(CompDate1[0]) == Convert.ToInt32(CompDate2[0]))
                        {
                            //next check
                            if (Convert.ToInt32(CompDate1[1]) > Convert.ToInt32(CompDate2[1]))
                            {
                                //error
                                ErrDate.Visible = true;
                            }
                            if (Convert.ToInt32(CompDate1[0]) == Convert.ToInt32(CompDate2[0]))
                            {
                                //next check
                                if (Convert.ToInt32(CompDate1[2]) > Convert.ToInt32(CompDate2[2]))
                                {
                                    //error
                                    ErrDate.Visible = true;
                                }
                                if (Convert.ToInt32(CompDate1[2]) == Convert.ToInt32(CompDate2[2]))
                                {
                                    //err
                                    ErrDate.Visible = true;
                                }

                            }
                        }

                    }

                }

                else
                {
                    ErrEnd.Visible = true;
                }
            }




            if (PkgDesc.Text == "")
            {
                ErrDesc.Visible = true;
            }
            else if (Base == false)
            {
                ErrBase.Visible = true;
            }
            else if (Com == false)
            {
                ErrAgency.Visible = false;
            }
            else if (ValidCom > ValidBase)
            {
                ErrTotal.Visible = true;
            }

            if (((ErrName.Visible == false) & (ErrStart.Visible == false)) & ((ErrEnd.Visible == false) & (ErrDesc.Visible == false)) & ((ErrBase.Visible == false) & (ErrAgency.Visible == false)) & ((ErrTotal.Visible == false) & (ErrDate.Visible == false)))
            //UPDATE TO WHERE IF NO ERRORS APPEAR THEN RUNCURRENT IS FOR TESTING
            {

                Package package = new Package();
                //set object values and update sql

                package.PackageName = PkgName.Text;

                if (nullcheck1 == true)
                {
                    package.PackageStart = null;
                }
                else
                {
                    package.PackageStart = ValidStrt;
                }

                if (nullcheck2 == true)
                {
                    package.PackageEnd = null;
                }
                else
                {
                    package.PackageEnd = ValidEnd;
                }

                package.Desc = PkgDesc.Text;

                package.BasePrice = Convert.ToDecimal(PkgBase.Text);
                package.AgencyCom = Convert.ToDecimal(PkgCom.Text);

                //call function to update


                PackagesDB.InsertDB(package);


            }
        }
    }
        
    }

