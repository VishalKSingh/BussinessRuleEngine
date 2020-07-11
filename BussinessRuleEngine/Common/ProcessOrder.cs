using BusinessRuleEngine.Model;
using BusinessRuleEngine.View;
using BussinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Common
{
   public static class ProcessOrder
    {
        /// <summary>
        /// This method will take user input for a product or a membership
        /// </summary>
        public static void PopulateUserDetails()
        {
           
            DisplayPaymentDetails.GenerateDetails(" Please Enter 1 for Product or 2 for Membership");
            int type = Convert.ToInt32(Console.ReadLine());

            while (type <=0 || type > 2)
            {
                DisplayPaymentDetails.GenerateDetails(" Please Enter 1 for Product or 2 for Membership");
                type = Convert.ToInt32(Console.ReadLine());
            }
            if (type == 1)
            {
                ProductInputDetails();
            }
            else if (type == 2)
            {
                MembershipInputDetails();
            }

            Console.Read();

        }

        /// <summary>
        /// This method will take product details from console and will processOrder
        /// </summary>
        private static void ProductInputDetails()
        {
            PaymentManager pm = PaymentManager.GetInstance();
            Product product = new Product();
            Console.Write("Please Enter Product Name :");
            product.Name = Console.ReadLine();
            DisplayPaymentDetails.GenerateDetails("Enter 0 for Physical Order or 1 for Virtual Order");
            int orderType = Convert.ToInt32(Console.ReadLine());

            // if order type is not valid
            while (orderType > 1 || orderType < 0)
            {
                DisplayPaymentDetails.GenerateDetails("Enter 0 for Physical Order or 1 for Virtual Order");
                orderType = Convert.ToInt32(Console.ReadLine());
            }
            product.Type = (OrderType)orderType;
            Console.Write("Price :");
            product.Price = Convert.ToInt32(Console.ReadLine());


            pm.ProcessProductOrder(product);
        }

        /// <summary>
        /// This method will take membership details from console and process membership
        /// </summary>
        private static void MembershipInputDetails()
        {
            PaymentManager pm = PaymentManager.GetInstance();
            Membership membership = new Membership();
            Console.Write("Please Enter Member Name :");
            membership.Name = Console.ReadLine();
            DisplayPaymentDetails.GenerateDetails("Enter 0 for Activate Order or 1 for Upgrade");
             
            int memberType = Convert.ToInt32(Console.ReadLine());

            // if member type is not valid
            while (memberType > 1 || memberType < 0)
            {
                Console.WriteLine("Type either 0 or 1");
                memberType = Convert.ToInt32(Console.ReadLine());
            }

            membership.Type = (MemberType)memberType;

            pm.ProcessMembership(membership);

        }
    }
}
