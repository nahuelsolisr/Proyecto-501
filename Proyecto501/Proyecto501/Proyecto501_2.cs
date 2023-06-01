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
    public partial class Proyecto501_2 : Form
    {
        public Proyecto501_2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
       
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form formActivo = null;


        private void FormHijo(Form FormHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(FormHijo);
            panel_contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            //DISEÑO
            btn_cursos.BackColor = Color.SteelBlue;
            btn_persona.BackColor = Color.FromArgb(87, 140, 169);
            btn_informe.BackColor = Color.FromArgb(87, 140, 169);
            btn_talleres.BackColor = Color.FromArgb(87, 140, 169);
            btn_modibaja.BackColor = Color.FromArgb(87, 140, 169);
            //
            FormHijo(new FrmCursos());
        }

        private void Proyecto501_2_Load(object sender, EventArgs e)
        {
            t_fechahora.Start();
        }

        private void t_fechahora_Tick(object sender, EventArgs e)
        {
            t_fechahora.Enabled = true;
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btn_persona_Click(object sender, EventArgs e)
        {
            //DISEÑO  
            btn_persona.BackColor = Color.SteelBlue;
            btn_cursos.BackColor = Color.FromArgb(87, 140, 169);
            btn_informe.BackColor = Color.FromArgb(87, 140, 169);
            btn_talleres.BackColor = Color.FromArgb(87, 140, 169);
            btn_modibaja.BackColor = Color.FromArgb(87, 140, 169);
            //
            FormHijo(new frm_personas());
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            //DISEÑO
            btn_informe.BackColor = Color.SteelBlue;
            btn_cursos.BackColor = Color.FromArgb(87, 140, 169);
            btn_persona.BackColor = Color.FromArgb(87, 140, 169);
            btn_talleres.BackColor = Color.FromArgb(87, 140, 169);
            btn_modibaja.BackColor = Color.FromArgb(87, 140, 169);
            //
            FormHijo(new FrmInforme());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DISEÑO
            btn_talleres.BackColor = Color.SteelBlue;
            btn_cursos.BackColor = Color.FromArgb(87, 140, 169);
            btn_persona.BackColor = Color.FromArgb(87, 140, 169);
            btn_informe.BackColor = Color.FromArgb(87, 140, 169);
            btn_modibaja.BackColor = Color.FromArgb(87, 140, 169);
            //

            FormHijo(new FrmTalleres());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //DISEÑO
            btn_modibaja.BackColor = Color.SteelBlue;
            btn_cursos.BackColor = Color.FromArgb(87, 140, 169);
            btn_persona.BackColor = Color.FromArgb(87, 140, 169);
            btn_informe.BackColor = Color.FromArgb(87, 140, 169);
            btn_talleres.BackColor = Color.FromArgb(87, 140, 169);
            //
            FormHijo(new FrmDarBaja());
        }
   
    }
}
