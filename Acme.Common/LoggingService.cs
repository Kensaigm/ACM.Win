using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class LoggingService
    {
        public static void writeToFile(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
                // Console.WriteLine(item.ToString());
                Console.WriteLine(item.Log());
            }
        }
    }
}
