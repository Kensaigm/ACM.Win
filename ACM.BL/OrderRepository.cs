using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        public void Add(Order order)
        {
            // -- Create the order for the customer. --
            // For each item ordered,
            // Validate the entered information.
            // If not valid, notify the user.
            // if valid,
            // Open a connection
            // Set stored procedure parameters with the order data.
            // Call the save stored procedure.
        }

        /// <summary>
        /// Retrieve one Order.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the request Id
            Order order = new Order(orderId);
            // Code that retrieves the defined product

            // Temporary hard coded values to return
            // a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(new DateTime(2015, 06, 3, 18 , 51, 50), new TimeSpan(-7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
    }
}
