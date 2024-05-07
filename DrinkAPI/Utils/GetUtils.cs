using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAPI.Utils
{
    internal class GetUtils
    {
        public string GetString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }
}
