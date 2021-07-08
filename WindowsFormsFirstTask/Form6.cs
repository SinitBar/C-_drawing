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
    public partial class Form6 : Form
    {
        uint[] m_p = new uint[6];
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Рисуем три линии - стороны треугольника
            e.Graphics.DrawLine(System.Drawing.Pens.DodgerBlue, m_p[0], m_p[1], m_p[2], m_p[3]); 
            e.Graphics.DrawLine(System.Drawing.Pens.Cyan, m_p[2], m_p[3], m_p[4], m_p[5]); 
            e.Graphics.DrawLine(System.Drawing.Pens.DeepSkyBlue, m_p[4], m_p[5], m_p[0], m_p[1]);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Text = "Рисование треугольника"; 
            button1.Text = "Рисовать";
            label1.Text = "Введите координаты\n вершин:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m_p[0] = Convert.ToUInt32(textBox1.Text);
                m_p[1] = Convert.ToUInt32(textBox2.Text);
                m_p[2] = Convert.ToUInt32(textBox3.Text);
                m_p[3] = Convert.ToUInt32(textBox4.Text);
                m_p[4] = Convert.ToUInt32(textBox3.Text);
                m_p[5] = Convert.ToUInt32(textBox6.Text);
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("textBoxes weren't filled right:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
