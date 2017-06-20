using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenBAHN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //lista obiektow klasy
        static List<MojaKlasa> lista_mojaklasa = new List<MojaKlasa>();
    

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Layout());
        }
        static void WriteToList(int x, int y, int id, bool haveParam, string param1, int param2, bool param3)
        {
            // *** Kod by Nitro modyfikacja i dostosowanie by jakubg1 ***

            //nowy item
            //definiuje nowy obiekt MojaKlasa zanim dodam do listy obiektow 
            MojaKlasa mk = new MojaKlasa();
            mk.x_kratki = x;
            mk.y_kratki = y;
            mk.id = id;
            mk.maParametry = haveParam;
            if (haveParam)
            {
                mk.parametry.parametr1 = param1;
                mk.parametry.parametr2 = param2;
                mk.parametry.parametr3 = param3;
            }
            //dodaje obiekt do listy
            lista_mojaklasa.Add(mk);


        }
        static void ReadFromList(int itemNumber)
        {


           
            /*//wyswietl
            for (int i = 0; i < mk.Count; i++)
            {
                Console.WriteLine("Item nr: " + i);
                Console.WriteLine("Kratka [x,y]: [" + mk[i].x_kratki + "," + mk[i].y_kratki + "]");
                Console.WriteLine("ID: " + mk[i].id.ToString());

                //ponizej mozna pominac i walic if sprawdzajac czy ma wartosc inna od pustej
                // if(mk[i].parametry.parametr1 != "")
                // lub if(!String.IsNullOrEmpty(mk[i].parametry.parametr1)) bo sprawdzamy wartosc stringa
                Console.WriteLine("Ma parametry?: " + mk[i].maParametry.ToString());

                if (mk[i].maParametry)
                {
                    //Console.WriteLine("Ma parametry wiec je wyswietlmy");
                    Console.WriteLine("parametr1: " + mk[i].parametry.parametr1);
                    Console.WriteLine("parametr2: " + mk[i].parametry.parametr2);
                    Console.WriteLine("parametr3: " + mk[i].parametry.parametr3);
                }

                Console.WriteLine("================");
            }



            Console.ReadKey();
            */
            //Console.WriteLine("Item nr: " + itemNumber);
            int x = mk[itemNumber].x_kratki;
            int y = mk[itemNumber].y_kratki;
            int id = mk[itemNumber].id;
            bool haveParam = mk[itemNumber].maParametry;

            if (mk[itemNumber].maParametry)
            {
                string param1 = mk[itemNumber].parametry.parametr1;
                int param2 = mk[itemNumber].parametry.parametr2;
                bool param3 = mk[itemNumber].parametry.parametr3;
            }
            // *** Koniec kodu by Nitro ***
        }
        static List<MojaKlasa> mk = new List<MojaKlasa>();
        static void test()
        {
            ///niepotrzebna jezeli chcesz sie odwolac do konkretnej komorki w tablicy
            //ReadFromList(1);
            if (!String.IsNullOrEmpty(mk[1].parametry.parametr1))
            {
                // some action
            }
        }
    }
}
