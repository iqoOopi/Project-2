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
    /// A data access class for dealing with suppliers table in DB
    /// </summary>
    
    public static class SuppliersDB
    {
        // a method to get a list of Suppliers
        public static List<Suppliers> GetSup()
        {
            List<Suppliers> suppliers = new List<Suppliers>(); // an empty list of Suppliers
            Suppliers spl; // an empty Supplier

            SqlConnection cnc = TravelExpertDB.GetConnection(); // connection to DB 

            string SelectQuery = "SELECT * FROM Suppliers"; // SQL query

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc); // Command

            try
            {
                cnc.Open(); // opening the connection

                SqlDataReader dr = cmnd.ExecuteReader(); // data reader

                while (dr.Read()) // until there is s.th. to read
                {
                    spl = new Suppliers(); // make the Supplier empty
                    spl.SupplierId = Convert.ToInt32(dr["SupplierId"]);  // get the SupplierId property

                    int SupNameIndex = dr.GetOrdinal("SupName"); // get the index of SupName property
                    if (dr.IsDBNull(SupNameIndex))
                        spl.SupName = null; // if the SupName is null in DB
                    else
                        spl.SupName = dr["SupName"].ToString(); // if the SupName is not null in DB

                    suppliers.Add(spl); // adding the supplier to the list
                }
                dr.Close(); // closing the data reader
            }
            catch (Exception ex) // if reading from DB was not successful
            {
                throw ex; // threw the exception to the upper leyer (presentation)
            }
            finally // in either way
            {
                cnc.Close(); // closing the connection
            }
            return suppliers; // return the suppliers list
        }

        // a method to get the first available Id to assign it to the newly added supplier -this primary key is not auto increment
        public static int GetAvlId()
        {
            List<int> Ids = new List<int>(); // make an empty list of IDs 
            int Id; // current Id
            int AvlId; // available Id

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

                    Ids.Add(Id); // add the Id to the list
                }
                dr.Close();

                AvlId = Ids.Max()+1; // find the max Id and its next number
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }

            return AvlId; // return the available Id
        }

        // a method to add a Supplier to DB by passing it (with no check on concurency):
        public static int InsertSupplier(Suppliers supplier)
        {
            int count = 0; // no. of added items
            int Id = 0; // the Id for the added item

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                    "VALUES(@SupplierId, @SupName)";

            SqlCommand cmd = new SqlCommand(insertStatement, cnc);

            // call the method to get the first available Id to assign it to the newly added supplier contact-this primary key is not auto increment
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
                Id = AvlID; // set the Id of the added item to the available Id
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


        // a method to edit a Supplier to DB by passing it
        public static int UpdateSuplier(Suppliers oldSupplier, Suppliers newSupplier)
        {
            int count = 0; // no. of edited items

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string UpdateStatement = "update Suppliers set SupName = @NewSupName " +

                                    "WHERE SupplierId = @SupplierId " + // to identify record
                                    "AND (SupName = @SupName " + // remaining: for optimistic concurrency
                                    "OR SupName IS NULL And @SupName IS NULL)";

            SqlCommand cmd = new SqlCommand(UpdateStatement, cnc);

            // add parameters to the command
            // nullable field in DB:
            if (newSupplier.SupName == null)
                cmd.Parameters.AddWithValue("@NewSupName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupName", newSupplier.SupName);
                       

            cmd.Parameters.AddWithValue("@SupplierId", oldSupplier.SupplierId);

            // nullable field in DB:
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
