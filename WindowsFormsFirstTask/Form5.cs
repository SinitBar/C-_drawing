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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Text = "Текстовый редактор";
            openFileDialog1.FileName = "C:\\Users\\varka\\Documents\\2 курс, 2 сем\\практика\\openMe.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null)
                return;
            try
            {
                using (StreamReader MyReader = new StreamReader(openFileDialog1.FileName))
                {
                    textBox1.Text = MyReader.ReadToEnd();
                    MyReader.Close();
                }
            }
            catch (FileNotFoundException what)
            {
                MessageBox.Show(what.Message + "\nФайл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception what)
            {
                MessageBox.Show(what.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName; 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
                Save();
        }
        void Save()
        {
            try
            {// Создание экземпляра StreamWriter для записи в файл: 
                using (StreamWriter MyWriter = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    MyWriter.Write(textBox1.Text);
                    MyWriter.Close();
                    textBox1.Modified = false;
                }
            }
            catch (Exception what)
            {
                MessageBox.Show(what.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false)
                return;
            DialogResult MeBox = MessageBox.Show("Текст был изменён. \nСохранить изменения?", "Простой редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (MeBox == DialogResult.No)
                return;
            if (MeBox == DialogResult.Cancel)
                e.Cancel = true;
            if (MeBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Save();
                    return;
                }
                else e.Cancel = true;
            }
        }
    };
}
