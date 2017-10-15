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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro Registro = new FrmRegistro();
            Registro.ShowDialog();
           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("esc");

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
