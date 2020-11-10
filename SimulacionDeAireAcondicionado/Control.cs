using System;
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

        //bool validar()
        //{
        //    bool paso = true;

        //    if (ventana == true && puerta == true)
        //    {
        //        paso = false;
        //        MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta y la ventana";
        //    }
        //    else if (puerta == true)
        //    {
        //        paso = false;
        //        MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta";
        //    }
        //    else if (ventana == true)
        //    {
        //        paso = false;
        //        MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la ventana";
        //    }

        //    decimal ta = TempAmbienteNumericUpDown.Value, td = TempDeseadaNumericUpDown.Value;
        //    if (td > ta)
        //        MensajeLabel.Text = "La temperatura actual es menor a la deseada";

        //    return paso;
        //}

        void Calcular()
        {
            //if(reposo == false)
            //{

            //    decimal ta = TempAmbienteNumericUpDown.Value, td = TempDeseadaNumericUpDown.Value;
            //    t = (ta - td) * 2;
            //    MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nllevar el cuarto a {1} grados °C", t, td);

            //    ReposoButton.Visible = true;
            //}

            //if (reposo == true)
            //{
            //    decimal tra = 0;

            //    if(puerta == true && ventana == true)
            //    {
            //        tra = tr - (tr * Convert.ToDecimal(0.35));
            //        MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nreposo", tra);
            //    }
            //    else if (puerta == true)
            //    {
            //        tra = 30 - (tr * Convert.ToDecimal(0.25));
            //        MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nreposo", tra);
            //    }
            //    else if (ventana == true)
            //    {
            //        tra = 30 - (tr * Convert.ToDecimal(0.10));
            //        MensajeLabel.Text = string.Format("El aire aconticionado tardara {0} minutos en \nreposo", tra);
            //    }
            //    else
            //        MensajeLabel.Text = "El aire aconticionado tardara 30 minutos en \nreposo";
            //}
        }



        



        private void PuertaButton_Click(object sender, EventArgs e)
        {
            if (puerta == false)
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

            //if (aire == true)
            //    Calcular();
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

            //if (aire == true)
            //    Calcular();
        }
        private void ReposoButton_Click(object sender, EventArgs e)
        {
            //if (reposo == false)
            //{
            //    reposo = true;
            //    Calcular();
            //    ReposoButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Play;
            //}
            //else
            //{
            //    reposo = false;
            //    Calcular();
            //    ReposoButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Pausa;
            //}
        }




        //----------------------------------------------------------------------------------------------------
        // -------
        //--------------------------------------------------------------------------------------------








        private void TempAmbienteNumericUpDown_ValueChanged(object sender, EventArgs e) 
        { //Este evento actualiza la temperatura del label de la temperatura actual cuando se cambia por las flechas el valor del NumericUpDown de la temperatura del ambiente
            TempActualLabel.Text = Convert.ToString(TempAmbienteNumericUpDown.Value);
        }
        
        private void TempAmbienteNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {//Este evento actualiza el valor del label de temperatura actual al precionar una tecla en el numericUodown de la temperatura del ambiente
            TempActualLabel.Text = Convert.ToString(TempAmbienteNumericUpDown.Value);
        }
        
        private void DisminuirTimer_Tick(object sender, EventArgs e) // Timer encargado de disminuir la temperatura
        {
            if (Convert.ToInt32(TempActualLabel.Text) <= TempDeseadaNumericUpDown.Value)
            {
                DisminuirTimer.Enabled = false;
                Reposo();
            }
            else
                if (ventana == true && puerta == true)
                {
                    MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta y la ventana";
                    
                if(Convert.ToInt32(TempActualLabel.Text) < TempAmbienteNumericUpDown.Value) { 
                        TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 2);

                        if (Convert.ToInt32(TempActualLabel.Text) > TempAmbienteNumericUpDown.Value)
                            TempActualLabel.Text = Convert.ToString(TempAmbienteNumericUpDown.Value);
                    }
                }

                else if (puerta == true)
                {
                    MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta";
                    
                    if (Convert.ToInt32(TempActualLabel.Text) < TempAmbienteNumericUpDown.Value)
                        TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
                }
                else if (ventana == true)
                {
                    MensajeLabel.Text = "El cuarto no alcanzara la temperatura deseada \ndebe cerrar la ventana";
                    
                    if (Convert.ToInt32(TempActualLabel.Text) < TempAmbienteNumericUpDown.Value)
                        TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
                }

                else
                {
                    MensajeLabel.Text = "¡El aire acondicionado se encendido!";
                    TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) - 1);
                }
                    
        }

        public void validar()
        {
            //if(ventana == true)

        }

        public void Reposo() // Funcion que trabaja cuando el aire se encuentra en reposo
        {
            MensajeLabel.Text = "¡El aire acondicionado se encuentra en reposo!";
            AumentarTimer.Enabled = true;
        }
        
        private void AumentarTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TempActualLabel.Text) >= TempDeseadaNumericUpDown.Value + 3)
            {
                AumentarTimer.Enabled = false;
                Encender();
            }
            else
                TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
        }
        
        private void EncenderButton_Click(object sender, EventArgs e)
        { //Clic al boton encender
            if(aire == false)
            {

                aire = true;
                EncenderButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Encendido;
                TempAmbienteNumericUpDown.Enabled = false;
                Encender();
            }


            //if(aire == false)
            //{
            //    DisminuirTimer.Interval = 3000;
            //    DisminuirTimer.Enabled = true;

            //    aire = true;
            //    
            //    

            //    Calcular();
            //}
            //else
            //{
            //    aire = false;
            //    TempAmbienteNumericUpDown.Enabled = true;
            //    MensajeLabel.Text = string.Empty;
            //    EncenderButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Apagado;
            //    ReposoButton.Visible = false;
            //}
        }


        public void Encender()
        {
            MensajeLabel.Text = "¡El aire acondicionado se encendido!";
            DisminuirTimer.Enabled = true;
        }
    }
}
