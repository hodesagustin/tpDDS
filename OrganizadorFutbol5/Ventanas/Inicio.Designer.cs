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
            this.bt_inscribirse = new System.Windows.Forms.Button();
            this.bt_crearPartido = new System.Windows.Forms.Button();
            this.gb_partidosCreados = new System.Windows.Forms.GroupBox();
            this.lb_listaPartidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ll_partidoSeleccionado = new System.Windows.Forms.Label();
            this.tb_partidoSeleccionado = new System.Windows.Forms.TextBox();
            this.gb_partidosCreados.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_inscribirse
            // 
            this.bt_inscribirse.Location = new System.Drawing.Point(12, 221);
            this.bt_inscribirse.Name = "bt_inscribirse";
            this.bt_inscribirse.Size = new System.Drawing.Size(75, 23);
            this.bt_inscribirse.TabIndex = 0;
            this.bt_inscribirse.Text = "Inscribirse";
            this.bt_inscribirse.UseVisualStyleBackColor = true;
            this.bt_inscribirse.Click += new System.EventHandler(this.bt_inscribirse_Click);
            // 
            // bt_crearPartido
            // 
            this.bt_crearPartido.Location = new System.Drawing.Point(347, 221);
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
            this.gb_partidosCreados.Size = new System.Drawing.Size(866, 122);
            this.gb_partidosCreados.TabIndex = 2;
            this.gb_partidosCreados.TabStop = false;
            this.gb_partidosCreados.Text = "Partidos Creados";
            // 
            // lb_listaPartidos
            // 
            this.lb_listaPartidos.FormattingEnabled = true;
            this.lb_listaPartidos.Location = new System.Drawing.Point(6, 19);
            this.lb_listaPartidos.Name = "lb_listaPartidos";
            this.lb_listaPartidos.Size = new System.Drawing.Size(853, 95);
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
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 253);
            this.Controls.Add(this.tb_partidoSeleccionado);
            this.Controls.Add(this.ll_partidoSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_partidosCreados);
            this.Controls.Add(this.bt_crearPartido);
            this.Controls.Add(this.bt_inscribirse);
            this.Name = "Inicio";
            this.Text = "Organizador de partidos Fútbol 5";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gb_partidosCreados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_inscribirse;
        private System.Windows.Forms.Button bt_crearPartido;
        private System.Windows.Forms.GroupBox gb_partidosCreados;
        private System.Windows.Forms.ListBox lb_listaPartidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ll_partidoSeleccionado;
        private System.Windows.Forms.TextBox tb_partidoSeleccionado;
    }
}

