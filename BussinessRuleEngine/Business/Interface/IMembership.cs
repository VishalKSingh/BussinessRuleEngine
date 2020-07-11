using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRuleEngine.Business.Interface
{
   public interface IMembership
    {

        public bool UpgradeMember(Membership membership);
        public bool ActivateMember(Membership membership);
        public bool SendEmail(Membership membership);
    }
}
