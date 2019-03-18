using ClassLibary;
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
    }
}
