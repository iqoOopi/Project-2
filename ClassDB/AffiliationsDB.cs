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
    /// Hoora - March 
    /// A data access class for dealing with suppliers info
    /// </summary>
    /// 
    public static class AffiliationsDB
    {
        public static Affiliations GetAff(string affiliationId)
        {
            Affiliations afl = new Affiliations();

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM Affiliations WHERE AffiliationId = @AffiliationId";

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc);

            cmnd.Parameters.AddWithValue("@AffiliationId", affiliationId);

            try
            {
                cnc.Open();

                SqlDataReader dr = cmnd.ExecuteReader();

                if (dr.Read())
                {
                    afl = new Affiliations();
                    afl.AffiliationId =dr["AffiliationId"].ToString();


                    int AflNameIndex = dr.GetOrdinal("AffName");
                    if (dr.IsDBNull(AflNameIndex))
                    {
                        afl.AffName = null;
                    }
                    else
                    {
                        afl.AffName = dr["AffName"].ToString();
                    }


                    int AflDescIndex = dr.GetOrdinal("AffDesc");
                    if (dr.IsDBNull(AflDescIndex))
                    {
                        afl.AffDesc = null;
                    }
                    else
                    {
                        afl.AffDesc = dr["AffDesc"].ToString();
                    }                    
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
            return afl;
        }
    }
}
