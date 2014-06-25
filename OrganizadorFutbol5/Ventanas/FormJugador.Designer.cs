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
            this.bt_crear = new System.Windows.Forms.Button();
            this.lblInfracciones = new System.Windows.Forms.Label();
            this.listInfracciones = new System.Windows.Forms.ListBox();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.listNotificaciones = new System.Windows.Forms.ListBox();
            this.listCalificaciones = new System.Windows.Forms.ListBox();
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.btnAgregarCalificacion = new System.Windows.Forms.Button();
            this.tb_Calificacion = new System.Windows.Forms.Label();
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
            this.ll_calificacion.Location = new System.Drawing.Point(12, 155);
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
            // bt_crear
            // 
            this.bt_crear.Location = new System.Drawing.Point(335, 425);
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
            this.lblInfracciones.Location = new System.Drawing.Point(12, 178);
            this.lblInfracciones.Name = "lblInfracciones";
            this.lblInfracciones.Size = new System.Drawing.Size(65, 13);
            this.lblInfracciones.TabIndex = 5;
            this.lblInfracciones.Text = "Infracciones";
            // 
            // listInfracciones
            // 
            this.listInfracciones.FormattingEnabled = true;
            this.listInfracciones.Location = new System.Drawing.Point(15, 194);
            this.listInfracciones.Name = "listInfracciones";
            this.listInfracciones.Size = new System.Drawing.Size(257, 95);
            this.listInfracciones.TabIndex = 6;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Location = new System.Drawing.Point(12, 296);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(74, 13);
            this.lblNotificaciones.TabIndex = 18;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // listNotificaciones
            // 
            this.listNotificaciones.FormattingEnabled = true;
            this.listNotificaciones.Location = new System.Drawing.Point(12, 312);
            this.listNotificaciones.Name = "listNotificaciones";
            this.listNotificaciones.Size = new System.Drawing.Size(398, 95);
            this.listNotificaciones.TabIndex = 17;
            // 
            // listCalificaciones
            // 
            this.listCalificaciones.FormattingEnabled = true;
            this.listCalificaciones.Location = new System.Drawing.Point(15, 46);
            this.listCalificaciones.Name = "listCalificaciones";
            this.listCalificaciones.Size = new System.Drawing.Size(257, 95);
            this.listCalificaciones.TabIndex = 20;
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Location = new System.Drawing.Point(12, 30);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(72, 13);
            this.lblCalificaciones.TabIndex = 19;
            this.lblCalificaciones.Text = "Calificaciones";
            // 
            // btnAgregarCalificacion
            // 
            this.btnAgregarCalificacion.Location = new System.Drawing.Point(295, 46);
            this.btnAgregarCalificacion.Name = "btnAgregarCalificacion";
            this.btnAgregarCalificacion.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarCalificacion.TabIndex = 22;
            this.btnAgregarCalificacion.Text = "Agregar Calificacion";
            this.btnAgregarCalificacion.UseVisualStyleBackColor = true;
            this.btnAgregarCalificacion.Click += new System.EventHandler(this.btnAgregarCalificacion_Click);
            // 
            // tb_Calificacion
            // 
            this.tb_Calificacion.AutoSize = true;
            this.tb_Calificacion.Location = new System.Drawing.Point(93, 155);
            this.tb_Calificacion.Name = "tb_Calificacion";
            this.tb_Calificacion.Size = new System.Drawing.Size(28, 13);
            this.tb_Calificacion.TabIndex = 23;
            this.tb_Calificacion.Text = "###";
            // 
            // FormJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 457);
            this.Controls.Add(this.tb_Calificacion);
            this.Controls.Add(this.btnAgregarCalificacion);
            this.Controls.Add(this.listCalificaciones);
            this.Controls.Add(this.lblCalificaciones);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.listNotificaciones);
            this.Controls.Add(this.listInfracciones);
            this.Controls.Add(this.lblInfracciones);
            this.Controls.Add(this.bt_crear);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.ll_calificacion);
            this.Controls.Add(this.ll_nombre);
            this.Name = "FormJugador";
            this.Text = "FormJugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ll_nombre;
        private System.Windows.Forms.Label ll_calificacion;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button bt_crear;
        private System.Windows.Forms.Label lblInfracciones;
        private System.Windows.Forms.ListBox listInfracciones;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.ListBox listNotificaciones;
        private System.Windows.Forms.ListBox listCalificaciones;
        private System.Windows.Forms.Label lblCalificaciones;
        private System.Windows.Forms.Button btnAgregarCalificacion;
        private System.Windows.Forms.Label tb_Calificacion;
    }
}