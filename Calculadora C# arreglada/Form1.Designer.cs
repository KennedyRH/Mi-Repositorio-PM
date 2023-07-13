
namespace Calculadora
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
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnQuitar = new Button();
            btnBorrarTodo = new Button();
            btnBorrar = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnCuadrado = new Button();
            btnRaizCuadrada = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnRestar = new Button();
            btnSumar = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(17, 15);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(389, 54);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.Red;
            btnUno.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnUno.Location = new Point(17, 299);
            btnUno.Margin = new Padding(3, 4, 3, 4);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(57, 54);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.Red;
            btnDos.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnDos.Location = new Point(90, 299);
            btnDos.Margin = new Padding(3, 4, 3, 4);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(57, 54);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.Red;
            btnTres.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.Location = new Point(163, 299);
            btnTres.Margin = new Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(57, 54);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.Red;
            btnSeis.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeis.Location = new Point(163, 228);
            btnSeis.Margin = new Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(57, 54);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.Red;
            btnCinco.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnCinco.Location = new Point(90, 228);
            btnCinco.Margin = new Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(57, 54);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = Color.Red;
            btnCuatro.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuatro.Location = new Point(17, 228);
            btnCuatro.Margin = new Padding(3, 4, 3, 4);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(57, 54);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.Red;
            btnQuitar.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuitar.Location = new Point(163, 86);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(57, 54);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = Color.Red;
            btnBorrarTodo.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarTodo.Location = new Point(90, 86);
            btnBorrarTodo.Margin = new Padding(3, 4, 3, 4);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(57, 54);
            btnBorrarTodo.TabIndex = 11;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(17, 86);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(57, 54);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.Red;
            btnNueve.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnNueve.Location = new Point(163, 158);
            btnNueve.Margin = new Padding(3, 4, 3, 4);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(57, 54);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.Red;
            btnOcho.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnOcho.Location = new Point(90, 158);
            btnOcho.Margin = new Padding(3, 4, 3, 4);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(57, 54);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.Red;
            btnSiete.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiete.Location = new Point(17, 158);
            btnSiete.Margin = new Padding(3, 4, 3, 4);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(57, 54);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += agregarNumero;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = Color.Red;
            btnCuadrado.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuadrado.Location = new Point(349, 86);
            btnCuadrado.Margin = new Padding(3, 4, 3, 4);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(57, 54);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = false;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.BackColor = Color.Red;
            btnRaizCuadrada.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaizCuadrada.Location = new Point(276, 86);
            btnRaizCuadrada.Margin = new Padding(3, 4, 3, 4);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(57, 54);
            btnRaizCuadrada.TabIndex = 13;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = false;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.Red;
            btnMultiplicar.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(349, 158);
            btnMultiplicar.Margin = new Padding(3, 4, 3, 4);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(57, 54);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.Red;
            btnDividir.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.Location = new Point(276, 158);
            btnDividir.Margin = new Padding(3, 4, 3, 4);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(57, 54);
            btnDividir.TabIndex = 15;
            btnDividir.Tag = "∕";
            btnDividir.Text = "∕";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.Red;
            btnRestar.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestar.Location = new Point(349, 228);
            btnRestar.Margin = new Padding(3, 4, 3, 4);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(57, 54);
            btnRestar.TabIndex = 18;
            btnRestar.Tag = "−";
            btnRestar.Text = "−";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.Red;
            btnSumar.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnSumar.Location = new Point(276, 228);
            btnSumar.Margin = new Padding(3, 4, 3, 4);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(57, 54);
            btnSumar.TabIndex = 17;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.Red;
            btnResultado.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnResultado.Location = new Point(276, 299);
            btnResultado.Margin = new Padding(3, 4, 3, 4);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(132, 54);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = Color.Red;
            btnPunto.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnPunto.Location = new Point(163, 372);
            btnPunto.Margin = new Padding(3, 4, 3, 4);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(57, 54);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.Red;
            btnCero.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnCero.Location = new Point(90, 372);
            btnCero.Margin = new Padding(3, 4, 3, 4);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(57, 54);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.BackColor = Color.Red;
            btnSigno.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSigno.Location = new Point(17, 372);
            btnSigno.Margin = new Padding(3, 4, 3, 4);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(57, 54);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(425, 438);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora by GFCSoft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSigno;
    }
}
