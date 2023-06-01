namespace Proyecto501
{
    partial class PARAHACERMODIFICACIONES
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Alumno = new System.Windows.Forms.TabPage();
            this.Tutor = new System.Windows.Forms.TabPage();
            this.Docente = new System.Windows.Forms.TabPage();
            this.txt_dnii = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellidoo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_direccionn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_localidadd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Alumno);
            this.tabControl1.Controls.Add(this.Tutor);
            this.tabControl1.Controls.Add(this.Docente);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 626);
            this.tabControl1.TabIndex = 36;
            this.tabControl1.Visible = false;
            // 
            // Alumno
            // 
            this.Alumno.BackColor = System.Drawing.Color.SteelBlue;
            this.Alumno.Controls.Add(this.txt_dnii);
            this.Alumno.Controls.Add(this.label5);
            this.Alumno.Controls.Add(this.txt_nombree);
            this.Alumno.Controls.Add(this.label4);
            this.Alumno.Controls.Add(this.txt_apellidoo);
            this.Alumno.Controls.Add(this.label7);
            this.Alumno.Controls.Add(this.txt_direccionn);
            this.Alumno.Controls.Add(this.label8);
            this.Alumno.Controls.Add(this.txt_localidadd);
            this.Alumno.Controls.Add(this.label9);
            this.Alumno.Controls.Add(this.txt_filtrar);
            this.Alumno.Controls.Add(this.label3);
            this.Alumno.Controls.Add(this.btn_modificar);
            this.Alumno.Controls.Add(this.btn_baja);
            this.Alumno.Controls.Add(this.label2);
            this.Alumno.Controls.Add(this.grilla);
            this.Alumno.Location = new System.Drawing.Point(4, 32);
            this.Alumno.Name = "Alumno";
            this.Alumno.Padding = new System.Windows.Forms.Padding(3);
            this.Alumno.Size = new System.Drawing.Size(904, 590);
            this.Alumno.TabIndex = 1;
            this.Alumno.Text = "Alumno";
            // 
            // Tutor
            // 
            this.Tutor.BackColor = System.Drawing.Color.SteelBlue;
            this.Tutor.Location = new System.Drawing.Point(4, 32);
            this.Tutor.Name = "Tutor";
            this.Tutor.Padding = new System.Windows.Forms.Padding(3);
            this.Tutor.Size = new System.Drawing.Size(1073, 299);
            this.Tutor.TabIndex = 2;
            this.Tutor.Text = "Tutor";
            // 
            // Docente
            // 
            this.Docente.BackColor = System.Drawing.Color.SteelBlue;
            this.Docente.Location = new System.Drawing.Point(4, 32);
            this.Docente.Name = "Docente";
            this.Docente.Padding = new System.Windows.Forms.Padding(3);
            this.Docente.Size = new System.Drawing.Size(1073, 299);
            this.Docente.TabIndex = 3;
            this.Docente.Text = "Docente";
            // 
            // txt_dnii
            // 
            this.txt_dnii.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_dnii.Location = new System.Drawing.Point(88, 120);
            this.txt_dnii.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dnii.Name = "txt_dnii";
            this.txt_dnii.Size = new System.Drawing.Size(203, 30);
            this.txt_dnii.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "Localidad:";
            // 
            // txt_nombree
            // 
            this.txt_nombree.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_nombree.Location = new System.Drawing.Point(89, 219);
            this.txt_nombree.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombree.Name = "txt_nombree";
            this.txt_nombree.Size = new System.Drawing.Size(203, 30);
            this.txt_nombree.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "Dirección:";
            // 
            // txt_apellidoo
            // 
            this.txt_apellidoo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_apellidoo.Location = new System.Drawing.Point(88, 169);
            this.txt_apellidoo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellidoo.Name = "txt_apellidoo";
            this.txt_apellidoo.Size = new System.Drawing.Size(203, 30);
            this.txt_apellidoo.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "DNI:";
            // 
            // txt_direccionn
            // 
            this.txt_direccionn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_direccionn.Location = new System.Drawing.Point(88, 267);
            this.txt_direccionn.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direccionn.Name = "txt_direccionn";
            this.txt_direccionn.Size = new System.Drawing.Size(203, 30);
            this.txt_direccionn.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 59;
            this.label8.Text = "Apellido:";
            // 
            // txt_localidadd
            // 
            this.txt_localidadd.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_localidadd.Location = new System.Drawing.Point(88, 316);
            this.txt_localidadd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_localidadd.Name = "txt_localidadd";
            this.txt_localidadd.Size = new System.Drawing.Size(203, 30);
            this.txt_localidadd.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Nombre:";
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txt_filtrar.Location = new System.Drawing.Point(88, 60);
            this.txt_filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(203, 30);
            this.txt_filtrar.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "FILTRAR:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_modificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_modificar.Location = new System.Drawing.Point(6, 428);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(143, 40);
            this.btn_modificar.TabIndex = 50;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_baja
            // 
            this.btn_baja.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_baja.FlatAppearance.BorderSize = 0;
            this.btn_baja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_baja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baja.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_baja.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_baja.Location = new System.Drawing.Point(155, 428);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(143, 40);
            this.btn_baja.TabIndex = 49;
            this.btn_baja.Text = "DAR DE BAJA";
            this.btn_baja.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 48;
            // 
            // grilla
            // 
            this.grilla.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Apellido,
            this.Nombre,
            this.Dirección,
            this.CP});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla.DefaultCellStyle = dataGridViewCellStyle1;
            this.grilla.EnableHeadersVisualStyles = false;
            this.grilla.Location = new System.Drawing.Point(337, 60);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla.RowHeadersVisible = false;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(501, 510);
            this.grilla.TabIndex = 47;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // PARAHACERMODIFICACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "PARAHACERMODIFICACIONES";
            this.Text = "PARAHACERMODIFICACIONES";
            this.tabControl1.ResumeLayout(false);
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Alumno;
        private System.Windows.Forms.TabPage Tutor;
        private System.Windows.Forms.TabPage Docente;
        private System.Windows.Forms.TextBox txt_dnii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellidoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_direccionn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_localidadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;

    }
}