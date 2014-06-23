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
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listInscriptosStandard = new System.Windows.Forms.ListBox();
            this.listInscriptosSolidarios = new System.Windows.Forms.ListBox();
            this.listInscriptosCondicionales = new System.Windows.Forms.ListBox();
            this.lblInscriptosStandard = new System.Windows.Forms.Label();
            this.lblInscriptosSolidarios = new System.Windows.Forms.Label();
            this.lblInscriptosCondicionales = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCantidadInscriptos = new System.Windows.Forms.Label();
            this.txtCantidadInscriptos = new System.Windows.Forms.TextBox();
            this.MenuInscriptosStandard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reemplazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lALALAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDarDeBajaStandard = new System.Windows.Forms.Button();
            this.btnDarDDeBajaSolidario = new System.Windows.Forms.Button();
            this.btnDarDeBajaCondicional = new System.Windows.Forms.Button();
            this.btnReemplazarCondicional = new System.Windows.Forms.Button();
            this.btnReemplazarSolidario = new System.Windows.Forms.Button();
            this.btnReemplazarStandard = new System.Windows.Forms.Button();
            this.MenuInscriptosStandard.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // listInscriptosStandard
            // 
            this.listInscriptosStandard.FormattingEnabled = true;
            this.listInscriptosStandard.Location = new System.Drawing.Point(16, 100);
            this.listInscriptosStandard.Name = "listInscriptosStandard";
            this.listInscriptosStandard.Size = new System.Drawing.Size(122, 147);
            this.listInscriptosStandard.TabIndex = 2;
            this.listInscriptosStandard.SelectedIndexChanged += new System.EventHandler(this.listInscriptosStandard_SelectedIndexChanged);
            // 
            // listInscriptosSolidarios
            // 
            this.listInscriptosSolidarios.FormattingEnabled = true;
            this.listInscriptosSolidarios.Location = new System.Drawing.Point(145, 100);
            this.listInscriptosSolidarios.Name = "listInscriptosSolidarios";
            this.listInscriptosSolidarios.Size = new System.Drawing.Size(120, 147);
            this.listInscriptosSolidarios.TabIndex = 3;
            // 
            // listInscriptosCondicionales
            // 
            this.listInscriptosCondicionales.FormattingEnabled = true;
            this.listInscriptosCondicionales.Location = new System.Drawing.Point(272, 100);
            this.listInscriptosCondicionales.Name = "listInscriptosCondicionales";
            this.listInscriptosCondicionales.Size = new System.Drawing.Size(120, 147);
            this.listInscriptosCondicionales.TabIndex = 4;
            // 
            // lblInscriptosStandard
            // 
            this.lblInscriptosStandard.AutoSize = true;
            this.lblInscriptosStandard.Location = new System.Drawing.Point(13, 81);
            this.lblInscriptosStandard.Name = "lblInscriptosStandard";
            this.lblInscriptosStandard.Size = new System.Drawing.Size(98, 13);
            this.lblInscriptosStandard.TabIndex = 5;
            this.lblInscriptosStandard.Text = "Inscriptos Standard";
            // 
            // lblInscriptosSolidarios
            // 
            this.lblInscriptosSolidarios.AutoSize = true;
            this.lblInscriptosSolidarios.Location = new System.Drawing.Point(142, 81);
            this.lblInscriptosSolidarios.Name = "lblInscriptosSolidarios";
            this.lblInscriptosSolidarios.Size = new System.Drawing.Size(100, 13);
            this.lblInscriptosSolidarios.TabIndex = 6;
            this.lblInscriptosSolidarios.Text = "Inscriptos Solidarios";
            // 
            // lblInscriptosCondicionales
            // 
            this.lblInscriptosCondicionales.AutoSize = true;
            this.lblInscriptosCondicionales.Location = new System.Drawing.Point(269, 81);
            this.lblInscriptosCondicionales.Name = "lblInscriptosCondicionales";
            this.lblInscriptosCondicionales.Size = new System.Drawing.Size(121, 13);
            this.lblInscriptosCondicionales.TabIndex = 7;
            this.lblInscriptosCondicionales.Text = "Inscriptos Condicionales";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(63, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(324, 20);
            this.txtFecha.TabIndex = 9;
            // 
            // lblCantidadInscriptos
            // 
            this.lblCantidadInscriptos.AutoSize = true;
            this.lblCantidadInscriptos.Location = new System.Drawing.Point(13, 327);
            this.lblCantidadInscriptos.Name = "lblCantidadInscriptos";
            this.lblCantidadInscriptos.Size = new System.Drawing.Size(97, 13);
            this.lblCantidadInscriptos.TabIndex = 10;
            this.lblCantidadInscriptos.Text = "Cantidad Inscriptos";
            // 
            // txtCantidadInscriptos
            // 
            this.txtCantidadInscriptos.Location = new System.Drawing.Point(116, 324);
            this.txtCantidadInscriptos.Name = "txtCantidadInscriptos";
            this.txtCantidadInscriptos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadInscriptos.TabIndex = 11;
            // 
            // MenuInscriptosStandard
            // 
            this.MenuInscriptosStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeBajaToolStripMenuItem,
            this.reemplazarToolStripMenuItem});
            this.MenuInscriptosStandard.Name = "MenuInscriptosStandard";
            this.MenuInscriptosStandard.Size = new System.Drawing.Size(142, 48);
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de Baja";
            // 
            // reemplazarToolStripMenuItem
            // 
            this.reemplazarToolStripMenuItem.Name = "reemplazarToolStripMenuItem";
            this.reemplazarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.reemplazarToolStripMenuItem.Text = "Reemplazar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lALALAToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // lALALAToolStripMenuItem
            // 
            this.lALALAToolStripMenuItem.Name = "lALALAToolStripMenuItem";
            this.lALALAToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.lALALAToolStripMenuItem.Text = "LA LA LA";
            // 
            // btnDarDeBajaStandard
            // 
            this.btnDarDeBajaStandard.Location = new System.Drawing.Point(16, 254);
            this.btnDarDeBajaStandard.Name = "btnDarDeBajaStandard";
            this.btnDarDeBajaStandard.Size = new System.Drawing.Size(75, 23);
            this.btnDarDeBajaStandard.TabIndex = 12;
            this.btnDarDeBajaStandard.Text = "Dar de Baja";
            this.btnDarDeBajaStandard.UseVisualStyleBackColor = true;
            this.btnDarDeBajaStandard.Click += new System.EventHandler(this.btnDarDeBajaStandard_Click);
            // 
            // btnDarDDeBajaSolidario
            // 
            this.btnDarDDeBajaSolidario.Location = new System.Drawing.Point(145, 254);
            this.btnDarDDeBajaSolidario.Name = "btnDarDDeBajaSolidario";
            this.btnDarDDeBajaSolidario.Size = new System.Drawing.Size(75, 23);
            this.btnDarDDeBajaSolidario.TabIndex = 13;
            this.btnDarDDeBajaSolidario.Text = "Dar de Baja";
            this.btnDarDDeBajaSolidario.UseVisualStyleBackColor = true;
            this.btnDarDDeBajaSolidario.Click += new System.EventHandler(this.btnDarDDeBajaSolidario_Click);
            // 
            // btnDarDeBajaCondicional
            // 
            this.btnDarDeBajaCondicional.Location = new System.Drawing.Point(272, 254);
            this.btnDarDeBajaCondicional.Name = "btnDarDeBajaCondicional";
            this.btnDarDeBajaCondicional.Size = new System.Drawing.Size(75, 23);
            this.btnDarDeBajaCondicional.TabIndex = 14;
            this.btnDarDeBajaCondicional.Text = "Dar de Baja";
            this.btnDarDeBajaCondicional.UseVisualStyleBackColor = true;
            this.btnDarDeBajaCondicional.Click += new System.EventHandler(this.btnDarDeBajaCondicional_Click);
            // 
            // btnReemplazarCondicional
            // 
            this.btnReemplazarCondicional.Location = new System.Drawing.Point(272, 283);
            this.btnReemplazarCondicional.Name = "btnReemplazarCondicional";
            this.btnReemplazarCondicional.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazarCondicional.TabIndex = 17;
            this.btnReemplazarCondicional.Text = "Reemplazar";
            this.btnReemplazarCondicional.UseVisualStyleBackColor = true;
            this.btnReemplazarCondicional.Click += new System.EventHandler(this.btnReemplazarCondicional_Click);
            // 
            // btnReemplazarSolidario
            // 
            this.btnReemplazarSolidario.Location = new System.Drawing.Point(145, 283);
            this.btnReemplazarSolidario.Name = "btnReemplazarSolidario";
            this.btnReemplazarSolidario.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazarSolidario.TabIndex = 16;
            this.btnReemplazarSolidario.Text = "Reemplazar";
            this.btnReemplazarSolidario.UseVisualStyleBackColor = true;
            this.btnReemplazarSolidario.Click += new System.EventHandler(this.btnReemplazarSolidario_Click);
            // 
            // btnReemplazarStandard
            // 
            this.btnReemplazarStandard.Location = new System.Drawing.Point(16, 283);
            this.btnReemplazarStandard.Name = "btnReemplazarStandard";
            this.btnReemplazarStandard.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazarStandard.TabIndex = 15;
            this.btnReemplazarStandard.Text = "Reemplazar";
            this.btnReemplazarStandard.UseVisualStyleBackColor = true;
            this.btnReemplazarStandard.Click += new System.EventHandler(this.btnReemplazarStandard_Click);
            // 
            // FormPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 454);
            this.Controls.Add(this.btnReemplazarCondicional);
            this.Controls.Add(this.btnReemplazarSolidario);
            this.Controls.Add(this.btnReemplazarStandard);
            this.Controls.Add(this.btnDarDeBajaCondicional);
            this.Controls.Add(this.btnDarDDeBajaSolidario);
            this.Controls.Add(this.btnDarDeBajaStandard);
            this.Controls.Add(this.txtCantidadInscriptos);
            this.Controls.Add(this.lblCantidadInscriptos);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblInscriptosCondicionales);
            this.Controls.Add(this.lblInscriptosSolidarios);
            this.Controls.Add(this.lblInscriptosStandard);
            this.Controls.Add(this.listInscriptosCondicionales);
            this.Controls.Add(this.listInscriptosSolidarios);
            this.Controls.Add(this.listInscriptosStandard);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormPartido";
            this.Text = "Partido";
            this.Load += new System.EventHandler(this.Partido_Load);
            this.MenuInscriptosStandard.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox listInscriptosStandard;
        private System.Windows.Forms.ListBox listInscriptosSolidarios;
        private System.Windows.Forms.ListBox listInscriptosCondicionales;
        private System.Windows.Forms.Label lblInscriptosStandard;
        private System.Windows.Forms.Label lblInscriptosSolidarios;
        private System.Windows.Forms.Label lblInscriptosCondicionales;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCantidadInscriptos;
        private System.Windows.Forms.TextBox txtCantidadInscriptos;
        private System.Windows.Forms.ContextMenuStrip MenuInscriptosStandard;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reemplazarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lALALAToolStripMenuItem;
        private System.Windows.Forms.Button btnDarDeBajaStandard;
        private System.Windows.Forms.Button btnDarDDeBajaSolidario;
        private System.Windows.Forms.Button btnDarDeBajaCondicional;
        private System.Windows.Forms.Button btnReemplazarCondicional;
        private System.Windows.Forms.Button btnReemplazarSolidario;
        private System.Windows.Forms.Button btnReemplazarStandard;
    }
}