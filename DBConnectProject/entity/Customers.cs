using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject
{
    internal class Customers
    {
        [Key]
        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string? ContactName { get; set; }

        public string? Fax { get; set; }

        public string? City { get; set; }





    }
}
