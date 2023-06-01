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
        int localidad = 0;
        int codigoCaract =0;
    

        public frm_personas()
        {
            InitializeComponent();
            CargarComboLocalidad();
            CargaCaracterizaciones();
        }
        
        //CARGA EL COMBOBOX LOCALIDAD

        private void CargarComboLocalidad()
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

        //CARGA EL COMBOBOX CARACTERIZACIONES

        private void CargaCaracterizaciones()
        {
            ConectaDB.AbrirDB();

            string consultaCaracterizacion = "SELECT especificacion FROM Caracterizacion";
            ConectaDB.LecturaDB(consultaCaracterizacion);
            while (DB.lector.Read())
            {
                cmb_caracterizacion1.Items.Add(DB.lector["especificacion"]);
              
            }
            DB.lector.Close();
        }


        //AÑADIR PERSONA
        private void btn_continuar_Click(object sender, EventArgs e)
        {
            v_dni();
            v_nombre();
            v_apellido();
            v_direccion();
            v_localidad();
            v_telefono();
          
        }
        //AÑADIR ALUMNO
        private void btn_añadiralumno_Click_1(object sender, EventArgs e)
        {
            v_lue();
            v_os();
            v_pension();
            v_responsable();
            v_sedeinclusion();
            v_caracterizacion();  
        }
        //AÑADIR TUTOR
        private void btn_añadirtutor_Click(object sender, EventArgs e)
        {
            v_parentesco();
            v_ocupacion();
            v_dniAluRes();
        }
        //AÑADIR DOCENTE
        private void btn_añadirdocente_Click(object sender, EventArgs e)
        {
            v_legajo();
            v_mail();
        }

        //BOTON DE INFORMACION
        private void lbl_informacion_Click(object sender, EventArgs e)
        {
            lbl_msjinfo.Visible = true;
        }


        private void altapersona() 
        {
            string nombre = "";
            tabControl1.Visible = true;
            lbl_info.Visible = true;
            nombre = txt_nombre.Text + " " + txt_apellido.Text;
            lbl_alumno.Text = nombre;
            lbl_tutor.Text = nombre;
            lbl_docente.Text = nombre;

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

        private void altaalumno()
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
            if (cmb_sedeinclusion.Text == "Domicilio")
            {
                SedeInclu = 3;
            }
            if (rb_cudsi.Checked)
            {
                cud = "Sí";
            }
            if (rb_cudno.Checked)
            {
                cud = "No";
            }

            if (cmb_caracterizacion1.Text == "TEL - Trastorno especifico del desarrollo")
            {
                codigoCaract = 1;
            }

            if (cmb_caracterizacion1.Text == "SH - Sordos hipoacusicos")
            {
                codigoCaract = 2;
            }

            if (cmb_caracterizacion1.Text == "DV - Ciego y disminuidos visuales")
            {
                codigoCaract = 3;
            }

            if (cmb_caracterizacion1.Text == "DM - Discapacidad neuromotora")
            {
                codigoCaract = 4;
            }

            if (cmb_caracterizacion1.Text == "DI - Discpacidad Intelectual")
            {
                codigoCaract = 5;
            }

            if (cmb_caracterizacion1.Text == "TES-Transtornos Emocionales Severos")
            {
                codigoCaract = 6;
            }




            ConectaDB.AbrirDB();
            string insertAlumn = "INSERT INTO Alumno(DNI, fechaIng, CUD, Obra_Soc, LUE, Pension, Fecha_Nac, Tutor,codSedInc) VALUES ( " + txt_dni.Text + "  , '" +
                fechaingreso + "' , '" + cud + "' , '" + txt_os.Text + "' ,  " + txt_lue.Text + ",' " + txt_pension.Text + "' ,' " + fechanac + "',' " + txt_responsable.Text + "'," + SedeInclu + " ) ; ";
            ConectaDB.CargarDB(insertAlumn);

            string insertAlumnCaracterizacion = "INSERT INTO AlumCaract(codAlumno, codCaract) VALUES ( " + txt_dni.Text + "  , " +
                codigoCaract + " ) ; ";
            ConectaDB.CargarDB(insertAlumnCaracterizacion);



            ConectaDB.CerrarDB();

            if (chk_carga.Checked)
            {
                FrmAgregarTutor FormularioAgregarTutor = new FrmAgregarTutor();
                FormularioAgregarTutor.ShowDialog();
            }
            else
            {
            }

            MessageBox.Show("Alumno cargado correctamente");
        }

        private void altadocente() 
        {
            ConectaDB.AbrirDB();
            string insertDocente = "INSERT INTO Docente(DNI, legajo, Mail) VALUES (" + txt_dni.Text + " ," + txt_legajo.Text + "  ,  '" +
           txt_mail.Text + " ') ; ";
            ConectaDB.CargarDB(insertDocente);
            ConectaDB.CerrarDB();
        }

        private void altatutor()
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


        //VALIDAR ESPACIOS VACIOS PERSONA

        public bool v_dni()
        {
            bool ok = true;
            if (txt_dni.Text == "")
            {
                errorProvider1.SetError(txt_dni, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_nombre()
        {
            bool ok = true;
            if (txt_nombre.Text == "")
            {
                errorProvider1.SetError(txt_nombre, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_apellido()
        {
            bool ok = true;
            if (txt_apellido.Text == "")
            {
                errorProvider1.SetError(txt_apellido, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_direccion()
        {
            bool ok = true;
            if (txt_direccion.Text == "")
            {
                errorProvider1.SetError(txt_direccion, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_localidad()
        {
            bool ok = true;
            if (cmb_localidad.Text == "")
            {
                errorProvider1.SetError(cmb_localidad, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_telefono()
        {
            bool ok = true;
            if (txt_telefono.Text == "")
            {
                errorProvider1.SetError(txt_telefono, "  Ingresa algo");
            }
            else 
            {
                altapersona();
            }
            return ok;
        }

        //VALIDACION KEYPRESS PERSONA

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
               (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
               || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
               || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_apellido, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
            (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
            || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
            || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_nombre, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
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
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_telefono, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        //ESPACIOS VACIOS ALUMNO

        public bool v_lue()
        {
            bool ok = true;
            if (txt_lue.Text == "")
            {
                errorProvider1.SetError(txt_lue, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_os()
        {
            bool ok = true;
            if (txt_os.Text == "")
            {
                errorProvider1.SetError(txt_os, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_pension()
        {
            bool ok = true;
            if (txt_pension.Text == "")
            {
                errorProvider1.SetError(txt_pension, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_responsable()
        {
            bool ok = true;
            if (txt_responsable.Text == "")
            {
                errorProvider1.SetError(txt_responsable, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_sedeinclusion()
        {
            bool ok = true;
            if (cmb_sedeinclusion.Text == "")
            {
                errorProvider1.SetError(cmb_sedeinclusion, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_caracterizacion()
        {
            bool ok = true;
            if (cmb_caracterizacion1.Text == "")
            {
                errorProvider1.SetError(cmb_caracterizacion1, "  Ingresa algo");
            }
            else
            {
                altaalumno();
            }

            return ok;
        }

        //VALIDACION KEYPRESS ALUMNO

        private void txt_lue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_lue, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_responsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
                || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
                || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_responsable, "pone letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        //ESPACIOS VACIOS DOCENTE

        public bool v_legajo()
        {
            bool ok = true;
            if (txt_legajo.Text == "")
            {
                errorProvider1.SetError(txt_legajo, "  Ingresa algo");
            }
            
            return ok;
        }
        public bool v_mail()
        {
            bool ok = true;
            if (txt_mail.Text == "")
            {
                errorProvider1.SetError(txt_mail, "  Ingresa algo");
            }
                if(txt_mail.Text.Contains("@") == false)
                {
                     errorProvider1.SetError(txt_mail, "No es un correo");
                }
                    if(txt_mail.Text.Contains(".") == false)
                    {
                        errorProvider1.SetError(txt_mail, "No es un correo");
                    }
            else
            {
                altadocente();
            }
                   
                
            return ok;
        }     

        //VALIDACION KEYPRESS DOCENTE

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
         (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
         || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
         || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_apellido, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_telefono, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }


        //ESPACIOS VACIOS RESPONSABLE
        public bool v_parentesco()
        {
            bool ok = true;
            if (cmb_parentesco.Text == "")
            {
                errorProvider1.SetError(cmb_parentesco, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_ocupacion()
        {
            bool ok = true;
            if (txt_ocupacion.Text == "")
            {
                errorProvider1.SetError(txt_ocupacion, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_dniAluRes()
        {
            bool ok = true;
            if (txt_dniAluRes.Text == "")
            {
                errorProvider1.SetError(txt_dniAluRes, "  Ingresa algo");
            }
            else
            {
                altatutor();
            }

            return ok;
        }

        //VALIDACION KEYPRESS RESPONSABLE

        private void txt_dniAluRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_dniAluRes, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void frm_personas_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtp_fechaingreso_ValueChanged(object sender, EventArgs e)
        {

        }

       

     
    }
}

       
  

