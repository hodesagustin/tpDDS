﻿namespace OrganizadorFutbol5.Ventanas
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
            this.inscribirse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.standard = new System.Windows.Forms.RadioButton();
            this.solidaria = new System.Windows.Forms.RadioButton();
            this.condicional = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxAmigos = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.proponer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscribirse});
            this.dataGridView1.Location = new System.Drawing.Point(129, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(412, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inscribirse
            // 
            this.inscribirse.HeaderText = "Inscribirse";
            this.inscribirse.Name = "inscribirse";
            this.inscribirse.ReadOnly = true;
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Location = new System.Drawing.Point(301, 28);
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
            this.solidaria.Location = new System.Drawing.Point(301, 51);
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
            this.condicional.Location = new System.Drawing.Point(301, 74);
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
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 328);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.condicional);
            this.tabPage1.Controls.Add(this.solidaria);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.standard);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inscripcción";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(127, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 140);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.listBoxAmigos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(556, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proponer amigo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxAmigos
            // 
            this.listBoxAmigos.FormattingEnabled = true;
            this.listBoxAmigos.Location = new System.Drawing.Point(20, 42);
            this.listBoxAmigos.Name = "listBoxAmigos";
            this.listBoxAmigos.Size = new System.Drawing.Size(128, 186);
            this.listBoxAmigos.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proponer});
            this.dataGridView2.Location = new System.Drawing.Point(271, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // proponer
            // 
            this.proponer.HeaderText = "Proponer amigo para este partido";
            this.proponer.Name = "proponer";
            this.proponer.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton solidaria;
        private System.Windows.Forms.RadioButton condicional;
        private System.Windows.Forms.DataGridViewButtonColumn inscribirse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn proponer;
        private System.Windows.Forms.ListBox listBoxAmigos;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}