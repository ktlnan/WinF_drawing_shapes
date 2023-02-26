namespace laba_8
{
    public partial class Form1 : Form
    {
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
        public class ShapeContainer //������������ 
        {
            public static List<figure> figureList; // ������ �����
            static ShapeContainer()
            {
                figureList = new List<figure>();
            }
            public static void AddFigure(figure figure) //�����  ���������� � ������ �����
            {
                figureList.Add(figure);
            }

            /*public static figure FindFigure(string name) // ������� ������ ������ �� ���, ��� ��� ���������
            {
                foreach (figure f in figureList) // ���� �� ������ f-��� ������ ���� ��� ������
                {
                    if (f.name == name) // ���� ��� ���� ��������� �� �� ��� ����� 
                    {
                        return f;
                    }
                }
                return null;
            }*/
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

        private void button1_Click(object sender, EventArgs e) //������ ��������
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

        private void button2_Click(object sender, EventArgs e) //������ �����������
        {
            figure figyra = ShapeContainer.figureList[comboBox1.SelectedIndex];
            int x = Convert.ToInt32(textBox5.Text), y = Convert.ToInt32(textBox6.Text);
            figyra.MoveTo(x, y);
            for (int i = 0; i < ShapeContainer.figureList.Count; i++) //������ ��� ���������� �������� �����
            {
                ShapeContainer.figureList[i].Draw();
            }
        }

        private void radioPoligon_CheckedChanged(object sender, EventArgs e) // ������� ������ ����� � ����������� ��� ��������������
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Form2 NewForm2 = new Form2();
            NewForm2.Owner = this;
        }

        private int repit = 0;
        private void button3_Click(object sender, EventArgs e) //��������� �����
        {
            if (radioellipse.Checked) // ������ ������
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                h = Convert.ToInt32(textBox4.Text);
                ellipse ellipse = new ellipse(x, y, w, h);
                ellipse.Draw();
                comboBox1.Items.Add("������ " + repit);
                ShapeContainer.AddFigure(ellipse);
            }
            if (radioCircle.Checked) //������ ����
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                circle round = new circle(x, y, w);
                round.Draw();
                comboBox1.Items.Add("���� " + repit);
                ShapeContainer.AddFigure(round);
            }
            if (radioRectangle.Checked) // ������ �������������
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                w = Convert.ToInt32(textBox3.Text);
                h = Convert.ToInt32(textBox4.Text);
                figure rectangle = new rectangle(x, y, w, h);
                rectangle.Draw();
                comboBox1.Items.Add("������������� " + repit);
                ShapeContainer.AddFigure(rectangle);
            }
          
        }
    }


        public static class Init //������������� ������������ ���������
        {
            public static Bitmap bitmap; //����� ���������
            public static PictureBox pictureBox;
            public static Pen pen;
        }


    }
