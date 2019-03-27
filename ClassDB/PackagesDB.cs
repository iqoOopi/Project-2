using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary;

namespace ClassDB
{
    public static class PackagesDB
    {
        //Matthew
        //2019-01-27
        

        public static List<Package> GetPackages()
        {
            string selectStatement = "select*from Packages";
            List<Package> PackageList = new List<Package>();
            Package package;

            SqlConnection cnn = TravelExpertDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, cnn);

            try
            {
                cnn.Open();
                SqlDataReader SqlReader = selectCommand.ExecuteReader();
                while (SqlReader.Read())
                {
                    package = new Package();

                    package.PackageID = (int)SqlReader["PackageID"];//unable to be updated so it cannot be null
                    //nextvalue
                    if (SqlReader["PkgName"] == DBNull.Value)
                    {
                        package.PackageName = null;
                    }
                    else
                    {
                        package.PackageName = (string)SqlReader["PkgName"];
                    }
                    //nextvalue
                    if (SqlReader["PkgStartDate"] == DBNull.Value)
                    {
                        package.PackageStart = null;
                    }
                    else
                    {
                        package.PackageStart = (DateTime)SqlReader["PkgStartDate"];
                    }

                    //next value
                    if (SqlReader["PkgEndDate"] == DBNull.Value)
                    {
                        package.PackageEnd = null;
                    }
                    else
                    {
                        package.PackageEnd = (DateTime)SqlReader["PkgEndDate"];
                    }

                    //next value
                    if (SqlReader["PkgDesc"] == DBNull.Value)
                    {
                        package.Desc = null;
                    }
                    else
                    {
                        package.Desc = (string)SqlReader["PkgDesc"];
                    }
                    //nextvalue
                    if (SqlReader["PkgBasePrice"] == DBNull.Value)
                    {
                        package.BasePrice = 0;
                    }
                    else
                    {
                        package.BasePrice = (decimal)SqlReader["PkgBasePrice"];
                    }
                    //nextvalue
                    if (SqlReader["PkgAgencyCommission"] == DBNull.Value)
                    {
                        package.AgencyCom = 0;
                    }
                    else
                    {
                        package.AgencyCom = (decimal)SqlReader["PkgAgencyCommission"];
                    }
                    PackageList.Add(package);//add filled package

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return PackageList;
        }

        public static void UpdateDB(int Counter,Package package)
        {
            
            string UPname = "update Packages set PkgName=" + "'" + package.PackageName + "'" + "where PackageId=" + (Counter + 1 );
            string UPstart = "update Packages set PkgStartDate="  +"'"+ package.PackageStart+"'"  + "where PackageId=" + (Counter + 1 );
            string UPend = "update Packages set PkgEndDate=" +"'"+ package.PackageEnd + "'"+  "where PackageId=" + (Counter + 1);
            string UPdesc = "update Packages set PkgDesc=" + "'" + package.Desc + "'" + "where PackageId=" + (Counter + 1); // update statements
            string UPBase = "update Packages set PkgBasePrice=" + package.BasePrice + "where PackageId=" + (Counter + 1);
            string UPCom = "update Packages set PkgAgencyCommission=" + package.AgencyCom  + "where PackageId=" + (Counter + 1);

            SqlConnection cnn = TravelExpertDB.GetConnection();
            

            SqlCommand selectName = new SqlCommand(UPname, cnn);
            SqlCommand selectStart = new SqlCommand(UPstart, cnn);
            SqlCommand selectEnd = new SqlCommand(UPend, cnn);
            SqlCommand selectDesc = new SqlCommand(UPdesc, cnn);
            SqlCommand selectBase = new SqlCommand(UPBase, cnn);
            SqlCommand selectCom = new SqlCommand(UPCom, cnn);

            try
            {
                cnn.Open();//open connection

                SqlDataReader SqlReader1 = selectName.ExecuteReader();//executes query
                cnn.Close();
                cnn.Open();
                SqlDataReader SqlReader2 = selectStart.ExecuteReader();
                cnn.Close();
                cnn.Open();
                SqlDataReader SqlReader3 = selectEnd.ExecuteReader();
                cnn.Close();
                cnn.Open();
                SqlDataReader SqlReader4 = selectDesc.ExecuteReader();
                cnn.Close();
                cnn.Open();
                SqlDataReader SqlReader5 = selectBase.ExecuteReader();
                cnn.Close();
                cnn.Open();
                SqlDataReader SqlReader6 = selectCom.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            
        }


        public static void InsertDB(Package package)
        {
             string insertStatement = "insert into Packages values(" + "'"+ package.PackageName +"'"+ ","+"'" + package.PackageStart + "'" + "," + "'" + package.PackageEnd + "'"+  "," + "'" + package.Desc + "'" + "," + package.BasePrice +","+ package.AgencyCom + ")";
            SqlConnection cnn = TravelExpertDB.GetConnection();

            SqlCommand insertState = new SqlCommand(insertStatement, cnn);
            try
            {
                cnn.Open();
                SqlDataReader SqlReader = insertState.ExecuteReader();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
        }





    }
}
