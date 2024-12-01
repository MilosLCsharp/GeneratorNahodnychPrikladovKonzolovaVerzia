using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorNahodnychPrikladov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vitajte v programe na precvičenie príkladov!");
            Console.WriteLine("Chcete začať?:(áno/nie)");
            string štart = Convert.ToString(Console.ReadLine());
            string príklad = štart;
            int PočetBodov = 0;
            int početPríkladov = 0;
            do
            {
                if ((štart == "áno") || (príklad == "áno"))
                {
                    Random Číslo = new Random();
                    int číslo1 = Číslo.Next(2, 50);
                    int číslo2 = Číslo.Next(1, číslo1 -1);
                    Console.WriteLine("Zvol operáciu (+,-)");
                    string operacia = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(číslo1);
                    Console.WriteLine(číslo2);
                    int výsledok2 = (číslo1 - číslo2);
                    int výsledok1 = (číslo1 + číslo2);
                    //int PočetBodov = 0;
                    Console.WriteLine("Vlož výsledok: ");
                    početPríkladov += 1;
                    int VýsledokUživatela = Convert.ToInt32(Console.ReadLine());

                    if ((VýsledokUživatela == výsledok1) && (operacia == "+"))
                    {
                        Console.WriteLine("Správna odpoveď,získavaš 1.bod");
                        PočetBodov += 1;
                    }
                    else if ((VýsledokUživatela == výsledok2) && (operacia == "-"))
                    {
                        Console.WriteLine("Správna odpoveď, získavaš 1.bod");
                        PočetBodov += 1;
                    }
                    else
                    {
                        Console.WriteLine("To nebola správna odpoveď.");
                    }
                    Console.WriteLine("Chcete další príklad?(áno/nie)");
                    príklad = Convert.ToString(Console.ReadLine());
                    Predelovač();// predelí príklad 10x(*)
                    try
                    {
                        if (príklad == "nie")
                        {
                            Console.WriteLine("Koniec programu");
                            Console.ForegroundColor = ConsoleColor.Green;// zmena farby pre Počet bodov
                            Console.WriteLine("Celkový počet bodov:{0} ", PočetBodov);
                            Console.WriteLine("Celkový počet príkladov: {0}",početPríkladov);
                            Console.ResetColor();
                            if (PočetBodov==početPríkladov)
                            {
                                Console.WriteLine("Skvelé,len tak ďalej!");
                            }
                            else if (PočetBodov<početPríkladov -8)
                            {
                                Console.WriteLine("Niečo sa nepodarilo ale stále je to dobré!");
                            }
                            else
                            {
                                Console.WriteLine("Treba skúšať ďalej");
                            }
                            Console.ReadKey();
                        }
                        else if (príklad != "áno")
                        {
                            Console.WriteLine("Takú možnosť nepoznám.");
                            Console.WriteLine("Chcete další príklad?(áno/nie)");
                            príklad = Convert.ToString(Console.ReadLine());
                        }
                        
                    }
                    catch (SystemException e)
                    {
                        Console.WriteLine("Vyskytla sa systémová výnimka: " + e.Message);// výnimka je definovaná ale nemá ju čo vyvolať 
                    }
                }
            } while (príklad == "áno");
        }
        static void Predelovač()//vlastná metóda na predelenie príkladu 
        {
            string i = "*";
            for (int c = 0; c < 20; c++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
        

