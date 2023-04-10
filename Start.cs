using System;
using System.Collections.Generic;
using System.Text;

namespace Kordamine_pythonist_csharpis
{
    public class Start
    {
        public static void Main(string[] args)
        {
            /*
            Console.Write("Tere tulemast, mis on sinu nimi? ");

            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            Console.WriteLine("Kirjuta 1 arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjuta 2 arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tehe: ");
            char tehe = char.Parse(Console.ReadLine());
            if (tehe == '+')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 + arv2);
            }
            else if(tehe=='-')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
            }
            
            Random rnd = new Random();
            string paev = "";
            for (int i = 0; i < 10; i++)
            {
                int nr = rnd.Next(1,7);
                Console.WriteLine(nr);

            
            switch (nr)
            {
                case 1: paev = "Esmaspäev";
                    break;
                case 2: paev = "Teisipäev";
                    break;
                case 3: paev = "Kolmapäev";
                    break;
                case 4: paev = "Neljapäev";
                    break;
                case 5: paev = "Reede";
                    break;
                case 6: paev = "Laupäev";
                    break;
                case 7: paev = "Pühapäev";
                    break;
                default: 
                    paev = "Mingi päev";
                    break;
            }
            Console.WriteLine(paev);
            }
            int j = 0;
            while (j<10)
            {
                Console.WriteLine(paev);
                j++;
            }
            Console.WriteLine(j);
            do
            {
                Console.WriteLine(paev);
                j--;
            }
            while (j!=0);
            Console.WriteLine(j);
            int[] arvud= new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(-100, 100);
            }

            foreach (int arv in arvud)
            {
                Console.WriteLine(arv);
                if (arv<0)
                {
                    Console.Beep();
                }
                
            }
            */
            /*
            //1
            Console.WriteLine("Mis on sinu nimi? ");
            string name = Console.ReadLine();
            string nimi = name.ToLower();
            if (nimi == "juku")
            {
                Console.WriteLine("Lähme Jukuga kinno!");
                Console.WriteLine("Palun sisesta Juku vanus: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 0 || age > 100)
                {
                    Console.WriteLine("Viga andmetega!");
                }
                else if (age < 6)
                {
                    Console.WriteLine("Juku pilet on tasuta.");
                }
                else if (age >= 6 && age <= 14)
                {
                    Console.WriteLine("Juku pilet on lastepilet.");
                }
                else if (age >= 15 && age <= 65)
                {
                    Console.WriteLine("Juku pilet on täispilet.");
                }
                else
                {
                    Console.WriteLine("Juku pilet on sooduspilet.");
                }
            }
            else
            {
                Console.WriteLine("Lähme kinno!");
            }
            */
            /*
            Console.WriteLine("Kirjuta esimese inimese nimi: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Kirjuta teise inimese nimi: ");
            string nimi2 = Console.ReadLine();
            Console.WriteLine(nimi1+ " ja " +nimi2+ " on pinginaabrid" );
            */
            /*
            //3
            Console.WriteLine("Sisestage ristkülikukujulise ruumi seinte pikkused (meetrites):");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double kokku = a * b;
            Console.WriteLine("Korruse pindala on: " + kokku + " ruutmeetrit.");
            Console.WriteLine("Kas soovite remonti teha? (jah ei)");
            string vastus = Console.ReadLine();

            if (vastus == "jah")
            {
                Console.WriteLine("Kui palju maksab üks ruutmeeter?");
                double hind = double.Parse(Console.ReadLine());
                double üldhind = kokku * hind;
                Console.WriteLine("Põranda vahetuse hind on: " + üldhind + " eurot.");
            }
            */
            /*
            //4
            Console.WriteLine("Palun sisesta hind 30% allahindlusega:");
            double allhind = double.Parse(Console.ReadLine());
            double alghind = allhind / 0.7;
            double Alghind = Math.Round(alghind, 2);
            Console.WriteLine("Alghind on: " + Alghind + " euro.")
            */
            /*
            //5
            Console.WriteLine("Sisestage temperatuur (Celsiuse järgi):");
            double temperatuur = double.Parse(Console.ReadLine());

            if (temperatuur > 18)
            {
                Console.WriteLine("Toa on soe.");
            }
            else
            {
                Console.WriteLine("Toa on külm.");
            }
            */
            /*
            //6
            Console.WriteLine("Palun sisestage oma pikkus (sentimeetrites):");
            double kõrgus = double.Parse(Console.ReadLine());

            if (kõrgus < 160)
            {
                Console.WriteLine("Olete lühike.");
            }
            else if (kõrgus >= 160 && kõrgus <= 180)
            {
                Console.WriteLine("Olete kesksuurusega.");
            }
            else if (kõrgus >180)
            {
                Console.WriteLine("Olete suur.");
            }
            else 
            {
                Console.WriteLine("Kirjutage õige number");
            }
            */
            /*
            //7
            Console.WriteLine("Palun sisestage oma pikkus (sentimeetrites):");
            double kõrgus = double.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisestage oma sugu (mees/naine):");
            string sugu = Console.ReadLine();

            if (sugu == "mees")
            {
                if (kõrgus < 160)
                {
                    Console.WriteLine("Olete lühike.");
                }
                else if (kõrgus >= 160 && kõrgus <= 180)
                {
                    Console.WriteLine("Olete kesksuurusega.");
                }
                else if (kõrgus > 180)
                {
                    Console.WriteLine("Olete suur.");
                }
            }
            else if (sugu == "naine")
            {
                if (kõrgus < 160)
                {
                    Console.WriteLine("Olete lühike.");
                }
                else if (kõrgus >= 160 && kõrgus <= 175)
                {
                    Console.WriteLine("Olete kesksuurusega.");
                }
                else if (kõrgus > 175)
                {
                    Console.WriteLine("Olete suur.");
                }
            }
            else
            {
                Console.WriteLine("Kirjuta õige oma sugu.");
            }
            */
            
            //8
            double piimahind = 1.5;
            double leibahind = 2.0;
            double juustuhind = 3.0;
            Console.WriteLine("piimahind on "+piimahind+  " ,leibahind on "+leibahind+ " ja juustuhind on "+juustuhind+ " euro");
            Console.WriteLine("Kas soovite piima osta? (jah ei)");
            string ostame_piima = Console.ReadLine();
            Console.WriteLine("Kas soovite leiba osta? (jah ei)");
            string ostame_leiba = Console.ReadLine();
            Console.WriteLine("Kas soovite juustu osta? (jah ei)");
            string ostame_juustu = Console.ReadLine();

            double koguhind = 0.0;

            if (ostame_piima == "jah")
            {
                koguhind += piimahind;
            }

            if (ostame_leiba == "jah")
            {
                koguhind += leibahind;
            }

            if (ostame_juustu == "jah")
            {
                koguhind += juustuhind;
            }

            Console.WriteLine("Teie ostu kogumaksumus on: " + koguhind + " eurot.");            

        }
    }
}

