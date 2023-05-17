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
        
        public int AuthorizationId()
        {
            int id1 = new Random().Next(0, 99999999);
            int id2 = new Random().Next(0, 33);
            int id3 = new Random().Next(0, 873171);

            int idTotal = id1 + id2 + id3;

            return int.MaxValue - idTotal;
        }
    }
}
