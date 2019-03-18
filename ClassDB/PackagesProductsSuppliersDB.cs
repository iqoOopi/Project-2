using Project_2;
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

        public static List<PackagesProductsSuppliers> GetPackProdSuppliers()
        {
            List<PackagesProductsSuppliers> packProdSuppliers = new List<PackagesProductsSuppliers>();
            PackagesProductsSuppliers pps;


            SqlConnection con = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM Packages_Products_Suppliers";

            SqlCommand command = new SqlCommand(SelectQuery, con);

            try
            {
                con.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    pps = new PackagesProductsSuppliers();
                    pps.PackageId = Convert.ToInt32(dr["PackageId"]);
                    pps.ProductSupplierId = Convert.ToInt32(dr["ProductSupplierId"]);

                    packProdSuppliers.Add(pps);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return packProdSuppliers;
        }
    }
}
