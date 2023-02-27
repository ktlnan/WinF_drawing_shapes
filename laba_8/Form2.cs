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

        public object polig;
        public PointF[] points;
        public int p=0;
        public int num;
        
        public Form2(ref PointF[] points)
        {
            InitializeComponent();
            this.points = points;
        
        }

        private void buttonCreatePoint_Click(object sender, EventArgs e)
        {

            //     bool q = int.TryParse(textBox1.Text, out int i);

            //     Point[] point = new Point[i];
            //if (p <= i)
            //{  if (p != i)
            //    {
            //        label5.Text = $"Введите координаты {p + 1}-й точки: ";
            //    }
            //else
            //    {
            //        label5.Text = "все точки заполнены";
            //    }

            //    bool a = int.TryParse(textBox2.Text, out int x);
            //    bool b = int.TryParse(textBox3.Text, out int y);

            //    point[p-1] =  new Point(x, y);
            //   // this.points = point;
            //    p = p + 1;
            //    textBox2.Text = ""; //очищаем 
            //    textBox3.Text = "";
            //}
            //else
            //{
            //    label5.Text = $"{point.Length}";
            //}
            //this.num = i; //записываем занчения в св-во для использования в другом методе
            //this.points = point;
            if (p < num)
            {
                points[p].X = Convert.ToInt32(textBox2.Text);
                points[p].Y = Convert.ToInt32(textBox3.Text);
                p++;
            } else
            {
                MessageBox.Show($"Массив полон");
            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            label5.Text = $"{points.Length}";
            Poligon poligon = new Poligon(points);
            poligon.Draw();
            polig = poligon;

           //comboBox1.Items.Add("Многоугольник");
            ShapeContainer.AddFigure(poligon); 
        }

        private void button1_Click(object sender, EventArgs e) //отправка в массив
        {
            num = Convert.ToInt32(textBox1.Text);
            points= new PointF[num];
        }
        private void button3_Click(object sender, EventArgs e) //треугольник
        {
            PointF[] tes = new PointF[3];
            tes[0].X = 100;
            tes[0].Y = 100;

            tes[1].X = 100;
            tes[1].Y = 200;

            tes[2].X = 200;
            tes[2].Y = 150;
            Poligon pol = new Poligon(tes);
            pol.Draw();
        }
    }
}
