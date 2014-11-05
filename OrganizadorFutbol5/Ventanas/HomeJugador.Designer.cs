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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.standard = new System.Windows.Forms.RadioButton();
            this.solidaria = new System.Windows.Forms.RadioButton();
            this.condicional = new System.Windows.Forms.RadioButton();
            this.inscribirse = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscribirse});
            this.dataGridView1.Location = new System.Drawing.Point(151, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(412, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Location = new System.Drawing.Point(323, 69);
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
            this.solidaria.Location = new System.Drawing.Point(323, 92);
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
            this.condicional.Location = new System.Drawing.Point(323, 115);
            this.condicional.Name = "condicional";
            this.condicional.Size = new System.Drawing.Size(133, 17);
            this.condicional.TabIndex = 3;
            this.condicional.TabStop = true;
            this.condicional.Text = "Inscripcion condicional";
            this.condicional.UseVisualStyleBackColor = true;
            // 
            // inscribirse
            // 
            this.inscribirse.HeaderText = "Inscribirse";
            this.inscribirse.Name = "inscribirse";
            this.inscribirse.ReadOnly = true;
            // 
            // HomeJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 339);
            this.Controls.Add(this.condicional);
            this.Controls.Add(this.solidaria);
            this.Controls.Add(this.standard);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mein Führer!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeJugador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton solidaria;
        private System.Windows.Forms.RadioButton condicional;
        private System.Windows.Forms.DataGridViewButtonColumn inscribirse;
    }
}