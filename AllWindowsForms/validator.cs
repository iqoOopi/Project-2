﻿using System;
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
        /// <param name="tb">textBox to Check</param>
        /// <param name="name">Name to use in errorMessage</param>
        /// <returns>is it valid</returns>
        public static bool IsProvided (Control tb, string name)
        {
            bool result=true;
            try
            {
                if (tb.Text == "")
                {
                    result = false;
                    MessageBox.Show(name + " has to be provided", "Input Error");
                    tb.Focus();
                }

            }
            catch (Exception)
            {
                result = false;
                MessageBox.Show(name + " has to be provided", "Input Error");
                tb.Focus();
            }

            return result;

        }

        /// <summary>
        /// Generic check is the input a non-negative number of a certain data type. (int,double etc.) 
        /// </summary>
        /// <param name="tb">textBox for Input</param>
        /// <param name="name">Name to use in errorMessage</param>
        /// <param name="reference">Type of required data type etc. int,double,decimal</param>
        /// <returns>is it valid</returns>
        public static bool IsNonNegative(Control tb, string name, Type reference)
        {
            bool result = true;
            try
            {
                dynamic var = Convert.ChangeType(tb.Text, reference);
                if (var < 0)
                {
                    result = false;
                    MessageBox.Show(name + " has to be a non-negative "+reference.Name+" number", "Input Error");
                    
                    tb.Focus();
                }
            } catch(Exception)
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative " + reference.Name + " number", "Input Error");
                tb.Focus();
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
        /// Generate Check are there a duplication with existing data, with optional exception item that will ignore
        /// the duplicate with it.
        /// class must have equals and Hashcode in order for this method to work
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="listItems">the list of existing data</param>
        /// <param name="item">the new item </param>
        /// <param name="ExceptionItem">the exception data</param>
        /// <returns> true for duplication found. </returns>
        public static bool checkNoDuplicate<T> (List<T> listItems, T item, T exceptionItem=default(T))
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
