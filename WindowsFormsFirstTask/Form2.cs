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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "Форма приветствия";
            label1.Text = "Name: ";
            label2.Text = "Напишите ваше имя: ";
            button1.Text = "Ввод";
            //------------- реализация ToolTip 
            toolTip1.SetToolTip(textBox1, "Введите\nваше имя"); 
            toolTip1.IsBalloon = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуй, " + textBox1.Text + "!", "Приветствие");
        }
    }
}
