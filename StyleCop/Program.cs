using System;

namespace StyleCop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            object[] myEven = new object[n];
            object[] myOdd = new object[n];
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int myEvenCount = 0;
            int myOddCount = 0;

            Random r = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = r.Next(1, 26);

                // Console.WriteLine(myArray[i] + " ");
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    myOdd[i] = myArray[i];
                }
                else
                {
                    myEven[i] = myArray[i];
                }

                // Console.WriteLine($"The value of myOdd[i] : " + myOdd[i]);
                // Console.WriteLine($"The value of myEven[i] : " + myEven[i]);
            }

            for (int i = 0; i < myEven.Length; i++)
            {
                if (myEven[i] != null)
                {
                    myEven[i] = alpha[(int)myEven[i] - 1];
                    switch (myEven[i])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'd':
                        case 'h':
                        case 'j':
                            myEven[i] = myEven[i].ToString().ToUpper();
                            myEvenCount++;
                            break;
                        default:
                            myEven[i] = myEven[i];
                            break;
                    }

                    // Console.WriteLine("The value of myEven: {0}", myEven[i]);
                }
            }

            for (int i = 0; i < myOdd.Length; i++)
            {
                if (myOdd[i] != null)
                {
                    myOdd[i] = alpha[(int)myOdd[i] - 1];
                    switch (myOdd[i])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'd':
                        case 'h':
                        case 'j':
                            myOdd[i] = myOdd[i].ToString().ToUpper();
                            myOddCount++;
                            break;
                        default:
                            myOdd[i] = myOdd[i];
                            break;
                    }

                    // Console.WriteLine("The value of myOdd: {0}, and myOddCount has {1} items", myOdd[i], myOddCount);
                }
            }

            if (myOddCount > myEvenCount)
            {
                Console.WriteLine("Odds array has more chars in capital than Evens array - {0}", myOddCount);
            }
            else if (myOddCount < myEvenCount)
            {
                Console.WriteLine("Evens array has more chars in capital than Odds array - {0}", myEvenCount);
            }
            else
            {
                Console.WriteLine("Both arrays have the same amount of capital chars");
            }

            // Console.WriteLine("Odds : {0}, Even : {1}", myOddCount, myEvenCount);

            // Array.ForEach(myEven, Console.Write);
            Console.WriteLine(string.Join(' ', myEven));
            Console.WriteLine(string.Join(' ', myOdd));

            Console.WriteLine();
        }
    }
}
