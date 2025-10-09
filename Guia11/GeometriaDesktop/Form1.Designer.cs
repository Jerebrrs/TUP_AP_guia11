namespace GeometriaDesktop
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            btn = new Button();
            btnLimpiar = new Button();
            tbArea = new TextBox();
            tbAlto = new TextBox();
            tbRadio = new TextBox();
            tbAncho = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lvwFiguras = new ListView();
            btnListado = new Button();
            btnRegistro = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Rectangulo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.RightToLeft = RightToLeft.No;
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Circulo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 158);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Figura";
            // 
            // btn
            // 
            btn.Location = new Point(387, 77);
            btn.Name = "btn";
            btn.Size = new Size(76, 49);
            btn.TabIndex = 12;
            btn.Text = "Configurar Registro";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(387, 46);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(255, 120);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(100, 23);
            tbArea.TabIndex = 10;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(255, 62);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(100, 23);
            tbAlto.TabIndex = 9;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(255, 91);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 23);
            tbRadio.TabIndex = 8;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(255, 34);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 128);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 94);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 66);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Alto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Ancho";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Location = new Point(15, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 87);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Figura";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(lvwFiguras);
            groupBox3.Location = new Point(12, 187);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(366, 257);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado de Figuras";
            // 
            // lvwFiguras
            // 
            lvwFiguras.Location = new Point(15, 33);
            lvwFiguras.Name = "lvwFiguras";
            lvwFiguras.Size = new Size(340, 138);
            lvwFiguras.TabIndex = 0;
            lvwFiguras.UseCompatibleStateImageBehavior = false;
            // 
            // btnListado
            // 
            btnListado.Location = new Point(384, 210);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(75, 45);
            btnListado.TabIndex = 4;
            btnListado.Text = "Actualizar Listado";
            btnListado.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(384, 275);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 42);
            btnRegistro.TabIndex = 5;
            btnRegistro.Text = "Elimiar Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 514);
            Controls.Add(btnRegistro);
            Controls.Add(btnListado);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbAlto;
        private TextBox tbRadio;
        private TextBox tbAncho;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox tbArea;
        private Button btn;
        private Button btnLimpiar;
        private GroupBox groupBox3;
        private Button btnListado;
        private Button btnRegistro;
        private ListView lvwFiguras;
    }
}
