using System;
using System.Windows.Forms;

namespace Diagnóstico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool EsRespuestaValida(string respuesta)
        {
            return respuesta == "" || respuesta == "sí" || respuesta == "no";
        }

        private void btnDiagnostico_Click_1(object sender, EventArgs e)
        {
            // Obtener respuestas del usuario
            string respuesta1 = Respuesta1.Text.Trim().ToLower();
            string respuesta2 = Respuesta2.Text.Trim().ToLower();
            string respuesta3 = Respuesta3.Text.Trim().ToLower();
            string respuesta4 = Respuesta4.Text.Trim().ToLower();
            string respuesta5 = Respuesta5.Text.Trim().ToLower();

            // Validar respuestas
            if (EsRespuestaValida(respuesta1) && EsRespuestaValida(respuesta2) &&
                EsRespuestaValida(respuesta3) && EsRespuestaValida(respuesta4) &&
                EsRespuestaValida(respuesta5))
            {
                // Evaluar respuestas y proporcionar diagnóstico preliminar
                string diagnostico = "";

                if (respuesta1 == "sí" || respuesta2 == "sí" || respuesta3 == "sí" || respuesta4 == "sí" || respuesta5 == "sí")
                {
                    diagnostico = "Podrías tener síntomas de COVID-19. Considera hacer una prueba y consultar a un médico.";
                }
                else
                {
                    diagnostico = "Tus síntomas son leves. Sigue las medidas de prevención y monitorea cualquier cambio.";
                }

                txtDiagnostico.Text = diagnostico;
            }
            else
            {
                txtDiagnostico.Text = "Ingresa respuestas válidas: 'sí' o 'no'.";
            }
        }

    }
}
