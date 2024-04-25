namespace Proyecto_Fase1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._8;
            pictureBox1.Location = new Point(120, 53);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(120, 321);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(120, 441);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 55, 71);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.Cross;
            textBox1.Location = new Point(149, 365);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(24, 55, 71);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(149, 507);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 55, 71);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(204, 576);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources._5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(526, 643);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "login";
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
