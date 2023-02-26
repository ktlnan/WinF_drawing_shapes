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
            /*public static figure FindFigure(string name) // находит нужную фигуру из тех, что уже создавала
            {
                foreach (figure f in figureList) // ищет по списку f-сам объект круг или эллипс
                {
                    if (f.name == name) // если имя соот заданному то он его возвр 
                    {
                        return f;
                    }
                }
                return null;
            }*/
        }
        public int x, y, w, h;
        private int repit = 0;
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
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
    }
}