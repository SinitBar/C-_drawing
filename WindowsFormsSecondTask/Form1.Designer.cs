
namespace WindowsFormsSecondTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Side = new System.Windows.Forms.TextBox();
            this.textBox2Side = new System.Windows.Forms.TextBox();
            this.button_Triangle = new System.Windows.Forms.Button();
            this.label_Center = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_Color_graphic = new System.Windows.Forms.Button();
            this.button_Color_back = new System.Windows.Forms.Button();
            this.button_Color_axes = new System.Windows.Forms.Button();
            this.button_Color_triangle = new System.Windows.Forms.Button();
            this.textBox_Width_triangle = new System.Windows.Forms.TextBox();
            this.toolTip_pictureBox_draw = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.button_move_direction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Spin_speed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Pulsation_size = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Pulsation_frequency = new System.Windows.Forms.TextBox();
            this.comboBox_Line_style_triangle = new System.Windows.Forms.ComboBox();
            this.comboBox_Line_style_graphic = new System.Windows.Forms.ComboBox();
            this.comboBox_Line_style_axes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Graphic_width = new System.Windows.Forms.TextBox();
            this.textBox_Axes_width = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Repeat_times = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Step_size = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 941);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задайте прямоугольный треугольник:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина первого катета:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Длина второго катета:";
            // 
            // textBox1Side
            // 
            this.textBox1Side.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1Side.Location = new System.Drawing.Point(662, 55);
            this.textBox1Side.Name = "textBox1Side";
            this.textBox1Side.Size = new System.Drawing.Size(63, 26);
            this.textBox1Side.TabIndex = 5;
            this.textBox1Side.TextChanged += new System.EventHandler(this.textBox1Side_TextChanged);
            // 
            // textBox2Side
            // 
            this.textBox2Side.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2Side.Location = new System.Drawing.Point(662, 89);
            this.textBox2Side.Name = "textBox2Side";
            this.textBox2Side.Size = new System.Drawing.Size(63, 26);
            this.textBox2Side.TabIndex = 6;
            this.textBox2Side.TextChanged += new System.EventHandler(this.textBox2Side_TextChanged);
            // 
            // button_Triangle
            // 
            this.button_Triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Triangle.Location = new System.Drawing.Point(477, 121);
            this.button_Triangle.Name = "button_Triangle";
            this.button_Triangle.Size = new System.Drawing.Size(252, 40);
            this.button_Triangle.TabIndex = 7;
            this.button_Triangle.Text = "Показать треугольник";
            this.button_Triangle.UseVisualStyleBackColor = true;
            this.button_Triangle.Click += new System.EventHandler(this.button_Triangle_Click);
            // 
            // label_Center
            // 
            this.label_Center.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Center.AutoSize = true;
            this.label_Center.Location = new System.Drawing.Point(12, 985);
            this.label_Center.Name = "label_Center";
            this.label_Center.Size = new System.Drawing.Size(51, 20);
            this.label_Center.TabIndex = 8;
            this.label_Center.Text = "label4";
            // 
            // button_Start
            // 
            this.button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Start.Location = new System.Drawing.Point(490, 979);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(411, 40);
            this.button_Start.TabIndex = 9;
            this.button_Start.Text = "Начать движение по траектории";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Plus.Location = new System.Drawing.Point(387, 979);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(36, 35);
            this.button_Plus.TabIndex = 10;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minus.Location = new System.Drawing.Point(429, 979);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(36, 35);
            this.button_Minus.TabIndex = 11;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_Color_graphic
            // 
            this.button_Color_graphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Color_graphic.Location = new System.Drawing.Point(764, 256);
            this.button_Color_graphic.Name = "button_Color_graphic";
            this.button_Color_graphic.Size = new System.Drawing.Size(130, 33);
            this.button_Color_graphic.TabIndex = 12;
            this.button_Color_graphic.Text = "цвет графика";
            this.button_Color_graphic.UseVisualStyleBackColor = true;
            this.button_Color_graphic.Click += new System.EventHandler(this.button_Color_graphic_Click);
            // 
            // button_Color_back
            // 
            this.button_Color_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Color_back.Location = new System.Drawing.Point(787, 299);
            this.button_Color_back.Name = "button_Color_back";
            this.button_Color_back.Size = new System.Drawing.Size(107, 33);
            this.button_Color_back.TabIndex = 13;
            this.button_Color_back.Text = "цвет фона";
            this.button_Color_back.UseVisualStyleBackColor = true;
            this.button_Color_back.Click += new System.EventHandler(this.button_Color_back_Click);
            // 
            // button_Color_axes
            // 
            this.button_Color_axes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Color_axes.Location = new System.Drawing.Point(780, 343);
            this.button_Color_axes.Name = "button_Color_axes";
            this.button_Color_axes.Size = new System.Drawing.Size(114, 33);
            this.button_Color_axes.TabIndex = 14;
            this.button_Color_axes.Text = "цвет осей";
            this.button_Color_axes.UseVisualStyleBackColor = true;
            this.button_Color_axes.Click += new System.EventHandler(this.button_Color_axes_Click);
            // 
            // button_Color_triangle
            // 
            this.button_Color_triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Color_triangle.Location = new System.Drawing.Point(731, 46);
            this.button_Color_triangle.Name = "button_Color_triangle";
            this.button_Color_triangle.Size = new System.Drawing.Size(170, 35);
            this.button_Color_triangle.TabIndex = 15;
            this.button_Color_triangle.Text = "цвет треугольника";
            this.button_Color_triangle.UseVisualStyleBackColor = true;
            this.button_Color_triangle.Click += new System.EventHandler(this.button_Color_triangle_Click);
            // 
            // textBox_Width_triangle
            // 
            this.textBox_Width_triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Width_triangle.Location = new System.Drawing.Point(841, 135);
            this.textBox_Width_triangle.Name = "textBox_Width_triangle";
            this.textBox_Width_triangle.Size = new System.Drawing.Size(59, 26);
            this.textBox_Width_triangle.TabIndex = 16;
            this.textBox_Width_triangle.TextChanged += new System.EventHandler(this.textBox_Width_triangle_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Толщина линии";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Скорость движения (от 1 до 10):";
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Speed.Location = new System.Drawing.Point(746, 175);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(106, 26);
            this.textBox_Speed.TabIndex = 20;
            this.textBox_Speed.TextChanged += new System.EventHandler(this.textBox_Speed_TextChanged);
            // 
            // button_move_direction
            // 
            this.button_move_direction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_move_direction.Location = new System.Drawing.Point(476, 256);
            this.button_move_direction.Name = "button_move_direction";
            this.button_move_direction.Size = new System.Drawing.Size(270, 40);
            this.button_move_direction.TabIndex = 21;
            this.button_move_direction.Text = "движение: справа налево";
            this.button_move_direction.UseVisualStyleBackColor = true;
            this.button_move_direction.Click += new System.EventHandler(this.button_move_direction_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Скорость вращения в радинах:";
            // 
            // textBox_Spin_speed
            // 
            this.textBox_Spin_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Spin_speed.Location = new System.Drawing.Point(740, 210);
            this.textBox_Spin_speed.Name = "textBox_Spin_speed";
            this.textBox_Spin_speed.Size = new System.Drawing.Size(154, 26);
            this.textBox_Spin_speed.TabIndex = 23;
            this.textBox_Spin_speed.TextChanged += new System.EventHandler(this.textBox_Spin_speed_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "(от -6,28319 до 6,28319)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Размах пульсации:";
            // 
            // textBox_Pulsation_size
            // 
            this.textBox_Pulsation_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pulsation_size.Location = new System.Drawing.Point(640, 302);
            this.textBox_Pulsation_size.Name = "textBox_Pulsation_size";
            this.textBox_Pulsation_size.Size = new System.Drawing.Size(107, 26);
            this.textBox_Pulsation_size.TabIndex = 26;
            this.textBox_Pulsation_size.TextChanged += new System.EventHandler(this.textBox_Pulsation_size_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Частота пульсации:";
            // 
            // textBox_Pulsation_frequency
            // 
            this.textBox_Pulsation_frequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pulsation_frequency.Location = new System.Drawing.Point(651, 337);
            this.textBox_Pulsation_frequency.Name = "textBox_Pulsation_frequency";
            this.textBox_Pulsation_frequency.Size = new System.Drawing.Size(96, 26);
            this.textBox_Pulsation_frequency.TabIndex = 28;
            this.textBox_Pulsation_frequency.TextChanged += new System.EventHandler(this.textBox_Pulsation_frequency_TextChanged);
            // 
            // comboBox_Line_style_triangle
            // 
            this.comboBox_Line_style_triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Line_style_triangle.FormattingEnabled = true;
            this.comboBox_Line_style_triangle.Items.AddRange(new object[] {
            "сплошная",
            "пунктирная",
            "точками",
            "штрих-пунктир",
            "пунктир-точка-точка"});
            this.comboBox_Line_style_triangle.Location = new System.Drawing.Point(488, 384);
            this.comboBox_Line_style_triangle.Name = "comboBox_Line_style_triangle";
            this.comboBox_Line_style_triangle.Size = new System.Drawing.Size(259, 28);
            this.comboBox_Line_style_triangle.TabIndex = 29;
            this.comboBox_Line_style_triangle.Text = "линия треугольника";
            this.comboBox_Line_style_triangle.SelectedIndexChanged += new System.EventHandler(this.comboBox_Line_style_triangle_SelectedIndexChanged);
            // 
            // comboBox_Line_style_graphic
            // 
            this.comboBox_Line_style_graphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Line_style_graphic.FormattingEnabled = true;
            this.comboBox_Line_style_graphic.Items.AddRange(new object[] {
            "сплошная",
            "пунктирная",
            "точками",
            "штрих-пунктир",
            "пунктир-точка-точка"});
            this.comboBox_Line_style_graphic.Location = new System.Drawing.Point(488, 418);
            this.comboBox_Line_style_graphic.Name = "comboBox_Line_style_graphic";
            this.comboBox_Line_style_graphic.Size = new System.Drawing.Size(259, 28);
            this.comboBox_Line_style_graphic.TabIndex = 30;
            this.comboBox_Line_style_graphic.Text = "линия графика";
            this.comboBox_Line_style_graphic.SelectedIndexChanged += new System.EventHandler(this.comboBox_Line_style_graphic_SelectedIndexChanged);
            // 
            // comboBox_Line_style_axes
            // 
            this.comboBox_Line_style_axes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Line_style_axes.FormattingEnabled = true;
            this.comboBox_Line_style_axes.Items.AddRange(new object[] {
            "сплошная",
            "пунктирная",
            "точками",
            "штрих-пунктир",
            "пунктир-точка-точка"});
            this.comboBox_Line_style_axes.Location = new System.Drawing.Point(488, 452);
            this.comboBox_Line_style_axes.Name = "comboBox_Line_style_axes";
            this.comboBox_Line_style_axes.Size = new System.Drawing.Size(259, 28);
            this.comboBox_Line_style_axes.TabIndex = 31;
            this.comboBox_Line_style_axes.Text = "линии осей";
            this.comboBox_Line_style_axes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Line_style_axes_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(776, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Толщина:";
            // 
            // textBox_Graphic_width
            // 
            this.textBox_Graphic_width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Graphic_width.Location = new System.Drawing.Point(787, 420);
            this.textBox_Graphic_width.Name = "textBox_Graphic_width";
            this.textBox_Graphic_width.Size = new System.Drawing.Size(65, 26);
            this.textBox_Graphic_width.TabIndex = 33;
            this.textBox_Graphic_width.TextChanged += new System.EventHandler(this.textBox_Graphic_width_TextChanged);
            // 
            // textBox_Axes_width
            // 
            this.textBox_Axes_width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Axes_width.Location = new System.Drawing.Point(787, 454);
            this.textBox_Axes_width.Name = "textBox_Axes_width";
            this.textBox_Axes_width.Size = new System.Drawing.Size(65, 26);
            this.textBox_Axes_width.TabIndex = 34;
            this.textBox_Axes_width.TextChanged += new System.EventHandler(this.textBox_Axes_width_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(735, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "треугольника";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(473, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Число повторов:";
            // 
            // textBox_Repeat_times
            // 
            this.textBox_Repeat_times.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Repeat_times.Location = new System.Drawing.Point(616, 494);
            this.textBox_Repeat_times.Name = "textBox_Repeat_times";
            this.textBox_Repeat_times.Size = new System.Drawing.Size(47, 26);
            this.textBox_Repeat_times.TabIndex = 37;
            this.textBox_Repeat_times.TextChanged += new System.EventHandler(this.textBox_Repeat_times_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Шаг перемещения:";
            // 
            // textBox_Step_size
            // 
            this.textBox_Step_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Step_size.Location = new System.Drawing.Point(829, 494);
            this.textBox_Step_size.Name = "textBox_Step_size";
            this.textBox_Step_size.Size = new System.Drawing.Size(65, 26);
            this.textBox_Step_size.TabIndex = 39;
            this.textBox_Step_size.TextChanged += new System.EventHandler(this.textBox_Step_size_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 989);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Изменить масштаб:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(508, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 438);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(736, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "(от 1 до 10):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 1050);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_Step_size);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_Repeat_times);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_Axes_width);
            this.Controls.Add(this.textBox_Graphic_width);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_Line_style_axes);
            this.Controls.Add(this.comboBox_Line_style_graphic);
            this.Controls.Add(this.comboBox_Line_style_triangle);
            this.Controls.Add(this.textBox_Pulsation_frequency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Pulsation_size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Spin_speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_move_direction);
            this.Controls.Add(this.textBox_Speed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Width_triangle);
            this.Controls.Add(this.button_Color_triangle);
            this.Controls.Add(this.button_Color_axes);
            this.Controls.Add(this.button_Color_back);
            this.Controls.Add(this.button_Color_graphic);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Center);
            this.Controls.Add(this.button_Triangle);
            this.Controls.Add(this.textBox2Side);
            this.Controls.Add(this.textBox1Side);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Движение по траектории";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Side;
        private System.Windows.Forms.TextBox textBox2Side;
        private System.Windows.Forms.Button button_Triangle;
        private System.Windows.Forms.Label label_Center;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_Color_graphic;
        private System.Windows.Forms.Button button_Color_back;
        private System.Windows.Forms.Button button_Color_axes;
        private System.Windows.Forms.Button button_Color_triangle;
        private System.Windows.Forms.TextBox textBox_Width_triangle;
        private System.Windows.Forms.ToolTip toolTip_pictureBox_draw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.Button button_move_direction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Spin_speed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Pulsation_size;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Pulsation_frequency;
        private System.Windows.Forms.ComboBox comboBox_Line_style_triangle;
        private System.Windows.Forms.ComboBox comboBox_Line_style_graphic;
        private System.Windows.Forms.ComboBox comboBox_Line_style_axes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Graphic_width;
        private System.Windows.Forms.TextBox textBox_Axes_width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Repeat_times;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Step_size;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}

