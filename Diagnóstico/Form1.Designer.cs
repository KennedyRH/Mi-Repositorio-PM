using System;

namespace Diagnóstico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Respuesta1 = new System.Windows.Forms.TextBox();
            this.Pregunta1 = new System.Windows.Forms.Label();
            this.Pregunta2 = new System.Windows.Forms.Label();
            this.Respuesta3 = new System.Windows.Forms.TextBox();
            this.Pregunta3 = new System.Windows.Forms.Label();
            this.Respuesta2 = new System.Windows.Forms.TextBox();
            this.Pregunta4 = new System.Windows.Forms.Label();
            this.Respuesta4 = new System.Windows.Forms.TextBox();
            this.Pregunta5 = new System.Windows.Forms.Label();
            this.Respuesta5 = new System.Windows.Forms.TextBox();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Respuesta1
            // 
            this.Respuesta1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta1.Location = new System.Drawing.Point(28, 68);
            this.Respuesta1.Name = "Respuesta1";
            this.Respuesta1.Size = new System.Drawing.Size(100, 30);
            this.Respuesta1.TabIndex = 0;
            // 
            // Pregunta1
            // 
            this.Pregunta1.AutoSize = true;
            this.Pregunta1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta1.Location = new System.Drawing.Point(23, 23);
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Size = new System.Drawing.Size(266, 22);
            this.Pregunta1.TabIndex = 1;
            this.Pregunta1.Text = "¿Tienes fiebre en este momento?";
            this.Pregunta1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pregunta2
            // 
            this.Pregunta2.AutoSize = true;
            this.Pregunta2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta2.Location = new System.Drawing.Point(23, 124);
            this.Pregunta2.Name = "Pregunta2";
            this.Pregunta2.Size = new System.Drawing.Size(252, 22);
            this.Pregunta2.TabIndex = 3;
            this.Pregunta2.Text = "¿Experimentas tos persistente?";
            this.Pregunta2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Respuesta3
            // 
            this.Respuesta3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta3.Location = new System.Drawing.Point(28, 286);
            this.Respuesta3.Name = "Respuesta3";
            this.Respuesta3.Size = new System.Drawing.Size(100, 30);
            this.Respuesta3.TabIndex = 2;
            // 
            // Pregunta3
            // 
            this.Pregunta3.AutoSize = true;
            this.Pregunta3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta3.Location = new System.Drawing.Point(23, 237);
            this.Pregunta3.Name = "Pregunta3";
            this.Pregunta3.Size = new System.Drawing.Size(447, 22);
            this.Pregunta3.TabIndex = 5;
            this.Pregunta3.Text = "¿Sientes dificultad para respirar o presión en el pecho?";
            this.Pregunta3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Respuesta2
            // 
            this.Respuesta2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta2.Location = new System.Drawing.Point(28, 179);
            this.Respuesta2.Name = "Respuesta2";
            this.Respuesta2.Size = new System.Drawing.Size(100, 30);
            this.Respuesta2.TabIndex = 4;
            this.Respuesta2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Pregunta4
            // 
            this.Pregunta4.AutoSize = true;
            this.Pregunta4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta4.Location = new System.Drawing.Point(23, 333);
            this.Pregunta4.Name = "Pregunta4";
            this.Pregunta4.Size = new System.Drawing.Size(315, 22);
            this.Pregunta4.TabIndex = 7;
            this.Pregunta4.Text = "¿Estás experimentando fatiga extrema?";
            // 
            // Respuesta4
            // 
            this.Respuesta4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta4.Location = new System.Drawing.Point(28, 369);
            this.Respuesta4.Name = "Respuesta4";
            this.Respuesta4.Size = new System.Drawing.Size(100, 30);
            this.Respuesta4.TabIndex = 6;
            this.Respuesta4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Pregunta5
            // 
            this.Pregunta5.AutoSize = true;
            this.Pregunta5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta5.Location = new System.Drawing.Point(23, 406);
            this.Pregunta5.Name = "Pregunta5";
            this.Pregunta5.Size = new System.Drawing.Size(706, 22);
            this.Pregunta5.TabIndex = 9;
            this.Pregunta5.Text = "¿Has estado en contacto con alguien positivo o viajado a áreas de riesgo reciente" +
    "mente?";
            // 
            // Respuesta5
            // 
            this.Respuesta5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta5.Location = new System.Drawing.Point(28, 450);
            this.Respuesta5.Name = "Respuesta5";
            this.Respuesta5.Size = new System.Drawing.Size(100, 30);
            this.Respuesta5.TabIndex = 8;
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostico.Location = new System.Drawing.Point(725, 23);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(196, 51);
            this.btnDiagnostico.TabIndex = 10;
            this.btnDiagnostico.Text = "Diagnosticar";
            this.btnDiagnostico.UseVisualStyleBackColor = true;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click_1);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(578, 80);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(492, 82);
            this.txtDiagnostico.TabIndex = 11;
            this.txtDiagnostico.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 507);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.Pregunta5);
            this.Controls.Add(this.Respuesta5);
            this.Controls.Add(this.Pregunta4);
            this.Controls.Add(this.Respuesta4);
            this.Controls.Add(this.Pregunta3);
            this.Controls.Add(this.Respuesta2);
            this.Controls.Add(this.Pregunta2);
            this.Controls.Add(this.Respuesta3);
            this.Controls.Add(this.Pregunta1);
            this.Controls.Add(this.Respuesta1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        #endregion
        private void Pregunta_Click(object sender, EventArgs e)
        {
            // No realizar ninguna acción al hacer clic en las preguntas
        }

        private System.Windows.Forms.TextBox Respuesta1;
        private System.Windows.Forms.Label Pregunta1;
        private System.Windows.Forms.Label Pregunta2;
        private System.Windows.Forms.TextBox Respuesta3;
        private System.Windows.Forms.Label Pregunta3;
        private System.Windows.Forms.TextBox Respuesta2;
        private System.Windows.Forms.Label Pregunta4;
        private System.Windows.Forms.TextBox Respuesta4;
        private System.Windows.Forms.Label Pregunta5;
        private System.Windows.Forms.TextBox Respuesta5;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
    }
}

