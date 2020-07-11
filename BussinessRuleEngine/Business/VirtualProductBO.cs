using BusinessRuleEngine.View;
using BussinessRuleEngine.Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRuleEngine.Business
{
    class VirtualProductBO : IVirtualProduct
    {
        public bool AddFreeFirstAidVideo()
        {
            // logic for adding free video
            DisplayPaymentDetails.GenerateDetails(" Free First Aid Video Added");

            return true;
        }
    }
}
