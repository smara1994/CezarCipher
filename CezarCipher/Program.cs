using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CezarCipher
{
    class Program
    {
        static void Main(string[] args)
        {


            Start:
            Console.WriteLine(" Add text you encrypt: ");
            string UserString = Console.ReadLine();
            if (UserString == string.Empty)
            {
                Console.WriteLine(" Please add text ");
                goto Start;
            }
            else
            {
                Console.WriteLine("\n");

                Console.Write(" add key ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");


                Console.WriteLine(" Text encrypt: ");

                string cipherText = Encipher(UserString, key);
                Console.WriteLine(cipherText);
                Console.Write("\n");

                Console.WriteLine(" Add text you decrypt: ");
                string UserStringDecript = Console.ReadLine();
                Console.WriteLine(" add key ");
                int keyy = Convert.ToInt32(Console.ReadLine());
                string t = StringDecript(UserStringDecript, keyy);
                Console.WriteLine("\n" + t);
                Console.Write("\n");
                Console.ReadKey();
            }

        }


        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string StringDecript(string input, int keys)
        {
            return Encipher(input, 26 - keys);
        }



    }
}
