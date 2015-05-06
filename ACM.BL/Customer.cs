using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }




        public bool ValidateEmail( out string message)
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.

            var valid = true;

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                valid = false;
                message = "Email address is null";
            }

            if (valid)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email.
                // using Regular Expressions.
                if (!isValidFormat == true)
                {
                    valid = false;
                    message = "Email address is not in a correct format";
                }
            }

            if (valid)
            {
                var isRealDomain = true;
                // Code here that confirms whethere domain exists.
                if (!isRealDomain)
                {
                    valid = false;
                    message = "Email address does not include a valid domain";
                }
            }

            return valid;
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

    }
}
