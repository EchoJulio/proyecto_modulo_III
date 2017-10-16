namespace WindowsFormsApp1
{
    partial class FrmRegistro
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(41, 422);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(227, 50);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.Window;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtContrasena.Location = new System.Drawing.Point(41, 254);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(230, 23);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
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
            this.label2.Size = new System.Drawing.Size(306, 103);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registrar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(267, -3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(46, 36);
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.Text = "x";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 28;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Gray;
            this.txtApellido.Location = new System.Drawing.Point(41, 166);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(230, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 24);
            this.label3.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(41, 125);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 32;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(41, 208);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 34;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmar.Location = new System.Drawing.Point(41, 301);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(228, 23);
            this.txtConfirmar.TabIndex = 5;
            this.txtConfirmar.Text = "Confirmar";
            this.txtConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmar.Enter += new System.EventHandler(this.txtConfirmar_Enter);
            this.txtConfirmar.Leave += new System.EventHandler(this.txtConfirmar_Leave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 24);
            this.label6.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmpresa);
            this.groupBox1.Controls.Add(this.rbEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(41, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 56);
            this.groupBox1.TabIndex = 37;
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
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmRegistro_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbEmpleado;
    }
}