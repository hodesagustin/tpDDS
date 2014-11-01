namespace OrganizadorFutbol5.Ventanas
{
    partial class VisualizarJugador
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
            this.Nombre = new System.Windows.Forms.Label();
            this.Handicap = new System.Windows.Forms.Label();
            this.PromedioUltimoPartido = new System.Windows.Forms.Label();
            this.PromedioTodos = new System.Windows.Forms.Label();
            this.FechaDeNacimiento = new System.Windows.Forms.Label();
            this.CantPartidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInfracciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfracciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(65, 54);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Handicap
            // 
            this.Handicap.AutoSize = true;
            this.Handicap.Location = new System.Drawing.Point(65, 76);
            this.Handicap.Name = "Handicap";
            this.Handicap.Size = new System.Drawing.Size(53, 13);
            this.Handicap.TabIndex = 1;
            this.Handicap.Text = "Handicap";
            // 
            // PromedioUltimoPartido
            // 
            this.PromedioUltimoPartido.AutoSize = true;
            this.PromedioUltimoPartido.Location = new System.Drawing.Point(140, 98);
            this.PromedioUltimoPartido.Name = "PromedioUltimoPartido";
            this.PromedioUltimoPartido.Size = new System.Drawing.Size(119, 13);
            this.PromedioUltimoPartido.TabIndex = 2;
            this.PromedioUltimoPartido.Text = "Promedio Último Partido";
            // 
            // PromedioTodos
            // 
            this.PromedioTodos.AutoSize = true;
            this.PromedioTodos.Location = new System.Drawing.Point(172, 120);
            this.PromedioTodos.Name = "PromedioTodos";
            this.PromedioTodos.Size = new System.Drawing.Size(151, 13);
            this.PromedioTodos.TabIndex = 3;
            this.PromedioTodos.Text = "Promedio de todos los partidos";
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.AutoSize = true;
            this.FechaDeNacimiento.Location = new System.Drawing.Point(127, 143);
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.Size = new System.Drawing.Size(106, 13);
            this.FechaDeNacimiento.TabIndex = 4;
            this.FechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // CantPartidos
            // 
            this.CantPartidos.AutoSize = true;
            this.CantPartidos.Location = new System.Drawing.Point(165, 168);
            this.CantPartidos.Name = "CantPartidos";
            this.CantPartidos.Size = new System.Drawing.Size(144, 13);
            this.CantPartidos.TabIndex = 6;
            this.CantPartidos.Text = "Cantidad de partidos jugados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Infracciones:";
            // 
            // dataGridViewInfracciones
            // 
            this.dataGridViewInfracciones.AllowUserToAddRows = false;
            this.dataGridViewInfracciones.AllowUserToDeleteRows = false;
            this.dataGridViewInfracciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfracciones.Location = new System.Drawing.Point(41, 223);
            this.dataGridViewInfracciones.Name = "dataGridViewInfracciones";
            this.dataGridViewInfracciones.ReadOnly = true;
            this.dataGridViewInfracciones.Size = new System.Drawing.Size(432, 45);
            this.dataGridViewInfracciones.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DATOS DEL JUGADOR:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad de partidos jugados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Promedio de todos los partidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Promedio Último Partido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Handicap:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre:";
            // 
            // VisualizarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewInfracciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantPartidos);
            this.Controls.Add(this.FechaDeNacimiento);
            this.Controls.Add(this.PromedioTodos);
            this.Controls.Add(this.PromedioUltimoPartido);
            this.Controls.Add(this.Handicap);
            this.Controls.Add(this.Nombre);
            this.Name = "VisualizarJugador";
            this.Text = "VisualizarJugador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfracciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Handicap;
        private System.Windows.Forms.Label PromedioUltimoPartido;
        private System.Windows.Forms.Label PromedioTodos;
        private System.Windows.Forms.Label FechaDeNacimiento;
        private System.Windows.Forms.Label CantPartidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInfracciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}