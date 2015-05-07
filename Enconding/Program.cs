using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enconding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string test = "𤭢";
            string value = "\u00C4 \uD802\u0033 \u00AE";
            string test2 = "♂♀♪♫¶§▬↨↑↑↓→";
 
            Console.WriteLine(test);
            Console.WriteLine(value);

            ValidateUTF8Encoding(value);
            ValidateUTF8Encoding(test);
            ValidateUTF8Encoding("asd?=)(/&%$#!");
            ValidateUTF8Encoding(test2);

            Console.ReadKey();
        }

        private static bool ValidateUTF8Encoding(string encoding) 
        {
            Encoding win1252 = Encoding.GetEncoding(1252);
            try
            {
                byte[] bytes = win1252.GetBytes(encoding);
                string value2 = win1252.GetString(bytes);
                if (String.Compare(encoding, value2) != 0) return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
