namespace Proyecto501
{
    partial class FrmAgregarTutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarTutor));
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb_localidad = new System.Windows.Forms.ComboBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ocupacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_parentesco = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_añadirtutor = new System.Windows.Forms.Button();
            this.txt_dniAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_telefono.Location = new System.Drawing.Point(613, 203);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(269, 35);
            this.txt_telefono.TabIndex = 43;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(495, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 29);
            this.label18.TabIndex = 44;
            this.label18.Text = "Telefono:";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Location = new System.Drawing.Point(614, 137);
            this.cmb_localidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Size = new System.Drawing.Size(268, 36);
            this.cmb_localidad.TabIndex = 42;
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_dni.Location = new System.Drawing.Point(191, 138);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(269, 35);
            this.txt_dni.TabIndex = 35;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(483, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Localidad:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_nombre.Location = new System.Drawing.Point(191, 199);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(269, 35);
            this.txt_nombre.TabIndex = 33;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Dirección:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_apellido.Location = new System.Drawing.Point(191, 266);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(269, 35);
            this.txt_apellido.TabIndex = 34;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "D.N.I:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_direccion.Location = new System.Drawing.Point(191, 332);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(269, 35);
            this.txt_direccion.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(80, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(256, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(520, 41);
            this.label6.TabIndex = 45;
            this.label6.Text = "No dejemos solo a ese alumno ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 41);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ingresemos tambien a su tutor! ";
            // 
            // txt_ocupacion
            // 
            this.txt_ocupacion.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_ocupacion.Location = new System.Drawing.Point(614, 335);
            this.txt_ocupacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ocupacion.Name = "txt_ocupacion";
            this.txt_ocupacion.Size = new System.Drawing.Size(269, 35);
            this.txt_ocupacion.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(474, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 29);
            this.label16.TabIndex = 49;
            this.label16.Text = "Ocupación:";
            // 
            // cmb_parentesco
            // 
            this.cmb_parentesco.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.cmb_parentesco.FormattingEnabled = true;
            this.cmb_parentesco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Hermano/a",
            "Tio/a",
            "Abuelo/a",
            "Otro"});
            this.cmb_parentesco.Location = new System.Drawing.Point(614, 266);
            this.cmb_parentesco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_parentesco.Name = "cmb_parentesco";
            this.cmb_parentesco.Size = new System.Drawing.Size(269, 36);
            this.cmb_parentesco.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(467, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 29);
            this.label20.TabIndex = 47;
            this.label20.Text = "Parentesco:";
            // 
            // btn_añadirtutor
            // 
            this.btn_añadirtutor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_añadirtutor.FlatAppearance.BorderSize = 0;
            this.btn_añadirtutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_añadirtutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_añadirtutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadirtutor.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_añadirtutor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_añadirtutor.Location = new System.Drawing.Point(680, 498);
            this.btn_añadirtutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_añadirtutor.Name = "btn_añadirtutor";
            this.btn_añadirtutor.Size = new System.Drawing.Size(284, 49);
            this.btn_añadirtutor.TabIndex = 51;
            this.btn_añadirtutor.Text = "AÑADIR TUTOR";
            this.btn_añadirtutor.UseVisualStyleBackColor = false;
            this.btn_añadirtutor.Click += new System.EventHandler(this.btn_añadirtutor_Click);
            // 
            // txt_dniAlumno
            // 
            this.txt_dniAlumno.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_dniAlumno.Location = new System.Drawing.Point(391, 511);
            this.txt_dniAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dniAlumno.Name = "txt_dniAlumno";
            this.txt_dniAlumno.Size = new System.Drawing.Size(269, 35);
            this.txt_dniAlumno.TabIndex = 52;
            this.txt_dniAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniAlumno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(226, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "D.N.I Alumno:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmAgregarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(991, 575);
            this.Controls.Add(this.txt_dniAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_añadirtutor);
            this.Controls.Add(this.txt_ocupacion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmb_parentesco);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmb_localidad);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAgregarTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarDocente";
            this.Load += new System.EventHandler(this.FrmAgregarTutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmb_localidad;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ocupacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_parentesco;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_añadirtutor;
        private System.Windows.Forms.TextBox txt_dniAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}