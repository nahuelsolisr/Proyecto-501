﻿namespace Proyecto501
{
    partial class frm_personas
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Alumno = new System.Windows.Forms.TabPage();
            this.cmb_sedeinclusion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_fechaingreso = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_fechanac = new System.Windows.Forms.DateTimePicker();
            this.rb_cudno = new System.Windows.Forms.RadioButton();
            this.rb_cudsi = new System.Windows.Forms.RadioButton();
            this.txt_pension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.btn_añadiralumno = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_lue = new System.Windows.Forms.TextBox();
            this.lblresp = new System.Windows.Forms.Label();
            this.txt_os = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Tutor = new System.Windows.Forms.TabPage();
            this.txt_ocupacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_parentesco = new System.Windows.Forms.ComboBox();
            this.btn_añadirtutor = new System.Windows.Forms.Button();
            this.lbl_tutor = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Docente = new System.Windows.Forms.TabPage();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_añadirdocente = new System.Windows.Forms.Button();
            this.lbl_docente = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.panel_persona = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tabControl1.SuspendLayout();
            this.Alumno.SuspendLayout();
            this.Tutor.SuspendLayout();
            this.Docente.SuspendLayout();
            this.panel_persona.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.lbl_info.Location = new System.Drawing.Point(392, 262);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(245, 33);
            this.lbl_info.TabIndex = 33;
            this.lbl_info.Text = "¿Como lo vamos a sumar?";
            this.lbl_info.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Alumno);
            this.tabControl1.Controls.Add(this.Tutor);
            this.tabControl1.Controls.Add(this.Docente);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(31, 301);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 335);
            this.tabControl1.TabIndex = 35;
            this.tabControl1.Visible = false;
            // 
            // Alumno
            // 
            this.Alumno.BackColor = System.Drawing.Color.SteelBlue;
            this.Alumno.Controls.Add(this.cmb_sedeinclusion);
            this.Alumno.Controls.Add(this.label11);
            this.Alumno.Controls.Add(this.dtp_fechaingreso);
            this.Alumno.Controls.Add(this.label13);
            this.Alumno.Controls.Add(this.dtp_fechanac);
            this.Alumno.Controls.Add(this.rb_cudno);
            this.Alumno.Controls.Add(this.rb_cudsi);
            this.Alumno.Controls.Add(this.txt_pension);
            this.Alumno.Controls.Add(this.label1);
            this.Alumno.Controls.Add(this.lbl_alumno);
            this.Alumno.Controls.Add(this.btn_añadiralumno);
            this.Alumno.Controls.Add(this.label9);
            this.Alumno.Controls.Add(this.label12);
            this.Alumno.Controls.Add(this.txt_lue);
            this.Alumno.Controls.Add(this.lblresp);
            this.Alumno.Controls.Add(this.txt_os);
            this.Alumno.Controls.Add(this.label14);
            this.Alumno.Controls.Add(this.label15);
            this.Alumno.Controls.Add(this.txt_responsable);
            this.Alumno.Controls.Add(this.label17);
            this.Alumno.Location = new System.Drawing.Point(4, 32);
            this.Alumno.Name = "Alumno";
            this.Alumno.Padding = new System.Windows.Forms.Padding(3);
            this.Alumno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Alumno.Size = new System.Drawing.Size(1073, 299);
            this.Alumno.TabIndex = 1;
            this.Alumno.Text = "Alumno";
            // 
            // cmb_sedeinclusion
            // 
            this.cmb_sedeinclusion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.cmb_sedeinclusion.FormattingEnabled = true;
            this.cmb_sedeinclusion.Items.AddRange(new object[] {
            "Sede",
            "Inclusion"});
            this.cmb_sedeinclusion.Location = new System.Drawing.Point(435, 169);
            this.cmb_sedeinclusion.Name = "cmb_sedeinclusion";
            this.cmb_sedeinclusion.Size = new System.Drawing.Size(202, 31);
            this.cmb_sedeinclusion.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(369, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 23);
            this.label11.TabIndex = 70;
            this.label11.Text = "Añadir >";
            // 
            // dtp_fechaingreso
            // 
            this.dtp_fechaingreso.Location = new System.Drawing.Point(107, 123);
            this.dtp_fechaingreso.Name = "dtp_fechaingreso";
            this.dtp_fechaingreso.Size = new System.Drawing.Size(203, 30);
            this.dtp_fechaingreso.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1, 126);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 23);
            this.label13.TabIndex = 68;
            this.label13.Text = "Fecha  Ingreso:";
            // 
            // dtp_fechanac
            // 
            this.dtp_fechanac.Location = new System.Drawing.Point(107, 166);
            this.dtp_fechanac.Name = "dtp_fechanac";
            this.dtp_fechanac.Size = new System.Drawing.Size(203, 30);
            this.dtp_fechanac.TabIndex = 64;
            // 
            // rb_cudno
            // 
            this.rb_cudno.AutoSize = true;
            this.rb_cudno.Location = new System.Drawing.Point(533, 239);
            this.rb_cudno.Name = "rb_cudno";
            this.rb_cudno.Size = new System.Drawing.Size(43, 27);
            this.rb_cudno.TabIndex = 55;
            this.rb_cudno.TabStop = true;
            this.rb_cudno.Text = "No";
            this.rb_cudno.UseVisualStyleBackColor = true;
            // 
            // rb_cudsi
            // 
            this.rb_cudsi.AutoSize = true;
            this.rb_cudsi.Location = new System.Drawing.Point(475, 239);
            this.rb_cudsi.Name = "rb_cudsi";
            this.rb_cudsi.Size = new System.Drawing.Size(40, 27);
            this.rb_cudsi.TabIndex = 54;
            this.rb_cudsi.TabStop = true;
            this.rb_cudsi.Text = "Sí";
            this.rb_cudsi.UseVisualStyleBackColor = true;
            // 
            // txt_pension
            // 
            this.txt_pension.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_pension.Location = new System.Drawing.Point(435, 79);
            this.txt_pension.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pension.Name = "txt_pension";
            this.txt_pension.Size = new System.Drawing.Size(203, 30);
            this.txt_pension.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(368, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Pensión: ";
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.lbl_alumno.Location = new System.Drawing.Point(599, 12);
            this.lbl_alumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(71, 33);
            this.lbl_alumno.TabIndex = 51;
            this.lbl_alumno.Text = "=TEXT1";
            // 
            // btn_añadiralumno
            // 
            this.btn_añadiralumno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_añadiralumno.FlatAppearance.BorderSize = 0;
            this.btn_añadiralumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_añadiralumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_añadiralumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadiralumno.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_añadiralumno.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_añadiralumno.Location = new System.Drawing.Point(745, 241);
            this.btn_añadiralumno.Name = "btn_añadiralumno";
            this.btn_añadiralumno.Size = new System.Drawing.Size(213, 40);
            this.btn_añadiralumno.TabIndex = 37;
            this.btn_añadiralumno.Text = "AÑADIR ALUMNO";
            this.btn_añadiralumno.UseVisualStyleBackColor = false;
            this.btn_añadiralumno.Click += new System.EventHandler(this.btn_añadiralumno_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(69, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "LUE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label12.Location = new System.Drawing.Point(307, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(299, 33);
            this.label12.TabIndex = 50;
            this.label12.Text = "Estamos cargando los datos de: ";
            // 
            // txt_lue
            // 
            this.txt_lue.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_lue.Location = new System.Drawing.Point(107, 83);
            this.txt_lue.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lue.Name = "txt_lue";
            this.txt_lue.Size = new System.Drawing.Size(203, 30);
            this.txt_lue.TabIndex = 48;
            // 
            // lblresp
            // 
            this.lblresp.AutoSize = true;
            this.lblresp.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.lblresp.ForeColor = System.Drawing.Color.Black;
            this.lblresp.Location = new System.Drawing.Point(341, 130);
            this.lblresp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresp.Name = "lblresp";
            this.lblresp.Size = new System.Drawing.Size(93, 23);
            this.lblresp.TabIndex = 47;
            this.lblresp.Text = "Responsable:";
            // 
            // txt_os
            // 
            this.txt_os.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_os.Location = new System.Drawing.Point(109, 208);
            this.txt_os.Margin = new System.Windows.Forms.Padding(2);
            this.txt_os.Name = "txt_os";
            this.txt_os.Size = new System.Drawing.Size(203, 30);
            this.txt_os.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(431, 241);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 23);
            this.label14.TabIndex = 46;
            this.label14.Text = "CUD:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 168);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 23);
            this.label15.TabIndex = 45;
            this.label15.Text = "Fecha de Nac:";
            // 
            // txt_responsable
            // 
            this.txt_responsable.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_responsable.Location = new System.Drawing.Point(435, 126);
            this.txt_responsable.Margin = new System.Windows.Forms.Padding(2);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.Size = new System.Drawing.Size(203, 30);
            this.txt_responsable.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(19, 208);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 23);
            this.label17.TabIndex = 43;
            this.label17.Text = "Obra Social:";
            // 
            // Tutor
            // 
            this.Tutor.BackColor = System.Drawing.Color.SteelBlue;
            this.Tutor.Controls.Add(this.txt_ocupacion);
            this.Tutor.Controls.Add(this.label16);
            this.Tutor.Controls.Add(this.cmb_parentesco);
            this.Tutor.Controls.Add(this.btn_añadirtutor);
            this.Tutor.Controls.Add(this.lbl_tutor);
            this.Tutor.Controls.Add(this.label20);
            this.Tutor.Controls.Add(this.label21);
            this.Tutor.Location = new System.Drawing.Point(4, 32);
            this.Tutor.Name = "Tutor";
            this.Tutor.Padding = new System.Windows.Forms.Padding(3);
            this.Tutor.Size = new System.Drawing.Size(1073, 299);
            this.Tutor.TabIndex = 2;
            this.Tutor.Text = "Tutor";
            // 
            // txt_ocupacion
            // 
            this.txt_ocupacion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_ocupacion.Location = new System.Drawing.Point(459, 135);
            this.txt_ocupacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ocupacion.Name = "txt_ocupacion";
            this.txt_ocupacion.Size = new System.Drawing.Size(203, 30);
            this.txt_ocupacion.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(377, 138);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 23);
            this.label16.TabIndex = 43;
            this.label16.Text = "Ocupación:";
            // 
            // cmb_parentesco
            // 
            this.cmb_parentesco.FormattingEnabled = true;
            this.cmb_parentesco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Hermano/a",
            "Tio/a",
            "Abuelo/a",
            "Otro"});
            this.cmb_parentesco.Location = new System.Drawing.Point(459, 95);
            this.cmb_parentesco.Name = "cmb_parentesco";
            this.cmb_parentesco.Size = new System.Drawing.Size(203, 31);
            this.cmb_parentesco.TabIndex = 42;
            // 
            // btn_añadirtutor
            // 
            this.btn_añadirtutor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_añadirtutor.FlatAppearance.BorderSize = 0;
            this.btn_añadirtutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_añadirtutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_añadirtutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadirtutor.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_añadirtutor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_añadirtutor.Location = new System.Drawing.Point(745, 237);
            this.btn_añadirtutor.Name = "btn_añadirtutor";
            this.btn_añadirtutor.Size = new System.Drawing.Size(213, 40);
            this.btn_añadirtutor.TabIndex = 41;
            this.btn_añadirtutor.Text = "AÑADIR TUTOR";
            this.btn_añadirtutor.UseVisualStyleBackColor = false;
            this.btn_añadirtutor.Click += new System.EventHandler(this.btn_añadirtutor_Click);
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.lbl_tutor.Location = new System.Drawing.Point(599, 12);
            this.lbl_tutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(71, 33);
            this.lbl_tutor.TabIndex = 40;
            this.lbl_tutor.Text = "=TEXT1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(373, 98);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 23);
            this.label20.TabIndex = 38;
            this.label20.Text = "Parentesco:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label21.Location = new System.Drawing.Point(307, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(299, 33);
            this.label21.TabIndex = 39;
            this.label21.Text = "Estamos cargando los datos de: ";
            // 
            // Docente
            // 
            this.Docente.BackColor = System.Drawing.Color.SteelBlue;
            this.Docente.Controls.Add(this.txt_mail);
            this.Docente.Controls.Add(this.label19);
            this.Docente.Controls.Add(this.btn_añadirdocente);
            this.Docente.Controls.Add(this.lbl_docente);
            this.Docente.Controls.Add(this.label24);
            this.Docente.Controls.Add(this.label25);
            this.Docente.Controls.Add(this.txt_legajo);
            this.Docente.Location = new System.Drawing.Point(4, 32);
            this.Docente.Name = "Docente";
            this.Docente.Padding = new System.Windows.Forms.Padding(3);
            this.Docente.Size = new System.Drawing.Size(1073, 299);
            this.Docente.TabIndex = 3;
            this.Docente.Text = "Docente";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_mail.Location = new System.Drawing.Point(459, 135);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(203, 30);
            this.txt_mail.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(416, 138);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 23);
            this.label19.TabIndex = 44;
            this.label19.Text = "Mail:";
            // 
            // btn_añadirdocente
            // 
            this.btn_añadirdocente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_añadirdocente.FlatAppearance.BorderSize = 0;
            this.btn_añadirdocente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_añadirdocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_añadirdocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadirdocente.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_añadirdocente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_añadirdocente.Location = new System.Drawing.Point(745, 237);
            this.btn_añadirdocente.Name = "btn_añadirdocente";
            this.btn_añadirdocente.Size = new System.Drawing.Size(204, 40);
            this.btn_añadirdocente.TabIndex = 42;
            this.btn_añadirdocente.Text = "AÑADIR DOCENTE";
            this.btn_añadirdocente.UseVisualStyleBackColor = false;
            this.btn_añadirdocente.Click += new System.EventHandler(this.btn_añadirdocente_Click);
            // 
            // lbl_docente
            // 
            this.lbl_docente.AutoSize = true;
            this.lbl_docente.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.lbl_docente.Location = new System.Drawing.Point(599, 12);
            this.lbl_docente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_docente.Name = "lbl_docente";
            this.lbl_docente.Size = new System.Drawing.Size(71, 33);
            this.lbl_docente.TabIndex = 41;
            this.lbl_docente.Text = "=TEXT1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(402, 99);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 23);
            this.label24.TabIndex = 39;
            this.label24.Text = "Legajo:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label25.Location = new System.Drawing.Point(307, 11);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(299, 33);
            this.label25.TabIndex = 40;
            this.label25.Text = "Estamos cargando los datos de: ";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_legajo.Location = new System.Drawing.Point(459, 95);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(203, 30);
            this.txt_legajo.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(647, 33);
            this.label6.TabIndex = 30;
            this.label6.Text = "Parece que alguien nuevo se sumo a la Escuela ¡Vamos a hacerlo parte!";
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_continuar.FlatAppearance.BorderSize = 0;
            this.btn_continuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_continuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_continuar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_continuar.Location = new System.Drawing.Point(768, 200);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(213, 40);
            this.btn_continuar.TabIndex = 31;
            this.btn_continuar.Text = "CONTINUAR";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // panel_persona
            // 
            this.panel_persona.Controls.Add(this.btn_continuar);
            this.panel_persona.Controls.Add(this.label6);
            this.panel_persona.Controls.Add(this.groupBox1);
            this.panel_persona.Location = new System.Drawing.Point(12, 12);
            this.panel_persona.Name = "panel_persona";
            this.panel_persona.Size = new System.Drawing.Size(1101, 254);
            this.panel_persona.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cmb_localidad);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(20, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(739, 190);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_telefono.Location = new System.Drawing.Point(459, 58);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(203, 30);
            this.txt_telefono.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(394, 62);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 23);
            this.label18.TabIndex = 32;
            this.label18.Text = "Telefono:";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Location = new System.Drawing.Point(460, 20);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Size = new System.Drawing.Size(202, 31);
            this.cmb_localidad.TabIndex = 29;
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_dni.Location = new System.Drawing.Point(118, 20);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(203, 30);
            this.txt_dni.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(379, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Localidad:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_nombre.Location = new System.Drawing.Point(118, 58);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(203, 30);
            this.txt_nombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dirección:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_apellido.Location = new System.Drawing.Point(118, 96);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(203, 30);
            this.txt_apellido.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(82, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "DNI:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_direccion.Location = new System.Drawing.Point(118, 134);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(203, 30);
            this.txt_direccion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(54, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nombre:";
            // 
            // frm_personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1124, 640);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.panel_persona);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_personas";
            this.Text = "FrmAlumnos";
            this.Load += new System.EventHandler(this.frm_personas_Load);
            this.tabControl1.ResumeLayout(false);
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            this.Tutor.ResumeLayout(false);
            this.Tutor.PerformLayout();
            this.Docente.ResumeLayout(false);
            this.Docente.PerformLayout();
            this.panel_persona.ResumeLayout(false);
            this.panel_persona.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Alumno;
        private System.Windows.Forms.TabPage Tutor;
        private System.Windows.Forms.TabPage Docente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Panel panel_persona;
        private System.Windows.Forms.TextBox txt_pension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Button btn_añadiralumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_lue;
        private System.Windows.Forms.Label lblresp;
        private System.Windows.Forms.TextBox txt_os;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_añadirtutor;
        private System.Windows.Forms.Label lbl_tutor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_añadirdocente;
        private System.Windows.Forms.Label lbl_docente;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.RadioButton rb_cudno;
        private System.Windows.Forms.RadioButton rb_cudsi;
        private System.Windows.Forms.TextBox txt_ocupacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_parentesco;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_localidad;
        private System.Windows.Forms.DateTimePicker dtp_fechanac;
        private System.Windows.Forms.DateTimePicker dtp_fechaingreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_sedeinclusion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label18;




    }
}