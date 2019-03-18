using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    /// <summary>
    /// Hoora - March
    /// Class to create affiliation objects
    /// </summary>

    public class Affiliations
    {
        // Constructor:
        public Affiliations() { }


        // properties:
        public string AffiliationId { get; set; }

        public string AffName { get; set; }

        public string AffDesc { get; set; }


        // methods:
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
