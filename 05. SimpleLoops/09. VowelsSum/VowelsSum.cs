using System;

namespace _09.VowelsSum
{
    public class VowelsSum
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                switch (c)
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    default: break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
