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
    /// A data access class for dealing with affiliation table in DB
    /// </summary>
    
    public static class AffiliationsDB
    {
        // a method to get an affiliation from DB by passing its Id
        public static Affiliations GetAff(string affiliationId)
        {
            Affiliations afl = new Affiliations(); // an empty affiliation

            SqlConnection cnc = TravelExpertDB.GetConnection(); // connection to DB

            string SelectQuery = "SELECT * FROM Affiliations WHERE AffiliationId = @AffiliationId"; // SQL query

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc); // command

            cmnd.Parameters.AddWithValue("@AffiliationId", affiliationId); // add parameters to the command

            try
            {
                cnc.Open(); // opening the connection

                SqlDataReader dr = cmnd.ExecuteReader(); // data reader

                if (dr.Read()) 
                {
                    afl = new Affiliations(); // make a new Affiliation object
                    afl.AffiliationId =dr["AffiliationId"].ToString();


                    int AflNameIndex = dr.GetOrdinal("AffName"); // get the index of AffName property
                    if (dr.IsDBNull(AflNameIndex))
                    {
                        afl.AffName = null; // if the AffName is null in DB
                    }
                    else
                    {
                        afl.AffName = dr["AffName"].ToString(); // if the AffName is not null in DB
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
            return afl; // return the affiliation
        }


        // a method to get all affiliations from DB
        public static List<Affiliations> GetAffs()
        {            
            List<Affiliations> aflList = new List<Affiliations>(); // an empty list of affiliations
            Affiliations afl = new Affiliations(); // an empty affiliation

            SqlConnection cnc = TravelExpertDB.GetConnection(); // connection to DB

            string SelectQuery = "SELECT * FROM Affiliations"; // SQL query

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc); // Command

            try
            {
                cnc.Open(); // opening the connection

                SqlDataReader dr = cmnd.ExecuteReader(); // data reader

                while (dr.Read()) // until there is s.th. to read
                {
                    afl = new Affiliations(); // make the affiliation empty 
                    afl.AffiliationId = dr["AffiliationId"].ToString(); // read the Id


                    int AflNameIndex = dr.GetOrdinal("AffName"); // get the index of AffName property
                    if (dr.IsDBNull(AflNameIndex))
                    {
                        afl.AffName = null; // if the AffName is null in DB
                    }
                    else
                    {
                        afl.AffName = dr["AffName"].ToString(); // if the AffName is not null in DB
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

                    aflList.Add(afl); // adding the affiliation to the list
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
            return aflList; // return the affiliation list
        }
    }
}
