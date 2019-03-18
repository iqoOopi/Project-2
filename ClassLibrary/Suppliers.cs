using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    /// <summary>
    /// Hoora - March
    /// Class to create suppliers objects
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
