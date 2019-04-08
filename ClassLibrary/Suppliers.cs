using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Hoora - March
    /// Class to create supplier objects
    /// </summary>
    
    public class Suppliers
    {
        // Constructor:
        public Suppliers() { }

        public Suppliers(int supplierId, string supName)
        {
            SupplierId = supplierId;
            SupName = supName;
        }


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
