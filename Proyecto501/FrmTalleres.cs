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
    public partial class FrmTalleres : Form
    {
        string codigo2;

        public FrmTalleres()
        {
            InitializeComponent();
            GrillaGrupo();
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

        //CARGO GRILLA GRUPO
        private void GrillaGrupo()
        {
            ConectaDB.AbrirDB();
            string consulta3 = "SELECT codGrup, fechaAlta, NombreGrupo, ciclo from Grupo inner join Ciclo on Grupo.codCiclo=Ciclo.codCiclo";
            ConectaDB.LecturaDB(consulta3);

            while (DB.lector.Read())
            {
                grilla_grupo.Rows.Add();
                grilla_grupo[0, grilla_grupo.Rows.Count - 2].Value = DB.lector["codGrup"].ToString();
                grilla_grupo[1, grilla_grupo.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                grilla_grupo[2, grilla_grupo.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();
                grilla_grupo[3, grilla_grupo.Rows.Count - 2].Value = DB.lector["ciclo"].ToString();

            }
            grilla_grupo.ClearSelection();
            DB.lector.Close();
        }
       
        //AÑADIR FORMACION GENERAL

        private void btn_formacionG_Click_1(object sender, EventArgs e)
        {
            v_asignatura();
            v_contactoG();
        }

        //AÑADIR FORMACION LABORAL
        private void btn_formacionL_Click_1(object sender, EventArgs e)
        {
            v_taller();
            v_contactoL();
        }

        //AÑADIR PRACTICA PROFESIONALIZANTE

        private void btn_practica_Click_1(object sender, EventArgs e)
        {
            v_institucion();
            v_contactoP();
        }

        //SELECCIONA LA COLUMNA Y LA FILA Y LO GUARDA EN LA VARIABLE CODIGO 2

        private void grilla_grupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                codigo2 = grilla_grupo.SelectedCells[0].Value.ToString();
            }
        }

        //VALIDACION DE ESPACIOS VACIOS
        public bool v_asignatura()
        {
            bool ok = true;
            if (txt_asignatura.Text == "")
            {
                errorProvider1.SetError(txt_asignatura, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_contactoG()
        {
            bool ok = true;
            if (txt_contacto.Text == "")
            {
                errorProvider1.SetError(txt_contacto, "  Ingresa algo");
            }
            else
            {
                ConectaDB.AbrirDB();
                string insertFormacionG = "INSERT INTO FormacionGeneral(codGrup, asignatura, Telefono) VALUES (" + codigo2 + " , '" + txt_asignatura.Text + "' , " + txt_contacto.Text + " ) ;  ";
                ConectaDB.CargarDB(insertFormacionG);
                ConectaDB.CerrarDB();


                txt_asignatura.Text = "";
                txt_contacto.Text = "";
                MessageBox.Show("Datos cargados correctamente");
            }

            return ok;
        }
        //VALIDACION KEYPRESS
        private void txt_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_contacto, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }



        //VALIDACION DE ESPACIOS VACIOS 
        public bool v_taller()
        {
            bool ok = true;
            if (txt_taller.Text == "")
            {
                errorProvider1.SetError(txt_taller, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_contactoL()
        {
            bool ok = true;
            if (txt_contactoL.Text == "")
            {
                errorProvider1.SetError(txt_contactoL, "  Ingresa algo");
            }
            else
            {
                ConectaDB.AbrirDB();
                string insertFormacionL = "INSERT INTO FormacionLaboral(codGrup, taller, Telefono) VALUES (" + codigo2 + " , '" + txt_taller.Text + "' , " + txt_contactoL.Text + ") ;  ";
                ConectaDB.CargarDB(insertFormacionL);
                ConectaDB.CerrarDB();

                txt_taller.Text = "";
                txt_contactoL.Text = "";

                MessageBox.Show("Datos cargados correctamente");
            }

            return ok;
        }
        //VALIDACION KEYPRESS
        private void txt_contactoL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_contactoL, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }




        //VALIDACION DE ESPACIOS VACIOS 
        public bool v_institucion()
        {
            bool ok = true;
            if (txt_institucion.Text == "")
            {
                errorProvider1.SetError(txt_institucion, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_contactoP()
        {
            bool ok = true;
            if (txt_contactoP.Text == "")
            {
                errorProvider1.SetError(txt_contactoP, "  Ingresa algo");
            }
            else
            {
                ConectaDB.AbrirDB();
                string insertPractica = "INSERT INTO PracticaProfesionalizante(codGrup, institucion, Telefono) VALUES (" + codigo2 + " , '" + txt_institucion.Text + "' , " + txt_contactoP.Text + ") ;  ";
                ConectaDB.CargarDB(insertPractica);
                ConectaDB.CerrarDB();
                txt_contactoP.Text = "";
                txt_institucion.Text = "";
                MessageBox.Show("Datos cargados correctamente");
            }

            return ok;
        }
        //VALIDACION KEYPRESS
        private void txt_contactoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_contactoP, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

    }
}
