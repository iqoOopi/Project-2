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
    public static class SupplierContactsDB
    {
        public static List<SupplierContacts> GetSupConts(int supplierId)
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


        public static SupplierContacts GetSupCont(int SupplierContactId)
        {
            SupplierContacts splCon = null;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string SelectQuery = "SELECT * FROM SupplierContacts WHERE SupplierContactId = @SupplierContactId";

            SqlCommand cmnd = new SqlCommand(SelectQuery, cnc);

            cmnd.Parameters.AddWithValue("@SupplierContactId", SupplierContactId);

            try
            {
                cnc.Open();

                SqlDataReader dr = cmnd.ExecuteReader();

                if (dr.Read())
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
                    if (dr.IsDBNull(SupIdIndex))
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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }
            return splCon;
        }


        public static bool DeleteSupCont(SupplierContacts supplierContact)
        {
            bool success = true;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string deleteStatement = "DELETE FROM SupplierContacts " +
                                    "WHERE SupplierContactId = @SupplierContactId " + // to identify record
                                    "AND SupConFirstName = @SupConFirstName " + // remaining: for optimistic concurrency
                                    "OR SupConFirstName IS NULL And @SupConFirstName IS NULL " + 
                                    "AND SupConLastName = @SupConLastName " +
                                    "OR SupConLastName IS NULL AND @SupConLastName IS NULL " +
                                    "AND SupConCompany = @SupConCompany " +
                                    "OR SupConCompany IS NULL AND @SupConCompany IS NULL " +
                                    "AND SupConAddress = @SupConAddress " +
                                    "OR SupConAddress IS NULL AND @SupConAddress IS NULL " +
                                    "AND SupConCity = @SupConCity " +
                                    "OR SupConCity IS NULL AND @SupConCity IS NULL " +
                                    "AND SupConProv = @SupConProv " +
                                    "OR SupConProv IS NULL AND @SupConProv IS NULL " +
                                    "AND SupConPostal = @SupConPostal " +
                                    "OR SupConPostal IS NULL AND @SupConPostal IS NULL " +
                                    "AND SupConCountry = @SupConCountry " +
                                    "OR SupConCountry IS NULL AND @SupConCountry IS NULL " +
                                    "AND SupConBusPhone = @SupConBusPhone " +
                                    "OR SupConBusPhone IS NULL AND @SupConBusPhone IS NULL " +
                                    "AND SupConFax = @SupConFax " +
                                    "OR SupConFax IS NULL AND @SupConFax IS NULL " +
                                    "AND SupConEmail = @SupConEmail " +
                                    "OR SupConEmail IS NULL AND @SupConEmail IS NULL " +
                                    "AND SupConURL = @SupConURL " +
                                    "OR SupConURL IS NULL AND @SupConURL IS NULL " +
                                    "AND AffiliationID = @AffiliationID " +
                                    "OR AffiliationID IS NULL AND @AffiliationID IS NULL " +
                                    "AND SupplierId = @SupplierId " +
                                    "OR SupplierId IS NULL AND @SupplierId IS NULL";

            SqlCommand cmd = new SqlCommand(deleteStatement, cnc);

            cmd.Parameters.AddWithValue("@SupplierContactId", supplierContact.SupplierContactId);
            if (supplierContact.SupConFirstName == null)
                cmd.Parameters.AddWithValue("@SupConFirstName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConFirstName", supplierContact.SupConFirstName);
            if (supplierContact.SupConLastName == null)
                cmd.Parameters.AddWithValue("@SupConLastName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConLastName", supplierContact.SupConLastName);
            if (supplierContact.SupConCompany == null)
                cmd.Parameters.AddWithValue("@SupConCompany", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCompany", supplierContact.SupConCompany);
            if (supplierContact.SupConAddress == null)
                cmd.Parameters.AddWithValue("@SupConAddress", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConAddress", supplierContact.SupConAddress);
            if (supplierContact.SupConCity == null)
                cmd.Parameters.AddWithValue("@SupConCity", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCity", supplierContact.SupConCity);
            if (supplierContact.SupConProv == null)
                cmd.Parameters.AddWithValue("@SupConProv", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConProv", supplierContact.SupConProv);
            if (supplierContact.SupConPostal == null)
                cmd.Parameters.AddWithValue("@SupConPostal", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConPostal", supplierContact.SupConPostal);
            if (supplierContact.SupConCountry == null)
                cmd.Parameters.AddWithValue("@SupConCountry", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCountry", supplierContact.SupConCountry);
            if (supplierContact.SupConBusPhone == null)
                cmd.Parameters.AddWithValue("@SupConBusPhone", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConBusPhone", supplierContact.SupConBusPhone);
            if (supplierContact.SupConFax == null)
                cmd.Parameters.AddWithValue("@SupConFax", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConFax", supplierContact.SupConFax);
            if (supplierContact.SupConEmail == null)
                cmd.Parameters.AddWithValue("@SupConEmail", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConEmail", supplierContact.SupConEmail);
            if (supplierContact.SupConURL == null)
                cmd.Parameters.AddWithValue("@SupConURL", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConURL", supplierContact.SupConURL);
            if (supplierContact.AffiliationID == null)
                cmd.Parameters.AddWithValue("@AffiliationId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@AffiliationId", supplierContact.AffiliationID);
            if (supplierContact.SupplierId == null)
                cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupplierId", supplierContact.SupplierId);


            try 
            {
                cnc.Open();
                int count = cmd.ExecuteNonQuery();
                if (count == 0) // optimistic concurrency violation
                    success = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }

            return success;
        }


        public static int AddContact(SupplierContacts supplierContact)
        {
            int suppConId = 0;

            SqlConnection cnc = TravelExpertDB.GetConnection();

            string insertStatement = "INSERT INTO SupplierContacts (SupConFirstName, SupConLastName, SupConCompany, SupConAddress, " +
                "SupConCity, SupConProv, SupConPostal, SupConCountry, SupConBusPhone, SupConFax, SupConEmail, SupConURL," +
                "AffiliationID, SupplierId) OUTPUT inserted.[SupplierContactId] " +

                "VALUES(@SupConFirstName, @SupConLastName, @SupConCompany, @SupConAddress, @SupConCity, @SupConProv, @SupConPostal," +
                "@SupConCountry, @SupConBusPhone, @SupConFax, @SupConEmail, @SupConURL, @AffiliationID,  @SupplierId)";

            SqlCommand cmd = new SqlCommand(insertStatement, cnc);

            if (supplierContact.SupConFirstName == null)
                cmd.Parameters.AddWithValue("@SupConFirstName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConFirstName", supplierContact.SupConFirstName);
            if (supplierContact.SupConLastName == null)
                cmd.Parameters.AddWithValue("@SupConLastName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConLastName", supplierContact.SupConLastName);
            if (supplierContact.SupConCompany == null)
                cmd.Parameters.AddWithValue("@SupConCompany", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCompany", supplierContact.SupConCompany);
            if (supplierContact.SupConAddress == null)
                cmd.Parameters.AddWithValue("@SupConAddress", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConAddress", supplierContact.SupConAddress);
            if (supplierContact.SupConCity == null)
                cmd.Parameters.AddWithValue("@SupConCity", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCity", supplierContact.SupConCity);
            if (supplierContact.SupConProv == null)
                cmd.Parameters.AddWithValue("@SupConProv", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConProv", supplierContact.SupConProv);
            if (supplierContact.SupConPostal == null)
                cmd.Parameters.AddWithValue("@SupConPostal", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConPostal", supplierContact.SupConPostal);
            if (supplierContact.SupConCountry == null)
                cmd.Parameters.AddWithValue("@SupConCountry", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCountry", supplierContact.SupConCountry);
            if (supplierContact.SupConBusPhone == null)
                cmd.Parameters.AddWithValue("@SupConBusPhone", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConBusPhone", supplierContact.SupConBusPhone);
            if (supplierContact.SupConFax == null)
                cmd.Parameters.AddWithValue("@SupConFax", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConFax", supplierContact.SupConFax);
            if (supplierContact.SupConEmail == null)
                cmd.Parameters.AddWithValue("@SupConEmail", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConEmail", supplierContact.SupConEmail);
            if (supplierContact.SupConURL == null)
                cmd.Parameters.AddWithValue("@SupConURL", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConURL", supplierContact.SupConURL);
            if (supplierContact.AffiliationID == null)
                cmd.Parameters.AddWithValue("@AffiliationId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@AffiliationId", supplierContact.AffiliationID);
            if (supplierContact.SupplierId == null)
                cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupplierId", supplierContact.SupplierId);

            try
            {
                cnc.Open();
                suppConId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnc.Close();
            }
            return suppConId;
        }

        
        public static int UpdateContact(SupplierContacts oldContact, SupplierContacts newContact)
        {
            int count = 0;
            
            SqlConnection cnc = TravelExpertDB.GetConnection();

            string UpdateStatement = "update SupplierContacts set " +
                                    "SupConFirstName = @NewSupConFirstName, " +                                     
                                    "SupConLastName = @NewSupConLastName, " +                                   
                                    "SupConCompany = @NewSupConCompany, " +
                                    "SupConAddress = @NewSupConAddress, " +
                                    "SupConCity = @NewSupConCity, " +
                                    "SupConProv = @NewSupConProv, " +
                                    "SupConPostal = @NewSupConPostal, " +
                                    "SupConCountry = @NewSupConCountry, " +
                                    "SupConBusPhone = @NewSupConBusPhone, " +
                                    "SupConFax = @NewSupConFax, " +
                                    "SupConEmail = @NewSupConEmail, " +
                                    "SupConURL = @NewSupConURL, " +
                                    "AffiliationID = @NewAffiliationID, " +
                                    "SupplierId = @NewSupplierId " +

                                    "WHERE SupplierContactId = @SupplierContactId " + // to identify record
                                    "AND SupConFirstName = @SupConFirstName " + // remaining: for optimistic concurrency
                                    "OR SupConFirstName IS NULL And @SupConFirstName IS NULL " +
                                    "AND SupConLastName = @SupConLastName " +
                                    "OR SupConLastName IS NULL AND @SupConLastName IS NULL " +
                                    "AND SupConCompany = @SupConCompany " +
                                    "OR SupConCompany IS NULL AND @SupConCompany IS NULL " +
                                    "AND SupConAddress = @SupConAddress " +
                                    "OR SupConAddress IS NULL AND @SupConAddress IS NULL " +
                                    "AND SupConCity = @SupConCity " +
                                    "OR SupConCity IS NULL AND @SupConCity IS NULL " +
                                    "AND SupConProv = @SupConProv " +
                                    "OR SupConProv IS NULL AND @SupConProv IS NULL " +
                                    "AND SupConPostal = @SupConPostal " +
                                    "OR SupConPostal IS NULL AND @SupConPostal IS NULL " +
                                    "AND SupConCountry = @SupConCountry " +
                                    "OR SupConCountry IS NULL AND @SupConCountry IS NULL " +
                                    "AND SupConBusPhone = @SupConBusPhone " +
                                    "OR SupConBusPhone IS NULL AND @SupConBusPhone IS NULL " +
                                    "AND SupConFax = @SupConFax " +
                                    "OR SupConFax IS NULL AND @SupConFax IS NULL " +
                                    "AND SupConEmail = @SupConEmail " +
                                    "OR SupConEmail IS NULL AND @SupConEmail IS NULL " +
                                    "AND SupConURL = @SupConURL " +
                                    "OR SupConURL IS NULL AND @SupConURL IS NULL " +
                                    "AND AffiliationID = @AffiliationID " +
                                    "OR AffiliationID IS NULL AND @AffiliationID IS NULL " +
                                    "AND SupplierId = @SupplierId " +
                                    "OR SupplierId IS NULL AND @SupplierId IS NULL";

            SqlCommand cmd = new SqlCommand(UpdateStatement, cnc);

            cmd.Parameters.AddWithValue("@NewSupplierContactId", newContact.SupplierContactId);

            if (newContact.SupConFirstName == null)
                cmd.Parameters.AddWithValue("@NewSupConFirstName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConFirstName", newContact.SupConFirstName);

            if (newContact.SupConLastName == null)
                cmd.Parameters.AddWithValue("@NewSupConLastName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConLastName", newContact.SupConLastName);

            if (newContact.SupConCompany == null)
                cmd.Parameters.AddWithValue("@NewSupConCompany", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConCompany", newContact.SupConCompany);

            if (newContact.SupConAddress == null)
                cmd.Parameters.AddWithValue("@NewSupConAddress", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConAddress", newContact.SupConAddress);

            if (newContact.SupConCity == null)
                cmd.Parameters.AddWithValue("@NewSupConCity", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConCity", newContact.SupConCity);

            if (newContact.SupConProv == null)
                cmd.Parameters.AddWithValue("@NewSupConProv", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConProv", newContact.SupConProv);

            if (newContact.SupConPostal == null)
                cmd.Parameters.AddWithValue("@NewSupConPostal", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConPostal", newContact.SupConPostal);

            if (newContact.SupConCountry == null)
                cmd.Parameters.AddWithValue("@NewSupConCountry", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConCountry", newContact.SupConCountry);

            if (newContact.SupConBusPhone == null)
                cmd.Parameters.AddWithValue("@NewSupConBusPhone", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConBusPhone", newContact.SupConBusPhone);

            if (newContact.SupConFax == null)
                cmd.Parameters.AddWithValue("@NewSupConFax", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConFax", newContact.SupConFax);

            if (newContact.SupConEmail == null)
                cmd.Parameters.AddWithValue("@NewSupConEmail", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConEmail", newContact.SupConEmail);

            if (newContact.SupConURL == null)
                cmd.Parameters.AddWithValue("@NewSupConURL", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupConURL", newContact.SupConURL);

            if (newContact.AffiliationID == null)
                cmd.Parameters.AddWithValue("@NewAffiliationId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewAffiliationId", newContact.AffiliationID);

            if (newContact.SupplierId == null)
                cmd.Parameters.AddWithValue("@NewSupplierId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewSupplierId", newContact.SupplierId);



            cmd.Parameters.AddWithValue("@SupplierContactId", oldContact.SupplierContactId);
            if (oldContact.SupConFirstName == null)
                cmd.Parameters.AddWithValue("@SupConFirstName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConFirstName", oldContact.SupConFirstName);
            if (oldContact.SupConLastName == null)
                cmd.Parameters.AddWithValue("@SupConLastName", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConLastName", oldContact.SupConLastName);
            if (oldContact.SupConCompany == null)
                cmd.Parameters.AddWithValue("@SupConCompany", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCompany", oldContact.SupConCompany);
            if (oldContact.SupConAddress == null)
                cmd.Parameters.AddWithValue("@SupConAddress", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConAddress", oldContact.SupConAddress);
            if (oldContact.SupConCity == null)
                cmd.Parameters.AddWithValue("@SupConCity", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCity", oldContact.SupConCity);
            if (oldContact.SupConProv == null)
                cmd.Parameters.AddWithValue("@SupConProv", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConProv", oldContact.SupConProv);
            if (oldContact.SupConPostal == null)
                cmd.Parameters.AddWithValue("@SupConPostal", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConPostal", oldContact.SupConPostal);
            if (oldContact.SupConCountry == null)
                cmd.Parameters.AddWithValue("@SupConCountry", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConCountry", oldContact.SupConCountry);
            if (oldContact.SupConBusPhone == null)
                cmd.Parameters.AddWithValue("@SupConBusPhone", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConBusPhone", oldContact.SupConBusPhone);
            if (oldContact.SupConFax == null)
                cmd.Parameters.AddWithValue("@SupConFax", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConFax", oldContact.SupConFax);
            if (oldContact.SupConEmail == null)
                cmd.Parameters.AddWithValue("@SupConEmail", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConEmail", oldContact.SupConEmail);
            if (oldContact.SupConURL == null)
                cmd.Parameters.AddWithValue("@SupConURL", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupConURL", oldContact.SupConURL);
            if (oldContact.AffiliationID == null)
                cmd.Parameters.AddWithValue("@AffiliationId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@AffiliationId", oldContact.AffiliationID);
            if (oldContact.SupplierId == null)
                cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@SupplierId", oldContact.SupplierId);

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

    }
}
