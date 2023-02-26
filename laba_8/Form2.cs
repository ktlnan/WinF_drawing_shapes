using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_8
{
    public partial class Form2 : Form
    {
        public bool flag; //Если логическая переменная flag равна true, то происходит определение количества вершин многоугольника.В противном случаепроисходит добавление точек в массив points.
        public int k; // k-тая точка
        public int numPoints; //  хранит количество вершин
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCreatePoint_Click(object sender, EventArgs e)
        {
           
        }
    }
}
