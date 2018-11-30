using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MKproyect.Models
{
    public class Billing
    {
        public string key { get; set; }
        public int currencyid { get; set; }

        public int denomination { get; set; }

        public string serial { get; set; }

        public string date { get; set; }
        public string image { get; set; }




    }
}