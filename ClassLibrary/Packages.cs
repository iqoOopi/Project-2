using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Package
    {
        int PackageID { get; set; }

        string PackageName { get; set; }

        DateTime? PackageStart { get; set; }

        DateTime? PackageEnd { get; set; }

        string Desc { get; set; }

        decimal BasePrice { get; set; }

        decimal AgencyCom { get; set; }

    }
}
