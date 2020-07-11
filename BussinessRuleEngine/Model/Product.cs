using BusinessRuleEngine.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRuleEngine.Model
{
   public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public OrderType Type { get; set; }


    }
}
