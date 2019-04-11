using ClassLibary;
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
    /// A data access class for dealing with supplier contact table including the related affiliation from affiliation table (supConAff)
    /// </summary>
    
    public static class SupConAffDB
    {
        // a method to get a supConAff from DB by passing its Id
        public static List<SupConAff> GetSupConAffs(int supplierId)
        {
            List<SupConAff> SupConAff = new List<SupConAff>(); // an empty list of supConAff

            SupConAff splConAff; // an empty supConAff

            SqlConnection cnc = TravelExpertDB.GetConnection(); // connection to DB

            string SelectQuery = "SELECT SupplierContactId, SupConFirstName , SupConLastName, " +
                "SupConCompany, SupConAddress, SupConCity, SupConProv, SupConPostal, SupConCountry, " +
                "SupConBusPhone, SupConFax, SupConEmail, SupConURL, SupplierId, " +
                "SupplierContacts.AffiliationId, AffName, AffDesc " +
                "FROM SupplierContacts LEFT JOIN Affiliations " +
                "ON SupplierContacts.AffiliationId = Affiliations.AffiliationId " +
                "WHERE SupplierId = @SupplierId"; // SQL query
            
            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc); // command

            cmnd.Parameters.AddWithValue("@SupplierId", supplierId);  // add parameters to the command

            try
            {
                cnc.Open(); // openint the connection

                SqlDataReader dr = cmnd.ExecuteReader(); // data reader

                while (dr.Read()) // until there is s.th. to read
                {
                    splConAff = new SupConAff(); // make the supConAff empty 

                    splConAff.SupplierContactId = Convert.ToInt32(dr["SupplierContactId"]); // read the Id


                    int SCFNameIndex = dr.GetOrdinal("SupConFirstName"); // get the index of SupConFirstName property
                    if (dr.IsDBNull(SCFNameIndex))
                    {
                        splConAff.SupConFirstName = null; // if the SupConFirstName is null in DB
                    }
                    else
                    {
                        splConAff.SupConFirstName = dr["SupConFirstName"].ToString(); // if the SupConFirstName is not null in DB
                    }


                    int SCFLNameIndex = dr.GetOrdinal("SupConLastName");
                    if (dr.IsDBNull(SCFLNameIndex))
                    {
                        splConAff.SupConLastName = null;
                    }
                    else
                    {
                        splConAff.SupConLastName = dr["SupConLastName"].ToString();
                    }


                    int SCCompanyIndex = dr.GetOrdinal("SupConCompany");
                    if (dr.IsDBNull(SCCompanyIndex))
                    {
                        splConAff.SupConCompany = null;
                    }
                    else
                    {
                        splConAff.SupConCompany = dr["SupConCompany"].ToString();
                    }


                    int SCAddressIndex = dr.GetOrdinal("SupConAddress");
                    if (dr.IsDBNull(SCAddressIndex))
                    {
                        splConAff.SupConAddress = null;
                    }
                    else
                    {
                        splConAff.SupConAddress = dr["SupConAddress"].ToString();
                    }


                    int SCCityIndex = dr.GetOrdinal("SupConCity");
                    if (dr.IsDBNull(SCCityIndex))
                    {
                        splConAff.SupConCity = null;
                    }
                    else
                    {
                        splConAff.SupConCity = dr["SupConCity"].ToString();
                    }


                    int SCProvIndex = dr.GetOrdinal("SupConProv");
                    if (dr.IsDBNull(SCProvIndex))
                    {
                        splConAff.SupConProv = null;
                    }
                    else
                    {
                        splConAff.SupConProv = dr["SupConProv"].ToString();
                    }


                    int SCPostalIndex = dr.GetOrdinal("SupConPostal");
                    if (dr.IsDBNull(SCProvIndex))
                    {
                        splConAff.SupConPostal = null;
                    }
                    else
                    {
                        splConAff.SupConPostal = dr["SupConPostal"].ToString();
                    }


                    int SCCountryIndex = dr.GetOrdinal("SupConCountry");
                    if (dr.IsDBNull(SCCountryIndex))
                    {
                        splConAff.SupConCountry = null;
                    }
                    else
                    {
                        splConAff.SupConCountry = dr["SupConCountry"].ToString();
                    }


                    int SCBPhoneIndex = dr.GetOrdinal("SupConBusPhone");
                    if (dr.IsDBNull(SCBPhoneIndex))
                    {
                        splConAff.SupConBusPhone = null;
                    }
                    else
                    {
                        splConAff.SupConBusPhone = dr["SupConBusPhone"].ToString();
                    }


                    int SCFaxIndex = dr.GetOrdinal("SupConFax");
                    if (dr.IsDBNull(SCFaxIndex))
                    {
                        splConAff.SupConFax = null;
                    }
                    else
                    {
                        splConAff.SupConFax = dr["SupConFax"].ToString();
                    }


                    int SCEmailIndex = dr.GetOrdinal("SupConEmail");
                    if (dr.IsDBNull(SCEmailIndex))
                    {
                        splConAff.SupConEmail = null;
                    }
                    else
                    {
                        splConAff.SupConEmail = dr["SupConEmail"].ToString();
                    }


                    int SCURLIndex = dr.GetOrdinal("SupConURL");
                    if (dr.IsDBNull(SCURLIndex))
                    {
                        splConAff.SupConURL = null;
                    }
                    else
                    {
                        splConAff.SupConURL = dr["SupConURL"].ToString();
                    }


                    int SupIdIndex = dr.GetOrdinal("SupplierId");
                    if (dr.IsDBNull(SupIdIndex))
                    {
                        splConAff.SupplierId = null;
                    }
                    else
                    {
                        splConAff.SupplierId = Convert.ToInt32(dr["SupplierId"]);
                    }
                        
                    
                    int AffIdIndex = dr.GetOrdinal("AffiliationID");
                    if (dr.IsDBNull(AffIdIndex))
                    {
                        splConAff.AffiliationID = null;
                    }
                    else
                    {
                        splConAff.AffiliationID = dr["AffiliationID"].ToString();

                    }


                    int AffNameIndex = dr.GetOrdinal("AffName");
                    if (dr.IsDBNull(AffNameIndex))
                    {
                        splConAff.AffName = null;
                    }
                    else
                    {
                        splConAff.AffName = dr["AffName"].ToString();
                    }


                    int AffDescIndex = dr.GetOrdinal("AffDesc");
                    if (dr.IsDBNull(AffDescIndex))
                    {
                        splConAff.AffDesc = null;
                    }
                    else
                    {
                        splConAff.AffDesc = dr["AffDesc"].ToString();
                    }

                    SupConAff.Add(splConAff); // adding the SupConAff to the list
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
            return SupConAff; // return the SupConAff list
        }

    }
}
