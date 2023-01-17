using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskProject5
{
    internal class DecodeCeaser
    {
        internal string Decode(int number, string s)
        {
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        int a = (s[i] - 65 - number + 26) % 26 + 65;
                        result += (char)a;
                    }

                    else
                    {
                        int A = (s[i] - 97 - number + 26) % 26 + 97;
                        result += (char)A;
                    }
                }

                else
                {
                    result += s[i];
                }
            }

            return result;
        }

        internal int DecodeNumber()
        {
            Console.Write("Ceaser sifrelemesini nece vahid dekodlasdirmaq istediyinizi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        internal string DecodeString()
        {
            Console.Write("Ceaser sifrelemesini daxil edin:");
            string s = Console.ReadLine();

            return s;
        }
    }
}
