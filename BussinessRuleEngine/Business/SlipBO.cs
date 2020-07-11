using BusinessRuleEngine.Business.Interface;
using BusinessRuleEngine.View;
using BussinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRuleEngine.Business
{
    public class SlipBO : ISlip
    {
        /// <summary>
        /// This will generate packing slip
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool GeneratePackingSlip(Product product)
        {
            bool result = false;

            try
            {
                if (product != null)
                {
                    // logic of slip generation for shipping
                    GenerateSlip(product);
                    GenerateSlipForShipping();
                    if (!string.IsNullOrEmpty(product.Name) && product.Name.Contains("Book"))
                    {
                        //logic of slip generation for royalty
                        GenerateSlip(product);
                        GenerateSlipForPatentee();
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Generate product deatisl in console
        /// </summary>
        /// <param name="product"></param>
        private void GenerateSlip(Product product)
        {
            DisplayPaymentDetails.GenerateDetails("++++++++++++++++");
            DisplayPaymentDetails.GenerateDetails("Name :" + product.Name);
            DisplayPaymentDetails.GenerateDetails("Type :" + product.Type);
            DisplayPaymentDetails.GenerateDetails("Price :" + product.Price);
            DisplayPaymentDetails.GenerateDetails("++++++++++++++++");

        }

        private void GenerateSlipForShipping()
        {
            DisplayPaymentDetails.GenerateDetails(" Slip is For Shipping");
        }

        private void GenerateSlipForPatentee()
        {
            DisplayPaymentDetails.GenerateDetails(" Slip is For Royalty Department");
        }
    }
}
