using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "Nombre")
                {
                    txtNombre.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    txtNombre.Text = "Nombre";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text == "")
                {
                    txtApellido.Text = "Apellido";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text == "Apellido")
                {
                    txtApellido.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    txtUsuario.Text = "Usuario";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "Usuario")
                {
                    txtUsuario.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtContrasena.Text == "Contraseña")
                {
                    txtContrasena.Text = "";
                    txtContrasena.PasswordChar = '.';
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtContrasena.Text == "")
                {
                    txtContrasena.Text = "Contraseña";
                    txtContrasena.PasswordChar = ' ';
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmar.Text == "")
                {
                    txtConfirmar.Text = "Confirmar";
                    txtConfirmar.PasswordChar = ' ';
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmar.Text == "Confirmar")
                {
                    txtConfirmar.Text = "";
                    txtConfirmar.PasswordChar = '.';
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
