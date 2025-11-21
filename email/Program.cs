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
            //adatszerkezet
            List<string> emailCimek = new List<string>();
            emailCimek.Add("alma@kkszki.hu");
            emailCimek.Add("Télapo@kkszki.hu");
            emailCimek.Add("Trup@kkszki.hu");
            emailCimek.Add("Poloska@kkszki.hu");
            emailCimek.Add("asdatkkszki.hu");
            emailCimek.Add("alma.peti@kkszki.hu");

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
                    case "1":
                        Console.Clear(); Console.WriteLine("E-mail címek:");
                        int sor = 0;
                        foreach (string s in emailCimek)
                        {
                            Console.WriteLine($"{sor++}. {s}");
                        }
                        break;
                    case "2": Console.WriteLine("Adja meg az uj-emailcimet:"); 
                        string uj = Console.ReadLine();
                        emailCimek.Add(uj);
                        break;
                    case "3": Console.WriteLine("Adja meg a torlendo email azonositojat:"); 
                        int index =Convert.ToInt32(Console.ReadLine()); 
                        emailCimek.RemoveAt(index);
                        break;
                    case "4": Console.WriteLine("érvényes e-mailok listázása"); break;
                    default: Console.Clear(); Console.WriteLine("Hibás parancs"); break;

                }
                Console.ReadKey();

            }   }
    }
}
