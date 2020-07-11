using BussinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Business.Interface
{
   public interface ISlip
    {

        public bool GeneratePackingSlip(Product product);
    }
}
