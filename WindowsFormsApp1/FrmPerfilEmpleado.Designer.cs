namespace WindowsFormsApp1
{
    partial class FrmPerfilEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbLicencia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmpresa);
            this.groupBox1.Controls.Add(this.rbEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(682, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 56);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmpresa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.ForeColor = System.Drawing.Color.Gray;
            this.rbEmpresa.Location = new System.Drawing.Point(130, 22);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(87, 23);
            this.rbEmpresa.TabIndex = 40;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Checked = true;
            this.rbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmpleado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleado.ForeColor = System.Drawing.Color.Gray;
            this.rbEmpleado.Location = new System.Drawing.Point(18, 22);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(96, 23);
            this.rbEmpleado.TabIndex = 39;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmar.Location = new System.Drawing.Point(682, 316);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(228, 23);
            this.txtConfirmar.TabIndex = 43;
            this.txtConfirmar.Text = "Confirmar";
            this.txtConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 24);
            this.label6.TabIndex = 50;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(44, 46);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 23);
            this.txtCorreo.TabIndex = 39;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 48;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.Window;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.Gray;
            this.txtCedula.Location = new System.Drawing.Point(44, 82);
            this.txtCedula.MaxLength = 30;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(230, 23);
            this.txtCedula.TabIndex = 40;
            this.txtCedula.Text = "Cedula";
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 24);
            this.label3.TabIndex = 47;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.Window;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtContrasena.Location = new System.Drawing.Point(682, 269);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(230, 23);
            this.txtContrasena.TabIndex = 42;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 46;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(267, -7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(46, 36);
            this.BtnCerrar.TabIndex = 45;
            this.BtnCerrar.Text = "x";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(682, 437);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(227, 50);
            this.BtnAceptar.TabIndex = 38;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(912, 103);
            this.label2.TabIndex = 44;
            this.label2.Text = "Perfil De Empleado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCedula);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 136);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Personal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 136);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Contacto";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(44, 46);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 23);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "Correo";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(44, 82);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 40;
            this.textBox2.Text = "Cedula";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 24);
            this.label7.TabIndex = 47;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbLicencia);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(364, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 136);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otras Informaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Licencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Vehiculo";
            // 
            // rbLicencia
            // 
            this.rbLicencia.AutoSize = true;
            this.rbLicencia.Location = new System.Drawing.Point(152, 46);
            this.rbLicencia.Name = "rbLicencia";
            this.rbLicencia.Size = new System.Drawing.Size(40, 23);
            this.rbLicencia.TabIndex = 4;
            this.rbLicencia.TabStop = true;
            this.rbLicencia.Text = "Si";
            this.rbLicencia.UseVisualStyleBackColor = true;
            // 
            // FrmPerfilEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 559);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerfilEmpleado";
            this.Text = "FrmPerfil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbLicencia;
    }
}