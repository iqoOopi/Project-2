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
        /// <param name="reference">Type of required data type etc. int</param>
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

    }
}
