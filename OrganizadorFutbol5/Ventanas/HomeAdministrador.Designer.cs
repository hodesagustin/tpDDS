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
            this.ll_partidoSeleccionado = new System.Windows.Forms.Label();
            this.tb_partidoSeleccionado = new System.Windows.Forms.TextBox();
            this.gb_partidosCreados = new System.Windows.Forms.GroupBox();
            this.lb_listaPartidos = new System.Windows.Forms.ListBox();
            this.gb_jugadoresCreados = new System.Windows.Forms.GroupBox();
            this.lb_jugadores = new System.Windows.Forms.ListBox();
            this.gb_jugadoresCondicionalesCreados = new System.Windows.Forms.GroupBox();
            this.lb_jugadoresCondicionales = new System.Windows.Forms.ListBox();
            this.bt_crearPartido = new System.Windows.Forms.Button();
            this.bt_abrirPartido = new System.Windows.Forms.Button();
            this.bt_crearJugador = new System.Windows.Forms.Button();
            this.bt_abrirJugador = new System.Windows.Forms.Button();
            this.bt_inscribirStandard = new System.Windows.Forms.Button();
            this.bt_inscribirSolidario = new System.Windows.Forms.Button();
            this.bt_inscribirCondicional = new System.Windows.Forms.Button();
            this.ll_titulo = new System.Windows.Forms.Label();
            this.gb_partidosCreados.SuspendLayout();
            this.gb_jugadoresCreados.SuspendLayout();
            this.gb_jugadoresCondicionalesCreados.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll_partidoSeleccionado
            // 
            this.ll_partidoSeleccionado.AutoSize = true;
            this.ll_partidoSeleccionado.Location = new System.Drawing.Point(9, 57);
            this.ll_partidoSeleccionado.Name = "ll_partidoSeleccionado";
            this.ll_partidoSeleccionado.Size = new System.Drawing.Size(106, 13);
            this.ll_partidoSeleccionado.TabIndex = 0;
            this.ll_partidoSeleccionado.Text = "Partido seleccionado";
            // 
            // tb_partidoSeleccionado
            // 
            this.tb_partidoSeleccionado.Location = new System.Drawing.Point(124, 54);
            this.tb_partidoSeleccionado.Name = "tb_partidoSeleccionado";
            this.tb_partidoSeleccionado.Size = new System.Drawing.Size(230, 20);
            this.tb_partidoSeleccionado.TabIndex = 1;
            // 
            // gb_partidosCreados
            // 
            this.gb_partidosCreados.Controls.Add(this.lb_listaPartidos);
            this.gb_partidosCreados.Location = new System.Drawing.Point(12, 83);
            this.gb_partidosCreados.Name = "gb_partidosCreados";
            this.gb_partidosCreados.Size = new System.Drawing.Size(200, 153);
            this.gb_partidosCreados.TabIndex = 2;
            this.gb_partidosCreados.TabStop = false;
            this.gb_partidosCreados.Text = "Partidos Creados";
            // 
            // lb_listaPartidos
            // 
            this.lb_listaPartidos.FormattingEnabled = true;
            this.lb_listaPartidos.Location = new System.Drawing.Point(14, 19);
            this.lb_listaPartidos.Name = "lb_listaPartidos";
            this.lb_listaPartidos.Size = new System.Drawing.Size(171, 121);
            this.lb_listaPartidos.TabIndex = 0;
            this.lb_listaPartidos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gb_jugadoresCreados
            // 
            this.gb_jugadoresCreados.Controls.Add(this.lb_jugadores);
            this.gb_jugadoresCreados.Location = new System.Drawing.Point(218, 83);
            this.gb_jugadoresCreados.Name = "gb_jugadoresCreados";
            this.gb_jugadoresCreados.Size = new System.Drawing.Size(200, 153);
            this.gb_jugadoresCreados.TabIndex = 3;
            this.gb_jugadoresCreados.TabStop = false;
            this.gb_jugadoresCreados.Text = "Jugadores Creados";
            // 
            // lb_jugadores
            // 
            this.lb_jugadores.FormattingEnabled = true;
            this.lb_jugadores.Location = new System.Drawing.Point(15, 19);
            this.lb_jugadores.Name = "lb_jugadores";
            this.lb_jugadores.Size = new System.Drawing.Size(170, 121);
            this.lb_jugadores.TabIndex = 0;
            // 
            // gb_jugadoresCondicionalesCreados
            // 
            this.gb_jugadoresCondicionalesCreados.Controls.Add(this.lb_jugadoresCondicionales);
            this.gb_jugadoresCondicionalesCreados.Location = new System.Drawing.Point(424, 83);
            this.gb_jugadoresCondicionalesCreados.Name = "gb_jugadoresCondicionalesCreados";
            this.gb_jugadoresCondicionalesCreados.Size = new System.Drawing.Size(200, 153);
            this.gb_jugadoresCondicionalesCreados.TabIndex = 4;
            this.gb_jugadoresCondicionalesCreados.TabStop = false;
            this.gb_jugadoresCondicionalesCreados.Text = "Jugadores Creados";
            // 
            // lb_jugadoresCondicionales
            // 
            this.lb_jugadoresCondicionales.FormattingEnabled = true;
            this.lb_jugadoresCondicionales.Location = new System.Drawing.Point(17, 19);
            this.lb_jugadoresCondicionales.Name = "lb_jugadoresCondicionales";
            this.lb_jugadoresCondicionales.Size = new System.Drawing.Size(168, 121);
            this.lb_jugadoresCondicionales.TabIndex = 0;
            // 
            // bt_crearPartido
            // 
            this.bt_crearPartido.Location = new System.Drawing.Point(12, 242);
            this.bt_crearPartido.Name = "bt_crearPartido";
            this.bt_crearPartido.Size = new System.Drawing.Size(90, 23);
            this.bt_crearPartido.TabIndex = 5;
            this.bt_crearPartido.Text = "Crear Partido";
            this.bt_crearPartido.UseVisualStyleBackColor = true;
            this.bt_crearPartido.Click += new System.EventHandler(this.bt_crearPartido_Click);
            // 
            // bt_abrirPartido
            // 
            this.bt_abrirPartido.Location = new System.Drawing.Point(108, 242);
            this.bt_abrirPartido.Name = "bt_abrirPartido";
            this.bt_abrirPartido.Size = new System.Drawing.Size(75, 23);
            this.bt_abrirPartido.TabIndex = 6;
            this.bt_abrirPartido.Text = "Abrir";
            this.bt_abrirPartido.UseVisualStyleBackColor = true;
            this.bt_abrirPartido.Click += new System.EventHandler(this.bt_abrirPartido_Click);
            // 
            // bt_crearJugador
            // 
            this.bt_crearJugador.Location = new System.Drawing.Point(218, 242);
            this.bt_crearJugador.Name = "bt_crearJugador";
            this.bt_crearJugador.Size = new System.Drawing.Size(91, 23);
            this.bt_crearJugador.TabIndex = 7;
            this.bt_crearJugador.Text = "Crear Jugador";
            this.bt_crearJugador.UseVisualStyleBackColor = true;
            this.bt_crearJugador.Click += new System.EventHandler(this.bt_crearJugador_Click);
            // 
            // bt_abrirJugador
            // 
            this.bt_abrirJugador.Location = new System.Drawing.Point(315, 242);
            this.bt_abrirJugador.Name = "bt_abrirJugador";
            this.bt_abrirJugador.Size = new System.Drawing.Size(75, 23);
            this.bt_abrirJugador.TabIndex = 8;
            this.bt_abrirJugador.Text = "Abrir";
            this.bt_abrirJugador.UseVisualStyleBackColor = true;
            this.bt_abrirJugador.Click += new System.EventHandler(this.bt_abrirJugador_Click);
            // 
            // bt_inscribirStandard
            // 
            this.bt_inscribirStandard.Location = new System.Drawing.Point(630, 102);
            this.bt_inscribirStandard.Name = "bt_inscribirStandard";
            this.bt_inscribirStandard.Size = new System.Drawing.Size(146, 23);
            this.bt_inscribirStandard.TabIndex = 9;
            this.bt_inscribirStandard.Text = "Inscribir Standard";
            this.bt_inscribirStandard.UseVisualStyleBackColor = true;
            this.bt_inscribirStandard.Click += new System.EventHandler(this.bt_inscribirStandard_Click);
            // 
            // bt_inscribirSolidario
            // 
            this.bt_inscribirSolidario.Location = new System.Drawing.Point(630, 152);
            this.bt_inscribirSolidario.Name = "bt_inscribirSolidario";
            this.bt_inscribirSolidario.Size = new System.Drawing.Size(146, 23);
            this.bt_inscribirSolidario.TabIndex = 10;
            this.bt_inscribirSolidario.Text = "Inscribir Solidario";
            this.bt_inscribirSolidario.UseVisualStyleBackColor = true;
            this.bt_inscribirSolidario.Click += new System.EventHandler(this.bt_inscribirSolidario_Click);
            // 
            // bt_inscribirCondicional
            // 
            this.bt_inscribirCondicional.Location = new System.Drawing.Point(630, 200);
            this.bt_inscribirCondicional.Name = "bt_inscribirCondicional";
            this.bt_inscribirCondicional.Size = new System.Drawing.Size(146, 23);
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
            // HomeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 279);
            this.Controls.Add(this.ll_titulo);
            this.Controls.Add(this.bt_inscribirCondicional);
            this.Controls.Add(this.bt_abrirJugador);
            this.Controls.Add(this.bt_inscribirSolidario);
            this.Controls.Add(this.bt_inscribirStandard);
            this.Controls.Add(this.bt_crearJugador);
            this.Controls.Add(this.bt_abrirPartido);
            this.Controls.Add(this.bt_crearPartido);
            this.Controls.Add(this.gb_jugadoresCondicionalesCreados);
            this.Controls.Add(this.gb_jugadoresCreados);
            this.Controls.Add(this.gb_partidosCreados);
            this.Controls.Add(this.tb_partidoSeleccionado);
            this.Controls.Add(this.ll_partidoSeleccionado);
            this.Name = "HomeAdministrador";
            this.Text = "Organizador de Partidos de Futbol 5";
            this.Load += new System.EventHandler(this.HomeAdministrador_Load);
            this.gb_partidosCreados.ResumeLayout(false);
            this.gb_jugadoresCreados.ResumeLayout(false);
            this.gb_jugadoresCondicionalesCreados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ll_partidoSeleccionado;
        private System.Windows.Forms.TextBox tb_partidoSeleccionado;
        private System.Windows.Forms.GroupBox gb_partidosCreados;
        private System.Windows.Forms.GroupBox gb_jugadoresCreados;
        private System.Windows.Forms.GroupBox gb_jugadoresCondicionalesCreados;
        private System.Windows.Forms.ListBox lb_listaPartidos;
        private System.Windows.Forms.ListBox lb_jugadores;
        private System.Windows.Forms.ListBox lb_jugadoresCondicionales;
        private System.Windows.Forms.Button bt_crearPartido;
        private System.Windows.Forms.Button bt_abrirPartido;
        private System.Windows.Forms.Button bt_crearJugador;
        private System.Windows.Forms.Button bt_abrirJugador;
        private System.Windows.Forms.Button bt_inscribirStandard;
        private System.Windows.Forms.Button bt_inscribirSolidario;
        private System.Windows.Forms.Button bt_inscribirCondicional;
        private System.Windows.Forms.Label ll_titulo;
    }
}