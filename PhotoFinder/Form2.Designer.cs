namespace PhotoFinder
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 213);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 43);
            label1.Name = "label1";
            label1.Size = new Size(993, 145);
            label1.TabIndex = 0;
            label1.Text = "Photo Finder help";
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Location = new Point(31, 231);
            label2.Name = "label2";
            label2.Size = new Size(940, 975);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // button1
            // 
            button1.Location = new Point(406, 1261);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(988, 1353);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}