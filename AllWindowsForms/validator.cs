using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllWindowsForms
{
    public static class validator //a collection of static validation method
    {
        /// <summary>
        /// Generic checks if content of input is non-empty
        /// </summary>
        /// <param name="ct">input to Check, could be textbox or combobox etc.</param>
        /// <param name="name">Name to use in errorMessage</param>
        /// <returns>is it valid</returns>
        public static bool IsProvided (Control ct, string name)
        {
            //textbox and combox is the Child class of Control, and Control has .text and .focus()
            bool result=true;
            try
            {
                if (ct.Text == "")
                {
                    result = false;
                    MessageBox.Show(name + " has to be provided", "Input Error");
                    ct.Focus();
                }

            }
            catch (Exception)
            {
                result = false;
                MessageBox.Show(name + " has to be provided", "Input Error");
                ct.Focus();
            }

            return result;

        }

        /// <summary>
        /// Generic check is the input a non-negative number of a certain data type. (int,double etc.) 
        /// </summary>
        /// <param name="ct">textBox for Input</param>
        /// <param name="name">Name to use in errorMessage</param>
        /// <param name="reference">Type of required data type etc. int,double,decimal</param>
        /// <returns>is it valid</returns>
        public static bool IsNonNegative(Control ct, string name, Type reference)
        {
            bool result = true;
            try
            {
                dynamic var = Convert.ChangeType(ct.Text, reference);
                if (var < 0)
                {
                    result = false;
                    MessageBox.Show(name + " has to be a non-negative "+reference.Name+" number", "Input Error");
                    
                    ct.Focus();
                }
            } catch(Exception)
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative " + reference.Name + " number", "Input Error");
                ct.Focus();
            }
                return result;

        }
        /// <summary>
        /// Check the length of input, must less than DB settings.
        /// </summary>
        /// <param name="ct">generic type for textBox, comboBox etc.</param>
        /// <param name="name">Name of Input Control</param>
        /// <param name="dbLength">the required max Length of DB coloumn</param>
        /// <returns></returns>
        public static bool IsValidLength(Control ct,string name, int dbLength)
        {
            bool result = true;
            try
            {
                
                if (ct.Text.Length>dbLength)
                {
                    result = false;
                    MessageBox.Show(name + " has to be less than" + dbLength+ " characters", "Input Error");
                    ct.Focus();
                }
            }
            catch (Exception)
            {
                result = false;
                MessageBox.Show(name + " has to be less than " + dbLength + " characters", "Input Error");
                ct.Focus();
            }
            return result;

        }
        /// <summary>
        /// generic check are there a duplication with existing data, with optional "exceptionItem" argument that will ignore
        /// the duplication with it.
        /// !!!!!!!!class must have equals and Hashcode overrided in order for this method to work!!!!!!!!!
        /// </summary>
        /// <typeparam name="T">generic class type, etc. products, suppliers</typeparam>
        /// <param name="listItems">the list of existing data</param>
        /// <param name="item">the new item need to be checked</param>
        /// <param name="ExceptionItem">the exception data</param>
        /// <returns> true for duplication found. </returns>
        public static bool checkNoDuplicate<T> (List<T> listItems, T item, T exceptionItem=default(T))//if T is reference type, default(T) will be null. 
            //if T is value type, default(T) I think will be 0
        {
            bool result = true;
            foreach (T tempData in listItems)
            {
                //if exceptionItem is provided, only check duplication with other items.
                if (!tempData.Equals(exceptionItem))
                {
                    if (item.Equals(tempData))
                    {
                        result = false;
                        MessageBox.Show("There are already same data existing in the DB", "Duplicate Data");
                    }
                }
            }
            return result;
        }

    }
}
