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
            MojaKlasa tmk = new MojaKlasa();

            //nowy item
            //definiuje nowy obiekt MojaKlasa zanim dodam do listy obiektow 
            tmk = new MojaKlasa();
            tmk.x_kratki = x;
            tmk.y_kratki = y;
            tmk.id = id;
            tmk.maParametry = haveParam;
            if (haveParam)
            {
                tmk.parametry.parametr1 = param1;
                tmk.parametry.parametr2 = param2;
                tmk.parametry.parametr3 = param3;
            }
            //dodaje obiekt do listy
            mk.Add(tmk);
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
            ReadFromList(1);
            if (param1 != "")
            {
                // some action
            }
        }
    }
    class KlasaID
    {
        public String parametr1 = "";
        public int parametr2 = -1;
        public bool parametr3 = false;
    }
    class MojaKlasa
    {
        public int x_kratki = -1;
        public int y_kratki = -1;
        public int id = -1;
        public bool maParametry = false;
        public KlasaID parametry = new KlasaID();
    }
}
