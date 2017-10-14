using System;

namespace _09.PasswordGuess
{
    public class PasswordGuess
    {
        public static void Main()
        {
            var password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (password != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
