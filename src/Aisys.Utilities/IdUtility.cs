using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aisys.Utilities
{
    public class IdUtility
    {
        public static string AlphaNumericalByLength(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_.~";

            return new string(Enumerable.Repeat(chars, length).Select(x => x[new Random().Next(x.Length)]).ToArray());
        }
    }
}
