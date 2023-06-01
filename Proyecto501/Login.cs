using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto501
{
    public partial class Login : Form
    {
      
        public bool USER2;

        public Login()
        {
            InitializeComponent();
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO")
            {
                txt_user.Text = "";
      
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "USUARIO";
         
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "CONTRASEÑA")
            {
                txt_pass.Text = "";
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "CONTRASEÑA";           
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public string user = "admin";
        public string contraseña = "admin";
        public string user2 = "invitado";
        public string contraseña2 = "invitado";

       
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            string usuario = txt_user.Text;
            string contra = txt_pass.Text;
           
                espaciosvacios();
                espaciosvacios2();

            if (user != usuario || user2 != usuario) 
            {
                errorProvider1.SetError(txt_user, "Usuario incorrecto");
            }
            if (contraseña!=contra || contraseña2 != contra)
            {
                errorProvider1.SetError(txt_pass, "Contraseña incorrecta");
            }
            if (user == usuario && contra == contraseña || user2 == usuario && contra == contraseña2) 
            {
                
                Form formulario2 = new Proyecto501_2();
                formulario2.ShowDialog();
                
                this.Close();
            }
        }
       VARIABLES Global = new VARIABLES();
        public bool espaciosvacios()
        {
            bool ok = true;
            if (txt_user.Text == "")
            {
                errorProvider1.SetError(txt_user, "Porfavor ingrese un usuario");
            }
            else
                errorProvider1.Clear();
            return ok;
        }
        public bool espaciosvacios2()
        {
            bool ok = true;
            if (txt_pass.Text == "")
            {
                errorProvider1.SetError(txt_pass, "Porfavor ingrese una contraseña");
            }
            else
                errorProvider1.Clear();
            return ok;
        }

    }
}
