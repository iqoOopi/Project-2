using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{/// <summary>
/// Linda Wallace
/// Business class for ProductsSuppliers table
/// </summary>
    public class ProductsSuppliers
    {
        public int ProductSupplierId { get; set; }

        public int? ProductId { get; set; }

        public int? SupplierId { get; set; }

        public ProductsSuppliers(int ProductsSupplierID, int? ProductId, int? SupplierId) { }
    }
}
