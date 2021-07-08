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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold); 
            button1.Text = "Рисовать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = string.Format("{0}", textBox1.Text); 
            Brush brush = new SolidBrush(Color.Red); 
            Graphics G = pictureBox1.CreateGraphics(); 
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias; 
            G.DrawString(Text, new System.Drawing.Font("Times New Roman", 40, FontStyle.Bold), brush, 155, 50); // Координаты размещения текста
        }
    }
}
