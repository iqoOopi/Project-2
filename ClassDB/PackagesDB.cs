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
                    
                    


                }

                




            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }





            return PackageList;

        }
        


    }
}
