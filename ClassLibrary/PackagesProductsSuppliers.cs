using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{/// <summary>
/// Linda Wallace
/// business class for PackagesProductsSuppliers table
/// </summary>
    public class PackagesProductsSuppliers
    {
        public int PackageId { get; set; }

        public int ProductSupplierId { get; set; }
        //constructor to ensure the order of the fields is the same as the AddProducts method
        public PackagesProductsSuppliers(int packid, int prodSupid)
        {
            PackageId = packid;
            ProductSupplierId = prodSupid;
        }
        // regular constructor
        public PackagesProductsSuppliers() { }
    }
}
