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
    /// Hoora - March 
    /// A data access class for dealing with suppliers info
    /// </summary>
    public static class SuppliersDB
    {
        public static List<Suppliers> GetSup()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            Suppliers spl;
           

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM Suppliers";

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc);

            try
            {
                cnc.Open();

                SqlDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    spl = new Suppliers();
                    spl.SupplierId = Convert.ToInt32(dr["SupplierId"]);

                    int SupNameIndex = dr.GetOrdinal("SupName");
                    if (dr.IsDBNull(SupNameIndex))
                        spl.SupName = null;
                    else
                        spl.SupName = dr["SupName"].ToString();

                    suppliers.Add(spl);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }
            return suppliers;
        }


        public static int GetAvlId()
        {
            List<int> Ids = new List<int>();
            int Id;
            int AvlId;


            SqlConnection cnc = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT SupplierId FROM Suppliers";

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc);

            try
            {
                cnc.Open();

                SqlDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    Id = Convert.ToInt32(dr["SupplierId"]);

                    Ids.Add(Id);
                }
                dr.Close();

                AvlId = Ids.Max()+1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }

            return AvlId;
        }

        // with no check on concurency:
        public static int InsertSupplier(Suppliers supplier)
        {
            int count = 0;
            int Id = 0;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                    "VALUES(@SupplierId, @SupName)";

            SqlCommand cmd = new SqlCommand(insertStatement, cnc);

            int AvlID = GetAvlId();

            cmd.Parameters.AddWithValue("@SupplierId", AvlID);

            if (supplier.SupName == null)
                cmd.Parameters.AddWithValue("@SupName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupName", supplier.SupName);
            
            try
            {
                cnc.Open();
                count = cmd.ExecuteNonQuery();
                Id = AvlID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }
            return Id;
        }



        public static int UpdateSuplier(Suppliers oldSupplier, Suppliers newSupplier)
        {
            int count = 0;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string UpdateStatement = "update Suppliers set SupName = @NewSupName " +

                                    "WHERE SupplierId = @SupplierId " + // to identify record
                                    "AND (SupName = @SupName " + // remaining: for optimistic concurrency
                                    "OR SupName IS NULL And @SupName IS NULL)";

            SqlCommand cmd = new SqlCommand(UpdateStatement, cnc);
            
            if (newSupplier.SupName == null)
                cmd.Parameters.AddWithValue("@NewSupName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupName", newSupplier.SupName);
                       

            cmd.Parameters.AddWithValue("@SupplierId", oldSupplier.SupplierId);


            if (oldSupplier.SupName == null)
                cmd.Parameters.AddWithValue("@SupName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupName", oldSupplier.SupName);

            try
            {
                cnc.Open();
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }
            return count;
        }



        public static List<Suppliers> ProdSuppChoice(List<ProductsSuppliers> CompList)//Matthew
        {
            List<Suppliers> List = GetSup();
            List<Suppliers> EditList = new List<Suppliers>();

            foreach (Suppliers Supp in List)
            {
                foreach(ProductsSuppliers PS in CompList)
                {
                    if(PS.SupplierId == Supp.SupplierId)
                    {
                        EditList.Add(Supp);
                    }
                }
            }

            return EditList;
        }
    }
}
