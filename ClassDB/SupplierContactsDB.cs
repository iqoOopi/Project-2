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
    public static class SupplierContactsDB
    {
        public static List<SupplierContacts> GetSupCont(int supplierId)
        {
            List<SupplierContacts> supplierContacts = new List<SupplierContacts>();

            SupplierContacts splCon;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM SupplierContacts WHERE SupplierId = @SupplierId";

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc);

            cmnd.Parameters.AddWithValue("@SupplierId", supplierId);

            try
            {
                cnc.Open();

                SqlDataReader dr = cmnd.ExecuteReader();

                while(dr.Read())
                {
                    splCon = new SupplierContacts();

                    splCon.SupplierContactId = Convert.ToInt32(dr["SupplierContactId"]);


                    int SCFNameIndex = dr.GetOrdinal("SupConFirstName");
                    if (dr.IsDBNull(SCFNameIndex))
                    {
                        splCon.SupConFirstName = null;
                    }
                    else
                    {
                        splCon.SupConFirstName = dr["SupConFirstName"].ToString();
                    }


                    int SCFLNameIndex = dr.GetOrdinal("SupConLastName");
                    if (dr.IsDBNull(SCFLNameIndex))
                    {
                        splCon.SupConLastName = null;
                    }
                    else
                    {
                        splCon.SupConLastName = dr["SupConLastName"].ToString();
                    }


                    int SCCompanyIndex = dr.GetOrdinal("SupConCompany");
                    if (dr.IsDBNull(SCCompanyIndex))
                    {
                        splCon.SupConCompany = null;
                    }
                    else
                    {
                        splCon.SupConCompany = dr["SupConCompany"].ToString();
                    }


                    int SCAddressIndex = dr.GetOrdinal("SupConAddress");
                    if (dr.IsDBNull(SCAddressIndex))
                    {
                        splCon.SupConAddress = null;
                    }
                    else
                    {
                        splCon.SupConAddress = dr["SupConAddress"].ToString();
                    }


                    int SCCityIndex = dr.GetOrdinal("SupConCity");
                    if (dr.IsDBNull(SCCityIndex))
                    {
                        splCon.SupConCity = null;
                    }
                    else
                    {
                        splCon.SupConCity = dr["SupConCity"].ToString();
                    }


                    int SCProvIndex = dr.GetOrdinal("SupConProv");
                    if (dr.IsDBNull(SCProvIndex))
                    {
                        splCon.SupConProv = null;
                    }
                    else
                    {
                        splCon.SupConProv = dr["SupConProv"].ToString();
                    }


                    int SCPostalIndex = dr.GetOrdinal("SupConPostal");
                    if (dr.IsDBNull(SCProvIndex))
                    {
                        splCon.SupConPostal = null;
                    }
                    else
                    {
                        splCon.SupConPostal = dr["SupConPostal"].ToString();
                    }


                    int SCCountryIndex = dr.GetOrdinal("SupConCountry");
                    if (dr.IsDBNull(SCCountryIndex))
                    {
                        splCon.SupConCountry = null;
                    }
                    else
                    {
                        splCon.SupConCountry = dr["SupConCountry"].ToString();
                    }


                    int SCBPhoneIndex = dr.GetOrdinal("SupConBusPhone");
                    if (dr.IsDBNull(SCBPhoneIndex))
                    {
                        splCon.SupConBusPhone = null;
                    }
                    else
                    {
                        splCon.SupConBusPhone = dr["SupConBusPhone"].ToString();
                    }


                    int SCFaxIndex = dr.GetOrdinal("SupConFax");
                    if (dr.IsDBNull(SCFaxIndex))
                    {
                        splCon.SupConFax = null;
                    }
                    else
                    {
                        splCon.SupConFax = dr["SupConFax"].ToString();
                    }


                    int SCEmailIndex = dr.GetOrdinal("SupConEmail");
                    if (dr.IsDBNull(SCEmailIndex))
                    {
                        splCon.SupConEmail = null;
                    }
                    else
                    {
                        splCon.SupConEmail = dr["SupConEmail"].ToString();
                    }


                    int SCURLIndex = dr.GetOrdinal("SupConURL");
                    if (dr.IsDBNull(SCURLIndex))
                    {
                        splCon.SupConURL = null;
                    }
                    else
                    {
                        splCon.SupConURL = dr["SupConURL"].ToString();
                    }


                    int AffIdIndex = dr.GetOrdinal("AffiliationID");
                    if (dr.IsDBNull(AffIdIndex))
                    {
                        splCon.AffiliationID = null;
                    }
                    else
                    {
                        splCon.AffiliationID = dr["AffiliationID"].ToString();

                    }


                    int SupIdIndex = dr.GetOrdinal("SupplierId");
                    if(dr.IsDBNull(SupIdIndex))
                    {
                        splCon.SupplierId = null;
                    }
                    else
                    {
                        splCon.SupplierId = Convert.ToInt32(dr["SupplierId"]);
                    }
                }
                dr.Close();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }
            return supplierContacts;
        }
    }
}
