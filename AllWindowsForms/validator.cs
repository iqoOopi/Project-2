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
        /// Checks if content of text box is non-empty
        /// </summary>
        /// <param name="tb">textBox to Check</param>
        /// <param name="name">Name to use in errorMessage</param>
        /// <returns>is it valid</returns>
        public static bool IsProvided (TextBox tb, string name)
        {
            bool result=true;
            if (tb.Text == "")
            {
                result = false;
                MessageBox.Show(name + " has to be provided","Input Error");
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
        public static bool IsNonNegative(TextBox tb, string name, Type reference)
        {
            bool result = true;
            try
            {
                dynamic var = Convert.ChangeType(tb.Text, reference);
                if (var < 0)
                {
                    result = false;
                    MessageBox.Show(name + " has to be a non-negative "+reference.Name+" number", "Input Error");
                    tb.SelectAll();//highlight text on the box for easy replacing
                    tb.Focus();
                }
            } catch(Exception)
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative " + reference.Name + " number", "Input Error");
                tb.SelectAll();//highlight text on the box for easy replacing
                tb.Focus();
            }
                return result;

        }
    }
}
