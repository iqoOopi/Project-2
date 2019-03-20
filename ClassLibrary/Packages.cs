using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Package
    {
       public int PackageID { get; set; }

       public string PackageName { get; set; }

      public  DateTime? PackageStart { get; set; }

       public DateTime? PackageEnd { get; set; }

       public string Desc { get; set; }

      public  decimal BasePrice { get; set; }

       public decimal AgencyCom { get; set; }

    }
}
