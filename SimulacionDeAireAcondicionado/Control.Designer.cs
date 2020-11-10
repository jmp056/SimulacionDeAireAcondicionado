namespace SimulacionDeAireAcondicionado
{
    partial class Control
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempDeseadaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TempAmbienteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.TempActualLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncenderButton = new System.Windows.Forms.Button();
            this.VentanaButton = new System.Windows.Forms.Button();
            this.MensajeGroupBox = new System.Windows.Forms.GroupBox();
            this.ReposoButton = new System.Windows.Forms.Button();
            this.MensajeLabel = new System.Windows.Forms.Label();
            this.PuertaButton = new System.Windows.Forms.Button();
            this.DisminuirTimer = new System.Windows.Forms.Timer(this.components);
            this.AumentarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TempDeseadaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbienteNumericUpDown)).BeginInit();
            this.ControlGroupBox.SuspendLayout();
            this.MensajeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura deseada °C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura del ambiente °C:";
            // 
            // TempDeseadaNumericUpDown
            // 
            this.TempDeseadaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempDeseadaNumericUpDown.Location = new System.Drawing.Point(220, 55);
            this.TempDeseadaNumericUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.TempDeseadaNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TempDeseadaNumericUpDown.Name = "TempDeseadaNumericUpDown";
            this.TempDeseadaNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.TempDeseadaNumericUpDown.TabIndex = 2;
            this.TempDeseadaNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // TempAmbienteNumericUpDown
            // 
            this.TempAmbienteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempAmbienteNumericUpDown.Location = new System.Drawing.Point(220, 15);
            this.TempAmbienteNumericUpDown.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.TempAmbienteNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TempAmbienteNumericUpDown.Name = "TempAmbienteNumericUpDown";
            this.TempAmbienteNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.TempAmbienteNumericUpDown.TabIndex = 3;
            this.TempAmbienteNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TempAmbienteNumericUpDown.ValueChanged += new System.EventHandler(this.TempAmbienteNumericUpDown_ValueChanged);
            this.TempAmbienteNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TempAmbienteNumericUpDown_KeyPress);
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.TempActualLabel);
            this.ControlGroupBox.Controls.Add(this.label5);
            this.ControlGroupBox.Controls.Add(this.label4);
            this.ControlGroupBox.Controls.Add(this.label3);
            this.ControlGroupBox.Controls.Add(this.EncenderButton);
            this.ControlGroupBox.Controls.Add(this.label2);
            this.ControlGroupBox.Controls.Add(this.TempAmbienteNumericUpDown);
            this.ControlGroupBox.Controls.Add(this.label1);
            this.ControlGroupBox.Controls.Add(this.TempDeseadaNumericUpDown);
            this.ControlGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(344, 164);
            this.ControlGroupBox.TabIndex = 4;
            this.ControlGroupBox.TabStop = false;
            // 
            // TempActualLabel
            // 
            this.TempActualLabel.AutoSize = true;
            this.TempActualLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempActualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempActualLabel.Location = new System.Drawing.Point(248, 111);
            this.TempActualLabel.Name = "TempActualLabel";
            this.TempActualLabel.Size = new System.Drawing.Size(54, 31);
            this.TempActualLabel.TabIndex = 7;
            this.TempActualLabel.Text = " 16";
            this.TempActualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = " °";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temperatura\r\n           Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // EncenderButton
            // 
            this.EncenderButton.Image = global::SimulacionDeAireAcondicionado.Properties.Resources.Apagado;
            this.EncenderButton.Location = new System.Drawing.Point(33, 97);
            this.EncenderButton.Name = "EncenderButton";
            this.EncenderButton.Size = new System.Drawing.Size(85, 50);
            this.EncenderButton.TabIndex = 4;
            this.EncenderButton.UseVisualStyleBackColor = true;
            this.EncenderButton.Click += new System.EventHandler(this.EncenderButton_Click);
            // 
            // VentanaButton
            // 
            this.VentanaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentanaButton.Image = global::SimulacionDeAireAcondicionado.Properties.Resources.VentanaCerrradaImg;
            this.VentanaButton.Location = new System.Drawing.Point(211, 185);
            this.VentanaButton.Name = "VentanaButton";
            this.VentanaButton.Size = new System.Drawing.Size(140, 100);
            this.VentanaButton.TabIndex = 7;
            this.VentanaButton.Text = "Abrir ventana";
            this.VentanaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VentanaButton.UseVisualStyleBackColor = true;
            this.VentanaButton.Click += new System.EventHandler(this.VentanaButton_Click);
            // 
            // MensajeGroupBox
            // 
            this.MensajeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MensajeGroupBox.Controls.Add(this.ReposoButton);
            this.MensajeGroupBox.Controls.Add(this.MensajeLabel);
            this.MensajeGroupBox.Location = new System.Drawing.Point(12, 297);
            this.MensajeGroupBox.Name = "MensajeGroupBox";
            this.MensajeGroupBox.Size = new System.Drawing.Size(344, 61);
            this.MensajeGroupBox.TabIndex = 8;
            this.MensajeGroupBox.TabStop = false;
            // 
            // ReposoButton
            // 
            this.ReposoButton.Image = global::SimulacionDeAireAcondicionado.Properties.Resources.Pausa;
            this.ReposoButton.Location = new System.Drawing.Point(313, 30);
            this.ReposoButton.Name = "ReposoButton";
            this.ReposoButton.Size = new System.Drawing.Size(25, 25);
            this.ReposoButton.TabIndex = 2;
            this.ReposoButton.UseVisualStyleBackColor = true;
            this.ReposoButton.Visible = false;
            this.ReposoButton.Click += new System.EventHandler(this.ReposoButton_Click);
            // 
            // MensajeLabel
            // 
            this.MensajeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MensajeLabel.AutoSize = true;
            this.MensajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeLabel.Location = new System.Drawing.Point(6, 13);
            this.MensajeLabel.Name = "MensajeLabel";
            this.MensajeLabel.Size = new System.Drawing.Size(0, 16);
            this.MensajeLabel.TabIndex = 1;
            // 
            // PuertaButton
            // 
            this.PuertaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuertaButton.Image = global::SimulacionDeAireAcondicionado.Properties.Resources.PuertaCerradaImg;
            this.PuertaButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PuertaButton.Location = new System.Drawing.Point(17, 185);
            this.PuertaButton.Name = "PuertaButton";
            this.PuertaButton.Size = new System.Drawing.Size(140, 100);
            this.PuertaButton.TabIndex = 5;
            this.PuertaButton.Text = "Abrir puerta";
            this.PuertaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PuertaButton.UseVisualStyleBackColor = true;
            this.PuertaButton.Click += new System.EventHandler(this.PuertaButton_Click);
            // 
            // DisminuirTimer
            // 
            this.DisminuirTimer.Interval = 3000;
            this.DisminuirTimer.Tick += new System.EventHandler(this.DisminuirTimer_Tick);
            // 
            // AumentarTimer
            // 
            this.AumentarTimer.Interval = 6000;
            this.AumentarTimer.Tick += new System.EventHandler(this.AumentarTimer_Tick);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 370);
            this.Controls.Add(this.MensajeGroupBox);
            this.Controls.Add(this.VentanaButton);
            this.Controls.Add(this.PuertaButton);
            this.Controls.Add(this.ControlGroupBox);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de aire acondicionado";
            ((System.ComponentModel.ISupportInitialize)(this.TempDeseadaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbienteNumericUpDown)).EndInit();
            this.ControlGroupBox.ResumeLayout(false);
            this.ControlGroupBox.PerformLayout();
            this.MensajeGroupBox.ResumeLayout(false);
            this.MensajeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TempDeseadaNumericUpDown;
        private System.Windows.Forms.NumericUpDown TempAmbienteNumericUpDown;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.Button EncenderButton;
        private System.Windows.Forms.Button PuertaButton;
        private System.Windows.Forms.Button VentanaButton;
        private System.Windows.Forms.GroupBox MensajeGroupBox;
        private System.Windows.Forms.Label MensajeLabel;
        private System.Windows.Forms.Button ReposoButton;
        private System.Windows.Forms.Label TempActualLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer DisminuirTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer AumentarTimer;
    }
}

