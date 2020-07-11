using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Model
{
  public  class Address
    {
        public string Country { get; set; }
        public string  State { get; set; }
        public string  City { get; set; }

        public string Street { get; set; }

        public string  Apartment { get; set; }

        public int ZipCode { get; set; }
    }
}
