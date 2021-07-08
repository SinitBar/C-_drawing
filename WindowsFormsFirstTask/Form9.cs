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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter; 
            label1.Text = "ERROR!!!"; 
            label1.ForeColor = Color.Red; 
            MessageBox.Show("Написано же:\nНЕ трогать!", "Fatal ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Text = "Hover"; 
            label1.TextAlign = ContentAlignment.MiddleCenter; 
            label1.Text = "Не трогай.";
        }
    }
}
