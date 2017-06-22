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
        // Deklaracje ważnych zmiennych !!!
        double OriginX = 32767;
        double OriginY = 32767;

        //lista obiektow klasy
        static List<MojaKlasa> lista_mojaklasa = new List<MojaKlasa>();
        int costam = 0;

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

        private void Grid_Click(object sender, EventArgs e)
        {
            //Grid.Image = global::OpenBAHN.Properties.Resources.("id" + Convert.ToString(costam));
            Grid.Image = global::OpenBAHN.Properties.Resources.id2;
            DrawLayout(OriginX, OriginY);
            costam++;
        }

        private void test666()
        {
            PictureBox nGrid = new PictureBox();
            nGrid.Location = new System.Drawing.Point(200, 200);
            nGrid.Size = new Size(20, 60);
            nGrid.Name = "hahaha";
            nGrid.Image = global::OpenBAHN.Properties.Resources.id1;
        }

        private void DrawLayout(double OriginX, double OriginY)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PictureBox nGrid = new PictureBox();
                    nGrid.Location = new System.Drawing.Point(200 + (j * 40), 200 + (i * 20));
                    nGrid.Size = new Size(20, 60);
                    nGrid.Name = "Grid" + Convert.ToString(j) + "," + Convert.ToString(i);
                    nGrid.Image = global::OpenBAHN.Properties.Resources.id1;
                    nGrid.Cursor = System.Windows.Forms.Cursors.Cross;
                }
            }
        }
    }
}
