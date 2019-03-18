using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{/// <summary>
/// Linda Wallace
/// Business class for ProductsSuppliers table
/// </summary>
    public class ProductsSuppliers
    {
        public int ProductSupplerId { get; set; }

        public int? ProductId { get; set; }

        public int? SupplierId { get; set; }
    }
}
