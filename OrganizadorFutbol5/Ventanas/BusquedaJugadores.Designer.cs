namespace OrganizadorFutbol5.Ventanas
{
    partial class BusquedaJugadores
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
            this.buscar_btn = new System.Windows.Forms.Button();
            this.limpiar_btn = new System.Windows.Forms.Button();
            this.nombre_gbx = new System.Windows.Forms.GroupBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaNac_gbx = new System.Windows.Forms.GroupBox();
            this.fechaNac_dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.handicap_gbx = new System.Windows.Forms.GroupBox();
            this.handHasta_nud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.handDesde_nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.promedio_gbx = new System.Windows.Forms.GroupBox();
            this.promHasta_nud = new System.Windows.Forms.NumericUpDown();
            this.promDesde_nud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infracNo_btn = new System.Windows.Forms.RadioButton();
            this.infracSi_btn = new System.Windows.Forms.RadioButton();
            this.criterios_gbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre_gbx.SuspendLayout();
            this.fechaNac_gbx.SuspendLayout();
            this.handicap_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handHasta_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handDesde_nud)).BeginInit();
            this.promedio_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promHasta_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promDesde_nud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.criterios_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar_btn
            // 
            this.buscar_btn.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Location = new System.Drawing.Point(12, 304);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(155, 35);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.Text = "Buscar Jugadores";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // limpiar_btn
            // 
            this.limpiar_btn.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar_btn.Location = new System.Drawing.Point(503, 304);
            this.limpiar_btn.Name = "limpiar_btn";
            this.limpiar_btn.Size = new System.Drawing.Size(154, 35);
            this.limpiar_btn.TabIndex = 3;
            this.limpiar_btn.Text = "Limpiar Busqueda";
            this.limpiar_btn.UseVisualStyleBackColor = true;
            this.limpiar_btn.Click += new System.EventHandler(this.limpiar_btn_Click);
            // 
            // nombre_gbx
            // 
            this.nombre_gbx.Controls.Add(this.nombre_txt);
            this.nombre_gbx.Controls.Add(this.label2);
            this.nombre_gbx.Location = new System.Drawing.Point(6, 19);
            this.nombre_gbx.Name = "nombre_gbx";
            this.nombre_gbx.Size = new System.Drawing.Size(302, 47);
            this.nombre_gbx.TabIndex = 5;
            this.nombre_gbx.TabStop = false;
            this.nombre_gbx.Text = "Nombre";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(89, 22);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(200, 20);
            this.nombre_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Comienza con:";
            // 
            // fechaNac_gbx
            // 
            this.fechaNac_gbx.Controls.Add(this.fechaNac_dtp);
            this.fechaNac_gbx.Controls.Add(this.label3);
            this.fechaNac_gbx.Location = new System.Drawing.Point(6, 72);
            this.fechaNac_gbx.Name = "fechaNac_gbx";
            this.fechaNac_gbx.Size = new System.Drawing.Size(302, 47);
            this.fechaNac_gbx.TabIndex = 6;
            this.fechaNac_gbx.TabStop = false;
            this.fechaNac_gbx.Text = "Fecha de Nacimiento";
            // 
            // fechaNac_dtp
            // 
            this.fechaNac_dtp.Location = new System.Drawing.Point(89, 21);
            this.fechaNac_dtp.Name = "fechaNac_dtp";
            this.fechaNac_dtp.Size = new System.Drawing.Size(200, 20);
            this.fechaNac_dtp.TabIndex = 1;
            this.fechaNac_dtp.Value = new System.DateTime(2014, 11, 5, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Antes de:";
            // 
            // handicap_gbx
            // 
            this.handicap_gbx.Controls.Add(this.handHasta_nud);
            this.handicap_gbx.Controls.Add(this.label4);
            this.handicap_gbx.Controls.Add(this.handDesde_nud);
            this.handicap_gbx.Controls.Add(this.label1);
            this.handicap_gbx.Location = new System.Drawing.Point(6, 125);
            this.handicap_gbx.Name = "handicap_gbx";
            this.handicap_gbx.Size = new System.Drawing.Size(301, 47);
            this.handicap_gbx.TabIndex = 7;
            this.handicap_gbx.TabStop = false;
            this.handicap_gbx.Text = "Hándicap";
            // 
            // handHasta_nud
            // 
            this.handHasta_nud.Location = new System.Drawing.Point(222, 19);
            this.handHasta_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.handHasta_nud.Name = "handHasta_nud";
            this.handHasta_nud.ReadOnly = true;
            this.handHasta_nud.Size = new System.Drawing.Size(47, 20);
            this.handHasta_nud.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta:";
            // 
            // handDesde_nud
            // 
            this.handDesde_nud.Location = new System.Drawing.Point(88, 19);
            this.handDesde_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.handDesde_nud.Name = "handDesde_nud";
            this.handDesde_nud.ReadOnly = true;
            this.handDesde_nud.Size = new System.Drawing.Size(47, 20);
            this.handDesde_nud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // promedio_gbx
            // 
            this.promedio_gbx.Controls.Add(this.promHasta_nud);
            this.promedio_gbx.Controls.Add(this.promDesde_nud);
            this.promedio_gbx.Controls.Add(this.label6);
            this.promedio_gbx.Controls.Add(this.label5);
            this.promedio_gbx.Location = new System.Drawing.Point(6, 178);
            this.promedio_gbx.Name = "promedio_gbx";
            this.promedio_gbx.Size = new System.Drawing.Size(302, 47);
            this.promedio_gbx.TabIndex = 8;
            this.promedio_gbx.TabStop = false;
            this.promedio_gbx.Text = "Promedio último partido";
            // 
            // promHasta_nud
            // 
            this.promHasta_nud.DecimalPlaces = 1;
            this.promHasta_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.promHasta_nud.Location = new System.Drawing.Point(222, 20);
            this.promHasta_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.promHasta_nud.Name = "promHasta_nud";
            this.promHasta_nud.Size = new System.Drawing.Size(60, 20);
            this.promHasta_nud.TabIndex = 9;
            // 
            // promDesde_nud
            // 
            this.promDesde_nud.DecimalPlaces = 1;
            this.promDesde_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.promDesde_nud.Location = new System.Drawing.Point(88, 20);
            this.promDesde_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.promDesde_nud.Name = "promDesde_nud";
            this.promDesde_nud.Size = new System.Drawing.Size(60, 20);
            this.promDesde_nud.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infracNo_btn);
            this.groupBox1.Controls.Add(this.infracSi_btn);
            this.groupBox1.Location = new System.Drawing.Point(5, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 47);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infracciones";
            // 
            // infracNo_btn
            // 
            this.infracNo_btn.AutoSize = true;
            this.infracNo_btn.Location = new System.Drawing.Point(182, 19);
            this.infracNo_btn.Name = "infracNo_btn";
            this.infracNo_btn.Size = new System.Drawing.Size(39, 17);
            this.infracNo_btn.TabIndex = 1;
            this.infracNo_btn.Text = "No";
            this.infracNo_btn.UseVisualStyleBackColor = true;
            this.infracNo_btn.Click += new System.EventHandler(this.infracNo_btn_Click);
            this.infracNo_btn.CheckedChanged += new System.EventHandler(this.infracNo_btn_CheckedChanged);
            // 
            // infracSi_btn
            // 
            this.infracSi_btn.AutoSize = true;
            this.infracSi_btn.Location = new System.Drawing.Point(89, 19);
            this.infracSi_btn.Name = "infracSi_btn";
            this.infracSi_btn.Size = new System.Drawing.Size(34, 17);
            this.infracSi_btn.TabIndex = 0;
            this.infracSi_btn.Text = "Si";
            this.infracSi_btn.UseVisualStyleBackColor = true;
            this.infracSi_btn.Click += new System.EventHandler(this.infracSi_btn_Click);
            this.infracSi_btn.CheckedChanged += new System.EventHandler(this.infracSi_btn_CheckedChanged);
            // 
            // criterios_gbx
            // 
            this.criterios_gbx.Controls.Add(this.dataGridView1);
            this.criterios_gbx.Controls.Add(this.groupBox1);
            this.criterios_gbx.Controls.Add(this.nombre_gbx);
            this.criterios_gbx.Controls.Add(this.promedio_gbx);
            this.criterios_gbx.Controls.Add(this.fechaNac_gbx);
            this.criterios_gbx.Controls.Add(this.handicap_gbx);
            this.criterios_gbx.Location = new System.Drawing.Point(13, 13);
            this.criterios_gbx.Name = "criterios_gbx";
            this.criterios_gbx.Size = new System.Drawing.Size(644, 285);
            this.criterios_gbx.TabIndex = 10;
            this.criterios_gbx.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(311, 259);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // BusquedaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 347);
            this.Controls.Add(this.limpiar_btn);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.criterios_gbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusquedaJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Jugadores";
            this.nombre_gbx.ResumeLayout(false);
            this.nombre_gbx.PerformLayout();
            this.fechaNac_gbx.ResumeLayout(false);
            this.fechaNac_gbx.PerformLayout();
            this.handicap_gbx.ResumeLayout(false);
            this.handicap_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handHasta_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handDesde_nud)).EndInit();
            this.promedio_gbx.ResumeLayout(false);
            this.promedio_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promHasta_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promDesde_nud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.criterios_gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Button limpiar_btn;
        private System.Windows.Forms.GroupBox nombre_gbx;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox fechaNac_gbx;
        private System.Windows.Forms.DateTimePicker fechaNac_dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox handicap_gbx;
        private System.Windows.Forms.NumericUpDown handHasta_nud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown handDesde_nud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox promedio_gbx;
        private System.Windows.Forms.NumericUpDown promHasta_nud;
        private System.Windows.Forms.NumericUpDown promDesde_nud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton infracNo_btn;
        private System.Windows.Forms.RadioButton infracSi_btn;
        private System.Windows.Forms.GroupBox criterios_gbx;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}