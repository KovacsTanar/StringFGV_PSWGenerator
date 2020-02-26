using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            do
            {
                Console.WriteLine("Kérek egy legalább 8 karakter hosszú jelszót, ami tartalmaz legalább egy '_' karaktert!");
                password = Console.ReadLine();

            } while ((password.Length < 8) || (!password.Contains('_')));

            password = password.Trim();
            password = password.Replace("_", "$$$");


            string temp = password.Substring(password.Length - 3).ToUpper();
            password = password.Remove(password.Length - 3);
            password = password + temp;


            password = password.Remove(2, 2);

            Console.WriteLine("A jelszó EDDIG: {0}", password);
            Console.ReadKey();
        }
    }
}
