namespace NuevoLogin
{
    partial class altaAlumno
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 25);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "nombre";
            textBox1.Size = new Size(381, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 76);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "apellido";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 123);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "dni";
            textBox3.Size = new Size(381, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(191, 181);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "telefono";
            textBox4.Size = new Size(381, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(191, 240);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "direccion";
            textBox5.Size = new Size(381, 23);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(245, 297);
            button1.Name = "button1";
            button1.Size = new Size(106, 42);
            button1.TabIndex = 5;
            button1.Text = "aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 297);
            button2.Name = "button2";
            button2.Size = new Size(97, 42);
            button2.TabIndex = 6;
            button2.Text = "cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // altaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 441);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "altaAlumno";
            Text = "altaAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
    }
}