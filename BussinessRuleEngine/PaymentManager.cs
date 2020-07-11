using BusinessRuleEngine.Business.Interface;
using BusinessRuleEngine.Model;
using BussinessRuleEngine.Business;
using BussinessRuleEngine.Business.Interface;
using BussinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Common
{
   public class PaymentManager
    {
        private static PaymentManager _mInstance;

        private IMembership membershipBO;
        private ISlip slipBO;
        private IVirtualProduct virtualProduct;

        public List<Product> ProductData { get; set; }

        private PaymentManager()
        {
            
        }
        private PaymentManager(ISlip slipBO, IMembership membershipBO, IVirtualProduct virtualProduct)
        {
            this.membershipBO = membershipBO;
            this.slipBO = slipBO;
            this.virtualProduct = virtualProduct;
        }


        public static PaymentManager GetInstance()
        {

            if (_mInstance == null)
            {
                _mInstance = new PaymentManager();

            }
            return _mInstance;
        }

        /// <summary>
        /// This method will process product order based on order type
        /// </summary>
        /// <param name="product"></param>
        public void ProcessProductOrder(Product product)
        {

            switch (product.Type)
            {
                case OrderType.Physical:
                    slipBO.GeneratePackingSlip(product);
                    break;
                case OrderType.Virtual:
                    slipBO.GeneratePackingSlip(product);
                    if (!string.IsNullOrEmpty(product.Name) && product.Name.ToLower().Contains("learning to ski"))
                    {
                        virtualProduct.AddFreeFirstAidVideo();
                    }
                    
                    break;
                default:
                    break;


            }
        }

        /// <summary>
        /// This method will process membership details
        /// </summary>
        /// <param name="membership"></param>
        public void ProcessMembership(Membership membership)
        {

            switch (membership.Type)
            {
                case MemberType.Activate:
                    membershipBO.ActivateMember(membership);

                    break;
                case MemberType.Cancel:

                    break;
                case MemberType.Upgrade:
                    membershipBO.UpgradeMember(membership);
                    break;

                default:
                    break;
            }

            // this will send email
            membershipBO.SendEmail(membership);
        }
  
    }
}
