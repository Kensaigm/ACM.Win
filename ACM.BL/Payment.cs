using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Payment
    {

        public int PaymentType { get; set; }

        public enum PaymentTypeOption
        {
            CreditCard = 1,
            PayPal = 2
        }

        public void ProcessPayment()
        {
            // -- Process the payment --
            // If credit card,
            // process the credit card payment.
            // If PayPal,
            // process the PayPal payment.
            // If there is a payment problem, notify the user.
            // Open a connection
            // Set stored procedure paramenters with the payment data.
            // Call the save stored procedures.
            switch ((PaymentTypeOption)this.PaymentType)
            {
                case PaymentTypeOption.CreditCard:
                    // Process credit card
                    break;

                case PaymentTypeOption.PayPal:
                    // Process PayPal
                    break;

                default:
                    throw new ArgumentException();
            }

        }
    }
}
