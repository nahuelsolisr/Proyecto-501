namespace Proyecto501
{
    partial class FrmTalleres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalleres));
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grilla_grupo = new System.Windows.Forms.DataGridView();
            this.codGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_asignatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_formacionG = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_contactoL = new System.Windows.Forms.TextBox();
            this.txt_taller = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_formacionL = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_contactoP = new System.Windows.Forms.TextBox();
            this.txt_institucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_practica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_contenedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_contenedor.Controls.Add(this.groupBox2);
            this.panel_contenedor.Controls.Add(this.label6);
            this.panel_contenedor.Location = new System.Drawing.Point(3, 0);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1480, 804);
            this.panel_contenedor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grilla_grupo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1451, 737);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            // 
            // grilla_grupo
            // 
            this.grilla_grupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_grupo.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla_grupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla_grupo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grilla_grupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_grupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_grupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codGrup,
            this.Column4,
            this.Column5,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_grupo.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_grupo.EnableHeadersVisualStyles = false;
            this.grilla_grupo.Location = new System.Drawing.Point(15, 58);
            this.grilla_grupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grilla_grupo.Name = "grilla_grupo";
            this.grilla_grupo.ReadOnly = true;
            this.grilla_grupo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_grupo.RowHeadersVisible = false;
            this.grilla_grupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_grupo.Size = new System.Drawing.Size(637, 646);
            this.grilla_grupo.TabIndex = 115;
            this.grilla_grupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_grupo_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 34);
            this.label2.TabIndex = 83;
            this.label2.Text = "Seleccione un grupo:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(660, 58);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(0, 0);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(765, 651);
            this.tabControl2.TabIndex = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.txt_contacto);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.txt_asignatura);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_formacionG);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(757, 609);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Formacion General";
            // 
            // txt_contacto
            // 
            this.txt_contacto.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_contacto.Location = new System.Drawing.Point(293, 258);
            this.txt_contacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contacto.MaxLength = 13;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(268, 35);
            this.txt_contacto.TabIndex = 93;
            this.txt_contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contacto_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(73, 265);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(214, 29);
            this.label31.TabIndex = 94;
            this.label31.Text = "Contacto Docente:";
            // 
            // txt_asignatura
            // 
            this.txt_asignatura.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_asignatura.Location = new System.Drawing.Point(292, 182);
            this.txt_asignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_asignatura.MaxLength = 30;
            this.txt_asignatura.Name = "txt_asignatura";
            this.txt_asignatura.Size = new System.Drawing.Size(269, 35);
            this.txt_asignatura.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(152, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = "Asignatura:";
            // 
            // btn_formacionG
            // 
            this.btn_formacionG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_formacionG.FlatAppearance.BorderSize = 0;
            this.btn_formacionG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_formacionG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_formacionG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_formacionG.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_formacionG.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_formacionG.Location = new System.Drawing.Point(292, 345);
            this.btn_formacionG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_formacionG.Name = "btn_formacionG";
            this.btn_formacionG.Size = new System.Drawing.Size(269, 49);
            this.btn_formacionG.TabIndex = 80;
            this.btn_formacionG.Text = "CARGAR";
            this.btn_formacionG.UseVisualStyleBackColor = false;
            this.btn_formacionG.Click += new System.EventHandler(this.btn_formacionG_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_contactoL);
            this.tabPage3.Controls.Add(this.txt_taller);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_formacionL);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(757, 609);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Formacion Laboral";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(73, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 29);
            this.label7.TabIndex = 96;
            this.label7.Text = "Contacto Docente:";
            // 
            // txt_contactoL
            // 
            this.txt_contactoL.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_contactoL.Location = new System.Drawing.Point(293, 258);
            this.txt_contactoL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contactoL.MaxLength = 13;
            this.txt_contactoL.Name = "txt_contactoL";
            this.txt_contactoL.Size = new System.Drawing.Size(268, 35);
            this.txt_contactoL.TabIndex = 95;
            this.txt_contactoL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactoL_KeyPress);
            // 
            // txt_taller
            // 
            this.txt_taller.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_taller.Location = new System.Drawing.Point(292, 182);
            this.txt_taller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_taller.MaxLength = 30;
            this.txt_taller.Name = "txt_taller";
            this.txt_taller.Size = new System.Drawing.Size(269, 35);
            this.txt_taller.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "Taller:";
            // 
            // btn_formacionL
            // 
            this.btn_formacionL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_formacionL.FlatAppearance.BorderSize = 0;
            this.btn_formacionL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_formacionL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_formacionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_formacionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_formacionL.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_formacionL.Location = new System.Drawing.Point(292, 345);
            this.btn_formacionL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_formacionL.Name = "btn_formacionL";
            this.btn_formacionL.Size = new System.Drawing.Size(269, 49);
            this.btn_formacionL.TabIndex = 83;
            this.btn_formacionL.Text = "CARGAR";
            this.btn_formacionL.UseVisualStyleBackColor = false;
            this.btn_formacionL.Click += new System.EventHandler(this.btn_formacionL_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txt_contactoP);
            this.tabPage4.Controls.Add(this.txt_institucion);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btn_practica);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(757, 610);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Practica Profesionalizante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(73, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 29);
            this.label8.TabIndex = 96;
            this.label8.Text = "Contacto Docente:";
            // 
            // txt_contactoP
            // 
            this.txt_contactoP.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_contactoP.Location = new System.Drawing.Point(293, 258);
            this.txt_contactoP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contactoP.MaxLength = 13;
            this.txt_contactoP.Name = "txt_contactoP";
            this.txt_contactoP.Size = new System.Drawing.Size(268, 35);
            this.txt_contactoP.TabIndex = 95;
            this.txt_contactoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactoP_KeyPress);
            // 
            // txt_institucion
            // 
            this.txt_institucion.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.txt_institucion.Location = new System.Drawing.Point(292, 182);
            this.txt_institucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_institucion.MaxLength = 35;
            this.txt_institucion.Name = "txt_institucion";
            this.txt_institucion.Size = new System.Drawing.Size(269, 35);
            this.txt_institucion.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 88;
            this.label5.Text = "Institucion:";
            // 
            // btn_practica
            // 
            this.btn_practica.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_practica.FlatAppearance.BorderSize = 0;
            this.btn_practica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_practica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_practica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_practica.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_practica.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_practica.Location = new System.Drawing.Point(292, 345);
            this.btn_practica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_practica.Name = "btn_practica";
            this.btn_practica.Size = new System.Drawing.Size(271, 49);
            this.btn_practica.TabIndex = 86;
            this.btn_practica.Text = "CARGAR";
            this.btn_practica.UseVisualStyleBackColor = false;
            this.btn_practica.Click += new System.EventHandler(this.btn_practica_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(652, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 34);
            this.label1.TabIndex = 81;
            this.label1.Text = "¿Donde vamos a cargar este grupo?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(621, 41);
            this.label6.TabIndex = 34;
            this.label6.Text = "Asignemos un grupo a una formacion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1483, 788);
            this.Controls.Add(this.panel_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTalleres";
            this.Text = "FrmTalleres";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_asignatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_formacionG;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_taller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_formacionL;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_institucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_practica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_contactoL;
        private System.Windows.Forms.TextBox txt_contactoP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}