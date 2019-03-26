using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDB
{
    /// <summary>
    /// Linda Wallace
    /// Data access class to get data from the Travel Experts database
    /// This table is used to link together Package products and their supplier
    /// </summary>
    public class PackagesProductsSuppliersDB
    {
        //method to retrieve data from database
        public static List<PackagesProductsSuppliers> GetPackProdSuppliers()
        {
            //create a new list and name it pps
            List<PackagesProductsSuppliers> packProdSuppliers = new List<PackagesProductsSuppliers>();
            PackagesProductsSuppliers pps;

            //connect
            SqlConnection con = TravelExpertDB.GetConnection();
            // create the query to retrieve all the records from Packages_Products_Suppliers table
            string SelectQuery = "SELECT * FROM Packages_Products_Suppliers";
            //send the query to the database
            SqlCommand command = new SqlCommand(SelectQuery, con);
            
            try
            {
                //open the connection
                con.Open();
                // start up the sql reader
                SqlDataReader dr = command.ExecuteReader();
                // while there is data to read, add a line to the pps list
                while (dr.Read())
                {
                    pps = new PackagesProductsSuppliers();
                    pps.PackageId = Convert.ToInt32(dr["PackageId"]);
                    pps.ProductSupplierId = Convert.ToInt32(dr["ProductSupplierId"]);

                    packProdSuppliers.Add(pps);
                }
                //close the sql reader
                dr.Close();
            }
            // check for exceptions
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //close the connection
                con.Close();
            }
            //return value is a list of the records in the Packages_Products_Suppliers table
            return packProdSuppliers;
        }
    }
}
