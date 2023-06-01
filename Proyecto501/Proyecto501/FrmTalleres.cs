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
        public FrmTalleres()
        {
            InitializeComponent();
        }
        private Form formActivo = null;

        string codigo2;

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

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
           
            ConectaDB.AbrirDB();
            string consulta3 = "SELECt codGrup, fechaAlta, NombreGrupo from Grupo";
            ConectaDB.LecturaDB(consulta3);
            while (DB.lector.Read())
            {
                grilla_grupo.Rows.Add();
                grilla_grupo[0, grilla_grupo.Rows.Count - 2].Value = DB.lector["codGrup"].ToString();
                grilla_grupo[1, grilla_grupo.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                grilla_grupo[2, grilla_grupo.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();

            }
            DB.lector.Close();

            grilla_grupo.ClearSelection();
            DB.lector.Close();
        }

        private void btn_formacionG_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string insertFormacionG = "INSERT INTO FormacionGeneral(codGrup, asignatura) VALUES ("+ codigo2 +" , '"+ txt_asignatura.Text +"') ;  ";
            ConectaDB.CargarDB(insertFormacionG);
            ConectaDB.CerrarDB();

            txt_asignatura.Text = "";
            MessageBox.Show("Datos cargados correctamente");
        }

        private void btn_formacionL_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string insertFormacionL = "INSERT INTO FormacionLaboral(codGrup, taller) VALUES ("+ codigo2 +" , '"+ txt_taller.Text+"') ;  ";
            ConectaDB.CargarDB(insertFormacionL);
            ConectaDB.CerrarDB();
            txt_taller.Text = "";
            MessageBox.Show("Datos cargados correctamente");
        }

        private void btn_practica_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string insertPractica = "INSERT INTO PracticaProfesionalizante(codGrup, institucion) VALUES ("+ codigo2 +" , '"+ txt_institucion.Text +"') ;  ";
            ConectaDB.CargarDB(insertPractica);
            ConectaDB.CerrarDB();
            txt_institucion.Text = "";
            MessageBox.Show("Datos cargados correctamente");
        }

        private void grilla_grupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                codigo2 = grilla_grupo.SelectedCells[0].Value.ToString();
            }
        }

    }
}
