using System;

public class StartUp
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