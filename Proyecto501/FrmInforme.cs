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
    public partial class FrmInforme : Form
    {
        string nameGrupo = "";
        string final = "";

        public FrmInforme()
        {
            InitializeComponent();
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

        //CARGO EN LA GRILLA LA TRAYECTORIA DEL ALUMNO
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            v_dni();

            
            grilla_trayectoria.Rows.Clear();
            v_dni();
        }
        //HABILITAR LOS INFORMES
        private void chk_informe1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_informe1.Checked)
            {
                txt_informe1.Enabled = true;
            }
            else
            {
                txt_informe1.Enabled = false;
            }
        }
        private void chk_informe2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_informe2.Checked)
            {
                txt_informe2.Enabled = true;
            }
            else
            {
                txt_informe2.Enabled = false;
            }
        }
        private void chk_informe3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_informe3.Checked)
            {
                txt_informe3.Enabled = true;
            }
            else
            {
                txt_informe3.Enabled = false;
            }
        }
        private void chk_final_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_final.Checked)
            {
                grup_final.Visible = true;
            }
            else
            {
                grup_final.Visible = false;
            }
        }
        //MODIFICAR INFORME
        private void btn_modificarInforme_Click(object sender, EventArgs e)
        {
             ConectaDB.AbrirDB();

            if (chk_informe1.Checked)
            {
                string modificarInforme1 = "UPDATE GrupAlum set observacion1='" + txt_informe1.Text + "' where DNIAlumno=" + txt_dni.Text;
                ConectaDB.CargarDB(modificarInforme1);
            }
            if (chk_informe2.Checked)
            {
                string modificarInforme2 = "UPDATE GrupAlum set observacion2='" + txt_informe2.Text + "' where DNIAlumno=" + txt_dni.Text;
                ConectaDB.CargarDB(modificarInforme2);
            }
            if (chk_informe3.Checked)
            {
                string modificarInforme3 = "UPDATE GrupAlum set observacion3='" + txt_informe3.Text + "' where DNIAlumno=" + txt_dni.Text;
                ConectaDB.CargarDB(modificarInforme3);
            }

            ConectaDB.CerrarDB();

        }
        //SELECCIONO LOS INDICES DE LA GRILLA
        private void grilla_trayectoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_informe1.Text = grilla_trayectoria.SelectedCells[2].Value.ToString();
            txt_informe2.Text = grilla_trayectoria.SelectedCells[3].Value.ToString();
            txt_informe3.Text = grilla_trayectoria.SelectedCells[4].Value.ToString();

            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                nameGrupo = grilla_trayectoria.SelectedCells[1].Value.ToString();
            }
        }
        //AÑADIR INSTANCIA FINAL
        private void btn_añadirFinal_Click(object sender, EventArgs e)
        {
            
            if (rb_aproboNo.Checked)
            {
                final = "DESAPROBADO";
            }
            if (rb_aproboSi.Checked)
            {
                final = "APROBADO";
            }

            string modificarInforme4 = "UPDATE GrupAlum set InstanciaFinal='" + final + "' where DNIAlumno=" + txt_dni.Text;
            ConectaDB.CargarDB(modificarInforme4);

        }


        //VALIDACION DE ESPACIOS

        public bool v_dni()
        {
            bool ok = true;
            if (txt_dni.Text == "")
            {
                errorProvider1.SetError(txt_dni, "  Ingresa algo");
            }
            else
            {
                ConectaDB.AbrirDB();
                string consulta2 = "SELECT Grupo.fechaAlta, Grupo.NombreGrupo, GrupAlum.observacion1, GrupAlum.observacion2, GrupAlum.observacion3, GrupAlum.InstanciaFinal FROM Grupo INNER JOIN (Alumno INNER JOIN GrupAlum ON Alumno.DNI = GrupAlum.DNIAlumno) ON Grupo.codGrup = GrupAlum.codGrup WHERE Alumno.DNI=" + txt_dni.Text + "";
                ConectaDB.LecturaDB(consulta2);
                while (DB.lector.Read())
                {
                    grilla_trayectoria.Rows.Add();
                    grilla_trayectoria[0, grilla_trayectoria.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                    grilla_trayectoria[1, grilla_trayectoria.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();
                    grilla_trayectoria[2, grilla_trayectoria.Rows.Count - 2].Value = DB.lector["observacion1"].ToString();
                    grilla_trayectoria[3, grilla_trayectoria.Rows.Count - 2].Value = DB.lector["observacion2"].ToString();
                    grilla_trayectoria[4, grilla_trayectoria.Rows.Count - 2].Value = DB.lector["observacion3"].ToString();
                    grilla_trayectoria[5, grilla_trayectoria.Rows.Count - 2].Value = DB.lector["InstanciaFinal"].ToString();

                }

                grilla_trayectoria.ClearSelection();
                DB.lector.Close();

                grilla_trayectoria.Enabled = true;
                groupBox2.Enabled = true;
            }

            return ok;
        }

        //VALIDACION KEYPRESS DNI
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_dni, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
    }
}
