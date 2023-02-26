using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba_8.Form1;

namespace laba_8
{
    internal class ellipse : figure
    {
        public int x, y, w, h;
        public ellipse(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.w = width;
            this.h = height;
        }
        public ellipse()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw() //переопределенный метод рисования
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void Clear() 
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(new Pen(Color.White, 5), this.x, this.y, this.w, this.h);
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

