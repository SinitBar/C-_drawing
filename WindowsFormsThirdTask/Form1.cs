using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsThirdTask
{
    public partial class Form1 : Form
    {
        static int levels = -1; // выбранное пользователем количество уровней
        int circles = 0; // выбранное пользователем количество кругов
        int min_amount_of_circles = 3; // наименьшее количество кругов
        static int indent = 20; // отуступ от полей и между фракталами
        int level_indent = 40; // отступ в дереве фракталов по уровню
        static int fractal_height = 420; // место, с которого по оси ОУ начинается часть экрана для фракталов
        Tree fractal_tree; // дерево
        static int tree_width = 1240; // ширина отрезка для построения дерева на 1 уровне
        static int initial_radius = 200; // радиус большей окружности изначального фрактала
        static int height = fractal_height + 2 * (indent + initial_radius); // высота picureBox
        static Color[] colors = { Color.Orange,  Color.Pink, Color.Lime, Color.Purple, Color.Cyan, Color.Red, Color.Magenta, Color.Blue, Color.Aquamarine, Color.Black, Color.Yellow, Color.Brown}; // цвета для ручек
        static int r = 2; // радиус для рисования вершин дерева
        bool to_draw = false; // индикатор, была ли нажата кнопка рисовать
        double mashtab_change = 0.1; // шаг изменения масштаба картинки
        int min_radius_size = 20; // минимальный радиус большей окружности фрактала
        int last_section = tree_width + 1;
        class Node
        {
            public Point Dot; // координаты точки для дерева
            public Point[] center; // координаты точки для фракталов
            public int R; // радиус круга для фрактала
            public int level; // номер уровня
            public Node[] children; // массив дочерних элементов данного узла, нулевой - центральный
            public Node(int lvl) 
            { 
                children = null; 
                level = lvl;
                center = new Point[levels - lvl + 1];
            }
        }

        class Tree
        {
            public Node root; // корень дерева
            public Tree(int levels_amount)
            {
                root = new Node(0);
                root.Dot = new Point(tree_width/2 - indent, indent); // уставновка вершины дерева на pictureBox
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_Circles_amount_SelectedIndexChanged(object sender, EventArgs e)
        {
            circles = comboBox_Circles_amount.SelectedIndex + min_amount_of_circles;
            if (levels >= 0 && to_draw)
                button_draw_Click(sender, e);
        }

        private void comboBox_Levels_amount_SelectedIndexChanged(object sender, EventArgs e)
        {
            levels = comboBox_Levels_amount.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Width = tree_width;
            pictureBox.Height = height;
            button_minus.Enabled = false;
            button_plus.Enabled = false;
            comboBox_Initial_R.SelectedIndex = 3;
        }

        private void fill_levels( Node now_node, int t_width)
        {
            now_node.children = new Node[circles + 1];
            int y = now_node.Dot.Y + level_indent;
            int section = t_width / (circles + 2);
            if (last_section < section)
                last_section = section;
            int x = now_node.Dot.X - t_width/2; // выбираем прямоугольный сектор для отрисовки
            double angle = 0;
            double r = now_node.R * Math.Sin(Math.PI / circles) / (1 + Math.Sin(Math.PI / circles)); // считается по формуле правильного многоугольника, вписанного в окружность
            for (int i = 0; i <= circles; i++)
            {
                if (now_node != fractal_tree.root)
                    now_node.children[i] = new Node(now_node.level + 1);
                else
                    now_node.children[i] = new Node(now_node.level);
                x += section;
                now_node.children[i].Dot = new Point(x, y);
                if (i == 0)
                {
                    now_node.children[i].R = (int)(now_node.R - 2 * r); // радиус окружности, вложенной по правилу построения
                    for (int j = now_node.center.Length - 1; j - now_node.center.Length + now_node.children[i].center.Length >= 0; j--)
                        now_node.children[i].center[j - now_node.center.Length + now_node.children[i].center.Length] = now_node.center[j];
                }
                else
                {
                    // подсчет центров окружностей через полярную систему координат
                    for (int j = now_node.center.Length - 1; j - now_node.center.Length + now_node.children[i].center.Length >= 0 ; j--)
                        now_node.children[i].center[j - now_node.center.Length + now_node.children[i].center.Length] = new Point(now_node.center[j].X + (int)((now_node.R - r) * Math.Cos(angle)), now_node.center[j].Y + (int)((now_node.R - r) * Math.Sin(angle)));
                    now_node.children[i].R = (int)r; // радиус у окружностей, составляющих кольцо
                    angle += 2 * Math.PI / circles; // изменяем угол для полярной системы координат
                }
            }
            if (now_node.level < levels)
            {
                for (int i = 0; i < now_node.children.Length; i++)
                    fill_levels(now_node.children[i], section);
            }
        }



        private void button_draw_Click(object sender, EventArgs e)
        {
            if (levels >= 0 && circles >= min_amount_of_circles)
            {
                to_draw = true;
                fractal_tree = new Tree(levels + 1);
                fractal_tree.root.R = initial_radius;
                fractal_tree.root.children = new Node[circles + 1];
                for (int i = 0; i < fractal_tree.root.children.Length; i++)
                    fractal_tree.root.children[i] = new Node(0);
                for (int i = 0; i <= levels; i++)
                {
                    fractal_tree.root.center[i] = new Point(indent + i * 2 * initial_radius + i * indent + initial_radius, fractal_height + initial_radius);
                    if (pictureBox.Width < fractal_tree.root.center[i].X)
                        pictureBox.Width = fractal_tree.root.center[i].X + initial_radius + indent;
                }
                fill_levels(fractal_tree.root, tree_width);
                if ((indent + (levels + 1) * 2 * (indent + fractal_tree.root.R)) > pictureBox.Width)
                pictureBox.Width = (indent + (levels + 1)*2 * (indent + fractal_tree.root.R)); // изменяем ширину экрана
                if (pictureBox.Height < fractal_height + indent + initial_radius * 2)
                    pictureBox.Height = fractal_height + indent + initial_radius * 2;
                button_minus.Enabled = true;
                button_plus.Enabled = true;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (to_draw)
            {
                Graphics graphics = e.Graphics;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                Node now = fractal_tree.root;
                Pen[] tree_pen = new Pen[levels + 3];
                for (int i = 0; i < tree_pen.Length; i++)
                    tree_pen[i] = new Pen(colors[i], 1f);
                graphics.DrawEllipse(tree_pen[0], now.Dot.X - r, now.Dot.Y - r, r * 2, r * 2);
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(now);
                while (q.Count != 0) // обход дерева в ширину
                {
                    if (now.children != null)
                    {
                        if (now.children[0].children != null)
                        {
                            for (int i = 0; i < now.children.Length; i++)
                            {
                                if (now.children[0].children[0].children != null)
                                {
                                    if (now != fractal_tree.root)
                                    {
                                        graphics.DrawLine(tree_pen[now.level + 2], now.Dot, now.children[i].Dot);
                                        graphics.DrawEllipse(tree_pen[now.level + 2], now.children[i].Dot.X - r / 2, now.children[i].Dot.Y - r / 2, r, r);
                                    }
                                    else
                                    {
                                        graphics.DrawLine(tree_pen[now.level + 1], now.Dot, now.children[i].Dot);
                                        graphics.DrawEllipse(tree_pen[now.level + 1], now.children[i].Dot.X - r / 2, now.children[i].Dot.Y - r / 2, r, r);
                                    }
                                }
                                q.Enqueue(now.children[i]);
                            }
                        }
                    }
                    now = q.Dequeue();
                    for (int j = 0; j < now.center.Length; j++)
                        graphics.DrawEllipse(tree_pen[now.level], now.center[j].X - now.R, now.center[j].Y - now.R, now.R*2, now.R*2);
                    if (levels == 0)
                    {
                        for (int i = 0; i < now.children.Length; i++)
                        {
                            graphics.DrawEllipse(tree_pen[0], now.children[i].center[0].X - now.children[i].R, now.children[i].center[0].Y - now.children[i].R, now.children[i].R * 2, now.children[i].R * 2);
                        }
                    }
                }
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (!button_minus.Enabled)
                button_minus.Enabled = true;
            Queue<Node> q = new Queue<Node>();
            Node now = fractal_tree.root;
            q.Enqueue(now);
            initial_radius = (int)((initial_radius + 1) * (1 + mashtab_change));
            pictureBox.Width = (int)(indent * (1 + mashtab_change) + (levels + 1)*2*(indent + now.R) * (1 + mashtab_change));
            pictureBox.Height = (int)((fractal_height + now.R)*(1 + mashtab_change) + 2* (indent + now.R)*(1 + mashtab_change));
            while (q.Count != 0)
            {
                now = q.Dequeue();
                if (now.children != null)
                {
                    for (int i = 0; i < now.children.Length; i++)
                        q.Enqueue(now.children[i]);
                }
                for (int i = 0; i < now.center.Length; i++)
                {
                    now.center[i].X = (int)((now.center[i].X) * (1 + mashtab_change));
                    now.center[i].Y = (int)((now.center[i].Y) * (1 + mashtab_change));
                }
                now.Dot.X = (int)((now.Dot.X) * (1 + mashtab_change));
                now.Dot.Y = (int)((now.Dot.Y) * (1 + mashtab_change));
                now.R = (int)((now.R + 1) * (1 + mashtab_change));
            }
            pictureBox.Invalidate();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (initial_radius >= min_radius_size)
            {
                Queue<Node> q = new Queue<Node>();
                Node now = fractal_tree.root;
                q.Enqueue(now);
                initial_radius = (int)(initial_radius * (1 - mashtab_change));
                pictureBox.Width = (int)(indent * (1 + mashtab_change) + (levels + 1) * 2 * (indent + now.R) * (1 + mashtab_change));
                pictureBox.Height = (int)((fractal_height + now.R) * (1 + mashtab_change) + 2 * (indent + now.R) * (1 + mashtab_change));
                while (q.Count != 0)
                {
                    now = q.Dequeue();
                    if (now.children != null)
                    {
                        for (int i = 0; i < now.children.Length; i++)
                            q.Enqueue(now.children[i]);
                    }
                    for (int i = 0; i < now.center.Length; i++)
                    { 
                        now.center[i].X = (int)(now.center[i].X * (1 - mashtab_change));
                        now.center[i].Y = (int)(now.center[i].Y * (1 - mashtab_change));
                    }
                    now.Dot.X = (int)(now.Dot.X * (1 - mashtab_change));
                    now.Dot.Y = (int)(now.Dot.Y * (1 - mashtab_change));
                    now.R = (int)((now.R+0.4) * (1 - mashtab_change));
                }
                if (initial_radius < min_radius_size)
                    button_minus.Enabled = false;
            }
            pictureBox.Invalidate();
        }

        private void comboBox_Initial_R_SelectedIndexChanged(object sender, EventArgs e)
        {
            initial_radius = int.Parse(comboBox_Initial_R.Items[comboBox_Initial_R.SelectedIndex].ToString());
            if (to_draw)
                button_draw_Click(sender, e);

        }
    }
}
