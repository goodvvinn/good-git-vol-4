using System;
using System.Text;

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
        }

        private static void FirstToUpper()
        {
            // string str = Console.ReadLine();
            // string[] arrS = str.Split(' ');
            string lookup = " \r\n\t";
            var sb = new StringBuilder(Console.ReadLine());

            if (sb.Length > 0 && char.IsLetter(sb[0]))
            {
                sb[0] = char.ToUpper(sb[0]);
            }

            for (int i = 1; i < sb.Length; i++)
            {
                char ch = sb[i];
                if (lookup.Contains(sb[i - 1]) && char.IsLetter(ch))
                {
                    sb[i] = char.ToUpper(ch);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
