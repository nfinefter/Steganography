﻿using System;
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

        struct Color
        {
            public byte A;
            public byte R;
            public byte G;
            public byte B;
            
            public Color(byte alpha, byte red, byte green, byte blue)
            {
                A = alpha;
                R = red;
                G = green;
                B = blue;
            }
        }

        static Color[] ConvertToColors(string msg)
        {
            int num = 0;
            if (msg.Length % 3 >= 0)
            {
                num = 1;
            }

            Color[] color = new Color[msg.Length / 3 + num];

            for (int i = 0; i < color.Length; i++)
            {
                color[i].R = ;
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



        }
    }
}