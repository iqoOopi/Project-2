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
            
            NameBox.Text = Convert.ToString(Packages[Counter].PackageName);
            StartBox.Text = Convert.ToString(Packages[Counter].PackageStart);
            EndDate.Text = Convert.ToString(Packages[Counter].PackageEnd);
            DescBox.Text = Convert.ToString(Packages[Counter].Desc);
            BaseBox.Text = Convert.ToString(Packages[Counter].BasePrice);
            AgencyBox.Text = Convert.ToString(Packages[Counter].AgencyCom);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Package> PackageList = PackagesDB.GetPackages();
            if (Counter < (Packages.Count-1))
            {
                Counter++;
                 Packages = PackagesDB.GetPackages();
                FillBoxes();
              // Packages = Form2.liveupdate();
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
            Packages = PackagesDB.GetPackages();
            int result;
            int i = 0;
            bool Found = false;
            ErrIDFind.Visible = false;
             Int32.TryParse(textBox7.Text, out result);
           // List<Package> PackageList = PackagesDB.GetPackages();
            foreach (Package Pk in Packages)
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
          List<Package>  LivePackages = PackagesDB.GetPackages();




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
            ErrDup.Visible = false;

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

            bool nullcheck1 = false;
            bool nullcheck2 = false;
           




            if (NameBox.Text == "")
            {
                ErrName.Visible = true;
            }
            //////////////////////////////
            if (StartBox.Text == "")
            {
                nullcheck1= true;
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




            if (EndDate.Text == "")
            {
                //null allowed
                nullcheck2 = true;

            }
            else if(pass == true)
            {
                if (result2.Success)
                {
                    //correct format date
                    if (StartBox.Text == "")
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

            if (((ErrName.Visible == false) & (ErrStart.Visible == false)) & ((ErrEnd.Visible == false) & (ErrDesc.Visible == false)) & ((ErrBase.Visible == false) & (ErrAgency.Visible == false)) & ((ErrTotal.Visible == false) & (ErrDate.Visible == false)))
            //UPDATE TO WHERE IF NO ERRORS APPEAR THEN RUNCURRENT IS FOR TESTING
            {
                ErrCon.Visible = false;
                //Concurrency check
                if ((Packages[Counter].PackageName != LivePackages[Counter].PackageName)|(Packages[Counter].PackageStart != LivePackages[Counter].PackageStart)|
                    (Packages[Counter].PackageEnd != LivePackages[Counter].PackageEnd)|
                    (Packages[Counter].BasePrice != LivePackages[Counter].BasePrice)|(Packages[Counter].AgencyCom != LivePackages[Counter].AgencyCom))
                {
                    ErrCon.Visible = true;
                    Packages = PackagesDB.GetPackages();
                    FillBoxes();
                }
                else {
                    //set object values and update sql

                    Packages[Counter].PackageName = NameBox.Text;

                    if (nullcheck1 == true)
                    {
                        Packages[Counter].PackageStart = null;
                    }
                    else
                    {
                        Packages[Counter].PackageStart = ValidStrt;
                    }

                    if (nullcheck2 == true)
                    {
                        Packages[Counter].PackageEnd = null;
                    }
                    else
                    {
                        Packages[Counter].PackageEnd = ValidEnd;
                    }

                    Packages[Counter].Desc = DescBox.Text;

                    Packages[Counter].BasePrice = Convert.ToDecimal(BaseBox.Text);
                    Packages[Counter].AgencyCom = Convert.ToDecimal(AgencyBox.Text);

                    //call function to update

                    int i = 0;
                    List<Package> PackComp = PackagesDB.GetPackages();
                    foreach (Package package in Packages) {
                        if (Counter == i)
                        {
                            //skips the current object
                        }
                        else
                        {
                            if ((Packages[Counter].PackageName == PackComp[i].PackageName) & (Packages[Counter].PackageStart == PackComp[i].PackageStart) & (Packages[Counter].PackageEnd == PackComp[i].PackageEnd))
                            {

                                ErrDup.Visible = true;
                            }
                        }
                        i++;
                    }
                    if (ErrDup.Visible == false)
                    {
                        PackagesDB.UpdateDB(Counter, Packages[Counter]);
                    }
                }
            }
        }

        private void Entrybtn_Click(object sender, EventArgs e)
        {

           Form EntryForm = new Form2 ();
            EntryForm.Show();
            

        }
    }
    
}
