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

        public static void UpdateDB(int Counter)
        {/*
            string EditName = ;
            string EditDesc = ;
            string UPname = "update Packages set PkgName=" + "'" + EditName + "'" + "where PackageId=" + Counter -1;


            string UPdesc = "update Packages set PkgName =" + "'" + EditDesc + "'" + "where PackageId =" Counter - 1;

            */










        }






    }
}
