using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsFirstTask
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = "Фото галерея";
            label1.Text = "";
            comboBox1.Text = "Список";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string directory = Directory.GetCurrentDirectory();
            switch (comboBox1.SelectedIndex) 
            { 
                case 0: 
                    pictureBox1.Image = Image.FromFile("C:\\Users\\varka\\Documents\\2 курс, 2 сем\\практика\\space.jpg"); 
                    label1.Text = "Space"; 
                    break; 
                case 1: 
                    pictureBox1.Image = Image.FromFile("C:\\Users\\varka\\Documents\\2 курс, 2 сем\\практика\\fire.jpg");
                    label1.Text = "Fire"; 
                    break; 
                case 2: 
                    pictureBox1.Image = Image.FromFile("C:\\Users\\varka\\Documents\\2 курс, 2 сем\\практика\\earth.jpg");
                    label1.Text = "Earth"; 
                    break; 
                case 3: 
                    pictureBox1.Image = Image.FromFile("C:\\Users\\varka\\Documents\\2 курс, 2 сем\\практика\\sea.jpg");
                    label1.Text = "Sea"; 
                    break; 
            }
        }
    }
}
