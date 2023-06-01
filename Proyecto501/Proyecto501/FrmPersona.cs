using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto501
{
    public partial class frm_personas : Form
    {
        public frm_personas()
        {
            InitializeComponent();
        }

        private void btn_continuar_Click(object sender, EventArgs e)

            {
                string nombre = "";
                tabControl1.Visible = true;
                lbl_info.Visible = true;
                nombre = txt_nombre.Text + " " + txt_apellido.Text;
                lbl_alumno.Text = nombre;
                lbl_tutor.Text = nombre;
                lbl_docente.Text = nombre;


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

                ConectaDB.AbrirDB();
                string insertPer = "INSERT INTO Persona(DNI, apellido, nombre, direccion, CP,Telefono) VALUES (' " + txt_dni.Text + " ' , ' " +
                txt_apellido.Text + " ' , ' " + txt_nombre.Text + " ' , ' " + txt_direccion.Text + "' ,  " + localidad + ", ' " + txt_telefono.Text + "' ) ; ";
                ConectaDB.CargarDB(insertPer);

                ConectaDB.CerrarDB();
           
          
        }

        private void btn_añadiralumno_Click_1(object sender, EventArgs e)
        {

            string fechaingreso = Convert.ToString(dtp_fechaingreso.Value);
            string fechanac = Convert.ToString(dtp_fechanac.Value);
            string cud = "";
            int SedeInclu = 0;

            if (cmb_sedeinclusion.Text == "Sede")
            {
                SedeInclu = 1;
            }
            if (cmb_sedeinclusion.Text == "Inclusion")
            {
                SedeInclu = 2;
            }
            if (rb_cudsi.Checked = true) 
            {
                cud = "Sí";
            }
            if (rb_cudno.Checked = false) 
            {
                cud = "No";
            }

            ConectaDB.AbrirDB();
            //string InsertRepresAlum = "INSERT INTO RepresAlum(DNIalumno,DNIrepresentante) VALUES  ( " + txt_dni.Text + "  , '" + "" + txt_dni.Text;
            string insertAlumn = "INSERT INTO Alumno(DNI, fechaIng, CUD, Obra_Soc, LUE, Pension, Fecha_Nac, Tutor,codSedInc) VALUES ( " + txt_dni.Text + "  , '" +
                fechaingreso + "' , '" + cud + "' , '" + txt_os.Text + "' ,  " + txt_lue.Text + ",' " + txt_pension.Text + "' ,' " + fechanac + "',' " + txt_responsable.Text + "'," + SedeInclu + " ) ; ";
            ConectaDB.CargarDB(insertAlumn);
            ConectaDB.CerrarDB();


            FrmAgregarTutor FormularioAgregarTutor = new FrmAgregarTutor();
            FormularioAgregarTutor.ShowDialog();
            
        }

        private void btn_añadirtutor_Click(object sender, EventArgs e)
        {
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
            string insertTutor = "INSERT INTO Responsable(DNI, codParentesco, Ocupacion) VALUES (" + txt_dni.Text + " ," + codparentesco + "  ,  '" +
            txt_ocupacion.Text + " ') ; ";
            ConectaDB.CargarDB(insertTutor);
            ConectaDB.CerrarDB();
        }

        private void btn_añadirdocente_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string insertDocente = "INSERT INTO Docente(DNI, legajo, Mail) VALUES (" + txt_dni.Text + " ," + txt_legajo.Text + "  ,  '" +
           txt_mail.Text + " ') ; ";
            ConectaDB.CargarDB(insertDocente);
            ConectaDB.CerrarDB();
        }

        private void frm_personas_Load(object sender, EventArgs e)
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


    }
}

       
  

