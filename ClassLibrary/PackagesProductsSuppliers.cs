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

        public PackagesProductsSuppliers(int PackageId, int ProductSupplierId) { }
    }
}
