using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramovaniUvod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*víceřádkový komentář
            //spušštění kódu zkratkou F5
            Console.WriteLine("Hello World!"); //příkaz WriteLine na konci řádku provede enter
            Console.WriteLine("Máme rádi 3D grafiku <33");
            Console.Write("C# je okopírovaná Java"); //příkaz Write neukončí řádek
            Console.Write(", proto se budeme učit C#");

            int cislo = 101; //název proměnné ber diakritiky
            //název proměnné musí dávat smysl
            int v;
            //tabulátor dopisuje zdrojový kód (cw a double-click tab)
            Console.WriteLine(cislo); //výpis obsahu proměnné číslo
            //true/false je bool, pravdivostní typ
            //svítí, nesvítí, ověřený mail (a/n)
            bool svetlo = true;
            Console.WriteLine("Světlo " + svetlo);
            svetlo = false; //aktualizace promenne svetlo
            Console.WriteLine("Světlo " + svetlo);
            //desetinná čísla se používá u datového typu float
            float desetinne_cislo = 4.96f; //na konci musi byt f, misto desetinne carky se pise .
            Console.WriteLine("Desetinné číslo " + desetinne_cislo);
            float druhe_desetinne_cislo = 3.14f;
            float vysledek = desetinne_cislo + druhe_desetinne_cislo;
            Console.WriteLine(desetinne_cislo + " + " + druhe_desetinne_cislo + " = " + vysledek); //pokud nechceme aby se hodnoty secetly sle aby tam bylo viditelne +, dame ho do "
            //jeden znak je char
            char znak = '$'; //uvozovky zkratkou alt + 39, alt + 36 je dollar
            Console.WriteLine("Obsah proměnné znak " + znak);
            //string je řetězec, prostý text, který může obsahovat libovolné znaky
            string veta = "Vašek nebude hrát hry! 666 PEKLO "; 
            Console.WriteLine(veta);*/

            /*Console.WriteLine("Načti celé číslo");
            int a = Convert.ToInt16(Console.ReadLine());//vtvoření proměnné
                                                        //nutná konverze je vhodný datový typ       
                                                        //načtení hodnoty z klávesnice ReadLine()
            Console.WriteLine("Načetl jsem hodnotu " + a);

            Console.WriteLine("Nacti druhe cele cislo");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("vysledek" + " = " + (a + b));//soucet musi byt v zavorkach*/

            /* Sudé/Liché
            Console.WriteLine("Zadej číslo:");
            int a = Convert.ToInt16(Console.ReadLine());
                if (a%2 == 0)
            {
               Console.WriteLine( "číslo je sudé");
                    }
            else
            {
                Console.WriteLine("číslo je liché");  
            }*/


            //Kalkulačka
            /* Console.WriteLine("zadej číslo");
             float a = float.Parse(Console.ReadLine()); //pro desetinne cisla nepouzivame convert to int ale float parse
             Console.WriteLine("zadej druhé číslo");
             float b = float.Parse(Console.ReadLine());
             Console.WriteLine("zadej volbu (1- sčítání, 2- odčítání, 3- násobení, 4- dělení)");
             int volba = Convert.ToInt16(Console.ReadLine());

             if (new int[] { 1, 2, 3, 4 }.Contains(volba)) //nový array s hodnotou pouze celého čísla, hodnoty 1, 2, 3, 4
                 { 
                 if (volba == 1)
             {
                 Console.WriteLine("výsledek:" + (a + b));
             }
                 if (volba == 2)
             {
                 Console.WriteLine("výsledek:" + (a - b));
             }
                 if (volba == 3)
             {
                 Console.WriteLine("výsledek:" + (a * b));
             }
                 if (volba == 4)
             {
                 if (b != 0)
                     {
                         Console.WriteLine("výsledek:" + (a / b));
                     }
                     else
                     {
                         Console.WriteLine("nejde delit 0");
                     }
             }
             }
                else
             {
                 Console.WriteLine("zvolte volbu 1-4");
             }*/

            /*
            Console.WriteLine("zadej číslo");
            float a = float.Parse(Console.ReadLine()); //pro desetinne cisla nepouzivame convert to int ale float parse
            Console.WriteLine("zadej znak (+ - sčítání, - - odčítání, * - násobení, / - dělení)");
            char znak = Console.ReadLine();
            Console.WriteLine("zadej druhé číslo");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej  ()");
           

            if (new char[] { +, -, *, / }.Contains(znak)) //nový array s hodnotou pouze celého čísla, hodnoty +, -, *, /
            {
                if (znak == 1)
                {
                    Console.WriteLine("výsledek:" + (a + b));
                }
                if (znak == 2)
                {
                    Console.WriteLine("výsledek:" + (a - b));
                }
                if (znak == 3)
                {
                    Console.WriteLine("výsledek:" + (a * b));
                }
                if (znak == 4)
                {
                    if (b != 0)
                    {
                        Console.WriteLine("výsledek:" + (a / b));
                    }
                    else
                    {
                        Console.WriteLine("nejde delit 0");
                    }
                }
            }
            else
            {
                Console.WriteLine("zvolte znak +, -, *, /");
            }
            /*

            /*Console.WriteLine("nacti cislo");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("chapes jo, druhe cislo zadej");
            int b = Convert.ToInt16(Console.ReadLine());

            int soucet = a + b;
            int rozdil = a - b;
            int nasobeni = a * b;
            int deleni = a / b;

            Console.WriteLine("Soucet:" + soucet);
            Console.WriteLine("Rozdil:" + rozdil);
            Console.WriteLine("Nasobeni:" + nasobeni);
            Console.WriteLine("Deleni:" + deleni);
            Console.WriteLine("nacti cele nebo desetinne cislo");
            //do kodu piseme tecku a do konzole carku
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("nacti cele nebo desetinne cislo");
            float y = float.Parse(Console.ReadLine());

            float vysledek = x / y;
            Console.WriteLine("Dělení:" + vysledek);*/
            //komentování oznaceneho textu ctrl + ckc, odoznaceni ctrl + cku
            //char znak = Convert.ToChar(Console.ReadLine()); //jedna moznost
            //char znak2 = char.Parse(Console.ReadLine()); //druha moznost
            //Console.WriteLine("Obsah charu: " + znak + ", " + znak2);
            //Console.WriteLine("Obsah charu v ASCI: " + "alt+" + (int)znak + ", " + (int)znak2);

            /*Console.WriteLine("zadej cislo vetsi nez 0");
            int a = Convert.ToInt16(Console.ReadLine());

            if (a >= 0)
            { 
            if (a == 0) //výraz, podmínka se testuje nebo vyhodnocuje

            {
                Console.WriteLine("jsi nula");
            }
            //příkaz
            else
            {
                Console.WriteLine("jsi nula tak i tak, jine cislo nic neznamena :)");
            }
            }
            else
            {
                Console.WriteLine("rekl jsem vetsi");
            }
            
            // = přizazeni, např. do proměnné
            // == pozovnání, např. dvou hodnot*/

            /*Console.WriteLine("Hodnota PI = " + Math.PI);
            Console.WriteLine("Odmocnina = " + Math.Sqrt(10.2));

            Console.WriteLine("Zadejte desetinné číslo pro výpočet odmocniny: ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0) //Podmínka vyhodnotí číslo včetně nuly
            {
                double vysledek = Math.Sqrt(x);
                Console.WriteLine("Odmocnina = " + vysledek);
            }
            else
            {
                Console.WriteLine("Hodnota musí být větší než nula.");
            }
            Console.WriteLine("Mocnina = " + Math.Pow(x, 2)); //Power --> mocnina
            //první parametr je základ čísla a druhý parametr je mocnitel*/

            /*Console.WriteLine("Zadejte základ čísla: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte exponent: ");
            double n = double.Parse(Console.ReadLine());
            double vysledek = Math.Pow(x, n);
            Console.WriteLine("Výsledek = " + vysledek);*/

            /*Console.WriteLine("zadej první číslo: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("zadej druhé číslo: ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("vysledek: " + (a+b));

            Console.WriteLine("Holka nebo kluk?");
            string pohlavi = Console.ReadLine();
            if (pohlavi == "Je to asi fuk")
            {
                Console.WriteLine("Tako s takovým kašpárkem na mě nechoď"); 
            }

            else if (pohlavi == "Muž")
                {
                        Console.WriteLine("Vítej v klubu chlape!"); 
                }
            else
            {
                Console.WriteLine("Počítač vygeneroval tento druh jako neznámý.");
            }
            
            Console.WriteLine("Načti jméno: ");
            string name = Console.ReadLine(); //Načtení textu, není nutná konverze
            Console.WriteLine("Jméno = " + name);
            if (name == "Václav")
            {
                Console.WriteLine("Jsem Václav");
            }
            else if(name == "Franta")
            {
                Console.WriteLine("Jsem Franta");
            }
            else
            {
                Console.WriteLine("Nejsem Václav ani Franta");
            }

            Console.WriteLine("Načti první desetinné číslo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Operace (Vybírej pouze ze znaků součet, rozdíl, součin, podíl:");
            char znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Načti druhé desetinné číslo: ");
            float b = float.Parse(Console.ReadLine());
            
            if (znak == '+')
            {
                float soucet = a + b;
                Console.WriteLine(a + " " + " + " + " "  + b + " = " + soucet);
            }

            else if(znak == '-')
            {
                float rozdil = a - b;
                Console.WriteLine(a + " " + " - " + " " + b + " = " + rozdil);
            }

            else if (znak == '*')
            {
                float soucin = a * b;
                Console.WriteLine(a + " " + " * " + " " + b + " = " + soucin);
            }

            else if (znak == '/')
            {
                if (b == '0')
                {
                    Console.WriteLine("Nelze dělit nulou");
                }

                else
                {
                    float podil = a / b;
                        Console.WriteLine(a + " " + " / " + " " + b + " = " + podil);
                } 
            }
            
            Console.WriteLine(a);
            Console.WriteLine("Načtěte 1.  číslo: ");
            float a = float.Parse(Console.ReadLine());
            char y = Char.Parse(Console.ReadLine());
            Console.WriteLine("Načtěte 2.  číslo: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Načtěte znak: ");

            Console.WriteLine("Zadej 10 čísel: ");
            int sude = 0;
            int liche = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt16(Console.ReadLine());
                if (a % 2 == 0)
                {
                    sude += 1;
                }
                else
                {
                    liche += 1;
                }
            }
            Console.WriteLine("Sudé: " + sude + ", " + "Liché: " + liche);
            
            // Program, který vybere z 10 čísel, které je kladné, záporné a nula
            Console.WriteLine("Zadej 10 čísel: ");
            int kladne = 0;
            int zaporne = 0;
            int nula = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt16(Console.ReadLine());
                if (a < 0)
                {
                    zaporne += 1;
                }
                else if (a == 0)
                {
                    nula += 1;
                }
                else
                {
                    kladne += 1;
                }
            }
            Console.WriteLine("Kladné: " + kladne + ", " + "Záporné: " + zaporne + ", " + "Nula:" + nula);

            

            // Program, který vybere z 10 čísel největší číslo a vypíše ho
            Console.WriteLine("Zadejte 10 čísel, program vybere po zadaní všech čísel největší číslo: ");
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }
                else
                {
                    max = max;
                }
            }
            Console.WriteLine("Nejvyšší číslo: " + max);
            

            Console.WriteLine("Zadejte volbu: ");
            char znak = char.Parse(Console.ReadLine());
            
            //vícenásobné větvení
            switch (znak) //vstupní parametr pro data (číslo, znak)
            {
                case 'a': //vyhodnocení výrazu
                    //příkaz
                    Console.WriteLine("Vaše volba byla A");
                    break; //ukončení bloku, které je povinné
                case 'b':
                    Console.WriteLine("Vaše volba byla B");
                    break;

                default: //pokud nejsou vyhodnoceny předchozí kroky, tak je provede default
                    break;
            }
            

            Console.WriteLine("Zadejte číslo:");
            int volba = Convert.ToInt16(Console.ReadLine());

            switch (volba)
            {
                case 1:
                    Console.WriteLine("Pondělí");
                    break;
                case 2:
                    Console.WriteLine("Úterý");
                    break;
                case 3:
                    Console.WriteLine("Středa");
                    break;
                case 4:
                    Console.WriteLine("Čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("Pátek");
                    break;
                default:
                    Console.WriteLine("Není pracovní den");
                        break;
            }
            */

            Console.WriteLine("Zadejte první číslo:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo:");
            float y = float.Parse(Console.ReadLine());


            Console.WriteLine("Zadejte znak (Na výběr jsou: 1 – sčítání, 2 – odčítání, 3 – násobení, 4 – dělení");
            int volba = Convert.ToInt16(Console.ReadLine());

            switch (volba)
            {
                case 1:
                    float scitani = x + y;
                    Console.WriteLine("Sčítání: " + x + "+" + y + "=" + scitani);
                    break;
                case 2:
                    float odcitani = x - y;
                    Console.WriteLine("Odčítání: " + x + "-" + y + "=" + odcitani);
                    break;
                case 3:
                    float nasobeni = x * y;
                    Console.WriteLine("Násobení:" + x + "*" + y + "=" + nasobeni);
                    break;
                case 4:
                    float deleni = x / y;
                    Console.WriteLine("Dělení: " + x + "/" + y + "=" + deleni);
                    break;
            }

            Console.ReadKey(); //ukončí se program po -- klavesy
        }
    }
}
