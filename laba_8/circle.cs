using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba_8.ellipse;

namespace laba_8
{
    internal class circle : ellipse
    {
        public circle(int x, int y, int width) 
        {
            this.x = x;
            this.y = y;
            this.w = width;
            this.h = width;
        }
        public override void Draw() //переопределенный метод рисования
        {
            base.Draw(); // берет из эллипса
        }
        public override void Clear()
        {
            base.Clear();
        }
        public override void MoveTo(int x, int y)
        {
            base.MoveTo(x, y);
        }
    }
}
