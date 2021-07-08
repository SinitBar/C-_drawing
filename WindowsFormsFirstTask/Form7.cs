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
    public partial class Form7 : Form
    {
        uint[] m_p = new uint[4];
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Text = "Рисование эллипса"; 
            label1.Text = "Введите данные"; 
            button1.Text = "Рисовать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m_p[0] = Convert.ToUInt32(textBox1.Text); // x координата верхнего левого угла
                m_p[1] = Convert.ToUInt32(textBox2.Text); // у координата верхнего левого угла
                m_p[2] = Convert.ToUInt32(textBox3.Text); // радиус эллипса по ох
                m_p[3] = Convert.ToUInt32(textBox4.Text); // радиус эллипса по оу
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("textBoxes weren't filled right:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White); 
            e.Graphics.DrawEllipse(pen, m_p[0], m_p[1], m_p[2], m_p[3]); //x0, y0, Rx, Ry
        }
    }
}
