namespace OrganizadorFutbol5.Ventanas
{
    partial class HomeAdministrador
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
            this.gb_partidosCreados = new System.Windows.Forms.GroupBox();
            this.lb_Partidos = new System.Windows.Forms.ListBox();
            this.bt_crearPartido = new System.Windows.Forms.Button();
            this.bt_abrirPartido = new System.Windows.Forms.Button();
            this.gb_jugadoresCreados = new System.Windows.Forms.GroupBox();
            this.lb_Jugadores = new System.Windows.Forms.ListBox();
            this.bt_crearJugador = new System.Windows.Forms.Button();
            this.bt_abrirJugador = new System.Windows.Forms.Button();
            this.gb_jugadoresCondicionalesCreados = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_JugadoresCondicionales = new System.Windows.Forms.ListBox();
            this.bt_inscribirStandard = new System.Windows.Forms.Button();
            this.bt_inscribirSolidario = new System.Windows.Forms.Button();
            this.bt_inscribirCondicional = new System.Windows.Forms.Button();
            this.ll_titulo = new System.Windows.Forms.Label();
            this.gb_AdministradoresCreados = new System.Windows.Forms.GroupBox();
            this.lb_Administradores = new System.Windows.Forms.ListBox();
            this.btnCrear_ProponerJugadores = new System.Windows.Forms.Button();
            this.gb_partidosCreados.SuspendLayout();
            this.gb_jugadoresCreados.SuspendLayout();
            this.gb_jugadoresCondicionalesCreados.SuspendLayout();
            this.gb_AdministradoresCreados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_partidosCreados
            // 
            this.gb_partidosCreados.Controls.Add(this.lb_Partidos);
            this.gb_partidosCreados.Controls.Add(this.bt_crearPartido);
            this.gb_partidosCreados.Controls.Add(this.bt_abrirPartido);
            this.gb_partidosCreados.Location = new System.Drawing.Point(272, 54);
            this.gb_partidosCreados.Name = "gb_partidosCreados";
            this.gb_partidosCreados.Size = new System.Drawing.Size(200, 250);
            this.gb_partidosCreados.TabIndex = 2;
            this.gb_partidosCreados.TabStop = false;
            this.gb_partidosCreados.Text = "Partidos Creados";
            // 
            // lb_Partidos
            // 
            this.lb_Partidos.FormattingEnabled = true;
            this.lb_Partidos.Location = new System.Drawing.Point(6, 19);
            this.lb_Partidos.Name = "lb_Partidos";
            this.lb_Partidos.Size = new System.Drawing.Size(188, 173);
            this.lb_Partidos.TabIndex = 0;
            // 
            // bt_crearPartido
            // 
            this.bt_crearPartido.Location = new System.Drawing.Point(13, 212);
            this.bt_crearPartido.Name = "bt_crearPartido";
            this.bt_crearPartido.Size = new System.Drawing.Size(90, 23);
            this.bt_crearPartido.TabIndex = 5;
            this.bt_crearPartido.Text = "Crear Partido";
            this.bt_crearPartido.UseVisualStyleBackColor = true;
            this.bt_crearPartido.Click += new System.EventHandler(this.bt_crearPartido_Click);
            // 
            // bt_abrirPartido
            // 
            this.bt_abrirPartido.Location = new System.Drawing.Point(109, 212);
            this.bt_abrirPartido.Name = "bt_abrirPartido";
            this.bt_abrirPartido.Size = new System.Drawing.Size(75, 23);
            this.bt_abrirPartido.TabIndex = 6;
            this.bt_abrirPartido.Text = "Abrir";
            this.bt_abrirPartido.UseVisualStyleBackColor = true;
            this.bt_abrirPartido.Click += new System.EventHandler(this.bt_abrirPartido_Click);
            // 
            // gb_jugadoresCreados
            // 
            this.gb_jugadoresCreados.Controls.Add(this.lb_Jugadores);
            this.gb_jugadoresCreados.Controls.Add(this.bt_crearJugador);
            this.gb_jugadoresCreados.Controls.Add(this.bt_abrirJugador);
            this.gb_jugadoresCreados.Location = new System.Drawing.Point(12, 310);
            this.gb_jugadoresCreados.Name = "gb_jugadoresCreados";
            this.gb_jugadoresCreados.Size = new System.Drawing.Size(233, 250);
            this.gb_jugadoresCreados.TabIndex = 3;
            this.gb_jugadoresCreados.TabStop = false;
            this.gb_jugadoresCreados.Text = "Jugadores Creados";
            // 
            // lb_Jugadores
            // 
            this.lb_Jugadores.FormattingEnabled = true;
            this.lb_Jugadores.Location = new System.Drawing.Point(6, 19);
            this.lb_Jugadores.Name = "lb_Jugadores";
            this.lb_Jugadores.Size = new System.Drawing.Size(221, 173);
            this.lb_Jugadores.TabIndex = 0;
            // 
            // bt_crearJugador
            // 
            this.bt_crearJugador.Location = new System.Drawing.Point(15, 212);
            this.bt_crearJugador.Name = "bt_crearJugador";
            this.bt_crearJugador.Size = new System.Drawing.Size(91, 23);
            this.bt_crearJugador.TabIndex = 7;
            this.bt_crearJugador.Text = "Crear Jugador";
            this.bt_crearJugador.UseVisualStyleBackColor = true;
            this.bt_crearJugador.Click += new System.EventHandler(this.bt_crearJugador_Click);
            // 
            // bt_abrirJugador
            // 
            this.bt_abrirJugador.Location = new System.Drawing.Point(119, 212);
            this.bt_abrirJugador.Name = "bt_abrirJugador";
            this.bt_abrirJugador.Size = new System.Drawing.Size(75, 23);
            this.bt_abrirJugador.TabIndex = 8;
            this.bt_abrirJugador.Text = "Abrir";
            this.bt_abrirJugador.UseVisualStyleBackColor = true;
            this.bt_abrirJugador.Click += new System.EventHandler(this.bt_abrirJugador_Click);
            // 
            // gb_jugadoresCondicionalesCreados
            // 
            this.gb_jugadoresCondicionalesCreados.Controls.Add(this.button1);
            this.gb_jugadoresCondicionalesCreados.Controls.Add(this.button2);
            this.gb_jugadoresCondicionalesCreados.Controls.Add(this.lb_JugadoresCondicionales);
            this.gb_jugadoresCondicionalesCreados.Location = new System.Drawing.Point(272, 310);
            this.gb_jugadoresCondicionalesCreados.Name = "gb_jugadoresCondicionalesCreados";
            this.gb_jugadoresCondicionalesCreados.Size = new System.Drawing.Size(200, 250);
            this.gb_jugadoresCondicionalesCreados.TabIndex = 4;
            this.gb_jugadoresCondicionalesCreados.TabStop = false;
            this.gb_jugadoresCondicionalesCreados.Text = "Jugadores Creados";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(107, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(10, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Crear Jugador";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lb_JugadoresCondicionales
            // 
            this.lb_JugadoresCondicionales.FormattingEnabled = true;
            this.lb_JugadoresCondicionales.Location = new System.Drawing.Point(6, 19);
            this.lb_JugadoresCondicionales.Name = "lb_JugadoresCondicionales";
            this.lb_JugadoresCondicionales.Size = new System.Drawing.Size(188, 173);
            this.lb_JugadoresCondicionales.TabIndex = 0;
            // 
            // bt_inscribirStandard
            // 
            this.bt_inscribirStandard.Location = new System.Drawing.Point(478, 346);
            this.bt_inscribirStandard.Name = "bt_inscribirStandard";
            this.bt_inscribirStandard.Size = new System.Drawing.Size(113, 23);
            this.bt_inscribirStandard.TabIndex = 9;
            this.bt_inscribirStandard.Text = "Inscribir Standard";
            this.bt_inscribirStandard.UseVisualStyleBackColor = true;
            this.bt_inscribirStandard.Click += new System.EventHandler(this.bt_inscribirStandard_Click);
            // 
            // bt_inscribirSolidario
            // 
            this.bt_inscribirSolidario.Location = new System.Drawing.Point(478, 396);
            this.bt_inscribirSolidario.Name = "bt_inscribirSolidario";
            this.bt_inscribirSolidario.Size = new System.Drawing.Size(113, 23);
            this.bt_inscribirSolidario.TabIndex = 10;
            this.bt_inscribirSolidario.Text = "Inscribir Solidario";
            this.bt_inscribirSolidario.UseVisualStyleBackColor = true;
            this.bt_inscribirSolidario.Click += new System.EventHandler(this.bt_inscribirSolidario_Click);
            // 
            // bt_inscribirCondicional
            // 
            this.bt_inscribirCondicional.Location = new System.Drawing.Point(478, 444);
            this.bt_inscribirCondicional.Name = "bt_inscribirCondicional";
            this.bt_inscribirCondicional.Size = new System.Drawing.Size(113, 23);
            this.bt_inscribirCondicional.TabIndex = 11;
            this.bt_inscribirCondicional.Text = "Inscribir Condicional";
            this.bt_inscribirCondicional.UseVisualStyleBackColor = true;
            this.bt_inscribirCondicional.Click += new System.EventHandler(this.bt_inscribirCondicional_Click);
            // 
            // ll_titulo
            // 
            this.ll_titulo.AutoSize = true;
            this.ll_titulo.Font = new System.Drawing.Font("Bauhaus 93", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_titulo.Location = new System.Drawing.Point(12, 13);
            this.ll_titulo.Name = "ll_titulo";
            this.ll_titulo.Size = new System.Drawing.Size(202, 35);
            this.ll_titulo.TabIndex = 12;
            this.ll_titulo.Text = "Mein Führer!";
            // 
            // gb_AdministradoresCreados
            // 
            this.gb_AdministradoresCreados.Controls.Add(this.lb_Administradores);
            this.gb_AdministradoresCreados.Location = new System.Drawing.Point(12, 54);
            this.gb_AdministradoresCreados.Name = "gb_AdministradoresCreados";
            this.gb_AdministradoresCreados.Size = new System.Drawing.Size(233, 250);
            this.gb_AdministradoresCreados.TabIndex = 13;
            this.gb_AdministradoresCreados.TabStop = false;
            this.gb_AdministradoresCreados.Text = "Administradores Creados";
            // 
            // lb_Administradores
            // 
            this.lb_Administradores.FormattingEnabled = true;
            this.lb_Administradores.Location = new System.Drawing.Point(6, 19);
            this.lb_Administradores.Name = "lb_Administradores";
            this.lb_Administradores.Size = new System.Drawing.Size(221, 225);
            this.lb_Administradores.TabIndex = 0;
            // 
            // btnCrear_ProponerJugadores
            // 
            this.btnCrear_ProponerJugadores.Location = new System.Drawing.Point(478, 495);
            this.btnCrear_ProponerJugadores.Name = "btnCrear_ProponerJugadores";
            this.btnCrear_ProponerJugadores.Size = new System.Drawing.Size(111, 38);
            this.btnCrear_ProponerJugadores.TabIndex = 14;
            this.btnCrear_ProponerJugadores.Text = "Crear y Proponer Jugadores";
            this.btnCrear_ProponerJugadores.UseVisualStyleBackColor = true;
            this.btnCrear_ProponerJugadores.Click += new System.EventHandler(this.btnCrear_ProponerJugadores_Click);
            // 
            // HomeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 567);
            this.Controls.Add(this.btnCrear_ProponerJugadores);
            this.Controls.Add(this.gb_AdministradoresCreados);
            this.Controls.Add(this.ll_titulo);
            this.Controls.Add(this.bt_inscribirCondicional);
            this.Controls.Add(this.bt_inscribirSolidario);
            this.Controls.Add(this.bt_inscribirStandard);
            this.Controls.Add(this.gb_jugadoresCondicionalesCreados);
            this.Controls.Add(this.gb_jugadoresCreados);
            this.Controls.Add(this.gb_partidosCreados);
            this.Name = "HomeAdministrador";
            this.Text = "Organizador de Partidos de Futbol 5";
            this.Load += new System.EventHandler(this.HomeAdministrador_Load);
            this.gb_partidosCreados.ResumeLayout(false);
            this.gb_jugadoresCreados.ResumeLayout(false);
            this.gb_jugadoresCondicionalesCreados.ResumeLayout(false);
            this.gb_AdministradoresCreados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_partidosCreados;
        private System.Windows.Forms.GroupBox gb_jugadoresCreados;
        private System.Windows.Forms.GroupBox gb_jugadoresCondicionalesCreados;
        private System.Windows.Forms.ListBox lb_Partidos;
        private System.Windows.Forms.ListBox lb_Jugadores;
        private System.Windows.Forms.ListBox lb_JugadoresCondicionales;
        private System.Windows.Forms.Button bt_crearPartido;
        private System.Windows.Forms.Button bt_abrirPartido;
        private System.Windows.Forms.Button bt_crearJugador;
        private System.Windows.Forms.Button bt_abrirJugador;
        private System.Windows.Forms.Button bt_inscribirStandard;
        private System.Windows.Forms.Button bt_inscribirSolidario;
        private System.Windows.Forms.Button bt_inscribirCondicional;
        private System.Windows.Forms.Label ll_titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gb_AdministradoresCreados;
        private System.Windows.Forms.ListBox lb_Administradores;
        private System.Windows.Forms.Button btnCrear_ProponerJugadores;
    }
}