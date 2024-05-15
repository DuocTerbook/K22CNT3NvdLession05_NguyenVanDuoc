using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVD_lession05.Models
{
    public class NvdCustomer
    {
        public int CustomerID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}