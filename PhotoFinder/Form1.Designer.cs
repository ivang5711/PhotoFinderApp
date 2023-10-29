namespace PhotoFinder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(331, 555);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(446, 64);
            button1.TabIndex = 0;
            button1.Text = "Copy to destination folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(13, 398);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "keywords";
            textBox1.Size = new Size(1073, 219);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(22, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(732, 145);
            label1.TabIndex = 2;
            label1.Text = "Photo Finder";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(22, 236);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search folder";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(758, 44);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(811, 229);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(284, 57);
            button2.TabIndex = 5;
            button2.Text = "Select folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(13, 308);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Destination folder";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(758, 44);
            textBox3.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(802, 301);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(284, 57);
            button3.TabIndex = 8;
            button3.Text = "Select destination";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(13, 635);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(180, 40);
            radioButton1.TabIndex = 11;
            radioButton1.Text = "JPEG/JPG";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(859, 635);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(213, 40);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "All file types";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(236, 635);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(200, 40);
            radioButton3.TabIndex = 13;
            radioButton3.Text = "CR2 (RAW)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(514, 635);
            radioButton4.Margin = new Padding(4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(109, 40);
            radioButton4.TabIndex = 14;
            radioButton4.Text = "PNG";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton5.Location = new Point(707, 635);
            radioButton5.Margin = new Padding(4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(113, 40);
            radioButton5.TabIndex = 15;
            radioButton5.Text = "TIFF";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(857, 49);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 40);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Always on top";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 913);
            panel1.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(957, 113);
            button4.Name = "button4";
            button4.Size = new Size(138, 58);
            button4.TabIndex = 18;
            button4.Text = "Help";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(1123, 713);
            panel2.TabIndex = 17;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(22, 640);
            progressBar1.Maximum = 500;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1073, 53);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            progressBar1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1106, 892);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Photo Finder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private CheckBox checkBox1;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        public ProgressBar progressBar1;
    }
}