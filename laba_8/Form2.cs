using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static laba_8.Form1;

namespace laba_8
{
    public partial class Form2 : Form
    {
       
 
        public Point[] points;
        public int p=1;
        public int num;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCreatePoint_Click(object sender, EventArgs e)
        {
           
                 bool q = int.TryParse(textBox1.Text, out int i);
            
                 Point[] point = new Point[i];
            if (p <= i)
            {  if (p != i)
                {
                    label5.Text = $"Введите координаты {p + 1}-й точки: ";
                }
            else
                {
                    label5.Text = "все точки заполнены";
                }

                bool a = int.TryParse(textBox2.Text, out int x);
                bool b = int.TryParse(textBox3.Text, out int y);

                point[p-1] =  new Point(x, y);
               // this.points = point;
                p = p + 1;
                textBox2.Text = ""; //очищаем 
                textBox3.Text = "";
            }
            else
            {
                label5.Text = $"{point.Length}";
            }
            this.num = i; //записываем занчения в св-во для использования в другом методе
            this.points = point;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = $"{points.Length}";
            Poligon poligon = new Poligon(points, num);
            poligon.Draw();
            Form1 form=new Form1();
            form.comboBox1.Items.Add("Многоугольник");
            ShapeContainer.AddFigure(poligon);
        }
    }
}
