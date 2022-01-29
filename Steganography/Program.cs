using System;
using System.Drawing;

namespace Steganography
{
    class Program
    {
        static string DecToBinary(int num)
        {
            int remainder = 0;
            string finalRemainderString = "";
            string remainderString = "";
            while (num != 0)
            {
                remainder = num % 2;
                num /= 2;
                remainderString += remainder;
            }
            for (int i = remainderString.Length - 1; i > -1; i--)
            {
                 finalRemainderString += remainderString[i];
            }
            return finalRemainderString;
        }

        static string HexaDecToBinary(int num)
        {
            int remainder = 0;
            string finalRemainderString = "";
            string remainderString = "";
            while (num != 0)
            {
                remainder = num % 2;
                num /= 2;
                remainderString += remainder;
            }
            for (int i = remainderString.Length - 1; i > -1; i--)
            {
                finalRemainderString += remainderString[i];
            }
            return finalRemainderString;

        }
        static string OctaToBinary(int num)
        {
            int remainder = 0;
            string finalRemainderString = "";
            string remainderString = "";
            while (num != 0)
            {
                remainder = num % 2;
                num /= 2;
                remainderString += remainder;
            }
            for (int i = remainderString.Length - 1; i > -1; i--)
            {
                finalRemainderString += remainderString[i];
            }
            return finalRemainderString;

        }
        static int BinaryToDec(string num)
        {
            int multiplier = 1;
            int sum = 0;

            for (int i = num.Length - 1; i > -1; i--)
            {
               
                if (num[i] == '1')
                {
                    sum += multiplier;
                }
                multiplier *= 2;
            }
            return sum;
        }

        /*
        public struct Color
        {
            public int A;
            public int R;
            public int G;
            public int B;
            
            public Color(int alpha, int red, int green, int blue)
            {
                A = alpha;
                R = red;
                G = green;
                B = blue;
            }
        }*/

        public static Color[] ConvertToColors(string msg)
        {
            while (msg.Length % 3 != 0)
            {
                msg += '\0';
            }

            Color[] color = new Color[msg.Length / 3];

            for (int i = 0, count = 0; i < msg.Length && count < color.Length; i += 3, count++)
            {
                int r = msg[i]; 
                int g = msg[i + 1];
                int b = msg[i + 2];

                //color[count].R = msg[i];
                //color[count].G = msg[i + 1];
                //color[count].B = msg[i + 2];

                color[count] = Color.FromArgb(r, g, b);
            }

            return color;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to convert to binary");
            int decNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine(DecToBinary(decNum));
            
            Console.WriteLine("Give me a number in binary to convert to decimal");
            string binaryNum = Console.ReadLine();

            Console.WriteLine(BinaryToDec(binaryNum));

            Console.WriteLine("Give me a string");
            string msg = Console.ReadLine();



            Color[] color = ConvertToColors(msg);

            for (int i = 0; i < color.Length; i++)
            {
                Console.WriteLine(color[i].R);
                Console.WriteLine(color[i].G);
                Console.WriteLine(color[i].B);
            }
        }
    }
}
