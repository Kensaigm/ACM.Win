using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {

        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            if (!Enum.IsDefined(typeof(PaymentType), this.PaymentType))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            }
            // -- Process the payment --
            // If credit card,
            // process the credit card payment.
            // If PayPal,
            // process the PayPal payment.
            // If there is a payment problem, notify the user.
            // Open a connection
            // Set stored procedure paramenters with the payment data.
            // Call the save stored procedures.
            switch ((PaymentType)this.PaymentType)
            {
                case ACM.BL.PaymentType.CreditCard:
                    // Process credit card
                    break;

                case ACM.BL.PaymentType.PayPal:
                    // Process PayPal
                    break;

                default:
                    throw new ArgumentException();
            }

        }
    }
}
