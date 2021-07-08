using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsSecondTask
{
    public partial class Form1 : Form
    {
        Pen pen_axes = new Pen(Color.LightGray, 1f); // перо для рисования осей
        Pen pen_graphic = new Pen(Color.Blue, 1f); // перо для рисования модуля параболы
        Pen pen_triangle = new Pen(Color.Black, 1f); // перо для рисования границы треугольника
        Brush brush_triangle = new SolidBrush(Color.Transparent); // кисть для заливки треугольника
        Point[] Ox = new Point[2]; // для оси Ох
        Point[] Oy = new Point[2]; // для оси Оу
        Point center = new Point();
        //Point initial_center = new Point();
        List<Point> p = new List<Point>(); // для графика модуля параболы
        Point[] vertexes = new Point[3];// прямоугольный треугольник
        double first_side = 0; // первый катет 
        double second_side = 0; // второй катет
        double third_side = 0; // гипотенуза
        int now_index = -1; // текущий индекс точки из массива точек графика модуля параболы
        int initial_index = -1;
        double now_angle = 0; // текущий угол поворота
        double angle = 0; // угол поворота в 1 времени
        double mashtab = 1; // текущий масшат изображений
        int speed = 0; // текущая скорость движения
        int max_speed = 10; // максмально допустимая скорость движения
        int pulsation_size = 0; // размах пульсации
        int pulsation_frequency = 0; // частота пульсации
        int max_frequency = 101; // максимальная частота пульсации
        int repeat_times = 1; // число повторов
        int current_times = 0; // текущее количество раз прохода по траектории
        int step = 1; // шаг перемещения объекта по траектории
        int sum_r = 0;
        bool triangle_drawn = false;
        bool axes_drawn = false;
        bool graphic_drawn = false;
        bool minus_clicked = false;
        bool plus_clicked = false;
        bool started = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_move_direction.Text = "движение: слева направо";
            for (double x = 0; x < 1001; x++)
            {
                p.Add(new Point((int)x, Ox[0].Y - (int)Math.Abs(((x - pictureBox.Width / 2) / 10) * ((x - pictureBox.Width / 2) / 10) - 400)));
            }
            draw_Axes();
            draw_graphic();
            pictureBox.BackColor = Color.White;
            label_Center.Text = "";
            toolTip_pictureBox_draw.SetToolTip(pictureBox, "Ткните мышью на траекторию, если хотите поместить начало движения в данной точке");
            toolTip_pictureBox_draw.SetToolTip(pictureBox1, "Данная в задании траектория");
            toolTip_pictureBox_draw.SetToolTip(label14, "При изменении масштаба размер меняется у всех элементов");
            toolTip_pictureBox_draw.SetToolTip(button_move_direction, " Нажмите для смены направления");
            toolTip_pictureBox_draw.SetToolTip(textBox_Pulsation_size, " Введите число от 0 до 100");
            toolTip_pictureBox_draw.SetToolTip(textBox_Pulsation_frequency, "Введите число от 0 до 100");
            toolTip_pictureBox_draw.SetToolTip(textBox_Graphic_width, "Введите число от 1 до 10");
            toolTip_pictureBox_draw.SetToolTip(textBox_Axes_width, "Введите число от 1 до 10");
            toolTip_pictureBox_draw.SetToolTip(textBox_Repeat_times, "Введите неотрицательное число");
            toolTip_pictureBox_draw.SetToolTip(textBox_Step_size, "Введите неотрицательное число");
            toolTip_pictureBox_draw.SetToolTip(textBox_Spin_speed, "Отрицательный угол соответствует вращению по часовой стрелке, положительный - против");
            toolTip_pictureBox_draw.SetToolTip(button_Start, "После нажатия начнется движения и станет недоступен выбор начальной точки, количество повторов и все кнопки, кроме + и -"); 
        }

        private void draw_Axes()
        {
            axes_drawn = true;
            Ox[0] = new Point(0, pictureBox.Height - 50);
            Ox[1] = new Point(pictureBox.Width, pictureBox.Height - 50);
            Oy[0] = new Point(pictureBox.Width / 2, pictureBox.Height);
            Oy[1] = new Point(pictureBox.Width / 2, 0);
        }

        private void draw_graphic()
        {
            graphic_drawn = true;
            p.Clear();
            for (double x = 0; x < 1001; x++)
                p.Add(new Point((int)(x * mashtab + Oy[0].X * (1 - mashtab)), Ox[0].Y - (int)(Math.Abs(((x - pictureBox.Width / 2) / 10) * ((x - pictureBox.Width / 2) / 10) - 400) * mashtab)));
        }

        private void draw_triangle(double first_side, double second_side, double third_side, double angle)
        {
            triangle_drawn = true;
            while (angle >= 2 * Math.PI) // 2pi
                angle -= 2 * Math.PI;
            while (angle <= -2 * Math.PI)
                angle += 2 * Math.PI;
            if (first_side > 0 && second_side > 0)
            {
                
                third_side = Math.Sqrt(first_side * first_side + second_side * second_side) * mashtab;
                double R = third_side / 2;
                vertexes[0] = new Point((int)(R * Math.Cos(angle + Math.PI / 2) + center.X), (int)(-R * Math.Sin(angle + Math.PI / 2) + center.Y));
                vertexes[1] = new Point((int)(R * Math.Cos(angle - Math.PI / 2) + center.X), (int)(-R * Math.Sin(angle - Math.PI / 2) + center.Y));
                vertexes[2] = new Point((int)(R * Math.Cos(angle + Math.PI / 2 - 2 * Math.Acos(second_side*mashtab/third_side)) + center.X), (int)(-R * Math.Sin(angle + Math.PI / 2 - 2 * Math.Asin(first_side*mashtab/third_side)) + center.Y));
                pictureBox.Invalidate();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (axes_drawn)
                draw_Axes();
            if (graphic_drawn)
                draw_graphic();
            pictureBox.Invalidate();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point center = me.Location;
            if (!started)
            {
                int index = 0;
                bool was = false;
                for (int i = 0; i < p.Count; i++)
                {
                    if ((p.ElementAt(i).Y <= center.Y + 2) && (p.ElementAt(i).Y >= center.Y - 2) && (p.ElementAt(i).X <= center.X + 2) && (p.ElementAt(i).X >= center.X - 2))
                    {
                        if ((p.ElementAt(i).Y - center.Y) * (p.ElementAt(i).Y - center.Y) + (p.ElementAt(i).X - center.X) * (p.ElementAt(i).X - center.X) < (p.ElementAt(index).Y - center.Y) * (p.ElementAt(index).Y - center.Y) + (p.ElementAt(index).X - center.X) * (p.ElementAt(index).X - center.X))
                        {
                            index = i;
                            was = true;
                        }
                    }
                }
                if (was)
                {
                    DialogResult result = MessageBox.Show("Хотите установить точку старта здесь?", "Изменение начальной позиции треугольника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        now_index = index;
                        initial_index = now_index;
                        label_Center.Text = "Точка начала траектории: " + p.ElementAt(index).X + "; " + p.ElementAt(index).Y;
                        if (triangle_drawn)
                            button_Triangle_Click(sender, e);
                    }
                }
            }
        }

        private void button_Color_graphic_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pen_graphic.Color = colorDialog1.Color;
                draw_Axes();
                draw_graphic();
                if (triangle_drawn)
                    draw_triangle(first_side, second_side, third_side, now_angle);
                pictureBox.Invalidate();
            }
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            if (mashtab < 1.4)
            {
                if (!button_Minus.Enabled)
                    button_Minus.Enabled = true;
                plus_clicked = true;
                draw_Axes();
                mashtab += 0.1;
                p.Clear();
                for (double x = 0; x < 1001; x++)
                    p.Add(new Point((int)(x * mashtab + Oy[0].X * (1 - mashtab)), Ox[0].Y - (int)(Math.Abs(((x - pictureBox.Width / 2) / 10) * ((x - pictureBox.Width / 2) / 10) - 400) * mashtab)));
                draw_graphic();

                if (triangle_drawn)
                {
                    center = p.ElementAt(now_index);
                    draw_triangle(first_side, second_side, third_side, now_angle);
                }
                pictureBox.Invalidate();
                if(mashtab >= 1.4)
                    button_Plus.Enabled = false;
            }
            else
                plus_clicked = false;
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            if (mashtab > 0.4)
            {
                if (!button_Plus.Enabled)
                    button_Plus.Enabled = true;
                minus_clicked = true;
                //Graphics graphics = pictureBox.CreateGraphics();
                //pictureBox.Refresh();
                draw_Axes();
                //graphics.DrawLine(pen_axes, Ox[0], Ox[1]);
                //graphics.DrawLine(pen_axes, Oy[0], Oy[1]);
                mashtab -= 0.1;
                p.Clear();
                for (double x = 0; x < 1001; x++)
                    p.Add(new Point((int)(x * mashtab + Oy[0].X * (1 - mashtab)), Ox[0].Y - (int)(Math.Abs(((x - pictureBox.Width / 2) / 10) * ((x - pictureBox.Width / 2) / 10) - 400) * mashtab)));
                draw_graphic();

                if (triangle_drawn)
                {
                    center = p.ElementAt(now_index);
                    draw_triangle(first_side, second_side, third_side, now_angle);
                }
                pictureBox.Invalidate();
                if (mashtab <= 0.4)
                    button_Minus.Enabled = false;
            }
            else
                minus_clicked = false;
        }

        private void button_Triangle_Click(object sender, EventArgs e)
        {
            if (now_index == -1)
            {
                for (int i = 0; i < p.Count; i++)
                {
                    if (p.ElementAt(i).Y >= 0 && p.ElementAt(i).X >= 0)
                    {
                        now_index = i;
                        break;
                    }
                }
            }
            initial_index = now_index;
            center = p.ElementAt(now_index);
            draw_triangle(first_side, second_side, third_side, now_angle);
            pictureBox.Invalidate();
        }

        private void textBox1Side_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox1Side.Text, out uint side))
                first_side = side;
            // можно добавить критерий, больше которого не может быть
        }

        private void textBox2Side_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox2Side.Text, out uint side))
                second_side = side;
            // можно добавить критерий, больше которого не может быть
        }

        private void button_Color_back_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox.BackColor = colorDialog1.Color;
                draw_Axes();
                draw_graphic();
                if (triangle_drawn)
                    draw_triangle(first_side, second_side, third_side, now_angle);
                pictureBox.Invalidate();
            }
        }

        private void button_Color_axes_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pen_axes.Color = colorDialog1.Color;
                draw_Axes();
                draw_graphic();
                if (triangle_drawn)
                    draw_triangle(first_side, second_side, third_side, now_angle);
                pictureBox.Invalidate();
            }
        }

        private void button_Color_triangle_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                brush_triangle = new SolidBrush(colorDialog1.Color);
                draw_Axes();
                draw_graphic();
                if (triangle_drawn)
                    draw_triangle(first_side, second_side, third_side, now_angle);
                pictureBox.Invalidate();
            }
        }

        private void textBox_Width_triangle_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox_Width_triangle.Text, out float width))
            {
                if (width > 0 && width <= 10)
                {
                    pen_triangle.Width = width;
                    draw_Axes();
                    draw_graphic();
                    if (triangle_drawn)
                        draw_triangle(first_side, second_side, third_side, now_angle);
                    pictureBox.Invalidate();
                }
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
            started = true;
            button_Triangle.Enabled = false;
            button_move_direction.Enabled = false;
            textBox_Repeat_times.Enabled = false;
            if (!triangle_drawn)
                button_Triangle_Click(sender, e);
            button_Color_triangle.Enabled = false;
            button_Color_graphic.Enabled = false;
            button_Color_back.Enabled = false;
            button_Color_axes.Enabled = false;
            button_Start.Enabled = false;
        }

        private void textBox_Speed_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Speed.Text, out int sp))
            {
                if (sp <= max_speed && sp > 0)
                    speed = max_speed - sp;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (axes_drawn)
            {
                graphics.DrawLine(pen_axes, Ox[0], Ox[1]);
                graphics.DrawLine(pen_axes, Oy[0], Oy[1]);
            }

            if (graphic_drawn)
                graphics.DrawLines(pen_graphic, p.ToArray());

            if (triangle_drawn)
            {
                graphics.FillPolygon(brush_triangle, vertexes);
                graphics.DrawLine(pen_triangle, vertexes[0], vertexes[1]);
                graphics.DrawLine(pen_triangle, vertexes[1], vertexes[2]);
                graphics.DrawLine(pen_triangle, vertexes[2], vertexes[0]);
            }

            if (plus_clicked)
                plus_clicked = false;

            if (minus_clicked)
                minus_clicked = false;

            if (started)
            {
                if (now_index < p.Count && now_index >= 0)
                {
                    while (p.ElementAt(now_index).Y < 0 || p.ElementAt(now_index).X < 0)
                    {
                        now_index += step;
                        if (now_index >= p.Count)
                            break;
                    }
                }
                if (now_index < p.Count && now_index >= 0)
                {
                    center = p.ElementAt(now_index);
                    now_angle += angle;
                    if (pulsation_frequency > 0)
                    {
                        sum_r += step;
                        if (sum_r > pulsation_frequency)
                        {
                            sum_r = 0;
                            first_side += pulsation_size;
                            second_side += pulsation_size;
                            pulsation_size = -pulsation_size;
                        }
                    }
                    draw_triangle(first_side, second_side, third_side, now_angle);
                    now_index += step;
                }
                else
                {
                    current_times++;
                    if (current_times >= repeat_times)
                    {
                        started = false;
                        now_index = -1;
                        MessageBox.Show("Движение завершено", "Конец работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (now_index >= 0)
                    {
                        now_index = initial_index;
                        center = new Point(p.ElementAt(now_index).X, p.ElementAt(now_index).Y);
                        //button_Start_Click(sender, new EventArgs());
                        pictureBox.Invalidate();
                    }
                }
                Thread.Sleep(speed);
            }
        }

        private void textBox_Spin_speed_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_Spin_speed.Text, out double a))
            {
                if (Math.Abs(a) < 6.28319)
                    angle = a;
            }
        }

        private void button_move_direction_Click(object sender, EventArgs e)
        {
            p.Reverse();
            if (button_move_direction.Text == "движение: слева направо")
                button_move_direction.Text = "движение: справа налево";
            else if (button_move_direction.Text == "движение: справа налево")
                button_move_direction.Text = "движение: слева направо";
        }

        private void textBox_Pulsation_size_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Pulsation_size.Text, out int r))
            {
                if (r <= 100 && Math.Abs(r) < first_side*mashtab && Math.Abs(r) < second_side*mashtab)
                    pulsation_size = r;
            }
        }

        private void textBox_Pulsation_frequency_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_Pulsation_frequency.Text, out uint r))
            {
                if (r <= max_frequency)
                {
                    if (r == 0)
                        pulsation_frequency = 0;
                    else
                        pulsation_frequency = max_frequency - (int)r;
                }
            }
        }

        private void comboBox_Line_style_triangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Line_style_triangle.SelectedIndex == 0)
                pen_triangle.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else if (comboBox_Line_style_triangle.SelectedIndex == 1)
                pen_triangle.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            else if (comboBox_Line_style_triangle.SelectedIndex == 2)
                pen_triangle.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            else if (comboBox_Line_style_triangle.SelectedIndex == 3)
                pen_triangle.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            else if (comboBox_Line_style_triangle.SelectedIndex == 4)
                pen_triangle.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pictureBox.Invalidate();
        }

        private void comboBox_Line_style_graphic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Line_style_graphic.SelectedIndex == 0)
                pen_graphic.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else if (comboBox_Line_style_graphic.SelectedIndex == 1)
                pen_graphic.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            else if (comboBox_Line_style_graphic.SelectedIndex == 2)
                pen_graphic.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            else if (comboBox_Line_style_graphic.SelectedIndex == 3)
                pen_graphic.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            else if (comboBox_Line_style_graphic.SelectedIndex == 4)
                pen_graphic.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pictureBox.Invalidate();
        }

        private void comboBox_Line_style_axes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Line_style_axes.SelectedIndex == 0)
                pen_axes.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else if (comboBox_Line_style_axes.SelectedIndex == 1)
                pen_axes.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            else if (comboBox_Line_style_axes.SelectedIndex == 2)
                pen_axes.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            else if (comboBox_Line_style_axes.SelectedIndex == 3)
                pen_axes.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            else if (comboBox_Line_style_axes.SelectedIndex == 4)
                pen_axes.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pictureBox.Invalidate();
        }

        private void textBox_Graphic_width_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox_Graphic_width.Text, out float width))
            {
                if (width > 0 && width <= 10)
                {
                    pen_graphic.Width = width;
                    pictureBox.Invalidate();
                }
            }
        }

        private void textBox_Axes_width_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox_Axes_width.Text, out float width))
            {
                if (width > 0 && width <= 10)
                {
                    pen_axes.Width = width;
                    pictureBox.Invalidate();
                }
            }
        }

        private void textBox_Repeat_times_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_Repeat_times.Text, out uint r))
                repeat_times = (int)r + 1;
        }

        private void textBox_Step_size_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_Step_size.Text, out uint r))
                step = (int)r;
        }
    }
}
