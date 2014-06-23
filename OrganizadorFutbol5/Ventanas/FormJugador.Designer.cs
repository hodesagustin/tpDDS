namespace OrganizadorFutbol5.Ventanas
{
    partial class FormJugador
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
            this.ll_nombre = new System.Windows.Forms.Label();
            this.ll_calificacion = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.nd_calificacion = new System.Windows.Forms.NumericUpDown();
            this.bt_crear = new System.Windows.Forms.Button();
            this.lblInfracciones = new System.Windows.Forms.Label();
            this.listInfracciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nd_calificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // ll_nombre
            // 
            this.ll_nombre.AutoSize = true;
            this.ll_nombre.Location = new System.Drawing.Point(12, 9);
            this.ll_nombre.Name = "ll_nombre";
            this.ll_nombre.Size = new System.Drawing.Size(44, 13);
            this.ll_nombre.TabIndex = 0;
            this.ll_nombre.Text = "Nombre";
            // 
            // ll_calificacion
            // 
            this.ll_calificacion.AutoSize = true;
            this.ll_calificacion.Location = new System.Drawing.Point(12, 34);
            this.ll_calificacion.Name = "ll_calificacion";
            this.ll_calificacion.Size = new System.Drawing.Size(61, 13);
            this.ll_calificacion.TabIndex = 1;
            this.ll_calificacion.Text = "Calificación";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(96, 6);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(176, 20);
            this.tb_nombre.TabIndex = 2;
            // 
            // nd_calificacion
            // 
            this.nd_calificacion.DecimalPlaces = 1;
            this.nd_calificacion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nd_calificacion.Location = new System.Drawing.Point(96, 32);
            this.nd_calificacion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nd_calificacion.Name = "nd_calificacion";
            this.nd_calificacion.Size = new System.Drawing.Size(176, 20);
            this.nd_calificacion.TabIndex = 4;
            // 
            // bt_crear
            // 
            this.bt_crear.Location = new System.Drawing.Point(197, 217);
            this.bt_crear.Name = "bt_crear";
            this.bt_crear.Size = new System.Drawing.Size(75, 23);
            this.bt_crear.TabIndex = 4;
            this.bt_crear.Text = "Crear";
            this.bt_crear.UseVisualStyleBackColor = true;
            this.bt_crear.Click += new System.EventHandler(this.bt_crear_Click);
            // 
            // lblInfracciones
            // 
            this.lblInfracciones.AutoSize = true;
            this.lblInfracciones.Location = new System.Drawing.Point(12, 66);
            this.lblInfracciones.Name = "lblInfracciones";
            this.lblInfracciones.Size = new System.Drawing.Size(65, 13);
            this.lblInfracciones.TabIndex = 5;
            this.lblInfracciones.Text = "Infracciones";
            // 
            // listInfracciones
            // 
            this.listInfracciones.FormattingEnabled = true;
            this.listInfracciones.Location = new System.Drawing.Point(15, 82);
            this.listInfracciones.Name = "listInfracciones";
            this.listInfracciones.Size = new System.Drawing.Size(257, 95);
            this.listInfracciones.TabIndex = 6;
            // 
            // FormJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.listInfracciones);
            this.Controls.Add(this.lblInfracciones);
            this.Controls.Add(this.bt_crear);
            this.Controls.Add(this.nd_calificacion);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.ll_calificacion);
            this.Controls.Add(this.ll_nombre);
            this.Name = "FormJugador";
            this.Text = "FormJugador";
            ((System.ComponentModel.ISupportInitialize)(this.nd_calificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ll_nombre;
        private System.Windows.Forms.Label ll_calificacion;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.NumericUpDown nd_calificacion;
        private System.Windows.Forms.Button bt_crear;
        private System.Windows.Forms.Label lblInfracciones;
        private System.Windows.Forms.ListBox listInfracciones;
    }
}