
namespace WindowsFormsThirdTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Circles_amount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Levels_amount = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_draw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.comboBox_Initial_R = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество кругов:";
            // 
            // comboBox_Circles_amount
            // 
            this.comboBox_Circles_amount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Circles_amount.FormattingEnabled = true;
            this.comboBox_Circles_amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Circles_amount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_Circles_amount.Location = new System.Drawing.Point(172, 8);
            this.comboBox_Circles_amount.Name = "comboBox_Circles_amount";
            this.comboBox_Circles_amount.Size = new System.Drawing.Size(69, 28);
            this.comboBox_Circles_amount.TabIndex = 1;
            this.comboBox_Circles_amount.SelectedIndexChanged += new System.EventHandler(this.comboBox_Circles_amount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество уровней прорисовки(вложенности) фрактала:";
            // 
            // comboBox_Levels_amount
            // 
            this.comboBox_Levels_amount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Levels_amount.FormattingEnabled = true;
            this.comboBox_Levels_amount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_Levels_amount.Location = new System.Drawing.Point(707, 8);
            this.comboBox_Levels_amount.Name = "comboBox_Levels_amount";
            this.comboBox_Levels_amount.Size = new System.Drawing.Size(69, 28);
            this.comboBox_Levels_amount.TabIndex = 3;
            this.comboBox_Levels_amount.SelectedIndexChanged += new System.EventHandler(this.comboBox_Levels_amount_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 404);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(782, 3);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(97, 33);
            this.button_draw.TabIndex = 5;
            this.button_draw.Text = "Рисовать";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(885, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Масштаб фрактала:";
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(1056, 5);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(36, 31);
            this.button_plus.TabIndex = 7;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(1098, 3);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(36, 31);
            this.button_minus.TabIndex = 8;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // comboBox_Initial_R
            // 
            this.comboBox_Initial_R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Initial_R.FormattingEnabled = true;
            this.comboBox_Initial_R.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250",
            "300"});
            this.comboBox_Initial_R.Location = new System.Drawing.Point(1311, 5);
            this.comboBox_Initial_R.Name = "comboBox_Initial_R";
            this.comboBox_Initial_R.Size = new System.Drawing.Size(102, 28);
            this.comboBox_Initial_R.TabIndex = 9;
            this.comboBox_Initial_R.SelectedIndexChanged += new System.EventHandler(this.comboBox_Initial_R_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1156, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Радиус фрактала:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Initial_R);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_Levels_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Circles_amount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Рисование фрактала";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Circles_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Levels_amount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.ComboBox comboBox_Initial_R;
        private System.Windows.Forms.Label label4;
    }
}

