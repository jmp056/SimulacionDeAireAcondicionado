using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionDeAireAcondicionado
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        bool ventana = false, puerta = false, aire = false, reposo = false;
        decimal t = 0, tr = 30;

        bool validar()
        {
            bool paso = true;

            if (ventana == true && puerta == true)
            {
                paso = false;
                MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta y la ventana";
            }
            else if (puerta == true)
            {
                paso = false;
                MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta";
            }
            else if (ventana == true)
            {
                paso = false;
                MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la ventana";
            }

            decimal ta = TempActualumericUpDown.Value, td = TempDeseanaNumericUpDown.Value;
            if (td > ta)
                MensajeLabel.Text = "La temperatura actual es menor a la deseada";

            return paso;
        }

        void Calcular()
        {
            if(reposo == false)
            {
                if(!validar())
                    return;

                decimal ta = TempActualumericUpDown.Value, td = TempDeseanaNumericUpDown.Value;
                t = (ta - td) * 2;
                MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nllevar el cuarto a {1} grados °C", t, td);

                ReposoButton.Visible = true;
            }

            if (reposo == true)
            {
                decimal tra = 0;

                if(puerta == true && ventana == true)
                {
                    tra = tr - (tr * Convert.ToDecimal(0.35));
                    MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nreposo", tra);
                }
                else if (puerta == true)
                {
                    tra = 30 - (tr * Convert.ToDecimal(0.25));
                    MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nreposo", tra);
                }
                else if (ventana == true)
                {
                    tra = 30 - (tr * Convert.ToDecimal(0.10));
                    MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nreposo", tra);
                }
                else
                    MensajeLabel.Text = "El aire aconticionado tardara 30 minutos en \nreposo";
            }
        }



        private void EncenderButton_Click(object sender, EventArgs e)
        {
            if(aire == false)
            {
                aire = true;
                EncenderButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Encendido;
                Calcular();
            }
            else
            {
                aire = false;
                MensajeLabel.Text = string.Empty;
                EncenderButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Apagado;
                ReposoButton.Visible = false;
            }
        }

        private void PuertaButton_Click(object sender, EventArgs e)
        {
            if(puerta == false)
            {
                puerta = true;
                PuertaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.PuertaAbiertaImg;
                PuertaButton.Text = "Cerrar puerta";

                if (reposo == false)
                    ReposoButton.Visible = false;
            }
            else
            {
                puerta = false;
                PuertaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.PuertaCerradaImg;
                PuertaButton.Text = "Abrir puerta";
            }

            if (aire == true)
                Calcular();
        }
        private void VentanaButton_Click(object sender, EventArgs e)
        {
            if (ventana == false)
            {
                ventana = true;
                VentanaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.VentanaAbiertaImg;
                VentanaButton.Text = "Cerrar ventana";

                if (reposo == false)
                    ReposoButton.Visible = false;
            }
            else
            {
                ventana = false;
                VentanaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.VentanaCerrradaImg;
                VentanaButton.Text = "Abrir ventana";
            }

            if (aire == true)
                Calcular();
        }
        private void ReposoButton_Click(object sender, EventArgs e)
        {
            if (reposo == false)
            {
                reposo = true;
                Calcular();
                ReposoButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Play;
            }
            else
            {
                reposo = false;
                Calcular();
                ReposoButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Pausa;
            }
        }

    }
}
