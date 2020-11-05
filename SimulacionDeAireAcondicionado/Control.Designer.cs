﻿namespace SimulacionDeAireAcondicionado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempDeseanaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TempActualumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.EncenderButton = new System.Windows.Forms.Button();
            this.VentanaButton = new System.Windows.Forms.Button();
            this.MensajeGroupBox = new System.Windows.Forms.GroupBox();
            this.ReposoButton = new System.Windows.Forms.Button();
            this.MensajeLabel = new System.Windows.Forms.Label();
            this.PuertaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TempDeseanaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempActualumericUpDown)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura actual °C:";
            // 
            // TempDeseanaNumericUpDown
            // 
            this.TempDeseanaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempDeseanaNumericUpDown.Location = new System.Drawing.Point(220, 55);
            this.TempDeseanaNumericUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.TempDeseanaNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TempDeseanaNumericUpDown.Name = "TempDeseanaNumericUpDown";
            this.TempDeseanaNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.TempDeseanaNumericUpDown.TabIndex = 2;
            this.TempDeseanaNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // TempActualumericUpDown
            // 
            this.TempActualumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempActualumericUpDown.Location = new System.Drawing.Point(220, 15);
            this.TempActualumericUpDown.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.TempActualumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TempActualumericUpDown.Name = "TempActualumericUpDown";
            this.TempActualumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.TempActualumericUpDown.TabIndex = 3;
            this.TempActualumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.EncenderButton);
            this.ControlGroupBox.Controls.Add(this.label2);
            this.ControlGroupBox.Controls.Add(this.TempActualumericUpDown);
            this.ControlGroupBox.Controls.Add(this.label1);
            this.ControlGroupBox.Controls.Add(this.TempDeseanaNumericUpDown);
            this.ControlGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(344, 164);
            this.ControlGroupBox.TabIndex = 4;
            this.ControlGroupBox.TabStop = false;
            // 
            // EncenderButton
            // 
            this.EncenderButton.Image = global::SimulacionDeAireAcondicionado.Properties.Resources.Apagado;
            this.EncenderButton.Location = new System.Drawing.Point(131, 96);
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
            ((System.ComponentModel.ISupportInitialize)(this.TempDeseanaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempActualumericUpDown)).EndInit();
            this.ControlGroupBox.ResumeLayout(false);
            this.ControlGroupBox.PerformLayout();
            this.MensajeGroupBox.ResumeLayout(false);
            this.MensajeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TempDeseanaNumericUpDown;
        private System.Windows.Forms.NumericUpDown TempActualumericUpDown;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.Button EncenderButton;
        private System.Windows.Forms.Button PuertaButton;
        private System.Windows.Forms.Button VentanaButton;
        private System.Windows.Forms.GroupBox MensajeGroupBox;
        private System.Windows.Forms.Label MensajeLabel;
        private System.Windows.Forms.Button ReposoButton;
    }
}

