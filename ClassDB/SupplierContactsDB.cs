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
                                    "AND SupConLastName = @SupConLastName " +
                                    "AND SupConCompany = @SupConCompany " +
                                    "AND SupConAddress = @SupConAddress " +
                                    "AND SupConCity = @SupConCity " +
                                    "AND SupConProv = @SupConProv" +
                                    "AND SupConPostal = @SupConPostal" +
                                    "AND SupConCountry = @SupConCountry" +
                                    "AND SupConBusPhone = @SupConBusPhone" +
                                    "AND SupConFax = @SupConFax" +
                                    "AND SupConEmail = @SupConEmail" +
                                    "AND SupConURL = @SupConURL" +
                                    "AND AffiliationID = @AffiliationID" +
                                    "AND SupplierId = @SupplierId";

            SqlCommand cmd = new SqlCommand(deleteStatement, cnc);

            cmd.Parameters.AddWithValue("@SupplierContactId", supplierContact.SupplierContactId);
            cmd.Parameters.AddWithValue("@SupConFirstName", supplierContact.SupConFirstName);
            cmd.Parameters.AddWithValue("@SupConLastName", supplierContact.SupConLastName);
            cmd.Parameters.AddWithValue("@SupConCompany", supplierContact.SupConCompany);
            cmd.Parameters.AddWithValue("@SupConAddress", supplierContact.SupConAddress);
            cmd.Parameters.AddWithValue("@SupConCity", supplierContact.SupConCity);
            cmd.Parameters.AddWithValue("@SupConProv", supplierContact.SupConProv);
            cmd.Parameters.AddWithValue("@SupConPostal", supplierContact.SupConPostal);
            cmd.Parameters.AddWithValue("@SupConCountry", supplierContact.SupConCountry);
            cmd.Parameters.AddWithValue("@SupConBusPhone", supplierContact.SupConBusPhone);
            cmd.Parameters.AddWithValue("@SupConFax", supplierContact.SupConFax);
            cmd.Parameters.AddWithValue("@SupConEmail", supplierContact.SupConEmail);
            cmd.Parameters.AddWithValue("@SupConURL", supplierContact.SupConURL);
            cmd.Parameters.AddWithValue("@AffiliationId", supplierContact.AffiliationID);
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


        public static int AddContact(SupplierContacts supCon)
        {
            int suppConId = 0;

            SqlConnection con = TravelExpertDB.GetConnection();

            //string insertStatement = "INSERT INTO Customers (Name, Address, City, State, ZipCode) " +
            //    "OUTPUT inserted.[CustomerID] " +
            //    "VALUES(@Name, @Address, @City, @State, @ZipCode)";

            //SqlCommand cmd = new SqlCommand(insertStatement, con);

            //cmd.Parameters.AddWithValue("@Name", cust.Name);
            //cmd.Parameters.AddWithValue("@Address", cust.Address);
            //cmd.Parameters.AddWithValue("@City", cust.City);
            //cmd.Parameters.AddWithValue("@State", cust.State);
            //cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);

            //try
            //{
            //    con.Open();
            //    custID = (int)cmd.ExecuteScalar();
            //    //string selectQuery = "SELECT IDENT_CURRENT('Customers') FROM Customers"; // identity value
            //    //SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            //    //custID = Convert.ToInt32(selectCommand.ExecuteScalar()); // single value
            //    // typecasting (int) does not work
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    con.Close();
            //}


            return suppConId;
        }



        public static bool UpdateContact(SupplierContacts oldContact, SupplierContacts newContact)
        {
            bool success = true;
            //SqlConnection con = MMABooksDB.GetConnection();
            //string updateStatement = "UPDATE Customers SET " +
            //                         "Name = @NewName, " +
            //                         "Address = @NewAddress, " +
            //                         "City = @NewCity, " +
            //                         "State = @NewState, " +
            //                         "ZipCode = @NewZipCode " +
            //                         "WHERE CustomerID = @OldCustomerID " + // to identify record to update
            //                         "AND Name = @OldName " + // remaining conditions for optimistic concurrency
            //                         "AND Address = @OldAddress " +
            //                         "AND City = @OldCity " +
            //                         "AND State = @OldState " +
            //                         "AND ZipCode = @OldZipCode";
            //SqlCommand cmd = new SqlCommand(updateStatement, con);
            //cmd.Parameters.AddWithValue("@NewName", newCustomer.Name);
            //cmd.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
            //cmd.Parameters.AddWithValue("@NewCity", newCustomer.City);
            //cmd.Parameters.AddWithValue("@NewState", newCustomer.State);
            //cmd.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);
            //cmd.Parameters.AddWithValue("@OldCustomerID", oldCustomer.CustomerID);
            //cmd.Parameters.AddWithValue("@OldName", oldCustomer.Name);
            //cmd.Parameters.AddWithValue("@OldAddress", oldCustomer.Address);
            //cmd.Parameters.AddWithValue("@OldCity", oldCustomer.City);
            //cmd.Parameters.AddWithValue("@OldState", oldCustomer.State);
            //cmd.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode);

            //try
            //{
            //    con.Open();
            //    int rowsUpdated = cmd.ExecuteNonQuery();
            //    if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    con.Close();
            //}

            return success;
        }

    }
}
