using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFirstTask
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Text = "Закрашивание фигур"; 
            label1.Text = "Выберите фигуру";
            comboBox1.Text = "Фигуры"; 
            string[] figures = { "Прямоугольник", "Эллипс", "Окружность" }; 
            comboBox1.Items.AddRange(figures);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics(); 
            Brush brush = new SolidBrush(Color.Orange); 
            graphics.Clear(SystemColors.Control);
            switch (comboBox1.SelectedIndex)
            {
                case 0: 
                    graphics.FillRectangle(brush, 100, 50, 120, 180); // прямоугольник
                    break;
                case 1: 
                    graphics.FillEllipse(brush, 60, 60, 180, 120); // эллипс
                    break;
                case 2: 
                    graphics.FillEllipse(brush, 100, 80, 120, 120); // окружность
                    break;
            }
        }
    }
}
