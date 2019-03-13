using Project_2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassDB
{
    public static class GenericReadWrite
    {
        /// <summary>
        /// Generic Reading method for get instants of certain Class from corresponding DB Tables
        /// </summary>
        /// <typeparam name="T"> Generic Type, could be Products, packages etc.</typeparam>
        /// <param name="tableName">Corresponding Table Name in DB</param>
        /// <returns>A list of requried entity classes for the corresponding DB </returns>
        public static List <T> GenericRead<T>(string tableName) where T : ParentClass //need inherit from ParentClass so that I can call the extra method
        {
            List<T> classData = new List<T>();//List to hold result
            
            T obj = Activator.CreateInstance<T>();//create an instant of Class T, something like: Products obj=new Products();
                                                  //can't use T obj = new T()
            using (SqlConnection connection = TravelExpertDB.GetConnection())//using method could auto close resources, so the connection got closed automatically
            {
                //The select Sql Syntax
                string selectStatement = "SELECT " + obj.FieldToSqlSyntax() + " " +
                                         "FROM " + tableName + " " + "ORDER BY " + obj.KeyFieldName();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))//auto close Sqlcommand
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dr = selectCommand.ExecuteReader())//auto close reader
                        {
                            while (dr.Read())
                            {
                                T tempObj = Activator.CreateInstance<T>();//temp entity class
                                PropertyInfo[] properties = tempObj.GetType().GetProperties();//get all the field of this entity class
                                                                                              //if T is Products Class,
                                                                                              //properties will looks like {ProductID, prodName}
                                foreach (PropertyInfo property in properties)
                                {
                                    //cast the reader result (string type) to correct type and then assign the value.
                                    //if T is Products Class, It's just like tempObj.ProductID=Convert.toInt32(dr["ProductID"])
                                    property.SetValue(tempObj, Convert.ChangeType(dr[property.Name], property.PropertyType));
                                }
                                classData.Add(tempObj);//add temp entity class to the result List
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;//throw any exception out
                    }
                }
                    
            }
                return classData;//returen results
        }

    }
}
