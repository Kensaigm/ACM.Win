using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class LoggingService
    {
        public static void writeToFile(List<Object> changedItems)
        {
            foreach (var item in changedItems)
            {
                // Console.WriteLine(item.Log());
            }
        }
    }
}
