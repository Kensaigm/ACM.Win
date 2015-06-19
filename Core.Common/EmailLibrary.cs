using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class EmailLibrary
    {

        public void SendEmail(string p1, string p2)
        {
            // If a valid email address is provided,
            try
            {
                // Send an email.
            }
            catch (InvalidOperationException ioe)
            {
                // Log issue ioe.Message()
                // Do not throw ex, rethrow the original
                throw;
            }
            // Send an email.
        }
    }
}
