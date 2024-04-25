namespace Proyecto_Fase1
{
    partial class Filtro
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
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 55, 71);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(170, 545);
            button1.Name = "button1";
            button1.Size = new Size(149, 39);
            button1.TabIndex = 41;
            button1.Text = "Buscar Tarea";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(24, 55, 71);
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(234, 365);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(172, 28);
            comboBox2.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(24, 55, 71);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 219);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(42, 365);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 35;
            label7.Text = "PRIORIDAD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(42, 216);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 31;
            label8.Text = "CATEGORIA";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(501, 106);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 371);
            dataGridView1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._17;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(728, 68);
            label1.TabIndex = 44;
            label1.Text = "VER LISTAS DE TAREAS";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(0, 64, 64);
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Activar Filtro" });
            checkedListBox1.Location = new Point(234, 280);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 24);
            checkedListBox1.TabIndex = 45;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.FromArgb(0, 64, 64);
            checkedListBox2.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox2.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Activar Filtro" });
            checkedListBox2.Location = new Point(234, 426);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 24);
            checkedListBox2.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(60, 121);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 47;
            label2.Text = "ELIGE UN FILTRO";
            // 
            // Filtro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources._21;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1254, 695);
            Controls.Add(label2);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Filtro";
            Text = "Filtro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private Label label2;
    }
}