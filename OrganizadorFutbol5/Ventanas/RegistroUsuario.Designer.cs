namespace OrganizadorFutbol5.Ventanas
{
    partial class RegistroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.registrarme_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confContraseña_txt = new System.Windows.Forms.TextBox();
            this.contraseña_txt = new System.Windows.Forms.TextBox();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.posiciones_chk = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.edad_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mein Führer!";
            // 
            // registrarme_btn
            // 
            this.registrarme_btn.Location = new System.Drawing.Point(12, 396);
            this.registrarme_btn.Name = "registrarme_btn";
            this.registrarme_btn.Size = new System.Drawing.Size(75, 23);
            this.registrarme_btn.TabIndex = 2;
            this.registrarme_btn.Text = "Registrame!";
            this.registrarme_btn.UseVisualStyleBackColor = true;
            this.registrarme_btn.Click += new System.EventHandler(this.registrarme_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(311, 396);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 3;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.confContraseña_txt);
            this.groupBox1.Controls.Add(this.contraseña_txt);
            this.groupBox1.Controls.Add(this.usuario_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmar contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Usuario";
            // 
            // confContraseña_txt
            // 
            this.confContraseña_txt.Location = new System.Drawing.Point(136, 86);
            this.confContraseña_txt.Name = "confContraseña_txt";
            this.confContraseña_txt.Size = new System.Drawing.Size(227, 20);
            this.confContraseña_txt.TabIndex = 2;
            // 
            // contraseña_txt
            // 
            this.contraseña_txt.Location = new System.Drawing.Point(136, 60);
            this.contraseña_txt.Name = "contraseña_txt";
            this.contraseña_txt.Size = new System.Drawing.Size(227, 20);
            this.contraseña_txt.TabIndex = 1;
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(136, 33);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(227, 20);
            this.usuario_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.posiciones_chk);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.email_txt);
            this.groupBox2.Controls.Add(this.edad_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.apellido_txt);
            this.groupBox2.Controls.Add(this.nombre_txt);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Posiciones Favoritas";
            // 
            // posiciones_chk
            // 
            this.posiciones_chk.FormattingEnabled = true;
            this.posiciones_chk.Items.AddRange(new object[] {
            "Delantero",
            "Mediocampista",
            "Defensor",
            "Arquero"});
            this.posiciones_chk.Location = new System.Drawing.Point(136, 140);
            this.posiciones_chk.Name = "posiciones_chk";
            this.posiciones_chk.Size = new System.Drawing.Size(227, 64);
            this.posiciones_chk.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(136, 113);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(227, 20);
            this.email_txt.TabIndex = 6;
            // 
            // edad_txt
            // 
            this.edad_txt.Location = new System.Drawing.Point(136, 86);
            this.edad_txt.Name = "edad_txt";
            this.edad_txt.Size = new System.Drawing.Size(227, 20);
            this.edad_txt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(136, 59);
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(227, 20);
            this.apellido_txt.TabIndex = 1;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(136, 32);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(227, 20);
            this.nombre_txt.TabIndex = 0;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.registrarme_btn);
            this.Controls.Add(this.label1);
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrarme_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox confContraseña_txt;
        private System.Windows.Forms.TextBox contraseña_txt;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox edad_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox posiciones_chk;
    }
}