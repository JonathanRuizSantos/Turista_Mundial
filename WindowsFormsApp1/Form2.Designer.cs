namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxPJ1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBoxPJ2 = new System.Windows.Forms.ListBox();
            this.listBoxEJ1 = new System.Windows.Forms.ListBox();
            this.listBoxEJ2 = new System.Windows.Forms.ListBox();
            this.listBoxPD = new System.Windows.Forms.ListBox();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lanzar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(569, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Comprar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listBoxPJ1
            // 
            this.listBoxPJ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxPJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPJ1.FormattingEnabled = true;
            this.listBoxPJ1.ItemHeight = 20;
            this.listBoxPJ1.Items.AddRange(new object[] {
            "Propiedades"});
            this.listBoxPJ1.Location = new System.Drawing.Point(27, 126);
            this.listBoxPJ1.Name = "listBoxPJ1";
            this.listBoxPJ1.Size = new System.Drawing.Size(187, 322);
            this.listBoxPJ1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(142, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 33);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Jugador 1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(783, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 33);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Jugador 2";
            // 
            // listBoxPJ2
            // 
            this.listBoxPJ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxPJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPJ2.FormattingEnabled = true;
            this.listBoxPJ2.ItemHeight = 20;
            this.listBoxPJ2.Items.AddRange(new object[] {
            "Propiedades"});
            this.listBoxPJ2.Location = new System.Drawing.Point(855, 126);
            this.listBoxPJ2.Name = "listBoxPJ2";
            this.listBoxPJ2.Size = new System.Drawing.Size(193, 322);
            this.listBoxPJ2.TabIndex = 4;
            // 
            // listBoxEJ1
            // 
            this.listBoxEJ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxEJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEJ1.FormattingEnabled = true;
            this.listBoxEJ1.ItemHeight = 20;
            this.listBoxEJ1.Items.AddRange(new object[] {
            "Efectivo Disponible"});
            this.listBoxEJ1.Location = new System.Drawing.Point(220, 126);
            this.listBoxEJ1.Name = "listBoxEJ1";
            this.listBoxEJ1.Size = new System.Drawing.Size(153, 322);
            this.listBoxEJ1.TabIndex = 6;
            // 
            // listBoxEJ2
            // 
            this.listBoxEJ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxEJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEJ2.FormattingEnabled = true;
            this.listBoxEJ2.ItemHeight = 20;
            this.listBoxEJ2.Items.AddRange(new object[] {
            "Efectivo Disponible"});
            this.listBoxEJ2.Location = new System.Drawing.Point(696, 126);
            this.listBoxEJ2.Name = "listBoxEJ2";
            this.listBoxEJ2.Size = new System.Drawing.Size(153, 322);
            this.listBoxEJ2.TabIndex = 7;
            // 
            // listBoxPD
            // 
            this.listBoxPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPD.FormattingEnabled = true;
            this.listBoxPD.ItemHeight = 20;
            this.listBoxPD.Items.AddRange(new object[] {
            "Propiedades Disponibles"});
            this.listBoxPD.Location = new System.Drawing.Point(438, 126);
            this.listBoxPD.Name = "listBoxPD";
            this.listBoxPD.Size = new System.Drawing.Size(211, 322);
            this.listBoxPD.TabIndex = 8;
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxSalida.Location = new System.Drawing.Point(36, 484);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(1012, 58);
            this.textBoxSalida.TabIndex = 9;
            this.textBoxSalida.Text = "Caja de Salidas";
            this.textBoxSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSalida.TextChanged += new System.EventHandler(this.textBoxSalida_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(489, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pngtree_travel_outgoing_goods_background_image_718317;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.listBoxPD);
            this.Controls.Add(this.listBoxEJ2);
            this.Controls.Add(this.listBoxEJ1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBoxPJ2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxPJ1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxPJ1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBoxPJ2;
        private System.Windows.Forms.ListBox listBoxEJ1;
        private System.Windows.Forms.ListBox listBoxEJ2;
        private System.Windows.Forms.ListBox listBoxPD;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.Button button3;
    }
}