using BusinessRuleEngine.Common;
using BusinessRuleEngine.Model;
using BusinessRuleEngine.View;
using BussinessRuleEngine.Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRuleEngine.Business
{
   public class MembershipBO : IMembership
    {
        /// <summary>
        /// 
        /// This method contains logic for membership Activation
        /// </summary>
        /// <param name="membership"></param>
        /// <returns></returns>
        public bool ActivateMember(Membership membership)
        {
            bool result = false;
            if(membership != null)
            {
                // Membership update relate logic will be written here
                DisplayPaymentDetails.GenerateDetails(" Member Activated");
                result = true;
            }

            return result;
        }

        /// <summary>
        ///  This method will upgrade membership
        /// </summary>
        /// <param name="membership"></param>
        /// <returns></returns>
        public bool UpgradeMember(Membership membership)
        {
            bool result = false;
            if(membership != null)
            {
                DisplayPaymentDetails.GenerateDetails(" Membership upgraded ");
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Thsi method will send email
        /// </summary>
        /// <param name="membership"></param>
        /// <returns></returns>
        public bool SendEmail(Membership membership)
        {
            bool sent = true;
            switch (membership.Type)
            {
                case MemberType.Activate:
                    DisplayPaymentDetails.GenerateDetails(" Membership Activated ");
                    break;
                case MemberType.Upgrade:
                    DisplayPaymentDetails.GenerateDetails(" Membership Upgraded ");
                    break;
                case MemberType.Cancel:
                    DisplayPaymentDetails.GenerateDetails(" Membership Canceled ");
                    break;
                default:
                    break;
            }
            return sent;

        }

    }
}
