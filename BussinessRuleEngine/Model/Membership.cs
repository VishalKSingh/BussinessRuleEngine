using BusinessRuleEngine.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Model
{
   public class Membership
    {
        public string Name { get; set; }
        public MemberType Type { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public bool IsActive { get; set; }

        public string EmailId { get; set; }
    }
}
