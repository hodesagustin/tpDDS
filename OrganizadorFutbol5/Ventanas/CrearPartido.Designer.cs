namespace OrganizadorFutbol5.Ventanas
{
    partial class CrearPartido
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
            this.gb_datosPartido = new System.Windows.Forms.GroupBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.tb_nombrePartido = new System.Windows.Forms.TextBox();
            this.ll_fecha = new System.Windows.Forms.Label();
            this.ll_nombrePartido = new System.Windows.Forms.Label();
            this.bt_aplicar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.gb_datosPartido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_datosPartido
            // 
            this.gb_datosPartido.Controls.Add(this.dateFecha);
            this.gb_datosPartido.Controls.Add(this.tb_nombrePartido);
            this.gb_datosPartido.Controls.Add(this.ll_fecha);
            this.gb_datosPartido.Controls.Add(this.ll_nombrePartido);
            this.gb_datosPartido.Location = new System.Drawing.Point(12, 12);
            this.gb_datosPartido.Name = "gb_datosPartido";
            this.gb_datosPartido.Size = new System.Drawing.Size(457, 93);
            this.gb_datosPartido.TabIndex = 0;
            this.gb_datosPartido.TabStop = false;
            this.gb_datosPartido.Text = "Datos del Partido";
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(107, 64);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(344, 20);
            this.dateFecha.TabIndex = 3;
            // 
            // tb_nombrePartido
            // 
            this.tb_nombrePartido.Location = new System.Drawing.Point(107, 38);
            this.tb_nombrePartido.Name = "tb_nombrePartido";
            this.tb_nombrePartido.Size = new System.Drawing.Size(344, 20);
            this.tb_nombrePartido.TabIndex = 2;
            // 
            // ll_fecha
            // 
            this.ll_fecha.AutoSize = true;
            this.ll_fecha.Location = new System.Drawing.Point(21, 64);
            this.ll_fecha.Name = "ll_fecha";
            this.ll_fecha.Size = new System.Drawing.Size(37, 13);
            this.ll_fecha.TabIndex = 1;
            this.ll_fecha.Text = "Fecha";
            // 
            // ll_nombrePartido
            // 
            this.ll_nombrePartido.AutoSize = true;
            this.ll_nombrePartido.Location = new System.Drawing.Point(21, 41);
            this.ll_nombrePartido.Name = "ll_nombrePartido";
            this.ll_nombrePartido.Size = new System.Drawing.Size(80, 13);
            this.ll_nombrePartido.TabIndex = 0;
            this.ll_nombrePartido.Text = "Nombre Partido";
            // 
            // bt_aplicar
            // 
            this.bt_aplicar.Location = new System.Drawing.Point(12, 111);
            this.bt_aplicar.Name = "bt_aplicar";
            this.bt_aplicar.Size = new System.Drawing.Size(75, 23);
            this.bt_aplicar.TabIndex = 1;
            this.bt_aplicar.Text = "Aplicar";
            this.bt_aplicar.UseVisualStyleBackColor = true;
            this.bt_aplicar.Click += new System.EventHandler(this.bt_aplicar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(394, 111);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // CrearPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 146);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aplicar);
            this.Controls.Add(this.gb_datosPartido);
            this.Name = "CrearPartido";
            this.Text = "CrearPartido";
            this.gb_datosPartido.ResumeLayout(false);
            this.gb_datosPartido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datosPartido;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.TextBox tb_nombrePartido;
        private System.Windows.Forms.Label ll_fecha;
        private System.Windows.Forms.Label ll_nombrePartido;
        private System.Windows.Forms.Button bt_aplicar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}