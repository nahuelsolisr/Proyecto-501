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
    public partial class FrmModiBaja : Form
    {
        public FrmModiBaja()
        {
            InitializeComponent();
            Cargargrilla();
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
        public void Cargargrilla()
        {
            ConectaDB.AbrirDB();

  string Consulta = "SELECT * from persona";
            //no hace falta consultar usando TABLA.CAMPO, se puede con * porque en este caso llama a todos los campos
            ConectaDB.LecturaDB(Consulta);
            while (DB.lector.Read()) 
            {

                grilla.Rows.Add();
                //la grilla tiene una fila cuando se coloca en el formulario por eso es grilla.Rows.Count -2,
                // para que quede el dato en la primer fila(Row)
                //La grilla espera un string, por eso al final convertis el valor DB.lector["campo"].ToString()
                grilla[0, grilla.Rows.Count - 2].Value = DB.lector["DNI"].ToString();
                grilla[1, grilla.Rows.Count - 2].Value = DB.lector["apellido"].ToString();
                grilla[2, grilla.Rows.Count - 2].Value = DB.lector["Nombre"].ToString();
                grilla[3, grilla.Rows.Count - 2].Value = DB.lector["direccion"].ToString();
                grilla[4, grilla.Rows.Count - 2].Value = DB.lector["CP"].ToString();   
            }

            grilla.ClearSelection();
            DB.lector.Close();        }

        private void FrmModiBaja_Load(object sender, EventArgs e)
        {

        }
    }
}
