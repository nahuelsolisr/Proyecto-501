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
        public FrmCursos()
        {
            InitializeComponent();
            mostrarGrillaAlumno();
            mostrarGrillaGrupo();
        }

        string DNI, Codigo;
       

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            string cmbDocente = "SELECT DNI FROM Docente";
            ConectaDB.LecturaDB(cmbDocente);
            while (DB.lector.Read())
            {
                cmb_dniDocente.Items.Add(DB.lector["DNI"]);

            }
            DB.lector.Close();
        }

       
        public void mostrarGrillaGrupo()
        {
            string consulta4 = "SELECT 1 FROM GrupAlum where DNI=1 AND codGrup =2";
   
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
       public void  mostrarGrillaAlumno()
       {
           
            ConectaDB.AbrirDB();
            string consulta2 = "SELECT Persona.DNI, Persona.Nombre, Persona.Apellido FROM Persona Inner Join Alumno on Persona.dni = Alumno.dni";
            ConectaDB.LecturaDB(consulta2);
            while (DB.lector.Read())
            {
                grilla_mostrarAlumno.Rows.Add(DB.lector["DNI"].ToString(),DB.lector["nombre"].ToString(),DB.lector["apellido"].ToString());
                
            }
            DB.lector.Close();

            grilla_mostrarAlumno.ClearSelection();
            DB.lector.Close();
        

       }

       private void grilla_mostrarAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           if(e.ColumnIndex > -1 && e.RowIndex > -1)
           {
             DNI = grilla_mostrarAlumno.SelectedCells[0].Value.ToString();
           }
       }

       private void btn_continuar_Click(object sender, EventArgs e)
       {
           ConectaDB.AbrirDB();
           string insertGrupAlum = "INSERT INTO GrupAlum(DNIAlumno, codGrup) VALUES (" + DNI + " , " + Codigo + ") ;  ";
           ConectaDB.CargarDB(insertGrupAlum);
           ConectaDB.CerrarDB();
       }

       private void grilla_grupo_CellClick(object sender, DataGridViewCellEventArgs e)
       {

           if (e.ColumnIndex > -1 && e.RowIndex > -1)
           {
               Codigo = grilla_grupo.Rows[e.RowIndex].Cells["codGrup"].Value.ToString();
           }
       }

       private void btn_crearGrupo_Click_1(object sender, EventArgs e)
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
    }
}
