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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_asignatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_formacionG = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_taller = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_formacionL = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_institucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_practica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grilla_grupo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.codGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_contenedor.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_contenedor.Controls.Add(this.tabControl1);
            this.panel_contenedor.Controls.Add(this.label6);
            this.panel_contenedor.Location = new System.Drawing.Point(2, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1110, 653);
            this.panel_contenedor.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(24, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1063, 558);
            this.tabControl1.TabIndex = 74;
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
            this.tabPage1.Text = "Asignar Formación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grilla_grupo);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 503);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 33);
            this.label2.TabIndex = 83;
            this.label2.Text = "Seleccione un grupo:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabControl2.Location = new System.Drawing.Point(341, 71);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(0, 0);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(675, 406);
            this.tabControl2.TabIndex = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.txt_asignatura);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_formacionG);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 369);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Formacion General";
            // 
            // txt_asignatura
            // 
            this.txt_asignatura.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_asignatura.Location = new System.Drawing.Point(263, 129);
            this.txt_asignatura.Margin = new System.Windows.Forms.Padding(2);
            this.txt_asignatura.Name = "txt_asignatura";
            this.txt_asignatura.Size = new System.Drawing.Size(203, 30);
            this.txt_asignatura.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
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
            this.btn_formacionG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_formacionG.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_formacionG.Location = new System.Drawing.Point(209, 188);
            this.btn_formacionG.Name = "btn_formacionG";
            this.btn_formacionG.Size = new System.Drawing.Size(257, 40);
            this.btn_formacionG.TabIndex = 80;
            this.btn_formacionG.Text = "CARGAR";
            this.btn_formacionG.UseVisualStyleBackColor = false;
            this.btn_formacionG.Click += new System.EventHandler(this.btn_formacionG_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.txt_taller);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_formacionL);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(667, 369);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Formacion Laboral";
            // 
            // txt_taller
            // 
            this.txt_taller.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_taller.Location = new System.Drawing.Point(263, 129);
            this.txt_taller.Margin = new System.Windows.Forms.Padding(2);
            this.txt_taller.Name = "txt_taller";
            this.txt_taller.Size = new System.Drawing.Size(203, 30);
            this.txt_taller.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(214, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
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
            this.btn_formacionL.Location = new System.Drawing.Point(209, 188);
            this.btn_formacionL.Name = "btn_formacionL";
            this.btn_formacionL.Size = new System.Drawing.Size(257, 40);
            this.btn_formacionL.TabIndex = 83;
            this.btn_formacionL.Text = "CARGAR";
            this.btn_formacionL.UseVisualStyleBackColor = false;
            this.btn_formacionL.Click += new System.EventHandler(this.btn_formacionL_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage4.Controls.Add(this.txt_institucion);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btn_practica);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(667, 369);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Practica Profesionalizante";
            // 
            // txt_institucion
            // 
            this.txt_institucion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_institucion.Location = new System.Drawing.Point(263, 129);
            this.txt_institucion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_institucion.Name = "txt_institucion";
            this.txt_institucion.Size = new System.Drawing.Size(203, 30);
            this.txt_institucion.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(181, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
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
            this.btn_practica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_practica.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_practica.Location = new System.Drawing.Point(209, 188);
            this.btn_practica.Name = "btn_practica";
            this.btn_practica.Size = new System.Drawing.Size(257, 40);
            this.btn_practica.TabIndex = 86;
            this.btn_practica.Text = "CARGAR";
            this.btn_practica.UseVisualStyleBackColor = false;
            this.btn_practica.Click += new System.EventHandler(this.btn_practica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(508, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 33);
            this.label1.TabIndex = 81;
            this.label1.Text = "¿Donde vamos a cargar este grupo?";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_grupo.DefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_grupo.EnableHeadersVisualStyles = false;
            this.grilla_grupo.Location = new System.Drawing.Point(33, 71);
            this.grilla_grupo.Name = "grilla_grupo";
            this.grilla_grupo.ReadOnly = true;
            this.grilla_grupo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_grupo.RowHeadersVisible = false;
            this.grilla_grupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_grupo.Size = new System.Drawing.Size(302, 406);
            this.grilla_grupo.TabIndex = 75;
            this.grilla_grupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_grupo_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(392, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 33);
            this.label6.TabIndex = 34;
            this.label6.Text = "Asignemos un grupo a una formacion";
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
            // FrmTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1112, 640);
            this.Controls.Add(this.panel_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTalleres";
            this.Text = "FrmTalleres";
            this.Load += new System.EventHandler(this.FrmTalleres_Load);
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_grupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_asignatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_formacionG;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_grupo;
        private System.Windows.Forms.TextBox txt_taller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_formacionL;
        private System.Windows.Forms.TextBox txt_institucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn codGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}