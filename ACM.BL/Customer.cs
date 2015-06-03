using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }

        private string _lastname;

        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName {
            get
            {
                return _lastname;
            } 
            
            set
            {
                _lastname = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public Tuple<bool, string> ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.

            Tuple<bool, string> result = Tuple.Create(true, "");

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                result = Tuple.Create(false, "Email address is null");
            }

            if (result.Item1 == true)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email.
                // using Regular Expressions.
                if (!isValidFormat == true)
                {
                    result = Tuple.Create(false,"Email address is not in a correct format");
                }
            }

            if (result.Item1 == true)
            {
                var isRealDomain = true;
                // Code here that confirms whethere domain exists.
                if (!isRealDomain)
                {
                    result = Tuple.Create(false, "Email address does not include a valid domain");
                }
            }

            return result;
        }

        public object CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            // Try 3
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual steps count must be entered", "actualSteps");

            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric"); 
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);            
        }

        public object CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return Math.Round((actualStepCount / goalStepCount) * 100 ,2);
        }

        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }

    }
}
