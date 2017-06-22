using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenBAHN
{
    public partial class Layout : Form
    {
        //lista obiektow klasy
        static List<MojaKlasa> lista_mojaklasa = new List<MojaKlasa>();
        public Layout()
        {
            InitializeComponent();
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
        static void test2()
        {
            bool kkk = false;
            //int ActualID = 1;
            if (kkk)
            {
                //Bitmap Tile = new Bitmap("id" + ActualID + ".png");
                Bitmap Tile = new Bitmap("id1.png");
                Graphics Drawing = Graphics.FromImage(Tile);
                Drawing.DrawImage(Tile, 20, 20);
            }
        }
    }
}
