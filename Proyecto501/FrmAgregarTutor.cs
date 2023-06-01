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

            v_dni();
            v_nombre();
            v_apellido();
            v_direccion();
            v_localidad();
            v_telefono();
            v_parentesco();
            v_ocupacion();
            v_dnialumno();
        }

        private void altatutor()
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

            MessageBox.Show("Responsable cargado correctamente");


            this.Close();
        }

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
          
            return ok;
        }
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
        public bool v_dnialumno()
        {
            bool ok = true;
            if (txt_dniAlumno.Text == "")
            {
                errorProvider1.SetError(txt_dniAlumno, "  Ingresa algo");
            }
            else
            {
                altatutor();
            }

            return ok;
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

        private void txt_dniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_dniAlumno, "Ingrese números");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }


    }
}
