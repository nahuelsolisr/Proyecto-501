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
    public partial class FrmCursos : Form
    {
        string DNI, Codigo;
       
        public FrmCursos()
        {
            InitializeComponent();
            CargaComboDocentes();
            mostrarGrillaAlumno();
            mostrarGrillaGrupo();
        }

        //CARGO COMBOBOX CON LOS DNI DE LOS DOCENTES
        private void CargaComboDocentes()
        {
            ConectaDB.AbrirDB();
            string cmbDocente = "SELECT Persona.DNI FROM Docente inner join Persona on Docente.DNI=Persona.DNI";
            ConectaDB.LecturaDB(cmbDocente);
            while (DB.lector.Read())
            {
                cmb_dniDocente.Items.Add(DB.lector["DNI"]);

            }
            DB.lector.Close();
        }

        //CARGO GRILLA DEL GRUPO
        public void mostrarGrillaGrupo()
        {
            ConectaDB.AbrirDB();
            string consultaGrupo = "SELECT codGrup, fechaAlta, NombreGrupo, ciclo from Grupo inner join Ciclo on Grupo.codCiclo=Ciclo.codCiclo";
            ConectaDB.LecturaDB(consultaGrupo);
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
        //CREAR GRUPO
        private void btn_crearGrupo_Click_1(object sender, EventArgs e)
        {
            v_nomgrupo();
            v_docente();
            v_ciclo();
            v_caracterizacion();
 
            grilla_grupo.Rows.Clear();
            mostrarGrillaGrupo();
            
        }

        public void altagrupo()
        {
             string fechaalta = Convert.ToString(dtp_fechaalta.Value);
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
                string insertGrupo = "INSERT INTO Grupo(DNIdocente, codCaract, codCiclo, fechaAlta, NombreGrupo) VALUES (" + cmb_dniDocente.Text + " , " + caracterizacion + " , " +
                ciclo + " , '" + fechaalta + "' , '" + txt_nomgrupo.Text + "') ; ";
                ConectaDB.CargarDB(insertGrupo);
                ConectaDB.CerrarDB();
        }
        
        //CARGO GRILLA DEL ALUMNO
        public void  mostrarGrillaAlumno()
        {
            ConectaDB.AbrirDB();
            string consultaAlumno = "SELECT Persona.DNI, Persona.Nombre, Persona.Apellido FROM Persona Inner Join Alumno on Persona.dni = Alumno.dni";
            ConectaDB.LecturaDB(consultaAlumno);
            while (DB.lector.Read())
            {
                grilla_mostrarAlumno.Rows.Add(DB.lector["DNI"].ToString(),DB.lector["nombre"].ToString(),DB.lector["apellido"].ToString());
                
            }
            DB.lector.Close();

            grilla_mostrarAlumno.ClearSelection();
            DB.lector.Close();
        

        }
        //AÑADIR ALUMNOS AL GRUPO
        private void btn_agregaralum_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string insertGrupAlum = "INSERT INTO GrupAlum(DNIAlumno, codGrup) VALUES (" + DNI + " , " + Codigo + ") ;  ";
            ConectaDB.CargarDB(insertGrupAlum);
            ConectaDB.CerrarDB();
        }

 
        //SELECCIONA LA COLUMNA Y LA FILA DEL ALUMNO PARA AGREGARLO A LA VARIABLE DNI
        private void grilla_mostrarAlumno_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex > -1 && e.RowIndex > -1)
           {
               DNI = grilla_mostrarAlumno.SelectedCells[0].Value.ToString();
           }
        }

        //SELECCIONA LA COLUMNA Y LA FILA DEL GRUPO PARA AGREGARLO A LA VARIABLE CODIGO
        private void grilla_grupo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex > -1 && e.RowIndex > -1)
           {
               Codigo = grilla_grupo.Rows[e.RowIndex].Cells["codGrup"].Value.ToString();
           }
        }


        //VALIDACIONES
        public bool v_docente()
        {
            bool ok = true;
            if (cmb_dniDocente.Text=="")
            {
                errorProvider1.SetError(cmb_dniDocente, "  Ingresa algo");
            }
            return ok;
        }
        public bool v_nomgrupo()
        {
            bool ok = true;
            if (txt_nomgrupo.Text == "")
            {
                errorProvider1.SetError(txt_nomgrupo, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_ciclo()
        {
            bool ok = true;
            if (cmb_ciclo.Text == "")
            {
                errorProvider1.SetError(cmb_ciclo, "  Ingresa algo");
            }

            return ok;
        }
        public bool v_caracterizacion()
        {
            bool ok = true;
            if (cmb_caracterizacion.Text == "")
            {
                errorProvider1.SetError(cmb_caracterizacion, "  Ingresa algo");
            }
            else 
            {
                altagrupo();
            }
            return ok;
        }


    }
}
