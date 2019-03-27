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

        //constructor to ensure order of parameters is the same as what is required in the AddProducts method
        public ProductsSuppliers(int prodSuppid, int? prodid, int? supid)
        {
            ProductSupplierId = prodSuppid;
            ProductId = prodid;
            SupplierId = supid;
        }
        // regular constructor
        public ProductsSuppliers() { }

        // HashCode for indexing when checking for double entries when adding new product
        public override bool Equals(object obj)
        {
            var suppliers = obj as ProductsSuppliers;
            return suppliers != null &&
                   EqualityComparer<int?>.Default.Equals(ProductId, suppliers.ProductId) &&
                   EqualityComparer<int?>.Default.Equals(SupplierId, suppliers.SupplierId);
        }
        
        public override int GetHashCode()
        {
            var hashCode = 1853477397;
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(ProductId);
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(SupplierId);
            return hashCode;
        }

        public static bool operator ==(ProductsSuppliers suppliers1, ProductsSuppliers suppliers2)
        {
            return EqualityComparer<ProductsSuppliers>.Default.Equals(suppliers1, suppliers2);
        }

        public static bool operator !=(ProductsSuppliers suppliers1, ProductsSuppliers suppliers2)
        {
            return !(suppliers1 == suppliers2);
        }
    }
}
