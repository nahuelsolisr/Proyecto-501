using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proyecto501
{
    public partial class FrmDarBaja : Form
    {
        public FrmDarBaja()
        {
            InitializeComponent();
            //Cargargrilla();
            CargargrillaAlumno();
            CargarGrillatutor();
            CargarGrillaDocente();
            CargarGrillaGrupos();
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
            //ConectaDB.AbrirDB();

            //string Consulta = "SELECT * from persona";
            //ConectaDB.LecturaDB(Consulta);
            //while (DB.lector.Read()) 
            //{
            //    grilla_Persona.Rows.Add();     
            //    grilla_Persona[0, grilla_Persona.Rows.Count - 2].Value = DB.lector["DNI"].ToString();
            //    grilla_Persona[1, grilla_Persona.Rows.Count - 2].Value = DB.lector["apellido"].ToString();
            //    grilla_Persona[2, grilla_Persona.Rows.Count - 2].Value = DB.lector["Nombre"].ToString();
            //    grilla_Persona[3, grilla_Persona.Rows.Count - 2].Value = DB.lector["direccion"].ToString();
            //    grilla_Persona[4, grilla_Persona.Rows.Count - 2].Value = DB.lector["CP"].ToString();   
            //}

            //grilla_Persona.ClearSelection();
            //DB.lector.Close();   
     
            
        }
        public void CargargrillaAlumno()
        {
            ConectaDB.AbrirDB();

            string consulta1 = "SELECT Persona.DNI, Persona.Nombre, Persona.Apellido, Persona.direccion, Persona.CP, Persona.Telefono, Alumno.fechaIng, Alumno.CUD, Alumno.codSedInc, Alumno.Pension, Alumno.LUE, Alumno.Obra_Soc, Alumno.Fecha_Nac, Alumno.Tutor FROM Persona Inner Join Alumno on Persona.dni  = Alumno.dni";

            ConectaDB.LecturaDB(consulta1);
            while (DB.lector.Read())
            {
                grilla_Alumno.Rows.Add();
                grilla_Alumno[0, grilla_Alumno.Rows.Count - 2].Value = DB.lector["DNI"].ToString();
                grilla_Alumno[1, grilla_Alumno.Rows.Count - 2].Value = DB.lector["nombre"].ToString();
                grilla_Alumno[2, grilla_Alumno.Rows.Count - 2].Value = DB.lector["apellido"].ToString();
                grilla_Alumno[3, grilla_Alumno.Rows.Count - 2].Value = DB.lector["Direccion"].ToString();
                grilla_Alumno[4, grilla_Alumno.Rows.Count - 2].Value = DB.lector["CP"].ToString();
                grilla_Alumno[5, grilla_Alumno.Rows.Count - 2].Value = DB.lector["Telefono"].ToString();
                grilla_Alumno[6, grilla_Alumno.Rows.Count - 2].Value = DB.lector["LUE"].ToString();
                grilla_Alumno[7, grilla_Alumno.Rows.Count - 2].Value = DB.lector["fechaIng"].ToString();
                grilla_Alumno[8, grilla_Alumno.Rows.Count - 2].Value = DB.lector["Fecha_Nac"].ToString();
                grilla_Alumno[9, grilla_Alumno.Rows.Count - 2].Value = DB.lector["Obra_Soc"].ToString();
                grilla_Alumno[10, grilla_Alumno.Rows.Count - 2].Value = DB.lector["Pension"].ToString();
                grilla_Alumno[11, grilla_Alumno.Rows.Count - 2].Value = DB.lector["Tutor"].ToString();
                grilla_Alumno[12, grilla_Alumno.Rows.Count - 2].Value = DB.lector["codSedInc"].ToString();
                grilla_Alumno[13, grilla_Alumno.Rows.Count - 2].Value = DB.lector["CUD"].ToString();
                
            }
            DB.lector.Close();

            grilla_Alumno.ClearSelection();
            DB.lector.Close();
        }

        private void grilla_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            //txt_alumnodni.Text = grilla_Persona.SelectedCells[0].Value.ToString();
            //txt_apellido.Text = grilla_Persona.SelectedCells[1].Value.ToString();
            //txt_nombre.Text = grilla_Persona.SelectedCells[2].Value.ToString();
            //txt_direccion.Text = grilla_Persona.SelectedCells[3].Value.ToString();
     
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            //int CP = localidad();

            //ConectaDB.AbrirDB();
            //string modificar = "UPDATE Persona set apellido='" + txt_apellido.Text + "', nombre='" + txt_nombre.Text + "', direccion='" + txt_direccion.Text + "', CP=" + CP + " where DNI=" + txt_alumnodni.Text;
            //ConectaDB.CargarDB(modificar);
            //MessageBox.Show("Registro modificado correctamente");
        }

        private void btn_baja_Click_1(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string baja = "DELETE * from Persona where DNI =" + txt_alumnodni.Text + "";
            ConectaDB.CargarDB(baja);
            MessageBox.Show("Registro eliminado correctamente");
        }

      


        private void grilla_Alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_alumnodni.Text = grilla_Alumno.SelectedCells[0].Value.ToString();
            txt_alumnonombre.Text = grilla_Alumno.SelectedCells[1].Value.ToString();
            txt_alumnoapellido.Text = grilla_Alumno.SelectedCells[2].Value.ToString();
            txt_alumnodireccion.Text = grilla_Alumno.SelectedCells[3].Value.ToString();
            txt_alumnolocalidad.Text = grilla_Alumno.SelectedCells[4].Value.ToString();
            txt_alumnotelefono.Text = grilla_Alumno.SelectedCells[5].Value.ToString();
            txt_lue.Text = grilla_Alumno.SelectedCells[6].Value.ToString();
            dtp_fechaingreso.Text = grilla_Alumno.SelectedCells[7].Value.ToString();
            dtp_fechanac.Text = grilla_Alumno.SelectedCells[8].Value.ToString();
            txt_os.Text = grilla_Alumno.SelectedCells[9].Value.ToString();
            txt_pension.Text = grilla_Alumno.SelectedCells[10].Value.ToString();
            txt_responsable.Text = grilla_Alumno.SelectedCells[11].Value.ToString();
            cmb_sedeinclusion.Text = grilla_Alumno.SelectedCells[12].Value.ToString();
        }

        private void btn_modificarAlumno_Click(object sender, EventArgs e)
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
            string modificarPer = "UPDATE Persona set apellido='" + txt_alumnoapellido.Text + "', nombre='" + txt_alumnonombre.Text + "', direccion='" + txt_alumnodireccion.Text + "', CP=" + txt_alumnolocalidad.Text +", Telefono='" + txt_alumnotelefono.Text + "' where DNI=" + txt_alumnodni.Text;
            ConectaDB.CargarDB(modificarPer);

            string modificarAlumno = "UPDATE Alumno set LUE=" + txt_lue.Text + ", fechaIng='" + fechaingreso + "', Fecha_Nac='" + fechanac + "', Obra_Soc='" + txt_os.Text + "', Pension='" + txt_pension.Text + "', Tutor='" + txt_responsable.Text + "', codSedInc=" + SedeInclu + ", CUD='" + cud + "' where DNI=" + txt_alumnodni.Text;
            ConectaDB.CargarDB(modificarAlumno);


            ConectaDB.CerrarDB();
        }

        private void btn_darbajaAlumno_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string bajaAlumno = "DELETE * from Alumno where DNI =" + txt_alumnodni.Text + "";
            ConectaDB.CargarDB(bajaAlumno);
            string bajaPersona = "DELETE * from Persona where DNI =" + txt_alumnodni.Text + "";
            ConectaDB.CargarDB(bajaPersona);

            ConectaDB.CerrarDB();
        }


        public void CargarGrillatutor() 
        {
            ConectaDB.AbrirDB();
            string consulta2 = "SELECT Persona.DNI, Persona.Nombre, Persona.Apellido,Persona.direccion, Persona.CP, Responsable.codParentesco, Responsable.Ocupacion FROM Persona Inner Join Responsable on Persona.dni = Responsable.dni";
            ConectaDB.LecturaDB(consulta2);
            while (DB.lector.Read())
            {
                grilla_tutor.Rows.Add();
                grilla_tutor[0, grilla_tutor.Rows.Count - 2].Value = DB.lector["DNI"].ToString();
                grilla_tutor[1, grilla_tutor.Rows.Count - 2].Value = DB.lector["nombre"].ToString();
                grilla_tutor[2, grilla_tutor.Rows.Count - 2].Value = DB.lector["apellido"].ToString();
                grilla_tutor[3, grilla_tutor.Rows.Count - 2].Value = DB.lector["Direccion"].ToString();
                grilla_tutor[4, grilla_tutor.Rows.Count - 2].Value = DB.lector["CP"].ToString();
                grilla_tutor[5, grilla_tutor.Rows.Count - 2].Value = DB.lector["codParentesco"].ToString();
                grilla_tutor[6, grilla_tutor.Rows.Count - 2].Value = DB.lector["Ocupacion"].ToString();
            }
            DB.lector.Close();

            grilla_tutor.ClearSelection();
            DB.lector.Close();
        }


        private void grilla_tutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tutordni.Text = grilla_tutor.SelectedCells[0].Value.ToString();
            txt_tutornombre.Text = grilla_tutor.SelectedCells[1].Value.ToString();
            txt_tutorapellido.Text = grilla_tutor.SelectedCells[2].Value.ToString();
            txt_tutordireccion.Text = grilla_tutor.SelectedCells[3].Value.ToString();
            txt_tutorlocalidad.Text = grilla_tutor.SelectedCells[4].Value.ToString();
            cmb_tutorparentesco.Text = grilla_tutor.SelectedCells[5].Value.ToString();
            txt_tutorocupacion.Text = grilla_tutor.SelectedCells[6].Value.ToString();
        }

        private void btn_tutormodificar_Click(object sender, EventArgs e)
        {
            int codparentesco = 0;

            if (cmb_tutorparentesco.Text == "Otro/a")
            {
                codparentesco = 0;
            }
            if (cmb_tutorparentesco.Text == "Madre")
            {
                codparentesco = 1;
            }
            if (cmb_tutorparentesco.Text == "Padre")
            {
                codparentesco = 2;
            }
            if (cmb_tutorparentesco.Text == "Hermano/a")
            {
                codparentesco = 3;
            }
            if (cmb_tutorparentesco.Text == "Tio/a")
            {
                codparentesco = 4;
            }
            if (cmb_tutorparentesco.Text == "Abuelo/a")
            {
                codparentesco = 5;
            }

            ConectaDB.AbrirDB();
            string modificarPertutor = "UPDATE Persona set apellido='" + txt_tutorapellido.Text + "', nombre='" + txt_tutornombre.Text + "', direccion='" + txt_tutordireccion.Text + "', CP=" + txt_tutorlocalidad.Text + " where DNI=" + txt_tutordni.Text;
            ConectaDB.CargarDB(modificarPertutor);
            string modificartutor = "UPDATE Responsable set codParentesco=" + codparentesco + ", Ocupacion= '" + txt_tutorocupacion.Text + "' where DNI=" + txt_tutordni.Text;
            ConectaDB.CargarDB(modificartutor);
            ConectaDB.CerrarDB();
        }

        private void btn_tutorbaja_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            //string bajaRepresAlumn = "DELETE * from RepresAlum where DNI =" + txt_tutordni.Text + "";
            //ConectaDB.CargarDB(bajaRepresAlumn);
            string bajatutor = "DELETE * from Responsable where DNI =" + txt_tutordni.Text + "";
            ConectaDB.CargarDB(bajatutor);
            string bajaPersonatutor = "DELETE * from Persona where DNI =" + txt_tutordni.Text + "";
            ConectaDB.CargarDB(bajaPersonatutor);
            ConectaDB.CerrarDB();

        }
        private void grilla_docente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dnidocente.Text = grilla_docente.SelectedCells[0].Value.ToString();
            txt_nombredocente.Text = grilla_docente.SelectedCells[1].Value.ToString();
            txt_apellidodocente.Text = grilla_docente.SelectedCells[2].Value.ToString();
            txt_direcciondocente.Text = grilla_docente.SelectedCells[3].Value.ToString();
            txt_localidaddocente.Text = grilla_docente.SelectedCells[4].Value.ToString();
            txt_legajo.Text = grilla_docente.SelectedCells[5].Value.ToString();
            txt_mail.Text = grilla_docente.SelectedCells[6].Value.ToString();
        }
 
        private void btn_docentebaja_Click(object sender, EventArgs e)
        {
          
        }
        private void btn_docentemodi_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string modificarPerDocente = "UPDATE Persona set apellido='" + txt_apellidodocente.Text + "', nombre='" + txt_nombredocente.Text + "', direccion='" + txt_direcciondocente.Text + "', CP=" + txt_localidaddocente.Text + " where DNI=" + txt_dnidocente.Text;
            ConectaDB.CargarDB(modificarPerDocente);
            string modificardocente = "UPDATE Docente set legajo=" + txt_legajo.Text + ", Mail='" + txt_mail.Text + "' where DNI=" + txt_dnidocente.Text;
            ConectaDB.CargarDB(modificardocente);
            ConectaDB.CerrarDB();

        }

        public void CargarGrillaDocente()
        {
            {
                ConectaDB.AbrirDB();

                string consultadocente = "SELECT Persona.DNI, Persona.Nombre, Persona.Apellido,Persona.direccion, Persona.CP, Docente.legajo, Docente.Mail FROM Persona Inner Join Docente on Persona.dni  = Docente.dni";

                ConectaDB.LecturaDB(consultadocente);
                while (DB.lector.Read())
                {
                    grilla_docente.Rows.Add();
                    grilla_docente[0, grilla_docente.Rows.Count - 2].Value = DB.lector["DNI"].ToString();
                    grilla_docente[1, grilla_docente.Rows.Count - 2].Value = DB.lector["nombre"].ToString();
                    grilla_docente[2, grilla_docente.Rows.Count - 2].Value = DB.lector["apellido"].ToString();
                    grilla_docente[3, grilla_docente.Rows.Count - 2].Value = DB.lector["Direccion"].ToString();
                    grilla_docente[4, grilla_docente.Rows.Count - 2].Value = DB.lector["CP"].ToString();
                    grilla_docente[5, grilla_docente.Rows.Count - 2].Value = DB.lector["legajo"].ToString();
                    grilla_docente[6, grilla_docente.Rows.Count - 2].Value = DB.lector["Mail"].ToString();
                  
                }
                DB.lector.Close();

                grilla_docente.ClearSelection();
                DB.lector.Close();
            }
        }
        public void CargarGrillaGrupos()
        {

            ConectaDB.AbrirDB();
            string consultaGrupo = "SELECt codGrup, DNIdocente, codCaract, codCiclo, fechaAlta, NombreGrupo from Grupo";
            ConectaDB.LecturaDB(consultaGrupo);
            while (DB.lector.Read())
            {
                grilla_grupos.Rows.Add();
                grilla_grupos[0, grilla_grupos.Rows.Count - 2].Value = DB.lector["codGrup"].ToString();
                grilla_grupos[1, grilla_grupos.Rows.Count - 2].Value = DB.lector["DNIdocente"].ToString();
                grilla_grupos[2, grilla_grupos.Rows.Count - 2].Value = DB.lector["codCaract"].ToString();
                grilla_grupos[3, grilla_grupos.Rows.Count - 2].Value = DB.lector["codCiclo"].ToString();
                grilla_grupos[4, grilla_grupos.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                grilla_grupos[5, grilla_grupos.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();

            }
            DB.lector.Close();

            grilla_grupos.ClearSelection();
            DB.lector.Close();
        }
    }
}
