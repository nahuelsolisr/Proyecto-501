namespace Proyecto501
{
    partial class FrmCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_cursos = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tutor = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cmb_dniDocente = new System.Windows.Forms.ComboBox();
            this.txt_nomgrupo = new System.Windows.Forms.TextBox();
            this.btn_crearGrupo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_fechaalta = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_ciclo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_caracterizacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grilla_mostrarAlumno = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.grilla_grupo = new System.Windows.Forms.DataGridView();
            this.btn_agregaralum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.codGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_cursos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mostrarAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cursos
            // 
            this.panel_cursos.Controls.Add(this.tabControl1);
            this.panel_cursos.Controls.Add(this.btn_agregaralum);
            this.panel_cursos.Controls.Add(this.label6);
            this.panel_cursos.Location = new System.Drawing.Point(12, 12);
            this.panel_cursos.Name = "panel_cursos";
            this.panel_cursos.Size = new System.Drawing.Size(1066, 604);
            this.panel_cursos.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tutor);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(3, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1063, 558);
            this.tabControl1.TabIndex = 73;
            // 
            // Tutor
            // 
            this.Tutor.BackColor = System.Drawing.Color.SteelBlue;
            this.Tutor.Controls.Add(this.groupBox1);
            this.Tutor.Location = new System.Drawing.Point(4, 33);
            this.Tutor.Name = "Tutor";
            this.Tutor.Padding = new System.Windows.Forms.Padding(3);
            this.Tutor.Size = new System.Drawing.Size(1055, 521);
            this.Tutor.TabIndex = 2;
            this.Tutor.Text = "CREAR GRUPO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.cmb_dniDocente);
            this.groupBox1.Controls.Add(this.txt_nomgrupo);
            this.groupBox1.Controls.Add(this.btn_crearGrupo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtp_fechaalta);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_ciclo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_caracterizacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1029, 504);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(761, 111);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(135, 29);
            this.lbl_nombre.TabIndex = 84;
            this.lbl_nombre.Text = "lbl_nombre";
            // 
            // cmb_dniDocente
            // 
            this.cmb_dniDocente.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.cmb_dniDocente.FormattingEnabled = true;
            this.cmb_dniDocente.Location = new System.Drawing.Point(502, 109);
            this.cmb_dniDocente.Name = "cmb_dniDocente";
            this.cmb_dniDocente.Size = new System.Drawing.Size(228, 31);
            this.cmb_dniDocente.TabIndex = 83;
            // 
            // txt_nomgrupo
            // 
            this.txt_nomgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_nomgrupo.Location = new System.Drawing.Point(502, 222);
            this.txt_nomgrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nomgrupo.Name = "txt_nomgrupo";
            this.txt_nomgrupo.Size = new System.Drawing.Size(228, 29);
            this.txt_nomgrupo.TabIndex = 81;
            // 
            // btn_crearGrupo
            // 
            this.btn_crearGrupo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_crearGrupo.FlatAppearance.BorderSize = 0;
            this.btn_crearGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_crearGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_crearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_crearGrupo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_crearGrupo.Location = new System.Drawing.Point(797, 445);
            this.btn_crearGrupo.Name = "btn_crearGrupo";
            this.btn_crearGrupo.Size = new System.Drawing.Size(213, 40);
            this.btn_crearGrupo.TabIndex = 63;
            this.btn_crearGrupo.Text = "CREAR GRUPO";
            this.btn_crearGrupo.UseVisualStyleBackColor = false;
            this.btn_crearGrupo.Click += new System.EventHandler(this.btn_crearGrupo_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(293, 227);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 24);
            this.label10.TabIndex = 82;
            this.label10.Text = "NOMBRE DEL GRUPO:";
            // 
            // dtp_fechaalta
            // 
            this.dtp_fechaalta.Location = new System.Drawing.Point(502, 376);
            this.dtp_fechaalta.Name = "dtp_fechaalta";
            this.dtp_fechaalta.Size = new System.Drawing.Size(229, 29);
            this.dtp_fechaalta.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(364, 381);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 24);
            this.label13.TabIndex = 79;
            this.label13.Text = "FECHA ALTA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(348, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(357, 29);
            this.label8.TabIndex = 78;
            this.label8.Text = "¿Como va a ser el nuevo grupo?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(427, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 76;
            this.label7.Text = "NIVEL:";
            // 
            // cmb_ciclo
            // 
            this.cmb_ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmb_ciclo.FormattingEnabled = true;
            this.cmb_ciclo.Items.AddRange(new object[] {
            "Ciclo único",
            "1° ciclo (Sede)",
            "2° ciclo (Sede)",
            "Ciclo Básico (Sede)",
            "Ciclo Superior",
            "Maternal (Inc)",
            "Infante (Inc)",
            "1°",
            "2°",
            "3°",
            "4°",
            "5°",
            "6°",
            "1° básica",
            "2° básica",
            "3° básica",
            "4° básica",
            "5° superior",
            "6° superior",
            "7° superior"});
            this.cmb_ciclo.Location = new System.Drawing.Point(502, 273);
            this.cmb_ciclo.Name = "cmb_ciclo";
            this.cmb_ciclo.Size = new System.Drawing.Size(229, 32);
            this.cmb_ciclo.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(303, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "CARACTERIZACION:";
            // 
            // cmb_caracterizacion
            // 
            this.cmb_caracterizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmb_caracterizacion.FormattingEnabled = true;
            this.cmb_caracterizacion.Items.AddRange(new object[] {
            "TEL",
            "SH",
            "DV",
            "DM",
            "DI"});
            this.cmb_caracterizacion.Location = new System.Drawing.Point(502, 321);
            this.cmb_caracterizacion.Name = "cmb_caracterizacion";
            this.cmb_caracterizacion.Size = new System.Drawing.Size(228, 32);
            this.cmb_caracterizacion.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "¿Quien va a estar a cargo?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "DNI DOCENTE:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 521);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "ASIGNAR  A GRUPO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grilla_mostrarAlumno);
            this.groupBox2.Controls.Add(this.btn_continuar);
            this.groupBox2.Controls.Add(this.grilla_grupo);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 503);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // grilla_mostrarAlumno
            // 
            this.grilla_mostrarAlumno.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla_mostrarAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla_mostrarAlumno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grilla_mostrarAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_mostrarAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_mostrarAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_mostrarAlumno.DefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_mostrarAlumno.EnableHeadersVisualStyles = false;
            this.grilla_mostrarAlumno.Location = new System.Drawing.Point(67, 28);
            this.grilla_mostrarAlumno.Name = "grilla_mostrarAlumno";
            this.grilla_mostrarAlumno.ReadOnly = true;
            this.grilla_mostrarAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_mostrarAlumno.RowHeadersVisible = false;
            this.grilla_mostrarAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_mostrarAlumno.Size = new System.Drawing.Size(301, 452);
            this.grilla_mostrarAlumno.TabIndex = 74;
            this.grilla_mostrarAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_mostrarAlumno_CellContentClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_continuar.FlatAppearance.BorderSize = 0;
            this.btn_continuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_continuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_continuar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_continuar.Location = new System.Drawing.Point(774, 429);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(257, 40);
            this.btn_continuar.TabIndex = 80;
            this.btn_continuar.Text = "ASIGNAR ALUMNO";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // grilla_grupo
            // 
            this.grilla_grupo.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla_grupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla_grupo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grilla_grupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_grupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codGrup,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_grupo.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_grupo.EnableHeadersVisualStyles = false;
            this.grilla_grupo.Location = new System.Drawing.Point(374, 28);
            this.grilla_grupo.Name = "grilla_grupo";
            this.grilla_grupo.ReadOnly = true;
            this.grilla_grupo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_grupo.RowHeadersVisible = false;
            this.grilla_grupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_grupo.Size = new System.Drawing.Size(313, 452);
            this.grilla_grupo.TabIndex = 75;
            this.grilla_grupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_grupo_CellClick);
            // 
            // btn_agregaralum
            // 
            this.btn_agregaralum.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_agregaralum.FlatAppearance.BorderSize = 0;
            this.btn_agregaralum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_agregaralum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregaralum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregaralum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_agregaralum.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregaralum.Location = new System.Drawing.Point(837, 548);
            this.btn_agregaralum.Name = "btn_agregaralum";
            this.btn_agregaralum.Size = new System.Drawing.Size(213, 40);
            this.btn_agregaralum.TabIndex = 63;
            this.btn_agregaralum.Text = "AGREGAR ALUMNOS";
            this.btn_agregaralum.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(351, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 33);
            this.label6.TabIndex = 56;
            this.label6.Text = "¡Vamos a crear un grupo!";
            // 
            // codGrup
            // 
            this.codGrup.HeaderText = "Codigo Grupo";
            this.codGrup.Name = "codGrup";
            this.codGrup.ReadOnly = true;
            this.codGrup.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de alta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre Grupo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1090, 628);
            this.Controls.Add(this.panel_cursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            this.panel_cursos.ResumeLayout(false);
            this.panel_cursos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Tutor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mostrarAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cursos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_agregaralum;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_crearGrupo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grilla_mostrarAlumno;
        private System.Windows.Forms.DataGridView grilla_grupo;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox txt_nomgrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_fechaalta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_ciclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_caracterizacion;
        private System.Windows.Forms.ComboBox cmb_dniDocente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;





    }
}