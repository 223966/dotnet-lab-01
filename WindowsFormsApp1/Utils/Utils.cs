using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Utils
{
    static class Utils
    {
        public static List<string> GetImplementedInterfaces(object o)
        {
            List<string> interfaces = new List<string>();
            foreach (Type i in o.GetType().GetInterfaces())
            {
                interfaces.Add(i.ToString().Split('.').Last());
            }
            return interfaces;
        }

        public static string GetClass(object o)
        {
            return o.GetType().ToString().Split('.').Last();
        }
    }
}
