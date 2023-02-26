using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba_8.Form1;

namespace laba_8
{
    internal class Poligon : figure
    {
        public int i;
        public Point[] points ;
        public Poligon(Point[] p, int i)
        {
            points = p;
            this.i = i;
        }

        public override void Draw() //переопределенный метод рисования
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(new Pen(Color.White, 5), points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y) //переопределенный метод передвижения
        {
            this.Clear();
            this.x += x;
            this.y += y;
            this.Draw();
        }

    }
}
