using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassDB
{
    /// <summary>
    /// This the generic read and update method I created to use in WorkShop4,
    /// This can take care any object from any DB
    /// Sql command is just string, so the key idea is to use stringbuilder to build the
    /// required sql command during the run time.
    /// 
    /// ***** the Classes mush have a constructor that takes 0 argument.
    /// </summary>
    public static class GenericDB
    {
        /// <summary>
        /// Generic Reading method for get instants of certain Class from corresponding DB Tables
        /// </summary>
        /// <typeparam name="T"> Generic Type, could be Products, packages etc. 
        /// ***** the Classes mush have a constructor that takes 0 argument.
        /// </typeparam>
        /// <param name="tableName">Corresponding Table Name in DB</param>
        /// <returns>A list of requried entity classes for the corresponding DB </returns>
        public static List<T> GenericRead<T>(string tableName) //need inherit from ParentClass so that I can call the extra method
        {
            List<T> classData = new List<T>();//List to hold result

            T obj = Activator.CreateInstance<T>();//create an instant of Class T, something like: Products obj=new Products();
                                                  //can't use T obj = new T()

            //prepare the Sql Syntax for the query
            StringBuilder FieldToSqlSyntax = new StringBuilder();
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                FieldToSqlSyntax.Append(property.Name).Append(",");
            }
            FieldToSqlSyntax.Length--;//remove the last ","

            using (SqlConnection connection = TravelExpertDB.GetConnection())//using method could auto close resources, so the connection got closed automatically
            {
                //The select Sql Syntax
                string selectStatement = "SELECT " + FieldToSqlSyntax + " " +
                                         "FROM " + tableName + " " + "ORDER BY 1";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))//auto close Sqlcommand
                {
                    connection.Open();
                    using (SqlDataReader dr = selectCommand.ExecuteReader())//auto close reader
                    {
                        while (dr.Read())
                        {
                            T tempObj = Activator.CreateInstance<T>();//temp entity class
                            PropertyInfo[] tempProperties = tempObj.GetType().GetProperties();//get all the field of this entity class
                                                                                              //if T is Products Class,
                                                                                              //properties will looks like {ProductID, prodName}
                            foreach (PropertyInfo property in tempProperties)
                            {
                                if (dr[property.Name] != DBNull.Value)
                                {
                                    //if the property is nullable, etc "datatime?"(this is a nullable type with datatime type underlying it)
                                    //to get the actual type (datatime) out of "datatime?" by calling Nullable.GetUnderlyingType
                                    //if the property is not nullable, etc int, then the "??" will return right-side property.propertyType which is "int" since left side is "null". 
                                    Type t = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                    //cast the reader result (Object type) to correct type and then assign the value.
                                    //if T is Products Class, It's just like tempObj.ProductID=Convert.toInt32(dr["ProductID"])
                                    property.SetValue(tempObj, Convert.ChangeType(dr[property.Name], t));
                                }
                                else
                                {
                                    //DBNull.Value in DB table, so set the property to null
                                    property.SetValue(tempObj, null);
                                }
                            }
                            classData.Add(tempObj);//add temp entity class to the result List
                        }
                    }
                }

            }
            return classData;//returen results
        }

        /// <summary>
        /// Generic update a record in DB
        /// </summary>
        /// <typeparam name="T">Generic class
        /// ***** the Classes mush have a constructor that takes 0 argument.
        /// </typeparam>
        /// <param name="tableName">Name of the DB Table</param>
        /// <param name="oldObj">the unchanged object for checking concurrency issue</param>
        /// <param name="newObj">the changed object</param>
        /// <param name="sqlCon">to receive outside connection so that enable transcation </param>
        /// <param name="sqlTran">to receive outside transcation so that enable commit or rollback </param>
        /// <returns></returns>
        public static int GenericUpdate<T>(string tableName, T oldObj, T newObj,SqlConnection sqlCon=null, SqlTransaction sqlTran=null)
        {
            int count = 0;
            bool useOutsideConnection=true;//indatictor of outside connection received
            
            //if no outside connection received, set indatictor to false, then start the connection.
            if(sqlCon == null)
            {
                useOutsideConnection = false;
                sqlCon = TravelExpertDB.GetConnection();
            }

            //Prepare the Update Sql Syntax
            StringBuilder FieldToSqlSet = new StringBuilder();
            PropertyInfo[] properties = oldObj.GetType().GetProperties();
            properties = properties.Skip(1).ToArray();//skip the primary key, as we don't need to update PK
            foreach (PropertyInfo property in properties)
            {
                FieldToSqlSet.Append(property.Name).Append("=@New").Append(property.Name).Append(",");
            }
            FieldToSqlSet.Length--;//remove the last ","

            //prepare the sql syntax for concurrency check
            StringBuilder FieldToSqlWhere = new StringBuilder();
            properties = oldObj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                FieldToSqlWhere.Append("(" + property.Name + "=@Old" + property.Name + " OR ")
               .Append(property.Name + " IS NULL AND @Old" + property.Name + " IS NULL)")
               .Append(" AND ");
            }
            FieldToSqlWhere.Length = FieldToSqlWhere.Length - 5;//remove the last " AND "

            string selectStatement = "UPDATE " + tableName + " SET " + FieldToSqlSet +
                                 " WHERE " + FieldToSqlWhere;

            SqlCommand cmd = new SqlCommand(selectStatement, sqlCon);

            //if outside transcation passed in, bound the sql command with the transcation 
            if (sqlTran != null)
            {
                cmd.Transaction = sqlTran;
            }

            PropertyInfo[] newObjProperties = newObj.GetType().GetProperties();//get all the field of this entity class
                                                                               //if T is Products Class,
                                                                               //properties will looks like {ProductID, prodName}

            //bound @new 
            newObjProperties = newObjProperties.Skip(1).ToArray();//skip the primary key, as we don't need to update
            foreach (PropertyInfo property in newObjProperties)
            {
                if (property.GetValue(newObj) == null)
                {
                    cmd.Parameters.AddWithValue("@New" + property.Name, DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@New" + property.Name, property.GetValue(newObj, null));
                }
            }

            //Bound @old
            PropertyInfo[] oldObjProperties = oldObj.GetType().GetProperties();//get all the field of this entity class
                                                                               //if T is Products Class,
                                                                               //properties will looks like {ProductID, prodName}
            foreach (PropertyInfo property in oldObjProperties)
            {
                if (property.GetValue(oldObj) == null)
                {
                    cmd.Parameters.AddWithValue("@Old" + property.Name, DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Old" + property.Name, property.GetValue(oldObj, null));
                }
            }

            //if no outsideConnection passed in, open the connection
            if (!useOutsideConnection)
            {
                sqlCon.Open();
            }

            //execute the query
            count = cmd.ExecuteNonQuery();

            ////if no outsideConnection passed in, close the connection
            if (!useOutsideConnection)
            {
                sqlCon.Close();
            }


            return count;
        }

    }
}
