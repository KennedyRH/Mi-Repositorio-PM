using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LiteDB;

namespace RisXpert_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Today.ToString();
        }

        private void btnNewRisk_Click(object sender, EventArgs e)
        {
            int _ = dtgvRisks.Rows.Add();
            ActualizarDatos(sender, e);
        }

        private void ActualizarDatos(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvRisks.Rows.Count; i++)
            {
                dtgvRisks.Rows[i].Cells[0].Value = txtID.Text;
                dtgvRisks.Rows[i].Cells[1].Value = txtAnalystName.Text;
                dtgvRisks.Rows[i].Cells[2].Value = txtActive.Text;
            }
        }

        private void dgtvValues_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex >= 3 && e.ColumnIndex <= 8 && !string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int numericValue))
                {
                    e.Cancel = true;
                    MessageBox.Show("Inserte valor numérico.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (numericValue < 1 || numericValue > 5)
                {
                    e.Cancel = true;
                    MessageBox.Show("Inserte valor entre 1 y 5.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvValues_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celdaValores = dtgvValues.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex >= 3)
            {
                if (int.TryParse(celdaValores.Value?.ToString(), out int valorNumerico))
                {
                    switch (valorNumerico)
                    {
                        case 1:
                            celdaValores.Style.BackColor = Color.Lime;
                            break;
                        case 2:
                            celdaValores.Style.BackColor = Color.LimeGreen;
                            break;
                        case 3:
                            celdaValores.Style.BackColor = Color.Yellow;
                            break;
                        case 4:
                            celdaValores.Style.BackColor = Color.Orange;
                            break;
                        case 5:
                            celdaValores.Style.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            for (int i = 0; i < dtgvRisks.Rows.Count; i++)
            {
                ActualizarTab2(i);
                ActualizarTab3(i);
                ActualizarTab4(i);
            }
        }

        private void ActualizarTab2(int i)
        {
            lblID.Text = txtID.Text;
            if (dtgvValues.Rows.Count < dtgvRisks.Rows.Count)
            {
                dtgvValues.Rows.Add();
            }
            dtgvValues.Rows[i].Cells[0].Value = dtgvRisks.Rows[i].Cells[2].Value;
            dtgvValues.Rows[i].Cells[1].Value = dtgvRisks.Rows[i].Cells[3].Value;
            dtgvValues.Rows[i].Cells[2].Value = dtgvRisks.Rows[i].Cells[4].Value;
        }

        private void ActualizarTab3(int i)
        {
            int I = Convert.ToInt32(dtgvValues.Rows[i].Cells[3].Value) * Convert.ToInt32(dtgvValues.Rows[i].Cells[4].Value); //F*S
            int D = Convert.ToInt32(dtgvValues.Rows[i].Cells[5].Value) * Convert.ToInt32(dtgvValues.Rows[i].Cells[8].Value); //P*E
            int Pb = Convert.ToInt32(dtgvValues.Rows[i].Cells[6].Value) * Convert.ToInt32(dtgvValues.Rows[i].Cells[7].Value); //A*V
            int C = I + D;
            int ER = Pb * C;
            if (dtgvEvaluation.Rows.Count < dtgvValues.Rows.Count)
            {
                dtgvEvaluation.Rows.Add();
            }
            dtgvEvaluation.Rows[i].Cells[0].Value = dtgvValues.Rows[i].Cells[0].Value;
            dtgvEvaluation.Rows[i].Cells[1].Value = dtgvValues.Rows[i].Cells[1].Value;
            dtgvEvaluation.Rows[i].Cells[2].Value = dtgvValues.Rows[i].Cells[2].Value;
            dtgvEvaluation.Rows[i].Cells[3].Value = C;
            dtgvEvaluation.Rows[i].Cells[4].Value = Pb;
            dtgvEvaluation.Rows[i].Cells[5].Value = ER;
        }

        private void ActualizarTab4(int i)
        {
            if (dtgvClassification.Rows.Count < dtgvEvaluation.Rows.Count)
            {
                dtgvClassification.Rows.Add();
            }
            dtgvClassification.Rows[i].Cells[0].Value = dtgvEvaluation.Rows[i].Cells[0].Value;
            dtgvClassification.Rows[i].Cells[1].Value = dtgvEvaluation.Rows[i].Cells[1].Value;
            dtgvClassification.Rows[i].Cells[2].Value = dtgvEvaluation.Rows[i].Cells[5].Value;

            DataGridViewCell valorER = dtgvClassification.Rows[i].Cells[2];
            DataGridViewRow filaClasificacion = dtgvClassification.Rows[i];

            if (Convert.ToInt32(valorER.Value) >= 2 && Convert.ToInt32(valorER.Value) <= 250)
            {
                filaClasificacion.Cells[3].Value = "Muy Pequeño";
                filaClasificacion.Cells[3].Style.BackColor = Color.Lime;
            }
            else if (Convert.ToInt32(valorER.Value) >= 251 && Convert.ToInt32(valorER.Value) <= 500)
            {
                filaClasificacion.Cells[3].Value = "Pequeño";
                filaClasificacion.Cells[3].Style.BackColor = Color.LimeGreen;
            }
            else if (Convert.ToInt32(valorER.Value) >= 501 && Convert.ToInt32(valorER.Value) <= 750)
            {
                filaClasificacion.Cells[3].Value = "Normal";
                filaClasificacion.Cells[3].Style.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(valorER.Value) >= 751 && Convert.ToInt32(valorER.Value) <= 1000)
            {
                filaClasificacion.Cells[3].Value = "Grande";
                filaClasificacion.Cells[3].Style.BackColor = Color.Orange;
            }
            else if (Convert.ToInt32(valorER.Value) >= 1001 && Convert.ToInt32(valorER.Value) <= 1250)
            {
                filaClasificacion.Cells[3].Value = "Elevado";
                filaClasificacion.Cells[3].Style.BackColor = Color.Red;
            }

            dtgvClassification.Sort(dtgvClassification.Columns[2], ListSortDirection.Descending);
        }

        public class AnalisisRiesgo
        {
            public string Analista { get; set; }
            public string Activo { get; set; }
            public string Riesgo { get; set; }
            public string Dano { get; set; }
            public string Clasificacion { get; set; }
            public int S { get; set; }
            public int F { get; set; }
            public int P { get; set; }
            public int A { get; set; }
            public int V { get; set; }
            public int E { get; set; }
            public int CR { get; set; }
            public int Pb { get; set; }
            public int ER { get; set; }
        }

        private void GuardarDatos(int i)
        {
            using (var db = new LiteDatabase(@"C:\Users\kenne\Documents\Test.db"))
            {
                var col = db.GetCollection<AnalisisRiesgo>(txtActive.Text + "_" + txtID.Text);
                DataGridViewRow filaEvaluacion = dtgvEvaluation.Rows[i];
                DataGridViewRow filaValores = dtgvValues.Rows[i];

                AnalisisRiesgo datosGuardar = new AnalisisRiesgo
                {
                    Analista = txtAnalystName.Text,
                    Activo = txtActive.Text,
                    Riesgo = filaEvaluacion.Cells[1].Value.ToString(),
                    Dano = filaEvaluacion.Cells[2].Value.ToString(),
                    S = Convert.ToInt16(filaValores.Cells[3].Value),
                    F = Convert.ToInt16(filaValores.Cells[4].Value),
                    P = Convert.ToInt16(filaValores.Cells[5].Value),
                    A = Convert.ToInt16(filaValores.Cells[6].Value),
                    V = Convert.ToInt16(filaValores.Cells[7].Value),
                    E = Convert.ToInt16(filaValores.Cells[8].Value),
                    CR = Convert.ToInt32(filaEvaluacion.Cells[3].Value),
                    Pb = Convert.ToInt32(filaEvaluacion.Cells[4].Value),
                    ER = Convert.ToInt32(filaEvaluacion.Cells[5].Value),
                    Clasificacion = Clasificar(i)
                };
                col.Insert(datosGuardar);
            }
        }

        private string Clasificar(int i)
        {
            DataGridViewCell valorER = dtgvClassification.Rows[i].Cells[2];

            if (Convert.ToInt32(valorER.Value) >= 2 && Convert.ToInt32(valorER.Value) <= 250)
            {
                return "Muy Pequeño";
            }
            else if (Convert.ToInt32(valorER.Value) >= 251 && Convert.ToInt32(valorER.Value) <= 500)
            {
                return "Pequeño";
            }
            else if (Convert.ToInt32(valorER.Value) >= 501 && Convert.ToInt32(valorER.Value) <= 750)
            {
                return "Normal";
            }
            else if (Convert.ToInt32(valorER.Value) >= 751 && Convert.ToInt32(valorER.Value) <= 1000)
            {
                return "Grande";
            }
            else if (Convert.ToInt32(valorER.Value) >= 1001 && Convert.ToInt32(valorER.Value) <= 1250)
            {
                return "Elevado";
            }
            else
            {
                return "";
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvRisks.Rows.Count; i++)
            {
                ActualizarTab3(i);
                ActualizarTab4(i);
                GuardarDatos(i);
            }
        }

        private void lblCaseID_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void lblCaseID2_Click(object sender, EventArgs e)
        {

        }
    }
}
