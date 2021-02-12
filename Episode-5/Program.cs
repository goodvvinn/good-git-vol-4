﻿using System;

namespace Episode_5
{
    internal class Program
    {
        private enum Alphabet
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I,
            J,
            K,
            L,
            M,
            N,
            O,
            P,
            Q,
            R,
            S,
            T,
            U,
            V,
            W,
            X,
            Y,
            Z
        }

        private static void Main(string[] args)
        {
            string lenght = Console.ReadLine();
            bool res = int.TryParse(lenght, out int a);
            int[] myArray = new int[a];
            Random random = new Random();
            if (res)
            {
                myArray = new int[a];
                Console.WriteLine("Lenght of the array is {0}", a);
            }
            else
            {
                Console.WriteLine("Wrong value, Please enter a valid number of elements in the array");
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 27);
            }

            // Console.WriteLine("The array contains : ");
            for (int i = 0; i < myArray.Length; i++)
            {
               Console.WriteLine(myArray[i]);
            }
        }
    }
}
