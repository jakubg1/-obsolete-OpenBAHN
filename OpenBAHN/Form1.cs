using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenBAHN.Properties;

namespace OpenBAHN
{
    public partial class Layout : Form
    {
        // Deklaracje ważnych zmiennych !!!
        // Jednorazowy bool służący do stworzenia planszy - w celu całkowitego odświeżenia zmienić na false w kodzie niżej
        bool Generated = false;
        // Lista wszystkich ID kratek
        static List<MojaKlasa> IndexListTemp = new List<MojaKlasa>();
        // Aktualne współrzędne górnego lewego rogu planszy
        double OriginX = 32767;
        double OriginY = 32767;
        // Zmienne czytania z danego ID do wykorzystania później
        int readx;
        int ready;
        int readid;
        bool readhaveParam;
        string readparam1;
        int readparam2;
        bool readparam3;

        //lista obiektow klasy
        static List<MojaKlasa> IndexList = new List<MojaKlasa>();
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
            MojaKlasa IndexListTemp = new MojaKlasa();
            IndexListTemp.x_kratki = x;
            IndexListTemp.y_kratki = y;
            IndexListTemp.id = id;
            IndexListTemp.maParametry = haveParam;
            if (haveParam)
            {
                IndexListTemp.parametry.parametr1 = param1;
                IndexListTemp.parametry.parametr2 = param2;
                IndexListTemp.parametry.parametr3 = param3;
            }
            //dodaje obiekt do listy
            IndexList.Add(IndexListTemp);


        }

        static void ReadFromList(int itemNumber)
        {
            int readx = IndexList[itemNumber].x_kratki;
            int ready = IndexList[itemNumber].y_kratki;
            int readid = IndexList[itemNumber].id;
            bool readhaveParam = IndexList[itemNumber].maParametry;

            if (IndexList[itemNumber].maParametry)
            {
                string readparam1 = IndexList[itemNumber].parametry.parametr1;
                int readparam2 = IndexList[itemNumber].parametry.parametr2;
                bool readparam3 = IndexList[itemNumber].parametry.parametr3;
            }
            // *** Koniec kodu by Nitro ***
        }

        static void test()
        {
            ///niepotrzebna jezeli chcesz sie odwolac do konkretnej komorki w tablicy
            //ReadFromList(1);
            if (!String.IsNullOrEmpty(IndexList[1].parametry.parametr1))
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

            var x = costam;
            var myImage = (Bitmap)Resources.ResourceManager.GetObject("id{x}");
            Grid.Image = myImage;
            costam++;
        }

        private void test666()
        {
            PictureBox nGrid = new PictureBox();
            nGrid.Location = new System.Drawing.Point(200, 200);
            nGrid.Size = new Size(40, 60);
            nGrid.Name = "hahaha";
            nGrid.Image = global::OpenBAHN.Properties.Resources.id1;
            this.Controls.Add(nGrid);
        }

        private void DrawLayout(double OriginX, double OriginY)
        {
            WriteToList(32767, 32767, 1, false, "", 0, false);
            WriteToList(32768, 32767, 1, false, "", 0, false);
            WriteToList(32769, 32767, 2, false, "", 0, false);
            WriteToList(32769, 32768, 2, false, "", 0, false);
            WriteToList(32770, 32768, 3, false, "", 0, false);
            WriteToList(32771, 32767, 3, false, "", 0, false);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double targetX = OriginX + j;
                    double targetY = OriginY + i;
                    int gotID = 0; // musimy to tutaj zdeklarowac bo inaczej przy pustej kratce bedzie wysyp
                    for (int k = 0; k < IndexList.Count; k++) // sprawdzamy dla kazdego wpisu
                    {
                        ReadFromList(k);
                        if (readx == targetX && ready == targetY)
                        {
                            gotID = readid;
                            break; // bo po co sprawdzac dalej
                        }
                    }
                    PictureBox nGrid = new PictureBox();
                    nGrid.Location = new System.Drawing.Point(80 + (j * 40), -20 + (i * 20));
                    nGrid.Size = new Size(40, 60);
                    nGrid.Name = "Grid" + Convert.ToString(j) + "," + Convert.ToString(i);
                    //nGrid.Image = global::OpenBAHN.Properties.Resources.id1;
                    if (gotID == 1)
                    {
                        nGrid.Image = global::OpenBAHN.Properties.Resources.id1;
                    }
                    if (gotID == 2)
                    {
                        nGrid.Image = global::OpenBAHN.Properties.Resources.id2;
                    }
                    //if (gotID == 3)
                    //{
                        nGrid.Image = global::OpenBAHN.Properties.Resources.id3;
                    //}
                    nGrid.Cursor = System.Windows.Forms.Cursors.Cross;
                    nGrid.BackColor = Color.Transparent;
                    this.Controls.Add(nGrid);
                }
            }
        }
    }
}
