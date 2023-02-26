using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba_8.Form1; 

namespace laba_8
{
    internal class rectangle : figure // наследуется 
    {
        public int x, y, w, h; // вводим переменные
        public rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.w = width;
            this.h = height;
        }
        public rectangle() // обнуляем значения
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw() // переопределенный метод передвижения
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(new Pen(Color.White, 5), this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y) // переопределенный метод передвижения
        {
            this.Clear();
            this.x += x;
            this.y += y;
            this.Draw();
        }
    }
}
