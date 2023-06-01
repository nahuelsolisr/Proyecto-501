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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.panel_cursos = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grilla_mostrarAlumno = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grilla_grupo = new System.Windows.Forms.DataGridView();
            this.codGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregaralum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_caracterizacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_crearGrupo = new System.Windows.Forms.Button();
            this.cmb_dniDocente = new System.Windows.Forms.ComboBox();
            this.cmb_ciclo = new System.Windows.Forms.ComboBox();
            this.txt_nomgrupo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_fechaalta = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_cursos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mostrarAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cursos
            // 
            this.panel_cursos.Controls.Add(this.groupBox2);
            this.panel_cursos.Controls.Add(this.groupBox1);
            this.panel_cursos.Location = new System.Drawing.Point(1, 2);
            this.panel_cursos.Name = "panel_cursos";
            this.panel_cursos.Size = new System.Drawing.Size(1101, 660);
            this.panel_cursos.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grilla_mostrarAlumno);
            this.groupBox2.Controls.Add(this.grilla_grupo);
            this.groupBox2.Controls.Add(this.btn_agregaralum);
            this.groupBox2.Location = new System.Drawing.Point(551, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 604);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 26);
            this.label2.TabIndex = 115;
            this.label2.Text = "¡Asignemos un alumno a un grupo!";
            // 
            // grilla_mostrarAlumno
            // 
            this.grilla_mostrarAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_mostrarAlumno.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla_mostrarAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla_mostrarAlumno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grilla_mostrarAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_mostrarAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_mostrarAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_mostrarAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_mostrarAlumno.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_mostrarAlumno.EnableHeadersVisualStyles = false;
            this.grilla_mostrarAlumno.Location = new System.Drawing.Point(4, 54);
            this.grilla_mostrarAlumno.Name = "grilla_mostrarAlumno";
            this.grilla_mostrarAlumno.ReadOnly = true;
            this.grilla_mostrarAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_mostrarAlumno.RowHeadersVisible = false;
            this.grilla_mostrarAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_mostrarAlumno.Size = new System.Drawing.Size(517, 279);
            this.grilla_mostrarAlumno.TabIndex = 113;
            this.grilla_mostrarAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_mostrarAlumno_CellContentClick_1);
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
            // grilla_grupo
            // 
            this.grilla_grupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_grupo.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla_grupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla_grupo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grilla_grupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_grupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilla_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_grupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codGrup,
            this.Column4,
            this.Column5,
            this.Column1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_grupo.DefaultCellStyle = dataGridViewCellStyle4;
            this.grilla_grupo.EnableHeadersVisualStyles = false;
            this.grilla_grupo.Location = new System.Drawing.Point(3, 339);
            this.grilla_grupo.Name = "grilla_grupo";
            this.grilla_grupo.ReadOnly = true;
            this.grilla_grupo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_grupo.RowHeadersVisible = false;
            this.grilla_grupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_grupo.Size = new System.Drawing.Size(518, 213);
            this.grilla_grupo.TabIndex = 114;
            this.grilla_grupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_grupo_CellClick_1);
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
            // Column1
            // 
            this.Column1.HeaderText = "Ciclo ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.btn_agregaralum.Location = new System.Drawing.Point(360, 558);
            this.btn_agregaralum.Name = "btn_agregaralum";
            this.btn_agregaralum.Size = new System.Drawing.Size(160, 40);
            this.btn_agregaralum.TabIndex = 63;
            this.btn_agregaralum.Text = "AGREGAR";
            this.btn_agregaralum.UseVisualStyleBackColor = false;
            this.btn_agregaralum.Click += new System.EventHandler(this.btn_agregaralum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_caracterizacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_crearGrupo);
            this.groupBox1.Controls.Add(this.cmb_dniDocente);
            this.groupBox1.Controls.Add(this.cmb_ciclo);
            this.groupBox1.Controls.Add(this.txt_nomgrupo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtp_fechaalta);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 604);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 26);
            this.label6.TabIndex = 56;
            this.label6.Text = "¡Vamos a crear un grupo!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "DOCENTE:";
            // 
            // cmb_caracterizacion
            // 
            this.cmb_caracterizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cmb_caracterizacion.FormattingEnabled = true;
            this.cmb_caracterizacion.Items.AddRange(new object[] {
            "TEL",
            "SH",
            "DV",
            "DM",
            "DI"});
            this.cmb_caracterizacion.Location = new System.Drawing.Point(200, 217);
            this.cmb_caracterizacion.Name = "cmb_caracterizacion";
            this.cmb_caracterizacion.Size = new System.Drawing.Size(269, 30);
            this.cmb_caracterizacion.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(18, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 101;
            this.label4.Text = "CARACTERIZACION:";
            // 
            // btn_crearGrupo
            // 
            this.btn_crearGrupo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_crearGrupo.FlatAppearance.BorderSize = 0;
            this.btn_crearGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_crearGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_crearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_crearGrupo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_crearGrupo.Location = new System.Drawing.Point(280, 339);
            this.btn_crearGrupo.Name = "btn_crearGrupo";
            this.btn_crearGrupo.Size = new System.Drawing.Size(188, 50);
            this.btn_crearGrupo.TabIndex = 100;
            this.btn_crearGrupo.Text = "CREAR GRUPO";
            this.btn_crearGrupo.UseVisualStyleBackColor = false;
            this.btn_crearGrupo.Click += new System.EventHandler(this.btn_crearGrupo_Click_1);
            // 
            // cmb_dniDocente
            // 
            this.cmb_dniDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cmb_dniDocente.FormattingEnabled = true;
            this.cmb_dniDocente.Location = new System.Drawing.Point(200, 69);
            this.cmb_dniDocente.Name = "cmb_dniDocente";
            this.cmb_dniDocente.Size = new System.Drawing.Size(269, 30);
            this.cmb_dniDocente.TabIndex = 109;
            // 
            // cmb_ciclo
            // 
            this.cmb_ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
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
            this.cmb_ciclo.Location = new System.Drawing.Point(200, 117);
            this.cmb_ciclo.Name = "cmb_ciclo";
            this.cmb_ciclo.Size = new System.Drawing.Size(269, 30);
            this.cmb_ciclo.TabIndex = 104;
            // 
            // txt_nomgrupo
            // 
            this.txt_nomgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_nomgrupo.Location = new System.Drawing.Point(200, 166);
            this.txt_nomgrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nomgrupo.MaxLength = 30;
            this.txt_nomgrupo.Name = "txt_nomgrupo";
            this.txt_nomgrupo.Size = new System.Drawing.Size(269, 28);
            this.txt_nomgrupo.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label7.Location = new System.Drawing.Point(130, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 103;
            this.label7.Text = "NIVEL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(77, 272);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 24);
            this.label13.TabIndex = 105;
            this.label13.Text = "FECHA ALTA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 24);
            this.label10.TabIndex = 108;
            this.label10.Text = "NOMBRE DEL GRUPO:";
            // 
            // dtp_fechaalta
            // 
            this.dtp_fechaalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dtp_fechaalta.Location = new System.Drawing.Point(200, 270);
            this.dtp_fechaalta.Name = "dtp_fechaalta";
            this.dtp_fechaalta.Size = new System.Drawing.Size(269, 28);
            this.dtp_fechaalta.TabIndex = 106;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.panel_cursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            this.panel_cursos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mostrarAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cursos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_agregaralum;
        private System.Windows.Forms.ComboBox cmb_dniDocente;
        private System.Windows.Forms.TextBox txt_nomgrupo;
        private System.Windows.Forms.Button btn_crearGrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_fechaalta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_ciclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_caracterizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grilla_mostrarAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView grilla_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;





    }
}