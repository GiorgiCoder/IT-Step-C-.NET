using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ClassWork
{
    internal class CeisarCypher
    {
        static void main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Encode(input, 1));
            Console.WriteLine(Decode(Encode(input, 1), 1));
        }

        public static string Encode(string input, int num)
        {
            StringBuilder encodedSentence = new StringBuilder(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97 && input[i] <= 122)
                {
                    int encodedValue = (input[i] - 97) + num % 26 + 97;
                    encodedSentence.Append((char)encodedValue);
                }
                else
                {
                    encodedSentence.Append(input[i]);
                }
            }

            return encodedSentence.ToString();
        }

        public static string Decode(string input, int num)
        {
            return Encode(input, -num);
        }
    }
}
