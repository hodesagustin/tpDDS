namespace OrganizadorFutbol5
{
    partial class Inicio
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
            this.btnInscribirStandard = new System.Windows.Forms.Button();
            this.bt_crearPartido = new System.Windows.Forms.Button();
            this.gb_partidosCreados = new System.Windows.Forms.GroupBox();
            this.lb_listaPartidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ll_partidoSeleccionado = new System.Windows.Forms.Label();
            this.tb_partidoSeleccionado = new System.Windows.Forms.TextBox();
            this.btnAbrirPartido = new System.Windows.Forms.Button();
            this.gb_JugadoresCreados = new System.Windows.Forms.GroupBox();
            this.lb_Jugadores = new System.Windows.Forms.ListBox();
            this.btnCrearJugador = new System.Windows.Forms.Button();
            this.btnAbrirJugador = new System.Windows.Forms.Button();
            this.btnInscribirSolidario = new System.Windows.Forms.Button();
            this.gb_JugadoresCondicionales = new System.Windows.Forms.GroupBox();
            this.lb_JugadoresCondicionales = new System.Windows.Forms.ListBox();
            this.btnInscribirCondicional = new System.Windows.Forms.Button();
            this.gb_partidosCreados.SuspendLayout();
            this.gb_JugadoresCreados.SuspendLayout();
            this.gb_JugadoresCondicionales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInscribirStandard
            // 
            this.btnInscribirStandard.Location = new System.Drawing.Point(749, 93);
            this.btnInscribirStandard.Name = "btnInscribirStandard";
            this.btnInscribirStandard.Size = new System.Drawing.Size(129, 23);
            this.btnInscribirStandard.TabIndex = 0;
            this.btnInscribirStandard.Text = "Inscribir Standard";
            this.btnInscribirStandard.UseVisualStyleBackColor = true;
            this.btnInscribirStandard.Click += new System.EventHandler(this.bt_inscribirse_Click);
            // 
            // bt_crearPartido
            // 
            this.bt_crearPartido.Location = new System.Drawing.Point(18, 222);
            this.bt_crearPartido.Name = "bt_crearPartido";
            this.bt_crearPartido.Size = new System.Drawing.Size(92, 23);
            this.bt_crearPartido.TabIndex = 1;
            this.bt_crearPartido.Text = "Crear Partido";
            this.bt_crearPartido.UseVisualStyleBackColor = true;
            this.bt_crearPartido.Click += new System.EventHandler(this.bt_crearPartido_Click);
            // 
            // gb_partidosCreados
            // 
            this.gb_partidosCreados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_partidosCreados.Controls.Add(this.lb_listaPartidos);
            this.gb_partidosCreados.Location = new System.Drawing.Point(12, 93);
            this.gb_partidosCreados.Name = "gb_partidosCreados";
            this.gb_partidosCreados.Size = new System.Drawing.Size(222, 122);
            this.gb_partidosCreados.TabIndex = 2;
            this.gb_partidosCreados.TabStop = false;
            this.gb_partidosCreados.Text = "Partidos Creados";
            // 
            // lb_listaPartidos
            // 
            this.lb_listaPartidos.FormattingEnabled = true;
            this.lb_listaPartidos.Location = new System.Drawing.Point(6, 19);
            this.lb_listaPartidos.Name = "lb_listaPartidos";
            this.lb_listaPartidos.Size = new System.Drawing.Size(204, 95);
            this.lb_listaPartidos.TabIndex = 0;
            this.lb_listaPartidos.SelectedIndexChanged += new System.EventHandler(this.lb_listaPartidos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido!";
            // 
            // ll_partidoSeleccionado
            // 
            this.ll_partidoSeleccionado.AutoSize = true;
            this.ll_partidoSeleccionado.Location = new System.Drawing.Point(12, 67);
            this.ll_partidoSeleccionado.Name = "ll_partidoSeleccionado";
            this.ll_partidoSeleccionado.Size = new System.Drawing.Size(108, 13);
            this.ll_partidoSeleccionado.TabIndex = 4;
            this.ll_partidoSeleccionado.Text = "Partido Seleccionado";
            // 
            // tb_partidoSeleccionado
            // 
            this.tb_partidoSeleccionado.Location = new System.Drawing.Point(126, 64);
            this.tb_partidoSeleccionado.Name = "tb_partidoSeleccionado";
            this.tb_partidoSeleccionado.Size = new System.Drawing.Size(177, 20);
            this.tb_partidoSeleccionado.TabIndex = 5;
            // 
            // btnAbrirPartido
            // 
            this.btnAbrirPartido.Location = new System.Drawing.Point(126, 222);
            this.btnAbrirPartido.Name = "btnAbrirPartido";
            this.btnAbrirPartido.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirPartido.TabIndex = 6;
            this.btnAbrirPartido.Text = "Abrir Partido";
            this.btnAbrirPartido.UseVisualStyleBackColor = true;
            this.btnAbrirPartido.Click += new System.EventHandler(this.btnAbrirPartido_Click);
            // 
            // gb_JugadoresCreados
            // 
            this.gb_JugadoresCreados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_JugadoresCreados.Controls.Add(this.lb_Jugadores);
            this.gb_JugadoresCreados.Location = new System.Drawing.Point(268, 93);
            this.gb_JugadoresCreados.Name = "gb_JugadoresCreados";
            this.gb_JugadoresCreados.Size = new System.Drawing.Size(222, 122);
            this.gb_JugadoresCreados.TabIndex = 7;
            this.gb_JugadoresCreados.TabStop = false;
            this.gb_JugadoresCreados.Text = "Jugadores Creados";
            // 
            // lb_Jugadores
            // 
            this.lb_Jugadores.FormattingEnabled = true;
            this.lb_Jugadores.Location = new System.Drawing.Point(6, 19);
            this.lb_Jugadores.Name = "lb_Jugadores";
            this.lb_Jugadores.Size = new System.Drawing.Size(204, 95);
            this.lb_Jugadores.TabIndex = 0;
            // 
            // btnCrearJugador
            // 
            this.btnCrearJugador.Location = new System.Drawing.Point(268, 222);
            this.btnCrearJugador.Name = "btnCrearJugador";
            this.btnCrearJugador.Size = new System.Drawing.Size(92, 23);
            this.btnCrearJugador.TabIndex = 8;
            this.btnCrearJugador.Text = "Crear Jugador";
            this.btnCrearJugador.UseVisualStyleBackColor = true;
            this.btnCrearJugador.Click += new System.EventHandler(this.btnCrearJugador_Click);
            // 
            // btnAbrirJugador
            // 
            this.btnAbrirJugador.Location = new System.Drawing.Point(394, 222);
            this.btnAbrirJugador.Name = "btnAbrirJugador";
            this.btnAbrirJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirJugador.TabIndex = 9;
            this.btnAbrirJugador.Text = "Abrir Jugador";
            this.btnAbrirJugador.UseVisualStyleBackColor = true;
            this.btnAbrirJugador.Click += new System.EventHandler(this.btnAbrirJugador_Click);
            // 
            // btnInscribirSolidario
            // 
            this.btnInscribirSolidario.Location = new System.Drawing.Point(749, 133);
            this.btnInscribirSolidario.Name = "btnInscribirSolidario";
            this.btnInscribirSolidario.Size = new System.Drawing.Size(129, 23);
            this.btnInscribirSolidario.TabIndex = 10;
            this.btnInscribirSolidario.Text = "Inscribir Solidario";
            this.btnInscribirSolidario.UseVisualStyleBackColor = true;
            this.btnInscribirSolidario.Click += new System.EventHandler(this.btnInscribirSolidario_Click);
            // 
            // gb_JugadoresCondicionales
            // 
            this.gb_JugadoresCondicionales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_JugadoresCondicionales.Controls.Add(this.lb_JugadoresCondicionales);
            this.gb_JugadoresCondicionales.Location = new System.Drawing.Point(517, 93);
            this.gb_JugadoresCondicionales.Name = "gb_JugadoresCondicionales";
            this.gb_JugadoresCondicionales.Size = new System.Drawing.Size(222, 122);
            this.gb_JugadoresCondicionales.TabIndex = 8;
            this.gb_JugadoresCondicionales.TabStop = false;
            this.gb_JugadoresCondicionales.Text = "Jugadores Creados";
            // 
            // lb_JugadoresCondicionales
            // 
            this.lb_JugadoresCondicionales.FormattingEnabled = true;
            this.lb_JugadoresCondicionales.Location = new System.Drawing.Point(6, 19);
            this.lb_JugadoresCondicionales.Name = "lb_JugadoresCondicionales";
            this.lb_JugadoresCondicionales.Size = new System.Drawing.Size(204, 95);
            this.lb_JugadoresCondicionales.TabIndex = 0;
            // 
            // btnInscribirCondicional
            // 
            this.btnInscribirCondicional.Location = new System.Drawing.Point(749, 175);
            this.btnInscribirCondicional.Name = "btnInscribirCondicional";
            this.btnInscribirCondicional.Size = new System.Drawing.Size(129, 23);
            this.btnInscribirCondicional.TabIndex = 11;
            this.btnInscribirCondicional.Text = "Inscribir Condicional";
            this.btnInscribirCondicional.UseVisualStyleBackColor = true;
            this.btnInscribirCondicional.Click += new System.EventHandler(this.btnInscribirCondicional_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 253);
            this.Controls.Add(this.btnInscribirCondicional);
            this.Controls.Add(this.gb_JugadoresCondicionales);
            this.Controls.Add(this.btnInscribirSolidario);
            this.Controls.Add(this.btnAbrirJugador);
            this.Controls.Add(this.btnCrearJugador);
            this.Controls.Add(this.gb_JugadoresCreados);
            this.Controls.Add(this.btnAbrirPartido);
            this.Controls.Add(this.tb_partidoSeleccionado);
            this.Controls.Add(this.ll_partidoSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_partidosCreados);
            this.Controls.Add(this.bt_crearPartido);
            this.Controls.Add(this.btnInscribirStandard);
            this.Name = "Inicio";
            this.Text = "Organizador de partidos Fútbol 5";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gb_partidosCreados.ResumeLayout(false);
            this.gb_JugadoresCreados.ResumeLayout(false);
            this.gb_JugadoresCondicionales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscribirStandard;
        private System.Windows.Forms.Button bt_crearPartido;
        private System.Windows.Forms.GroupBox gb_partidosCreados;
        private System.Windows.Forms.ListBox lb_listaPartidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ll_partidoSeleccionado;
        private System.Windows.Forms.TextBox tb_partidoSeleccionado;
        private System.Windows.Forms.Button btnAbrirPartido;
        private System.Windows.Forms.GroupBox gb_JugadoresCreados;
        private System.Windows.Forms.ListBox lb_Jugadores;
        private System.Windows.Forms.Button btnCrearJugador;
        private System.Windows.Forms.Button btnAbrirJugador;
        private System.Windows.Forms.Button btnInscribirSolidario;
        private System.Windows.Forms.GroupBox gb_JugadoresCondicionales;
        private System.Windows.Forms.ListBox lb_JugadoresCondicionales;
        private System.Windows.Forms.Button btnInscribirCondicional;
    }
}

