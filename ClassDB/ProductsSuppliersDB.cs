using ClassLibrary;
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
    /// obtain data from Travel Experts database for the
    /// ProductsSuppliers table
    /// This table is required to link the Suppliers table to the products table
    /// </summary>
    public static class ProductsSuppliersDB
    {

        public static List<ProductsSuppliers> GetProdSuppliers()
        {
            List<ProductsSuppliers> prodSuppliers = new List<ProductsSuppliers>();
            ProductsSuppliers ps;


            SqlConnection con = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM Products_Suppliers";

            SqlCommand command = new SqlCommand(SelectQuery, con);

            try
            {
                con.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    ps = new ProductsSuppliers();
                    ps.ProductSupplerId = Convert.ToInt32(dr["ProductSupplerId"]);
                    ps.ProductId = Convert.ToInt32(dr["ProductId"]);
                    ps.SupplierId = Convert.ToInt32(dr["SupplierId"]);

                    prodSuppliers.Add(ps);
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
            return prodSuppliers;
        }
    }
}
