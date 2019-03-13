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
        public static List <T> GenericRead<T>(string tableName,int id=-1) where T : ParentClass
        {
            List<T> classData = new List<T>();
            T obj = Activator.CreateInstance<T>();
            using (SqlConnection connection = TravelExpertDB.GetConnection())
            {
                string selectStatement = "SELECT " + obj.FieldToSqlSyntax() + " " +
                                         "FROM " + tableName + " " + "ORDER BY " + obj.KeyFieldName();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dr = selectCommand.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                obj = Activator.CreateInstance<T>();
                                PropertyInfo[] properties = obj.GetType().GetProperties();
                                foreach (PropertyInfo property in properties)
                                {

                                    property.SetValue(obj,Convert.ChangeType(dr[property.Name],property.GetType()));
                                }
                                classData.Add(obj);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                    
       
            }



                return classData;
        }

    }
}
