using System;

namespace maskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your secret");
            var secret = Console.ReadLine();
            var masker = secret.Substring(secret.Length - 4).PadLeft(secret.Length, '_');
            Console.WriteLine(masker);
        }
    }
}
