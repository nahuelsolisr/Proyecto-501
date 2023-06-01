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
    public partial class frm_personas : Form
    {
        public frm_personas()
        {
            InitializeComponent();
        }


        private Form formActivo = null;



        


        private void btn_alumno_Click(object sender, EventArgs e)
        {
           
        }


        private void FormHijo(Form FormHijo)
        {
            //if (formActivo != null) formActivo.Close();
            //formActivo = FormHijo;
            //FormHijo.TopLevel = false;
            //FormHijo.FormBorderStyle = FormBorderStyle.None;
            //FormHijo.Dock = DockStyle.Fill;
            //panel_contenedor.Controls.Add(FormHijo);
            //panel_contenedor.Tag = FormHijo;
            //FormHijo.BringToFront();
            //FormHijo.Show();

        }

        private void btn_alumno_Click_1(object sender, EventArgs e)
        {
            panel_inicio.Visible = false;
            panel_alumno.Dock = DockStyle.Fill;
            panel_alumno.Visible = true;
            

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            panel_alumno.Visible = false;
            panel_inicio.Visible = true;
            
        }

        private void btn_tutor_Click(object sender, EventArgs e)
        {
            panel_inicio.Visible = false;
            panel_tutor.Dock = DockStyle.Fill;
            panel_tutor.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_alumno.Visible = false;
            panel_inicio.Visible = true;
        }

        private void btn_volver2_Click(object sender, EventArgs e)
        {

            panel_tutor.Visible = false;
            panel_inicio.Visible = true;
        }


        private void btn_docente_Click(object sender, EventArgs e)
        {
            panel_inicio.Visible = false;
            panel_docente.Dock = DockStyle.Fill;
            panel_docente.Visible =true;
        }

        private void btn_volver3_Click(object sender, EventArgs e)
        {
            panel_docente.Visible = false;
            panel_inicio.Visible = true;
        }

       

       
        


       

        //private void txt_nombre_Enter(object sender, EventArgs e)
        //{
        //    if (txt_nombre.Text == "NOMBRE")
        //    {
        //       txt_nombre.Text = "";
        //    }
        //}

        //private void txt_nombre_Leave(object sender, EventArgs e)
        //{
        //    if (txt_nombre.Text == "")
        //  {
        //      txt_nombre.Text = "NOMBRE";

        //   }
        //}

       

        //private void txt_apellido_Enter(object sender, EventArgs e)
        //{
        //    if (txt_apellido.Text == "APELLIDO")
        //    {
        //        txt_apellido.Text = "";

        //    }
        //}

        //private void txt_apellido_Leave(object sender, EventArgs e)
        //{
        //    if (txt_apellido.Text == "")
        //    {
        //        txt_apellido.Text = "APELLIDO";

        //  }
        //}

        
    }
}

       
  

