using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal paymentdue { get; set; }



        public string Display
        {
            get
            {
                return string.Format("{0}{1} - ${2}", FirstName, LastName, paymentdue);
            }

        }
        public Vendor()
        {
            Commission = 0.5;
        }
    }
}
