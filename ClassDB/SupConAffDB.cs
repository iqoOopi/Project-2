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
    public static class SupConAffDB
    {
        public static List<SupConAff> GetSupConAff(int supplierId)
        {
            List<SupConAff> SupConAff = new List<SupConAff>();

            SupConAff splConAff;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT SupplierContactId, SupConFirstName , SupConLastName, " +
                "SupConCompany, SupConAddress, SupConCity, SupConProv, SupConPostal, SupConCountry, " +
                "SupConBusPhone, SupConFax, SupConEmail, SupConURL, SupplierContacts.AffiliationId, " +
                "SupplierId, AffName, AffDesc " +
                "FROM SupplierContacts LEFT JOIN Affiliations " +
                "ON SupplierContacts.AffiliationId = Affiliations.AffiliationId " +
                "WHERE SupplierId = @SupplierId";             
            
            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc);

            cmnd.Parameters.AddWithValue("@SupplierId", supplierId);

            try
            {
                cnc.Open();

                SqlDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    splConAff = new SupConAff();

                    splConAff.SupplierContactId = Convert.ToInt32(dr["SupplierContactId"]);


                    int SCFNameIndex = dr.GetOrdinal("SupConFirstName");
                    if (dr.IsDBNull(SCFNameIndex))
                    {
                        splConAff.SupConFirstName = null;
                    }
                    else
                    {
                        splConAff.SupConFirstName = dr["SupConFirstName"].ToString();
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


                    int AffIdIndex = dr.GetOrdinal("AffiliationID");
                    if (dr.IsDBNull(AffIdIndex))
                    {
                        splConAff.AffiliationID = null;
                    }
                    else
                    {
                        splConAff.AffiliationID = dr["AffiliationID"].ToString();

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
                    SupConAff.Add(splConAff);
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
            return SupConAff;
        }
    }
}
