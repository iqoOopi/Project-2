﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    /// <summary>
    /// Hoora - March
    /// Class to create supplier contact objects
    /// </summary>
    public class SupplierContacts
    {
        // Constructor:
        public SupplierContacts() { }

        // properties:
        public int SupplierContactId { get; set; }

        public string SupConFirstName { get; set; }

        public string SupConLastName { get; set; }

        public string SupConCompany { get; set; }

        public string SupConAddress { get; set; }

        public string SupConCity { get; set; }

        public string SupConProv { get; set; }

        public string SupConPostal { get; set; }

        public string SupConCountry { get; set; }

        public string SupConBusPhone { get; set; }

        public string SupConFax { get; set; }

        public string SupConEmail { get; set; }

        public string SupConURL { get; set; }

        public string AffiliationID { get; set; }

        public int? SupplierId { get; set; }

        // methods:
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
