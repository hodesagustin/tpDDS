namespace OrganizadorFutbol5.Ventanas
{
    partial class HomeJugador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inscribirse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.standard = new System.Windows.Forms.RadioButton();
            this.solidaria = new System.Windows.Forms.RadioButton();
            this.condicional = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.proponer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listBoxAmigos = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCalificaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCalificacionesPendientes = new System.Windows.Forms.DataGridView();
            this.calificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listBoxAmigosParaReemplazo = new System.Windows.Forms.ListBox();
            this.dataGridViewBaja = new System.Windows.Forms.DataGridView();
            this.proponerReemplazo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bajaSinReemplazo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificacionesPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaja)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscribirse});
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(505, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inscribirse
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = "Inscribirse";
            this.inscribirse.DefaultCellStyle = dataGridViewCellStyle10;
            this.inscribirse.HeaderText = "Inscribirse";
            this.inscribirse.Name = "inscribirse";
            this.inscribirse.ReadOnly = true;
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Location = new System.Drawing.Point(19, 15);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(120, 17);
            this.standard.TabIndex = 1;
            this.standard.TabStop = true;
            this.standard.Text = "Inscripcion standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // solidaria
            // 
            this.solidaria.AutoSize = true;
            this.solidaria.Location = new System.Drawing.Point(19, 38);
            this.solidaria.Name = "solidaria";
            this.solidaria.Size = new System.Drawing.Size(117, 17);
            this.solidaria.TabIndex = 2;
            this.solidaria.TabStop = true;
            this.solidaria.Text = "Inscripcion solidaria";
            this.solidaria.UseVisualStyleBackColor = true;
            // 
            // condicional
            // 
            this.condicional.AutoSize = true;
            this.condicional.Location = new System.Drawing.Point(19, 61);
            this.condicional.Name = "condicional";
            this.condicional.Size = new System.Drawing.Size(133, 17);
            this.condicional.TabIndex = 3;
            this.condicional.TabStop = true;
            this.condicional.Text = "Inscripcion condicional";
            this.condicional.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 328);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 140);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inscripcción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.listBoxAmigos);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(556, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proponer amigo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proponer});
            this.dataGridView2.Location = new System.Drawing.Point(6, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(355, 186);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // proponer
            // 
            this.proponer.HeaderText = "Proponer amigo para este partido";
            this.proponer.Name = "proponer";
            this.proponer.ReadOnly = true;
            // 
            // listBoxAmigos
            // 
            this.listBoxAmigos.FormattingEnabled = true;
            this.listBoxAmigos.Location = new System.Drawing.Point(20, 42);
            this.listBoxAmigos.Name = "listBoxAmigos";
            this.listBoxAmigos.Size = new System.Drawing.Size(128, 186);
            this.listBoxAmigos.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(556, 302);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Calificar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCalificaciones);
            this.groupBox2.Location = new System.Drawing.Point(276, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 282);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calificaciones Realizadas";
            // 
            // dataGridViewCalificaciones
            // 
            this.dataGridViewCalificaciones.AllowUserToAddRows = false;
            this.dataGridViewCalificaciones.AllowUserToDeleteRows = false;
            this.dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificaciones.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            this.dataGridViewCalificaciones.ReadOnly = true;
            this.dataGridViewCalificaciones.Size = new System.Drawing.Size(264, 257);
            this.dataGridViewCalificaciones.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCalificacionesPendientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 283);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones Pendientes";
            // 
            // dataGridViewCalificacionesPendientes
            // 
            this.dataGridViewCalificacionesPendientes.AllowUserToAddRows = false;
            this.dataGridViewCalificacionesPendientes.AllowUserToDeleteRows = false;
            this.dataGridViewCalificacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificacionesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calificar});
            this.dataGridViewCalificacionesPendientes.Location = new System.Drawing.Point(6, 101);
            this.dataGridViewCalificacionesPendientes.Name = "dataGridViewCalificacionesPendientes";
            this.dataGridViewCalificacionesPendientes.ReadOnly = true;
            this.dataGridViewCalificacionesPendientes.Size = new System.Drawing.Size(253, 175);
            this.dataGridViewCalificacionesPendientes.TabIndex = 4;
            this.dataGridViewCalificacionesPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCalificacionesPendientes_CellContentClick);
            // 
            // calificar
            // 
            this.calificar.HeaderText = "Calificar";
            this.calificar.Name = "calificar";
            this.calificar.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comentarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calificación:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 75);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(556, 302);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Darse de baja";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listBoxAmigosParaReemplazo
            // 
            this.listBoxAmigosParaReemplazo.FormattingEnabled = true;
            this.listBoxAmigosParaReemplazo.Location = new System.Drawing.Point(49, 19);
            this.listBoxAmigosParaReemplazo.Name = "listBoxAmigosParaReemplazo";
            this.listBoxAmigosParaReemplazo.Size = new System.Drawing.Size(128, 186);
            this.listBoxAmigosParaReemplazo.TabIndex = 1;
            // 
            // dataGridViewBaja
            // 
            this.dataGridViewBaja.AllowUserToAddRows = false;
            this.dataGridViewBaja.AllowUserToDeleteRows = false;
            this.dataGridViewBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proponerReemplazo,
            this.bajaSinReemplazo});
            this.dataGridViewBaja.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewBaja.Name = "dataGridViewBaja";
            this.dataGridViewBaja.ReadOnly = true;
            this.dataGridViewBaja.Size = new System.Drawing.Size(328, 150);
            this.dataGridViewBaja.TabIndex = 0;
            this.dataGridViewBaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJugadores_CellContentClick);
            // 
            // proponerReemplazo
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = "Proponer reemplazo";
            this.proponerReemplazo.DefaultCellStyle = dataGridViewCellStyle11;
            this.proponerReemplazo.HeaderText = "Proponer reemplazo";
            this.proponerReemplazo.Name = "proponerReemplazo";
            this.proponerReemplazo.ReadOnly = true;
            this.proponerReemplazo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proponerReemplazo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bajaSinReemplazo
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = "Baja sin reemplazo";
            this.bajaSinReemplazo.DefaultCellStyle = dataGridViewCellStyle12;
            this.bajaSinReemplazo.HeaderText = "Baja sin reemplazo";
            this.bajaSinReemplazo.Name = "bajaSinReemplazo";
            this.bajaSinReemplazo.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewBaja);
            this.groupBox3.Location = new System.Drawing.Point(11, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Partidos a los que se está inscripto";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxAmigosParaReemplazo);
            this.groupBox4.Location = new System.Drawing.Point(363, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 267);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de amigos";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(8, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 235);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lista de amigos";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(168, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 235);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lista de partidos";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.condicional);
            this.groupBox7.Controls.Add(this.solidaria);
            this.groupBox7.Controls.Add(this.standard);
            this.groupBox7.Location = new System.Drawing.Point(13, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(162, 90);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tipo de inscripcción:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(17, 119);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(533, 177);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Partidos para inscribirse";
            // 
            // HomeJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 339);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mein Führer!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeJugador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificacionesPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaja)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton solidaria;
        private System.Windows.Forms.RadioButton condicional;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn proponer;
        private System.Windows.Forms.ListBox listBoxAmigos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewCalificaciones;
        private System.Windows.Forms.DataGridView dataGridViewCalificacionesPendientes;
        private System.Windows.Forms.DataGridViewButtonColumn calificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewButtonColumn inscribirse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewBaja;
        private System.Windows.Forms.DataGridViewButtonColumn proponerReemplazo;
        private System.Windows.Forms.DataGridViewButtonColumn bajaSinReemplazo;
        private System.Windows.Forms.ListBox listBoxAmigosParaReemplazo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}