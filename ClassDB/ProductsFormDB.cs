using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDB
{
    public static class ProductsFormDB
    {
       // public static List<>

        public static bool Update(Products oldProd,Products newProd)
        {
            //update results, 1 for success
            int proTblUpdResult = 0;
            int prod_supTblUpdResult = 0;
            bool success = false;
            //since we gonna update 2 tables, use transcation here
            using (SqlConnection connection = TravelExpertDB.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    //update products table
                    proTblUpdResult = GenericDB.GenericUpdate<Products>("Products", oldProd, newProd, connection, transaction);
                    //update products_supplier table as well
                    prod_supTblUpdResult = 1;//setting for testing updating products table
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                    
                }

                //if both update are succeed, commit the change otherwise rollback
                if (prod_supTblUpdResult == 1 && proTblUpdResult == 1)
                {
                    transaction.Commit();
                    success = true;
                }
                else
                {
                    transaction.Rollback();
                }

            }

            return success;
        }
        public static List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>();
            Products Prod;


            SqlConnection cnn = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM Products";

            SqlCommand command = new SqlCommand(SelectQuery, cnn);

            try
            {
                cnn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Prod = new Products();
                    Prod.ProductId = (int)dr["ProductId"];
                    Prod.ProdName = (string)dr["ProdName"];

                    productList.Add(Prod);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return productList;
        }
    }
}
