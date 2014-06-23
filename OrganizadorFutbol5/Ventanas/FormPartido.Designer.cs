namespace OrganizadorFutbol5.Ventanas
{
    partial class FormPartido
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
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_inscriptosStandard = new System.Windows.Forms.ListBox();
            this.lb_inscriptosCondicionales = new System.Windows.Forms.ListBox();
            this.lb_inscriptosSolidarios = new System.Windows.Forms.ListBox();
            this.bt_darDeBajaStandard = new System.Windows.Forms.Button();
            this.bt_reemplazarStandard = new System.Windows.Forms.Button();
            this.bt_darDeBajaSolidario = new System.Windows.Forms.Button();
            this.bt_reemplazarSolidario = new System.Windows.Forms.Button();
            this.bt_darDeBajaCondicional = new System.Windows.Forms.Button();
            this.bt_reemplazarCondicional = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cantidadInscriptos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listNotificaciones = new System.Windows.Forms.ListBox();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(62, 6);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(293, 20);
            this.tb_nombre.TabIndex = 2;
            // 
            // tb_fecha
            // 
            this.tb_fecha.Location = new System.Drawing.Point(62, 32);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(293, 20);
            this.tb_fecha.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_inscriptosStandard);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscriptos Standard";
            // 
            // lb_inscriptosStandard
            // 
            this.lb_inscriptosStandard.FormattingEnabled = true;
            this.lb_inscriptosStandard.Location = new System.Drawing.Point(6, 19);
            this.lb_inscriptosStandard.Name = "lb_inscriptosStandard";
            this.lb_inscriptosStandard.Size = new System.Drawing.Size(157, 160);
            this.lb_inscriptosStandard.TabIndex = 0;
            // 
            // lb_inscriptosCondicionales
            // 
            this.lb_inscriptosCondicionales.FormattingEnabled = true;
            this.lb_inscriptosCondicionales.Location = new System.Drawing.Point(6, 19);
            this.lb_inscriptosCondicionales.Name = "lb_inscriptosCondicionales";
            this.lb_inscriptosCondicionales.Size = new System.Drawing.Size(172, 160);
            this.lb_inscriptosCondicionales.TabIndex = 2;
            // 
            // lb_inscriptosSolidarios
            // 
            this.lb_inscriptosSolidarios.FormattingEnabled = true;
            this.lb_inscriptosSolidarios.Location = new System.Drawing.Point(6, 19);
            this.lb_inscriptosSolidarios.Name = "lb_inscriptosSolidarios";
            this.lb_inscriptosSolidarios.Size = new System.Drawing.Size(168, 160);
            this.lb_inscriptosSolidarios.TabIndex = 1;
            // 
            // bt_darDeBajaStandard
            // 
            this.bt_darDeBajaStandard.Location = new System.Drawing.Point(23, 257);
            this.bt_darDeBajaStandard.Name = "bt_darDeBajaStandard";
            this.bt_darDeBajaStandard.Size = new System.Drawing.Size(75, 23);
            this.bt_darDeBajaStandard.TabIndex = 5;
            this.bt_darDeBajaStandard.Text = "Dar de Baja";
            this.bt_darDeBajaStandard.UseVisualStyleBackColor = true;
            this.bt_darDeBajaStandard.Click += new System.EventHandler(this.bt_darDeBajaStandard_Click);
            // 
            // bt_reemplazarStandard
            // 
            this.bt_reemplazarStandard.Location = new System.Drawing.Point(23, 283);
            this.bt_reemplazarStandard.Name = "bt_reemplazarStandard";
            this.bt_reemplazarStandard.Size = new System.Drawing.Size(75, 23);
            this.bt_reemplazarStandard.TabIndex = 6;
            this.bt_reemplazarStandard.Text = "Reemplazar";
            this.bt_reemplazarStandard.UseVisualStyleBackColor = true;
            this.bt_reemplazarStandard.Click += new System.EventHandler(this.bt_reemplazarStandard_Click);
            // 
            // bt_darDeBajaSolidario
            // 
            this.bt_darDeBajaSolidario.Location = new System.Drawing.Point(198, 257);
            this.bt_darDeBajaSolidario.Name = "bt_darDeBajaSolidario";
            this.bt_darDeBajaSolidario.Size = new System.Drawing.Size(75, 23);
            this.bt_darDeBajaSolidario.TabIndex = 7;
            this.bt_darDeBajaSolidario.Text = "Dar de Baja";
            this.bt_darDeBajaSolidario.UseVisualStyleBackColor = true;
            this.bt_darDeBajaSolidario.Click += new System.EventHandler(this.bt_darDeBajaSolidario_Click);
            // 
            // bt_reemplazarSolidario
            // 
            this.bt_reemplazarSolidario.Location = new System.Drawing.Point(198, 283);
            this.bt_reemplazarSolidario.Name = "bt_reemplazarSolidario";
            this.bt_reemplazarSolidario.Size = new System.Drawing.Size(75, 23);
            this.bt_reemplazarSolidario.TabIndex = 8;
            this.bt_reemplazarSolidario.Text = "Reemplazar";
            this.bt_reemplazarSolidario.UseVisualStyleBackColor = true;
            this.bt_reemplazarSolidario.Click += new System.EventHandler(this.bt_reemplazarSolidario_Click);
            // 
            // bt_darDeBajaCondicional
            // 
            this.bt_darDeBajaCondicional.Location = new System.Drawing.Point(376, 257);
            this.bt_darDeBajaCondicional.Name = "bt_darDeBajaCondicional";
            this.bt_darDeBajaCondicional.Size = new System.Drawing.Size(75, 23);
            this.bt_darDeBajaCondicional.TabIndex = 9;
            this.bt_darDeBajaCondicional.Text = "Dar de Baja";
            this.bt_darDeBajaCondicional.UseVisualStyleBackColor = true;
            this.bt_darDeBajaCondicional.Click += new System.EventHandler(this.bt_darDeBajaCondicional_Click);
            // 
            // bt_reemplazarCondicional
            // 
            this.bt_reemplazarCondicional.Location = new System.Drawing.Point(376, 283);
            this.bt_reemplazarCondicional.Name = "bt_reemplazarCondicional";
            this.bt_reemplazarCondicional.Size = new System.Drawing.Size(75, 23);
            this.bt_reemplazarCondicional.TabIndex = 10;
            this.bt_reemplazarCondicional.Text = "Reemplazar";
            this.bt_reemplazarCondicional.UseVisualStyleBackColor = true;
            this.bt_reemplazarCondicional.Click += new System.EventHandler(this.bt_reemplazarCondicional_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad de Inscriptos";
            // 
            // tb_cantidadInscriptos
            // 
            this.tb_cantidadInscriptos.Location = new System.Drawing.Point(494, 32);
            this.tb_cantidadInscriptos.Name = "tb_cantidadInscriptos";
            this.tb_cantidadInscriptos.Size = new System.Drawing.Size(50, 20);
            this.tb_cantidadInscriptos.TabIndex = 12;
            this.tb_cantidadInscriptos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_inscriptosSolidarios);
            this.groupBox2.Location = new System.Drawing.Point(187, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inscriptos Solidarios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_inscriptosCondicionales);
            this.groupBox3.Location = new System.Drawing.Point(373, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 193);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inscriptos Condicionales";
            // 
            // listNotificaciones
            // 
            this.listNotificaciones.FormattingEnabled = true;
            this.listNotificaciones.Location = new System.Drawing.Point(15, 335);
            this.listNotificaciones.Name = "listNotificaciones";
            this.listNotificaciones.Size = new System.Drawing.Size(536, 95);
            this.listNotificaciones.TabIndex = 15;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Location = new System.Drawing.Point(12, 319);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(74, 13);
            this.lblNotificaciones.TabIndex = 16;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // FormPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 440);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.listNotificaciones);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_cantidadInscriptos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_reemplazarCondicional);
            this.Controls.Add(this.bt_darDeBajaCondicional);
            this.Controls.Add(this.bt_reemplazarSolidario);
            this.Controls.Add(this.bt_darDeBajaSolidario);
            this.Controls.Add(this.bt_reemplazarStandard);
            this.Controls.Add(this.bt_darDeBajaStandard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPartido";
            this.Text = "FormPartido";
            this.Load += new System.EventHandler(this.FormPartido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_inscriptosCondicionales;
        private System.Windows.Forms.ListBox lb_inscriptosSolidarios;
        private System.Windows.Forms.ListBox lb_inscriptosStandard;
        private System.Windows.Forms.Button bt_darDeBajaStandard;
        private System.Windows.Forms.Button bt_reemplazarStandard;
        private System.Windows.Forms.Button bt_darDeBajaSolidario;
        private System.Windows.Forms.Button bt_reemplazarSolidario;
        private System.Windows.Forms.Button bt_darDeBajaCondicional;
        private System.Windows.Forms.Button bt_reemplazarCondicional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cantidadInscriptos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listNotificaciones;
        private System.Windows.Forms.Label lblNotificaciones;
    }
}