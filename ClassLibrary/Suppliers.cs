using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibary
{
    /// <summary>
    /// Hoora - March
    /// Class to create supplier objects
    /// </summary>
    /// 
    public class Suppliers
    {
        // Constructor:
        public Suppliers() { }


        // properties:
        public int SupplierId { get; set; }

        public string SupName { get; set; }


        // methods:
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
