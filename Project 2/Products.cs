using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Henry March 1st
    /// Refer to "Products" Table in DB, need commit prior to table "products_suppliers" as Id is requried
    /// </summary>
    public class Products
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }

        /// <summary>
        /// Constructor for Read from DB
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="prodName"></param>
        public Products(int productId, string prodName)
        {
            ProductId = productId;
            ProdName = prodName;
        }

        /// <summary>
        /// Constructor for create new Product, Id should be NULL as it is auto incremental
        /// </summary>
        /// <param name="prodName"></param>
        public Products(string prodName)
        {
            ProdName = prodName;
        }

        /// <summary>
        /// ToString for Display
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Generate MySQL command for save new product to DB
        /// </summary>
        /// <returns></returns>
        public string AddToSQL()
        {
            return null;
        }

        /// <summary>
        /// Generate MySQL command for updating existing product
        /// </summary>
        /// <returns></returns>
        public string EditToSQL()
        {
            return null;
        }

        /// <summary>
        /// Generate MySQL command 
        /// </summary>
        /// <returns></returns>
        public string DeleteFromSQL()
        {
            return null;
        }

        //-----------------------------------------------------------------------
        // Equals and HashCode to compare existing products to avoid duplicate
        //only check product Name
        public override bool Equals(object obj)
        {
            var products = obj as Products;
            return products != null &&
                   ProdName == products.ProdName;
        }

        public override int GetHashCode()
        {
            return 78275079 + EqualityComparer<string>.Default.GetHashCode(ProdName);
        }

        public static bool operator ==(Products products1, Products products2)
        {
            return EqualityComparer<Products>.Default.Equals(products1, products2);
        }

        public static bool operator !=(Products products1, Products products2)
        {
            return !(products1 == products2);
        }
        //-----------------------------------------------------------------------



    }
}
