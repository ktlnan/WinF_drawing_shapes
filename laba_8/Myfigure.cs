using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static laba_8.Form1;

namespace laba_8
{
    internal class Myfigure : figure
    {

        PointF[] tes = new PointF[4]; // основание лодки
        PointF[] tec = new PointF[3]; //треугольник влево
        PointF[] ter = new PointF[3]; //треугольник вправо
        public Poligon niz, tr1, tr2;


        public Myfigure(int x, int y, int w, int h)
        {

            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;

            tes[0].X = x;
            tes[0].Y = y + h / 2;

            tes[1].X = x + w / 4;
            tes[1].Y = y + h;

            tes[2].X = x + w / 4 * 3;
            tes[2].Y = y + h;

            tes[3].X = x + w;
            tes[3].Y = y + h / 2;
            //----------------------------------------------------

            tec[0].X = x + w / 2;
            tec[0].Y = y;

            tec[1].X = x + w / 2;
            tec[1].Y = y + h / 2;

            tec[2].X = x + w / 4;
            tec[2].Y = y + h / 2;

            //---------------------------------------------------

            ter[0].X = x + w / 2;
            ter[0].Y = y;

            ter[1].X = x + w / 2;
            ter[1].Y = y + h / 2;

            ter[2].X = x + w * 3 / 4;
            ter[2].Y = y + h / 2;

            //----------------------------------------------------          

            niz = new Poligon(tes);
            tr1 = new Poligon(tec);
            tr2 = new Poligon(ter);
        }
        public override void Draw() //переопределенный метод рисования
        {
            //Graphics g = Graphics.FromImage(Init.bitmap);
            //g.DrawPolygon(Init.pen, tes );
            //Init.pictureBox.Image = Init.bitmap;

            niz.Draw();
            tr1.Draw();
            tr2.Draw();
        }

        public override void Clear()
        {
            niz.Clear();
            tr1.Clear();
            tr2.Clear();
        }

        public override void MoveTo(int x, int y) //переопределенный метод передвижения для основания лодки
        {
            //this.Clear();
            //for (int i = 0; i < tes.Length; i++)
            //{
            //    tes[i].X += x;
            //    tes[i].Y += y;
            //}

            //this.Draw();
            niz.MoveTo(x, y);
            tr1.MoveTo(x, y);
            tr2.MoveTo(x, y);
        }
    }
}
        






