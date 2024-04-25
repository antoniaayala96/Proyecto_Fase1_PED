namespace Proyecto_Fase1
{
    partial class Usuario
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
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(114, 100);
            label1.Name = "label1";
            label1.Size = new Size(296, 42);
            label1.TabIndex = 0;
            label1.Text = "Agregar Usuarios";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 55, 71);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(198, 498);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 32;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(24, 55, 71);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(122, 390);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 55, 71);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.Cross;
            textBox1.Location = new Point(122, 248);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(93, 324);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 29;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(93, 204);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 28;
            label3.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._17;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources._5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(468, 588);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Usuario";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}