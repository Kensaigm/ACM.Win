using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            // -- If this is a new customer, create the custoemr record --
            // Determine whether the customer is an existing customer.
            // If not, validate entered customer information
            // if not valid, notify the user.
            // If valid,
            // Open a connection
            // Set stored procedure parameters wiht the customer data.
            // Call the save stored procedure.
        }

        public void Update()
        {
            // Open a connection
            // Set stored procedure parameters with the customer data.
            // Call the save stored procedure.
        }

//        public Customer Find(string customerID)
//        {
//            Customer result = new Customer();
//
//           return result;
//        }

        public List<Customer> Find(string customerName)
        {
            List<Customer> results = new List<Customer>();
            results.Add(new Customer());
            results.Add(new Customer());
            results.Add(new Customer());

            return results;
        }
    }
}
