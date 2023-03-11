using System.Windows.Forms;

namespace laba_8
{
    public partial class Form1 : Form
    {
        PointF[] points;
        
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 3);
            Pen penClear = new Pen(Color.White, 3);
            Init.bitmap = bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = pen;
            

            ShapeContainer shape = new ShapeContainer();
        }
        public class ShapeContainer //пространство 
        {
            public static List<figure> figureList; // список фигур
            static ShapeContainer()
            {
                figureList = new List<figure>();
            }
            public static void AddFigure(figure figure) //метод  добавление в список фигур
            {
                figureList.Add(figure);
            }

        }
        abstract public class figure
        {
            public int x;
            public int y;
            public int w;
            public int h;
            abstract public void Draw();
            abstract public void Clear();
            abstract public void MoveTo(int x, int y);

        }
        public int x, y, w, h;

        private void button1_Click(object sender, EventArgs e) //кнопка удаления
        {
            figure figyra = ShapeContainer.figureList[comboBox1.SelectedIndex];
            figyra.Clear();
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            ShapeContainer.figureList.Remove(figyra);
            for (int i = 0; i < ShapeContainer.figureList.Count; i++)
            {
                ShapeContainer.figureList[i].Draw();
            }

        }

        private void button2_Click(object sender, EventArgs e) //кнопка перемещения
        {
            figure figyra = ShapeContainer.figureList[comboBox1.SelectedIndex];
            int x = Convert.ToInt32(textBox5.Text), y = Convert.ToInt32(textBox6.Text);
            figyra.MoveTo(x, y);
            for (int i = 0; i < ShapeContainer.figureList.Count; i++) //фигура при прорисовке остается целой
            {
                ShapeContainer.figureList[i].Draw();
            }
        }

        private void radioTriabgle_CheckedChanged(object sender, EventArgs e)
        {
            points = new PointF[3];
            Form2 newForm = new Form2(ref points, true);
            this.Hide();
            newForm.ShowDialog();
            Poligon poligon = (Poligon)newForm.polig;
            this.Show();


            comboBox1.Items.Add(poligon);
        }

        private void radioPoligon_CheckedChanged(object sender, EventArgs e) // создали вторую форму с параметрами для многоугольника
        {
            points = new PointF[3];
            Form2 newForm = new Form2(ref points);
            this.Hide();
            newForm.ShowDialog();
            Poligon poligon = (Poligon)newForm.polig;
            this.Show();


            comboBox1.Items.Add(poligon);


        }

        private int repit = 0;
        private void button3_Click(object sender, EventArgs e) //генерация фигур
        {
            if (radioShip.Checked) // рисует эллипс
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                h = Convert.ToInt32(textBox4.Text);
               Myfigure  cake = new(x, y, w, h);
                cake.Draw();
                comboBox1.Items.Add("что то " + repit);
                ShapeContainer.AddFigure(cake);
                repit++;
            }
            if (radioellipse.Checked) // рисует 
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                h = Convert.ToInt32(textBox4.Text);
                ellipse ellipse = new ellipse(x, y, w, h);
                ellipse.Draw();
                comboBox1.Items.Add("Эллипс " + repit);
                ShapeContainer.AddFigure(ellipse);
                repit++;
            }
            if (radioCircle.Checked) //рисует круг
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                circle round = new circle(x, y, w);
                round.Draw();
                comboBox1.Items.Add("Круг " + repit);
                ShapeContainer.AddFigure(round);
            }
            if (radioRectangle.Checked) // рисует прямоугольник
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                h = Convert.ToInt32(textBox4.Text);
                figure rectangle = new rectangle(x, y, w, h);
                rectangle.Draw();
                comboBox1.Items.Add("Прямоугольник " + repit);
                ShapeContainer.AddFigure(rectangle);
            }
          
        }
    }


        public static class Init //Инициализация инструментов рисования
        {
            public static Bitmap bitmap; //инстр рисования
            public static PictureBox pictureBox;
            public static Pen pen;
        }


    }
