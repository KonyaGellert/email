using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MENÜVEZÉRLÉS
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - E-mail címek listázása");
                Console.WriteLine("2 - Uj e-mail");
                Console.WriteLine("3 - e-mail törlese");
                Console.WriteLine("4 - érvényes e-mailok listázása");

                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0":
                        return;
                    case "1": Console.WriteLine("E-mail címek listázása"); break;
                    case "2": Console.WriteLine("Uj e-mail"); break;
                    case "3": Console.WriteLine("e-mail törlese"); break;
                    case "4": Console.WriteLine("érvényes e-mailok listázása"); break;
                    default: Console.Clear(); Console.WriteLine("Hibás parancs"); break;

                }
                Console.ReadKey();

            }   }
    }
}
