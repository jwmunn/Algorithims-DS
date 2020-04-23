using System;
using System.Text;

namespace UrlShortener
{
    class Base62Converter
    {
        const string _base62 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        // 1. For our first problem, write a function that converts a given base-62 string
        //    into an integer. Only a single string will be provided, and it will be up to
        //    11 characters in length.  
        // LpuPe81bc2w => 18327995462734721974
        public static ulong ToBase10(string videoId)
        {
            int videoIdLength = videoId.Length - 1;
            int baseNum = 62;
            long multiplier = 1;
            long result = 0;

            for (int i = 0; i <= videoIdLength; i++)
            {
                int base10Val = _base62.IndexOf(videoId[videoIdLength - i]);

                result += base10Val * multiplier;
                multiplier *= baseNum;
            }

            return (ulong)result;
        }

        // 2. Write a function that does the opposite of the previous one. 
        // That is, it encodes a base 10 number into base 62
        // producing a string that represents the same number.
        // 18327995462734721974 => LpuPe81bc2w
        public static string ToBase62(ulong number)
        {
            StringBuilder sb = new StringBuilder();
            ulong baseNum = 62;
            ulong n = number;

            while (n > 0)
            {
                ulong remainder = n % baseNum;
                char base62Char = _base62[(int)remainder];
                sb.Insert(0, base62Char);
                n /= 62;
            }

            return sb.ToString();
        }






        // For testing. Don't modify.
        public static void Main(string[] args)
        {
            Console.WriteLine(ToBase10("LpuPe81bc2w"));
            Console.WriteLine(ToBase62(18327995462734721974));

            string mode = Console.ReadLine();
            string arg = Console.ReadLine();
            if (mode == "decode")
            {
                Console.WriteLine(ToBase10(arg));
            }

            if (mode == "encode")
            {
                var videoKey = ulong.Parse(arg);
                Console.WriteLine(ToBase62(videoKey));
            }
        }

    }
}
