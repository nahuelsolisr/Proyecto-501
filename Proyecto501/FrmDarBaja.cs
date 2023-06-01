using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto501
{
    public partial class FrmDarBaja : Form
    {
        VARIABLES Global = new VARIABLES();
        public bool usuario2;
        string CODIGO = "";
        int SELECCION = 0;
        public FrmDarBaja()
        {
            
            InitializeComponent();
            //modificar();
            CargarGrillaAlumno();
            CargarGrillaTutor();
            CargarGrillaDocente();
            CargarGrillaGrupoFG();
            CargarGrillaGrupoFL();
            CargarGrillaGrupoPP();
            

        }
        //private void modificar()
        //{
        //    if (usuario2 == false)
        //    {
        //        groupBox2.Enabled = false;
        //        grup.Enabled = false;
        //        groupBox1.Enabled = false;
        //        groupBox3.Enabled = false;
        //    }
        //    if (usuario2 == true)
        //    {
        //        groupBox2.Enabled = true;
        //        grup.Enabled = true;
        //        groupBox1.Enabled = true;
        //        groupBox3.Enabled = true;
        //    }
        //}
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

        //CARGA GRILLA ALUMNO
        public void CargarGrillaAlumno()
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
            grilla_Alumno.ClearSelection();
            DB.lector.Close();
        }
        //MODIFICAR ALUMNO
        private void btn_modificarAlumno_Click(object sender, EventArgs e)
        {
            v_apellidoalumno();
            v_direccionalumno();
            v_dnialumno();
            v_localidadalumno();
            v_lue();
            v_nombrealumno();
            v_os();
            v_pension();
            v_responsable();
            v_telefonoalumno();
            v_sedeinclusion();
            
    
        }
        //DAR BAJA ALUMNO
        private void btn_darbajaAlumno_Click(object sender, EventArgs e)
        {
            BajaAlum();
        }
        //GRILLA CONTENT ALUMNO
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
            Thread.Sleep(500);
        }



        //CARGA GRILLA TUTOR
        public void CargarGrillaTutor()
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

            grilla_tutor.ClearSelection();
            DB.lector.Close();
        }
        //MODIFICAR TUTOR
        private void btn_tutormodificar_Click(object sender, EventArgs e)
        {
            v_dnitutor();
            v_nombretutor();
            v_apellidotutor();
            v_direccionatutor();
            v_localidadtutor();
            v_parentescotutor();
            v_localidadresponsable();
        }
        //DAR DE BAJA TUTOR
        private void btn_tutorbaja_Click(object sender, EventArgs e)
        {
            BajaResponsable();   
        }
        public bool v_dnitutor()
        {
            bool ok = true;
            if (txt_tutordni.Text == "")
            {
                errorProvider1.SetError(txt_tutordni, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_nombretutor()
        {
            bool ok = true;
            if (txt_tutornombre.Text == "")
            {
                errorProvider1.SetError(txt_tutornombre, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_apellidotutor()
        {
            bool ok = true;
            if (txt_tutorapellido.Text == "")
            {
                errorProvider1.SetError(txt_tutorapellido, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_direccionatutor()
        {
            bool ok = true;
            if (txt_tutordireccion.Text == "")
            {
                errorProvider1.SetError(txt_tutordireccion, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_localidadtutor()
        {
            bool ok = true;
            if (txt_tutorlocalidad.Text == "")
            {
                errorProvider1.SetError(txt_tutorlocalidad, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_parentescotutor()
        {
            bool ok = true;
            if (cmb_tutorparentesco.Text == "")
            {
                errorProvider1.SetError(cmb_tutorparentesco, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_localidadresponsable()
        {
            bool ok = true;
            if (txt_tutorocupacion.Text == "")
            {
                errorProvider1.SetError(txt_tutorocupacion, "  Ingresa algo");
            }
            else
            {
                ModResponsable();
            }

            return ok;
        }
        public bool vb_localidadresponsable()
        {
            bool ok = true;
            if (txt_tutorocupacion.Text == "")
            {
                errorProvider1.SetError(txt_tutorocupacion, "  Ingresa algo");
            }
            else
            {
                BajaResponsable();
            }

            return ok;
        }
        //GRILLA CONTENT TUTOR
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


        //CARGA GRILLA DOCENTE
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
                grilla_docente.ClearSelection();
                DB.lector.Close();
            }
        }
        //MODIFICAR DOCENTE
        private void btn_docentemodi_Click(object sender, EventArgs e)
        {
            v_dnidocente();
            v_nombredocente();
            v_apellidodocente();
            v_localidaddocente();
            v_direcciondocente();
            v_legajodocente();
            v_mail();

        }
        //DAR BAJA DOCENTE
        private void btn_docentebaja_Click(object sender, EventArgs e)
        {
            BajaDocente();
        }
        //GRILLA CONTENT DOCENTE
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


        //CARGA GRILLA GRUPOS
        public void CargarGrillaGrupoFG()
        {
            ConectaDB.AbrirDB();
            string consultaGrupo1 = "SELECT FormacionGeneral.codGrup, FormacionGeneral.asignatura, FormacionGeneral.Telefono, DNIdocente, codCaract, codCiclo, fechaAlta, NombreGrupo from FormacionGeneral inner join Grupo on FormacionGeneral.codGrup=Grupo.codGrup";
            ConectaDB.LecturaDB(consultaGrupo1);
            while (DB.lector.Read())
            {
                grilla_grupos.Rows.Add();
                grilla_grupos[0, grilla_grupos.Rows.Count - 2].Value = DB.lector["codGrup"].ToString();
                grilla_grupos[1, grilla_grupos.Rows.Count - 2].Value = DB.lector["asignatura"].ToString();
                grilla_grupos[2, grilla_grupos.Rows.Count - 2].Value = DB.lector["Telefono"].ToString();
                grilla_grupos[3, grilla_grupos.Rows.Count - 2].Value = DB.lector["DNIdocente"].ToString();
                grilla_grupos[4, grilla_grupos.Rows.Count - 2].Value = DB.lector["codCaract"].ToString();
                grilla_grupos[5, grilla_grupos.Rows.Count - 2].Value = DB.lector["codCiclo"].ToString();
                grilla_grupos[6, grilla_grupos.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                grilla_grupos[7, grilla_grupos.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();

            }


            grilla_grupos.ClearSelection();
            DB.lector.Close();
        }
        public void CargarGrillaGrupoFL()
        {
            ConectaDB.AbrirDB();
            string consultaGrupo2 = "SELECT FormacionLaboral.codGrup, FormacionLaboral.taller, FormacionLaboral.Telefono, DNIdocente, codCaract, codCiclo, fechaAlta, NombreGrupo from FormacionLaboral inner join Grupo on FormacionLaboral.codGrup=Grupo.codGrup";
            ConectaDB.LecturaDB(consultaGrupo2);
            while (DB.lector.Read())
            {
                Grilla_grupos2.Rows.Add();
                Grilla_grupos2[0, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["codGrup"].ToString();
                Grilla_grupos2[1, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["Taller"].ToString();
                Grilla_grupos2[2, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["Telefono"].ToString();
                Grilla_grupos2[3, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["DNIdocente"].ToString();
                Grilla_grupos2[4, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["codCaract"].ToString();
                Grilla_grupos2[5, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["codCiclo"].ToString();
                Grilla_grupos2[6, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                Grilla_grupos2[7, Grilla_grupos2.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();

            }
            Grilla_grupos2.ClearSelection();
            DB.lector.Close();
        }
        public void CargarGrillaGrupoPP()
        {
            ConectaDB.AbrirDB();
            string consultaGrupo3 = "SELECT PracticaProfesionalizante.codGrup, PracticaProfesionalizante.institucion, PracticaProfesionalizante.Telefono, DNIdocente, codCaract, codCiclo, fechaAlta, NombreGrupo from PracticaProfesionalizante inner join Grupo on PracticaProfesionalizante.codGrup=Grupo.codGrup";
            ConectaDB.LecturaDB(consultaGrupo3);
            while (DB.lector.Read())
            {
                grilla_grupos3.Rows.Add();
                grilla_grupos3[0, grilla_grupos3.Rows.Count - 2].Value = DB.lector["codGrup"].ToString();
                grilla_grupos3[1, grilla_grupos3.Rows.Count - 2].Value = DB.lector["Institucion"].ToString();
                grilla_grupos3[2, grilla_grupos3.Rows.Count - 2].Value = DB.lector["Telefono"].ToString();
                grilla_grupos3[3, grilla_grupos3.Rows.Count - 2].Value = DB.lector["DNIdocente"].ToString();
                grilla_grupos3[4, grilla_grupos3.Rows.Count - 2].Value = DB.lector["codCaract"].ToString();
                grilla_grupos3[5, grilla_grupos3.Rows.Count - 2].Value = DB.lector["codCiclo"].ToString();
                grilla_grupos3[6, grilla_grupos3.Rows.Count - 2].Value = DB.lector["fechaAlta"].ToString();
                grilla_grupos3[7, grilla_grupos3.Rows.Count - 2].Value = DB.lector["NombreGrupo"].ToString();

            }
            grilla_grupos3.ClearSelection();
            DB.lector.Close();
        }
  
        //ALTA DE MODIFICACIONES
        private void BajaAlum()
        {
            v2_dnialumno();
        }
        private void ModAlum()
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
            if (rb_cudsi.Checked)
            {
                cud = "Sí";
            }
            if (rb_cudno.Checked)
            {
                cud = "No";
            }

            ConectaDB.AbrirDB();
            string modificarPer = "UPDATE Persona set apellido='" + txt_alumnoapellido.Text + "', nombre='" + txt_alumnonombre.Text + "', direccion='" + txt_alumnodireccion.Text + "', CP=" + txt_alumnolocalidad.Text + ", Telefono='" + txt_alumnotelefono.Text + "' where DNI=" + txt_alumnodni.Text;
            ConectaDB.CargarDB(modificarPer);

            string modificarAlumno = "UPDATE Alumno set LUE=" + txt_lue.Text + ", fechaIng='" + fechaingreso + "', Fecha_Nac='" + fechanac + "', Obra_Soc='" + txt_os.Text + "', Pension='" + txt_pension.Text + "', Tutor='" + txt_responsable.Text + "', codSedInc=" + SedeInclu + ", CUD='" + cud + "' where DNI=" + txt_alumnodni.Text;
            ConectaDB.CargarDB(modificarAlumno);

            grilla_Alumno.Rows.Clear();
            CargarGrillaAlumno();
            ConectaDB.CerrarDB();
            
        }
        private void ModDocente() 
        {
            ConectaDB.AbrirDB();
            string modificarPerDocente = "UPDATE Persona set apellido='" + txt_apellidodocente.Text + "', nombre='" + txt_nombredocente.Text + "', direccion='" + txt_direcciondocente.Text + "', CP=" + txt_localidaddocente.Text + " where DNI=" + txt_dnidocente.Text;
            ConectaDB.CargarDB(modificarPerDocente);
            string modificardocente = "UPDATE Docente set legajo=" + txt_legajo.Text + ", Mail='" + txt_mail.Text + "' where DNI=" + txt_dnidocente.Text;
            ConectaDB.CargarDB(modificardocente);
            ConectaDB.CerrarDB();

            grilla_docente.Rows.Clear();
            CargarGrillaDocente();
            
        }
        private void BajaDocente()
        {
            v2_dnidocente();
        }
        private void ModResponsable() 
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
            grilla_tutor.Rows.Clear();
            CargarGrillaTutor();
        }
        private void BajaResponsable() 
        {
            v2_bajatutor();
        }

        //VALIDAR ESPACIOS VACIOS ALUMNO

        public bool v_dnialumno()
        {
            bool ok = true;
            if (txt_alumnodni.Text == "")
            {
                errorProvider1.SetError(txt_alumnodni, "  Ingresa algo");
            }
            

            return ok;
        }
        public bool v2_dnialumno()
        {
            bool ok = true;
            if (txt_alumnodni.Text == "")
            {
                errorProvider1.SetError(txt_alumnodni, "  Ingresa algo");
            }
            else
            {
                var result = MessageBox.Show("¿Estás seguro que quieres eliminar esta persona?", "Advertencia",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ConectaDB.AbrirDB();
                    string bajaGrupAlum = "DELETE * from GrupAlum where DNIAlumno =" + txt_alumnodni.Text + "";
                    ConectaDB.CargarDB(bajaGrupAlum);
                    string bajaCaract = "DELETE * from AlumCaract where codAlumno =" + txt_alumnodni.Text + "";
                    ConectaDB.CargarDB(bajaCaract);
                    string bajaAlumno = "DELETE * from Alumno where DNI =" + txt_alumnodni.Text + "";
                    ConectaDB.CargarDB(bajaAlumno);
                    string bajaPersona = "DELETE * from Persona where DNI =" + txt_alumnodni.Text + "";
                    ConectaDB.CargarDB(bajaPersona);

                    MessageBox.Show("Se ha dado de baja al Alumno" );
                }
                grilla_Alumno.Rows.Clear();
                CargarGrillaAlumno();
                ConectaDB.CerrarDB();
            }

            return ok;
        }
        public bool v_nombrealumno()
        {
            bool ok = true;
            if (txt_alumnonombre.Text == "")
            {
                errorProvider1.SetError(txt_alumnonombre, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_apellidoalumno()
        {
            bool ok = true;
            if (txt_alumnoapellido.Text == "")
            {
                errorProvider1.SetError(txt_alumnoapellido, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_direccionalumno()
        {
            bool ok = true;
            if (txt_alumnodireccion.Text == "")
            {
                errorProvider1.SetError(txt_alumnodireccion, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_localidadalumno()
        {
            bool ok = true;
            if (txt_alumnolocalidad.Text == "")
            {
                errorProvider1.SetError(txt_alumnolocalidad, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_telefonoalumno()
        {
            bool ok = true;
            if (txt_alumnotelefono.Text == "")
            {
                errorProvider1.SetError(txt_alumnotelefono, "  Ingresa algo");
            }

            return ok;
        }

        //VALIDAR ESPACIOS VACIOS RESPONSABLE

        public bool v2_bajatutor()
        {
            bool ok = true;
            if (txt_tutordni.Text == "")
            {
                errorProvider1.SetError(txt_tutordni, "  Ingresa algo");
            }
            {
                 var result = MessageBox.Show("¿Estás seguro que quieres eliminar esta persona?", "Advertencia",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                 if (result == DialogResult.Yes)
                 {
                     ConectaDB.AbrirDB();
                     string bajatutor = "DELETE * from Responsable where DNI =" + txt_tutordni.Text + "";
                     ConectaDB.CargarDB(bajatutor);
                     string bajaPersonatutor = "DELETE * from Persona where DNI =" + txt_tutordni.Text + "";
                     ConectaDB.CargarDB(bajaPersonatutor);
                     ConectaDB.CerrarDB();

                     MessageBox.Show("se ha dado de baja al tutor");
                 }

                grilla_tutor.Rows.Clear();
                CargarGrillaTutor();

            }

            return ok;
        }
       

        //VALIDAR ESPACIOS VACIOS DOCENTE

        public bool v2_dnidocente()
        {
            bool ok = true;
            if (txt_dnidocente.Text == "")
            {
                errorProvider1.SetError(txt_dnidocente, "  Ingresa algo");
            }
            else
            {
                var result = MessageBox.Show("¿Estás seguro que quieres eliminar esta persona?", "Advertencia",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ConectaDB.AbrirDB();
                    string bajatutor = "DELETE * from Docente where DNI =" + txt_dnidocente.Text + "";
                    ConectaDB.CargarDB(bajatutor);
                    string bajaPersonatutor = "DELETE * from Persona where DNI =" + txt_dnidocente.Text + "";
                    ConectaDB.CargarDB(bajaPersonatutor);
                    ConectaDB.CerrarDB();
                    MessageBox.Show("Se a dado de baja al docente");
                }
                grilla_docente.Rows.Clear();
                CargarGrillaDocente();
               
            }

            return ok;
        }
        public bool v_dnidocente()
        {
            bool ok = true;
            if (txt_dnidocente.Text == "")
            {
                errorProvider1.SetError(txt_dnidocente, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_nombredocente()
        {
            bool ok = true;
            if (txt_nombredocente.Text == "")
            {
                errorProvider1.SetError(txt_nombredocente, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_apellidodocente()
        {
            bool ok = true;
            if (txt_apellidodocente.Text == "")
            {
                errorProvider1.SetError(txt_apellidodocente, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_direcciondocente()
        {
            bool ok = true;
            if (txt_direcciondocente.Text == "")
            {
                errorProvider1.SetError(txt_direcciondocente, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_localidaddocente()
        {
            bool ok = true;
            if (txt_localidaddocente.Text == "")
            {
                errorProvider1.SetError(txt_localidaddocente, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_legajodocente()
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
            else 
            {
                ModDocente();
            }

            return ok;
        }
        public bool vb_mail()
        {
            bool ok = true;
            if (txt_mail.Text == "")
            {
                errorProvider1.SetError(txt_mail, "  Ingresa algo");
            }
            else
            {
                BajaDocente();
            }

            return ok;
        }

        //VALIDAR ESPACIOS VACIOS ALUMNO

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
            else
            {
                ModAlum();
            }

            return ok;
        }
        public bool vb_sedeinclusion()
        {
            bool ok = true;
            if (cmb_sedeinclusion.Text == "")
            {
                errorProvider1.SetError(cmb_sedeinclusion, "  Ingresa algo");
            }
           

            return ok;
        }

        //EVENTOS KEYPRESS VALIDACION

        private void txt_alumnodni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_alumnodni, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_alumnonombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
            (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
            || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
            || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_alumnonombre, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_alumnoapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
            (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
            || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
            || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_alumnoapellido, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_alumnotelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_alumnotelefono, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
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
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
           (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
           || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
           || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_responsable, "Ingrese letras");
                e.Handled = true;
                return;
            }





        }
        private void txt_tutordni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_tutordni, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_tutornombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
            (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
            || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
            || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_tutornombre, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_tutorapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
            (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
            || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
            || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_tutornombre, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_tutorlocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
            (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
            || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
            || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_tutorlocalidad, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_dnidocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_dnidocente, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_nombredocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
           (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
           || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
           || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_nombredocente, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_apellidodocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
           (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
           || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
           || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_apellidodocente, "Ingrese letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_legajo, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void grilla_grupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CODIGO = grilla_grupos.SelectedCells[0].Value.ToString();
            txt_comodin.Text = grilla_grupos.SelectedCells[1].Value.ToString();
            txt_contacto.Text = grilla_grupos.SelectedCells[2].Value.ToString();
            txt_GruposDNI.Text = grilla_grupos.SelectedCells[3].Value.ToString();
            cmb_caracterizacion.Text = grilla_grupos.SelectedCells[4].Value.ToString();
            cmb_ciclo.Text = grilla_grupos.SelectedCells[5].Value.ToString();
            dtp_fechaalta.Text = grilla_grupos.SelectedCells[6].Value.ToString();
            txt_nombreGrupo.Text = grilla_grupos.SelectedCells[7].Value.ToString();

        }

        private void Grilla_grupos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CODIGO = Grilla_grupos2.SelectedCells[0].Value.ToString();
            txt_comodin.Text = Grilla_grupos2.SelectedCells[1].Value.ToString();
            txt_contacto.Text = Grilla_grupos2.SelectedCells[2].Value.ToString();
            txt_GruposDNI.Text = Grilla_grupos2.SelectedCells[3].Value.ToString();
            cmb_caracterizacion.Text = Grilla_grupos2.SelectedCells[4].Value.ToString();
            cmb_ciclo.Text = Grilla_grupos2.SelectedCells[5].Value.ToString();
            dtp_fechaalta.Text = Grilla_grupos2.SelectedCells[6].Value.ToString();
            txt_nombreGrupo.Text = Grilla_grupos2.SelectedCells[7].Value.ToString();
        }

        private void grilla_grupos3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CODIGO = grilla_grupos3.SelectedCells[0].Value.ToString();
            txt_comodin.Text = grilla_grupos3.SelectedCells[1].Value.ToString();
            txt_contacto.Text = grilla_grupos3.SelectedCells[2].Value.ToString();
            txt_GruposDNI.Text = grilla_grupos3.SelectedCells[3].Value.ToString();
            cmb_caracterizacion.Text = grilla_grupos3.SelectedCells[4].Value.ToString();
            cmb_ciclo.Text = grilla_grupos3.SelectedCells[5].Value.ToString();
            dtp_fechaalta.Text = grilla_grupos3.SelectedCells[6].Value.ToString();
            txt_nombreGrupo.Text = grilla_grupos3.SelectedCells[7].Value.ToString();
        }

        private void btn_modigrupos_Click(object sender, EventArgs e)
        {

            int caracterizacion = 0;
            int ciclo = 0;

            if (cmb_ciclo.Text == "Ciclo único")
            {
                ciclo = 1;
            }
            if (cmb_ciclo.Text == "1° ciclo (Sede)")
            {
                ciclo = 2;
            }
            if (cmb_ciclo.Text == "2° ciclo (Sede)")
            {
                ciclo = 3;
            }
            if (cmb_ciclo.Text == "Ciclo Básico (Sede)")
            {
                ciclo = 4;
            }
            if (cmb_ciclo.Text == "Ciclo Superior")
            {
                ciclo = 5;
            }
            if (cmb_ciclo.Text == "Maternal (Inc)")
            {
                ciclo = 6;
            }
            if (cmb_ciclo.Text == "Infante (Inc)")
            {
                ciclo = 7;
            }
            if (cmb_ciclo.Text == "1°")
            {
                ciclo = 8;
            }
            if (cmb_ciclo.Text == "2°")
            {
                ciclo = 9;
            }
            if (cmb_ciclo.Text == "3°")
            {
                ciclo = 10;
            }
            if (cmb_ciclo.Text == "4°")
            {
                ciclo = 11;
            }
            if (cmb_ciclo.Text == "5°")
            {
                ciclo = 12;
            }
            if (cmb_ciclo.Text == "6°")
            {
                ciclo = 13;
            }
            if (cmb_ciclo.Text == "1° básica")
            {
                ciclo = 14;
            }
            if (cmb_ciclo.Text == "2° básica")
            {
                ciclo = 15;
            }
            if (cmb_ciclo.Text == "3° básica")
            {
                ciclo = 16;
            }
            if (cmb_ciclo.Text == "4° básica")
            {
                ciclo = 17;
            }
            if (cmb_ciclo.Text == "5° superior")
            {
                ciclo = 18;
            }
            if (cmb_ciclo.Text == "6° superior")
            {
                ciclo = 19;
            }
            if (cmb_ciclo.Text == "7° superior")
            {
                ciclo = 20;
            }


            if (cmb_caracterizacion.Text == "TEL")
            {
                caracterizacion = 1;
            }
            if (cmb_caracterizacion.Text == "SH")
            {
                caracterizacion = 2;
            }
            if (cmb_caracterizacion.Text == "DV")
            {
                caracterizacion = 3;
            }
            if (cmb_caracterizacion.Text == "DM")
            {
                caracterizacion = 4;
            }
            if (cmb_caracterizacion.Text == "DI")
            {
                caracterizacion = 5;
            }


            ConectaDB.AbrirDB();
            if (radioButton1.Checked)
            {
                string FG = "UPDATE FormacionGeneral set asignatura='" + txt_comodin.Text + "', Telefono=" + txt_contacto.Text + " where codGrup=" + CODIGO;
                ConectaDB.CargarDB(FG);
            }
            if (radioButton2.Checked)
            {
                string FL = "UPDATE FormacionLaboral set taller='" + txt_comodin.Text + "', Telefono=" + txt_contacto.Text + " where codGrup=" + CODIGO;
                ConectaDB.CargarDB(FL);
            }
            if (radioButton3.Checked)
            {
                string PP = "UPDATE PracticaProfesionalizante set institucion='" + txt_comodin.Text + "', Telefono=" + txt_contacto.Text + " where codGrup=" + CODIGO;
                ConectaDB.CargarDB(PP);
            }

            string modificarGrupos = "UPDATE Grupo set DNIdocente=" + txt_GruposDNI.Text + ", codCaract=" + caracterizacion + ", codCiclo=" + ciclo + ", fechaAlta='" + dtp_fechaalta.Text + "', NombreGrupo='" + txt_nombreGrupo.Text + "' where codGrup=" + CODIGO;
            ConectaDB.CargarDB(modificarGrupos);
            ConectaDB.CerrarDB();
            txt_contacto.Enabled = false;
            txt_comodin.Enabled = false;
            grilla_grupos.Rows.Clear();
            Grilla_grupos2.Rows.Clear();
            grilla_grupos3.Rows.Clear();
            CargarGrillaGrupoFG();
            CargarGrillaGrupoFL();
            CargarGrillaGrupoPP();

        }

        private void btn_bajagrupos_Click(object sender, EventArgs e)
        {
            
            if (txt_comodin.Text == "")
            {
                errorProvider1.SetError(lbl_verificacion, "Campos vacios");
            }
            else
            {
                var result = MessageBox.Show("¿Estás seguro que quieres eliminar esta persona?", "Advertencia",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ConectaDB.AbrirDB();
                    string bajaFG = "DELETE * from FormacionGeneral where asignatura ='" + txt_comodin.Text + "'";
                    ConectaDB.CargarDB(bajaFG);
                    string bajaFL = "DELETE * from FormacionLaboral where taller ='" + txt_comodin.Text + "'";
                    ConectaDB.CargarDB(bajaFL);
                    string bajaPP = "DELETE * from PracticaProfesionalizante where institucion ='" + txt_comodin.Text + "'";
                    ConectaDB.CargarDB(bajaPP);
                    string bajagrupos1 = "DELETE * from Grupo where NombreGrupo ='" + txt_nombreGrupo.Text + "'";
                    ConectaDB.CargarDB(bajagrupos1);
                    
                    ConectaDB.CerrarDB();
                    MessageBox.Show("Se a dado de baja al grupo");
                }
                grilla_grupos.Rows.Clear();
                Grilla_grupos2.Rows.Clear();
                grilla_grupos3.Rows.Clear();
                CargarGrillaGrupoFG();
                CargarGrillaGrupoFL();
                CargarGrillaGrupoPP();
            }

          
        }


        private void txt_GruposDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                      (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar >= 166 && e.KeyChar <= 180)
                      || (e.KeyChar >= 184 && e.KeyChar <= 209) || (e.KeyChar >= 217 && e.KeyChar <= 223)
                      || (e.KeyChar >= 238 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(lbl_verificacion, "caracteres ingresados no validos");

                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

      

        private void radioButton3_Click(object sender, EventArgs e)
        {
            txt_contacto.Enabled = true;
            txt_comodin.Enabled = true;
        }  
    }
}

