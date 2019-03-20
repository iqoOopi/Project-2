using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDB;
using ClassLibrary;
using System.Text.RegularExpressions;

namespace AllWindowsForms
{//MatthewMacMaster
    //Threaded Project Part 2
    //2019-03-19
    /// <summary>
    ///
    /// </summary>
    public partial class Form1 : Form
    {
        List<Package> Packages = PackagesDB.GetPackages();
        int Counter = 0;
        public Form1()
        {
            InitializeComponent();
            FillBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void FillBoxes()
        {
            List<Package> PackageList = PackagesDB.GetPackages();
            NameBox.Text = Convert.ToString(PackageList[Counter].PackageName);
            StartBox.Text = Convert.ToString(PackageList[Counter].PackageStart);
            EndDate.Text = Convert.ToString(PackageList[Counter].PackageEnd);
            DescBox.Text = Convert.ToString(PackageList[Counter].Desc);
            BaseBox.Text = Convert.ToString(PackageList[Counter].BasePrice);
            AgencyBox.Text = Convert.ToString(PackageList[Counter].AgencyCom);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Package> PackageList = PackagesDB.GetPackages();
            if (Counter < (PackageList.Count-1))
            {
                Counter++;
                FillBoxes();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Counter == 0)
            {
                Counter = 0;
                FillBoxes();
            }
            if(Counter > 0)
            {
                Counter--;
                FillBoxes();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result;
            int i = 0;
            bool Found = false;
            ErrIDFind.Visible = false;
             Int32.TryParse(textBox7.Text, out result);
            List<Package> PackageList = PackagesDB.GetPackages();
            foreach (Package Pk in PackageList)
            {
                if(Pk.PackageID == result)
                {
                    Counter = i;
                    Found = true;
                }
                i++;
            }
            if(Found == false)
            {
                ErrIDFind.Visible = true;
            }
            FillBoxes();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            StartBox.Text = "";
            EndDate.Text = "";
            DescBox.Text = "";
            BaseBox.Text = "";
            AgencyBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //   a)the Agency Commission cannot be greater than the Base Price -- DONE
            //     b)the Package End Date must be later than Package Start Date -- toughy
            //   c)Package Name and Package Description cannot be null -- DONE
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
            bool Base = decimal.TryParse(BaseBox.Text, out ValidBase);
            bool Com = decimal.TryParse(AgencyBox.Text, out ValidCom);

            bool pass = true;
            //Date validation
            Regex rx = new Regex(@"^\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])$");//confirms its in correct format-via reguler expression
            string[] remT1 = StartBox.Text.Split(' ');
            string[] remT2 = EndDate.Text.Split(' ');

            string Date1 = remT1[0];
            string Date2 = remT2[0];

            Match result1 = rx.Match(Date1);
            Match result2 = rx.Match(Date2);

            DateTime ValidStrt;
            DateTime ValidEnd;
            bool Start = DateTime.TryParse(StartBox.Text, out ValidStrt);
            bool End = DateTime.TryParse(EndDate.Text, out ValidEnd);







            if (NameBox.Text == "")
            {
                ErrName.Visible = true;
            }

            if (StartBox.Text == "")
            {
                Packages[Counter].PackageStart = null;
            }
            else if (pass == true)
            {
                if (result1.Success)
                {
                    //correct format date
                    Packages[Counter].PackageStart = Convert.ToDateTime(Date1);
                  
                }
                else
                {
                    ErrStart.Visible = true;
                }
            }




            if (EndDate.Text == "")
            {
                //null allowed
                Packages[Counter].PackageEnd = null;

            }
            else if(pass == true)
            {
                if (result2.Success)
                {
                    //correct format date
                    if (StartBox.Text == "")
                    {
                        Packages[Counter].PackageEnd = Convert.ToDateTime(Date2);
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
            
            


             if (DescBox.Text == "")
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

            if ((ErrName.Visible == false) && (ErrStart.Visible == false) && (ErrEnd.Visible = false) && (ErrDesc.Visible = false) && // all values check out
            (ErrBase.Visible = false) && (ErrAgency.Visible = false) && (ErrTotal.Visible = false) && (ErrDate.Visible = false))
            {

                //set object values and update sql



            }
          
        }
        
    }
    
}
