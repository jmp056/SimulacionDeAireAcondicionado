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

        private void PuertaButton_Click(object sender, EventArgs e)
        {
            if (puerta == false)
            {
                puerta = true;
                PuertaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.PuertaAbiertaImg;
                PuertaButton.Text = "Cerrar puerta";
            }
            else
            {
                puerta = false;
                PuertaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.PuertaCerradaImg;
                PuertaButton.Text = "Abrir puerta";
            }

            if(aire == true && reposo == false)
                ProcesosAireEncendido();
            else if(aire == true && reposo == true)
                ProcesosAireEnReposo();


        }



        private void VentanaButton_Click(object sender, EventArgs e)
        {
            if (ventana == false)
            {
                ventana = true;
                VentanaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.VentanaAbiertaImg;
                VentanaButton.Text = "Cerrar ventana";
            }
            else
            {
                ventana = false;
                VentanaButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.VentanaCerrradaImg;
                VentanaButton.Text = "Abrir ventana";
            }

            if (aire == true && reposo == false)
                ProcesosAireEncendido();
            else if (aire == true && reposo == true)
                ProcesosAireEnReposo();
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
            ProcesosAireEncendido();        
        }


        public void ProcesosAireEncendido() // Procesos que reliza el aire si esta encendido
        {
            DisminuirTimer.Interval = 2000;
            if (Convert.ToInt32(TempActualLabel.Text) <= TempDeseadaNumericUpDown.Value)
            {
                DisminuirTimer.Enabled = false;
                Reposo();
            }
            else
            {
                if (ventana == true && puerta == true)
                {
                    MensajeLabel.Text = "¡El aire acondicionado esta encendido!\nEl cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta y la ventana";

                    if (Convert.ToInt32(TempActualLabel.Text) < TempAmbienteNumericUpDown.Value)
                    {
                        DisminuirTimer.Interval = 1000;
                        TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);

                        if (Convert.ToInt32(TempActualLabel.Text) > TempAmbienteNumericUpDown.Value)
                            TempActualLabel.Text = Convert.ToString(TempAmbienteNumericUpDown.Value);
                    }
                }
                else if (puerta == true)
                {
                    MensajeLabel.Text = "¡El aire acondicionado esta encendido!\nEl cuarto no alcanzara la temperatura deseada \ndebe cerrar la puerta";

                    if (Convert.ToInt32(TempActualLabel.Text) < TempAmbienteNumericUpDown.Value)
                        TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
                }
                else if (ventana == true)
                {
                    MensajeLabel.Text = "¡El aire acondicionado esta encendido!\nEl cuarto no alcanzara la temperatura deseada \ndebe cerrar la ventana";

                    if (Convert.ToInt32(TempActualLabel.Text) < TempAmbienteNumericUpDown.Value)
                        TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
                }
                else
                {
                    MensajeLabel.Text = "¡El aire acondicionado esta encendido!";
                    TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) - 1);
                }
            }
        }

        public void ProcesosAireEnReposo() // Procesos que reliza el aire si esta en repso
        {
            AumentarTimer.Interval = 6000;
            if (puerta == false && ventana == false)
            {
                if (Convert.ToInt32(TempActualLabel.Text) >= TempDeseadaNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;
                    Encender();
                }                    
            }
            else if(puerta == true && ventana == true)
            {
                AumentarTimer.Interval = 1000;
                if (Convert.ToInt32(TempActualLabel.Text) >= TempDeseadaNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;
                    Encender();
                }
            }
            else if(puerta == true)
            {
                AumentarTimer.Interval = 2000;
                if (Convert.ToInt32(TempActualLabel.Text) >= TempDeseadaNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;
                    Encender();
                }
                MensajeLabel.Text = "El aire acondicionado se encuentra en reposo\ny la ventana se encuentra abierta,\nel cuarto se calentara mas rapido!";
            }
            else if(ventana == true)
            {
                AumentarTimer.Interval = 2000;
                if (Convert.ToInt32(TempActualLabel.Text) >= TempDeseadaNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;
                    Encender();
                }
                MensajeLabel.Text = "El aire acondicionado se encuentra en reposo\ny la ventana se encuentra abierta\nel cuarto se calentara mas rapido!";
            }
            TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
        }


        private void Proceso_AireApagado()    // Procesos que se ejecutan cuando se apaga el aire 
        {
            

            AumentarTimer.Interval = 3000;

            if (puerta == false && ventana == false)
            {
                if (Convert.ToInt32(TempActualLabel.Text) <= TempAmbienteNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;

                }
            }
            else if (puerta == true && ventana == true)
            {
                AumentarTimer.Interval = 1000;
                if (Convert.ToInt32(TempActualLabel.Text) <= TempAmbienteNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;

                }
            }
            else if (puerta == true)
            {
                AumentarTimer.Interval = 2000;
                if (Convert.ToInt32(TempActualLabel.Text) <= TempAmbienteNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;

                }

            }
            else if (ventana == true)
            {
                AumentarTimer.Interval = 2000;
                if (Convert.ToInt32(TempActualLabel.Text) <= TempAmbienteNumericUpDown.Value + 3)
                {
                    AumentarTimer.Enabled = false;

                }

            }

          
      
           TempActualLabel.Text = Convert.ToString(Convert.ToSingle(TempActualLabel.Text) + 1);
            

        }

        public void AireApagado()    //Funcion para cuando se apague el aire
        {
            AumentarTimer.Enabled = true;
        }


        public void Reposo() // Funcion que trabaja cuando el aire se encuentra en reposo
        {
            MensajeLabel.Text = "¡El aire acondicionado se encuentra en reposo!";
            AumentarTimer.Enabled = true;
        }
        
        private void AumentarTimer_Tick(object sender, EventArgs e)
        {
            if (aire == true)
            {
                ProcesosAireEnReposo();
            }
            else
            {
                Proceso_AireApagado();
            }
            
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
            else
            {
                aire = false;
                EncenderButton.Image = SimulacionDeAireAcondicionado.Properties.Resources.Apagado;
                TempAmbienteNumericUpDown.Enabled = true;
                DisminuirTimer.Enabled = false;
                AumentarTimer.Enabled = false;
                MensajeLabel.Text = string.Empty;
                //TempActualLabel.Text = Convert.ToString(TempAmbienteNumericUpDown.Value);
                AireApagado();

            }
        }


        public void Encender()
        {
            MensajeLabel.Text = "¡El aire acondicionado se encendido!";
            DisminuirTimer.Enabled = true;
        }
    }
}
