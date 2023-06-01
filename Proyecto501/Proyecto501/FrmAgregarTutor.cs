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
    public partial class FrmAgregarTutor : Form
    {
        public FrmAgregarTutor()
        {
            InitializeComponent();
        }

        private void FrmAgregarTutor_Load(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();

            string consultaLocalidad = "SELECT nomLocalidad FROM Localidad";
            ConectaDB.LecturaDB(consultaLocalidad);
            while (DB.lector.Read())
            {
                cmb_localidad.Items.Add(DB.lector["nomLocalidad"]);


            }
            DB.lector.Close();
            
        }

        private void btn_añadirtutor_Click(object sender, EventArgs e)
        {

            int localidad = 0;

            if (cmb_localidad.Text == "Alejandro Korn")
            {
                localidad = 1864;
            }
            if (cmb_localidad.Text == "San Vicente")
            {
                localidad = 1865;
            }
            if (cmb_localidad.Text == "Guernica")
            {
                localidad = 1862;
            }
            if (cmb_localidad.Text == "Domselaar")
            {
                localidad = 1984;
            }
            if (cmb_localidad.Text == "Brandsen")
            {
                localidad = 1980;
            }

            int codparentesco = 0;

            if (cmb_parentesco.Text == "Otro/a")
            {
                codparentesco = 0;
            }
            if (cmb_parentesco.Text == "Madre")
            {
                codparentesco = 1;
            }
            if (cmb_parentesco.Text == "Padre")
            {
                codparentesco = 2;
            }
            if (cmb_parentesco.Text == "Hermano/a")
            {
                codparentesco = 3;
            }
            if (cmb_parentesco.Text == "Tio/a")
            {
                codparentesco = 4;
            }
            if (cmb_parentesco.Text == "Abuelo/a")
            {
                codparentesco = 5;
            }


            ConectaDB.AbrirDB();

            string insertPer = "INSERT INTO Persona(DNI, apellido, nombre, direccion, CP,Telefono) VALUES (' " + txt_dni.Text + " ' , ' " +
                txt_apellido.Text + " ' , ' " + txt_nombre.Text + " ' , ' " + txt_direccion.Text + "' ,  " + localidad + ", ' " + txt_telefono.Text + "' ) ; ";
            ConectaDB.CargarDB(insertPer);
            
            string insertTutor = "INSERT INTO Responsable(DNI, codParentesco, Ocupacion) VALUES (" + txt_dni.Text + " ," + codparentesco + "  ,  '" +
            txt_ocupacion.Text + " ') ; ";
            ConectaDB.CargarDB(insertTutor);
            ConectaDB.CerrarDB();

            this.Close();
        }

      
    }
}
