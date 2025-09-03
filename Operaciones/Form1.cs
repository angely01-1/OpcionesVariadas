using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        private Opciones Op;
        private Dictionary<string, Panel> paneles;
        public Form1()
        {
            InitializeComponent();
            BarraTareas();
            Op = new Opciones();
        }
        #region variables
        private double opcion1 = 0;
        private double opcion2 = 0;
        private double opcion3 = 0;
        private double opcion4 = 0;
        private double opcion5 = 0;
        private double opcion6 = 0;
        private string Resultado = "";
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPanel(panel1);
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            string opcion = Opciones.SelectedItem?.ToString();

            if (paneles.ContainsKey(opcion))
            {
                MostrarPanel(paneles[opcion
                    ]);
            }
            else
            {
                MessageBox.Show("Seleccione una opción válida.");
            }
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Metodos Necesarios
        private void BarraTareas()
        {
            paneles = new Dictionary<string, Panel>()
            {
                { "Multiplicar", PanelMultiplicar },
                { "Convertidor Temperatura", panelTemperatura },
                { "Calcular Distancias", panelCalcularDistancia },
                { "Promedio", panelPromedios },
                { "Puntaje Final", panelRespuestas },
                { "Puntaje Partido", panelPartidos },
                { "Planilla Pago", panelPlaPa },
                { "Area De Un Triangulo", panelAreaTri },
                { "Total MicroDiscos Backup", panelMicroDisc },
                { "Distancia Entre (A y B)", panelPlanoCart },
                { "Inscripcion SMO", panelSMO },
                { "Diferencias De Edades", panelHermano },
                { "Incentivos", panelIncentivos },
                { "Numero Mayor", panelNumMay },
                { "Tipo De Triangulo", panelTipoTriangulo },
                { "Equivalente Romano", panelNumRoman },
                { "Bonificacion", panelMontoVentas },
                 { "Angely", panelMontoVentas },
            };
            Opciones.Items.Clear();
            foreach (var opcion in paneles.Keys)
            {
                Opciones.Items.Add(opcion);
            }
            Opciones.SelectedIndex = 0;
        }
        private void MostrarPanel(Panel panel)
        {
            panel1.Visible = false;
            PanelMultiplicar.Visible = false;
            panelTemperatura.Visible = false;
            panelCalcularDistancia.Visible = false;
            panelPromedios.Visible = false;
            panelRespuestas.Visible = false;
            panelPartidos.Visible = false;
            panelPlaPa.Visible = false;
            panelAreaTri.Visible = false;
            panelMicroDisc.Visible = false;
            panelPlanoCart.Visible = false;
            panelHermano.Visible = false;
            panelSMO.Visible = false;
            panelIncentivos.Visible = false;
            panelNumMay.Visible = false;
            panelTipoTriangulo.Visible = false;
            panelNumRoman.Visible = false;
            panelMontoVentas.Visible = false;
            panel.Visible = true;
        }
        private void LimpiarControles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                    txt.Clear();
                if (c.HasChildren)
                    LimpiarControles(c);
            }
            opcion1 = opcion2 = opcion3 = opcion4 = opcion5 = opcion6 = 0;
            Resultado = "";
        }
        #endregion

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Opcion1Mult.Text, out int v1) &&
                    int.TryParse(Opcion2Mult.Text, out int v2))
                {
                    opcion1 = v1;
                    opcion2 = v2;
                    Resultado = Op.Multiplicar(opcion1, opcion2).ToString();
                    ResultadoMult.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarMult_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel pnl && pnl.Visible)
                {
                    LimpiarControles(pnl);
                    break;
                }
            }
        }
        private void RegresarMult_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel pnl && pnl.Visible)
                {
                    LimpiarControles(pnl);
                    break;
                }
            }
            MostrarPanel(panel1);
        }

        private void FaC_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textTemperatura.Text, out int v1))
                {
                    opcion1 = v1;
                    Resultado = Op.TemperaturaFarenheits(opcion1, opcion2).ToString();
                    textResultadoTemperatura.Text = Resultado;
                }
                else MessageBox.Show("Ingrese una temperatura válida.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CaF_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textTemperatura.Text, out int v1))
                {
                    opcion1 = v1;
                    Resultado = Op.TemperaturaCelcius(opcion1, opcion2).ToString();
                    textResultadoTemperatura.Text = Resultado;
                }
                else MessageBox.Show("Ingrese una temperatura válida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcularDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(VelocidadD.Text, out int v1) &&
                    int.TryParse(TiempoD.Text, out int v2))
                {
                    opcion1 = v1;
                    opcion2 = v2;
                    Resultado = Op.CalcularDistancia(opcion1, opcion2).ToString();
                    ResultadoDistancia.Text = Resultado;
                }
                else MessageBox.Show("Ingrese valores válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Nota1Pro.Text, out int v1) &&
                    int.TryParse(Nota2Pro.Text, out int v2) &&
                    int.TryParse(Nota3Pro.Text, out int v3))
                {
                    opcion1 = v1; opcion2 = v2; opcion3 = v3;
                    Resultado = Op.Promedio(opcion1, opcion2, opcion3).ToString();
                    ResultadoPro.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textRes1.Text, out int v1) &&
                    int.TryParse(textRes2.Text, out int v2) &&
                    int.TryParse(textRes3.Text, out int v3))
                {
                    opcion1 = v1; opcion2 = v2; opcion3 = v3;
                    Resultado = Op.respuestas(opcion1, opcion2, opcion3).ToString();
                    ProRes.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textGanados.Text, out int v1) &&
                    int.TryParse(textEmpatados.Text, out int v2) &&
                    int.TryParse(textPerdidos.Text, out int v3))
                {
                    opcion1 = v1; opcion2 = v2; opcion3 = v3;
                    Resultado = Op.Partidos(opcion1, opcion2, opcion3).ToString();
                    textPartidos.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularPlaPa_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textHorala.Text, out int v1) &&
                    int.TryParse(textTarifaHora.Text, out int v2))
                {
                    opcion1 = v1; opcion2 = v2;
                    Resultado = Op.Planillapa(opcion1, opcion2).ToString();
                    textPlanilaPa.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularAreaTri_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textLongLaA.Text, out int v1) &&
                    int.TryParse(textLongLaB.Text, out int v2) &&
                    int.TryParse(textLongLaC.Text, out int v3))
                {
                    opcion1 = v1; opcion2 = v2; opcion3 = v3;
                    Resultado = Op.Partidos(opcion1, opcion2, opcion3).ToString();
                    textAreaTri.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularMircroDisc_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textDiscoDuroGB.Text, out int v1))
                {
                    opcion1 = v1;
                    Resultado = Op.microdiscos(opcion1).ToString();
                    RestMicroDisc.Text = Resultado;
                }
                else MessageBox.Show("Ingrese un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularDist_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textAbcA.Text, out int v1) &&
                    int.TryParse(textAbcB.Text, out int v2) &&
                    int.TryParse(textOrdA.Text, out int v3) &&
                    int.TryParse(textOrdB.Text, out int v4))
                {
                    opcion1 = v1; opcion2 = v2; opcion3 = v3; opcion4 = v4;
                    Resultado = Op.PlanoCart(opcion1, opcion2, opcion3, opcion4).ToString();
                    textDistCalc.Text = Resultado;
                }
                else MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularSMO_Click(object sender, EventArgs e)
        {
            try
            {
                opcion1 = Convert.ToInt32(textAñoNa.Text); 
                opcion2 = Convert.ToInt32(textFecActual.Text); 
                Resultado = Op.FechSNO(opcion1, opcion2);
                MensaggeSMO.Text = Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcMayorHer_Click(object sender, EventArgs e)
        {
            try
            {
                opcion1 = Convert.ToInt32(textPriHermano.Text); 
                opcion2 = Convert.ToInt32(textSegHermano.Text); 
                Resultado = Op.CalcularEdad(opcion1, opcion2);
                textMayHermano.Text = Resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularIncentivos_Click(object sender, EventArgs e)
        {
            try
            {
                opcion1 = Convert.ToInt32(textProLunes.Text); 
                opcion2 = Convert.ToInt32(textProMartes.Text); 
                opcion3 = Convert.ToInt32(textProMiercoles.Text);
                opcion4 = Convert.ToInt32(textProJueves.Text); 
                opcion5 = Convert.ToInt32(textProViernes.Text); 
                opcion6 = Convert.ToInt32(textProSabado.Text);
                Resultado = Op.Incentivos(opcion1, opcion2, opcion3, opcion4, opcion5, opcion6);
                textIncentivos.Text = Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcNumMay_Click(object sender, EventArgs e)
        {
            try
            {
                opcion1 = Convert.ToInt32(textNumUno.Text);
                opcion2 = Convert.ToInt32(textNumDos.Text);
                opcion3 = Convert.ToInt32(textNumTres.Text);
                Resultado = Op.NumeroMayor(opcion1, opcion2, opcion3);
                textMayNum.Text = Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcRomanNum_Click(object sender, EventArgs e)
        {
            try
            {
                opcion1 = Convert.ToInt32(textNum.Text); 
                Resultado = Op.NumRomano(((int)opcion1)).ToString(); 
                textRomanNum.Text = Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcBonificacion_Click(object sender, EventArgs e)
        {
            try
            {
                opcion1 = Convert.ToInt32(textMontVent.Text);
                Resultado = Op.Bonificacion(((int)opcion1)).ToString();
                textBonificacion.Text = Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularTri_Click(object sender, EventArgs e)
        {

            try
            {
                opcion1 = Convert.ToInt32(textPriLado.Text);
                opcion2 = Convert.ToInt32(textSegLado.Text);
                opcion3 = Convert.ToInt32(textTerLado.Text);
                Resultado = Op.TipoTriangulo(opcion1, opcion2, opcion3);
                textResTri.Text = Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
