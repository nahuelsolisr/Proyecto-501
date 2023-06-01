namespace Proyecto501
{
    partial class FrmInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInforme));
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_informe3 = new System.Windows.Forms.CheckBox();
            this.chk_informe2 = new System.Windows.Forms.CheckBox();
            this.chk_informe1 = new System.Windows.Forms.CheckBox();
            this.chk_final = new System.Windows.Forms.CheckBox();
            this.grup_final = new System.Windows.Forms.GroupBox();
            this.btn_añadirFinal = new System.Windows.Forms.Button();
            this.rb_aproboNo = new System.Windows.Forms.RadioButton();
            this.rb_aproboSi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_informe3 = new System.Windows.Forms.TextBox();
            this.txt_informe2 = new System.Windows.Forms.TextBox();
            this.btn_modificarInforme = new System.Windows.Forms.Button();
            this.txt_informe1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grilla_trayectoria = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_contenedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grup_final.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_trayectoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Controls.Add(this.label2);
            this.panel_contenedor.Controls.Add(this.groupBox2);
            this.panel_contenedor.Controls.Add(this.groupBox1);
            this.panel_contenedor.Controls.Add(this.label6);
            this.panel_contenedor.Location = new System.Drawing.Point(1, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1035, 660);
            this.panel_contenedor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(609, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 26);
            this.label2.TabIndex = 118;
            this.label2.Text = "Agreguemos unos informes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_informe3);
            this.groupBox2.Controls.Add(this.chk_informe2);
            this.groupBox2.Controls.Add(this.chk_informe1);
            this.groupBox2.Controls.Add(this.chk_final);
            this.groupBox2.Controls.Add(this.grup_final);
            this.groupBox2.Controls.Add(this.txt_informe3);
            this.groupBox2.Controls.Add(this.txt_informe2);
            this.groupBox2.Controls.Add(this.btn_modificarInforme);
            this.groupBox2.Controls.Add(this.txt_informe1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(615, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 562);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            // 
            // chk_informe3
            // 
            this.chk_informe3.AutoSize = true;
            this.chk_informe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chk_informe3.Location = new System.Drawing.Point(24, 243);
            this.chk_informe3.Name = "chk_informe3";
            this.chk_informe3.Size = new System.Drawing.Size(112, 28);
            this.chk_informe3.TabIndex = 134;
            this.chk_informe3.Text = "Informe 3:";
            this.chk_informe3.UseVisualStyleBackColor = true;
            this.chk_informe3.CheckedChanged += new System.EventHandler(this.chk_informe3_CheckedChanged);
            // 
            // chk_informe2
            // 
            this.chk_informe2.AutoSize = true;
            this.chk_informe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chk_informe2.Location = new System.Drawing.Point(23, 129);
            this.chk_informe2.Name = "chk_informe2";
            this.chk_informe2.Size = new System.Drawing.Size(112, 28);
            this.chk_informe2.TabIndex = 133;
            this.chk_informe2.Text = "Informe 2:";
            this.chk_informe2.UseVisualStyleBackColor = true;
            this.chk_informe2.CheckedChanged += new System.EventHandler(this.chk_informe2_CheckedChanged);
            // 
            // chk_informe1
            // 
            this.chk_informe1.AutoSize = true;
            this.chk_informe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chk_informe1.Location = new System.Drawing.Point(21, 16);
            this.chk_informe1.Name = "chk_informe1";
            this.chk_informe1.Size = new System.Drawing.Size(112, 28);
            this.chk_informe1.TabIndex = 132;
            this.chk_informe1.Text = "Informe 1:";
            this.chk_informe1.UseVisualStyleBackColor = true;
            this.chk_informe1.CheckedChanged += new System.EventHandler(this.chk_informe1_CheckedChanged);
            // 
            // chk_final
            // 
            this.chk_final.AutoSize = true;
            this.chk_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chk_final.Location = new System.Drawing.Point(24, 405);
            this.chk_final.Name = "chk_final";
            this.chk_final.Size = new System.Drawing.Size(140, 28);
            this.chk_final.TabIndex = 130;
            this.chk_final.Text = "Instancia final";
            this.chk_final.UseVisualStyleBackColor = true;
            this.chk_final.CheckedChanged += new System.EventHandler(this.chk_final_CheckedChanged);
            // 
            // grup_final
            // 
            this.grup_final.Controls.Add(this.btn_añadirFinal);
            this.grup_final.Controls.Add(this.rb_aproboNo);
            this.grup_final.Controls.Add(this.rb_aproboSi);
            this.grup_final.Controls.Add(this.label7);
            this.grup_final.Location = new System.Drawing.Point(20, 444);
            this.grup_final.Name = "grup_final";
            this.grup_final.Size = new System.Drawing.Size(369, 107);
            this.grup_final.TabIndex = 131;
            this.grup_final.TabStop = false;
            this.grup_final.Visible = false;
            // 
            // btn_añadirFinal
            // 
            this.btn_añadirFinal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_añadirFinal.FlatAppearance.BorderSize = 0;
            this.btn_añadirFinal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_añadirFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_añadirFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadirFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadirFinal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_añadirFinal.Location = new System.Drawing.Point(209, 54);
            this.btn_añadirFinal.Name = "btn_añadirFinal";
            this.btn_añadirFinal.Size = new System.Drawing.Size(154, 42);
            this.btn_añadirFinal.TabIndex = 132;
            this.btn_añadirFinal.Text = "AÑADIR FINAL";
            this.btn_añadirFinal.UseVisualStyleBackColor = false;
            this.btn_añadirFinal.Click += new System.EventHandler(this.btn_añadirFinal_Click);
            // 
            // rb_aproboNo
            // 
            this.rb_aproboNo.AutoSize = true;
            this.rb_aproboNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_aproboNo.Location = new System.Drawing.Point(10, 67);
            this.rb_aproboNo.Name = "rb_aproboNo";
            this.rb_aproboNo.Size = new System.Drawing.Size(49, 22);
            this.rb_aproboNo.TabIndex = 131;
            this.rb_aproboNo.Text = "NO";
            this.rb_aproboNo.UseVisualStyleBackColor = true;
            // 
            // rb_aproboSi
            // 
            this.rb_aproboSi.AutoSize = true;
            this.rb_aproboSi.Checked = true;
            this.rb_aproboSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_aproboSi.Location = new System.Drawing.Point(10, 38);
            this.rb_aproboSi.Name = "rb_aproboSi";
            this.rb_aproboSi.Size = new System.Drawing.Size(39, 22);
            this.rb_aproboSi.TabIndex = 130;
            this.rb_aproboSi.TabStop = true;
            this.rb_aproboSi.Text = "SI";
            this.rb_aproboSi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 129;
            this.label7.Text = "Aprobo:";
            // 
            // txt_informe3
            // 
            this.txt_informe3.Enabled = false;
            this.txt_informe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_informe3.Location = new System.Drawing.Point(20, 276);
            this.txt_informe3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_informe3.Multiline = true;
            this.txt_informe3.Name = "txt_informe3";
            this.txt_informe3.Size = new System.Drawing.Size(369, 80);
            this.txt_informe3.TabIndex = 127;
            // 
            // txt_informe2
            // 
            this.txt_informe2.Enabled = false;
            this.txt_informe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_informe2.Location = new System.Drawing.Point(21, 163);
            this.txt_informe2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_informe2.Multiline = true;
            this.txt_informe2.Name = "txt_informe2";
            this.txt_informe2.Size = new System.Drawing.Size(369, 80);
            this.txt_informe2.TabIndex = 125;
            // 
            // btn_modificarInforme
            // 
            this.btn_modificarInforme.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_modificarInforme.FlatAppearance.BorderSize = 0;
            this.btn_modificarInforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_modificarInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_modificarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_modificarInforme.ForeColor = System.Drawing.Color.Black;
            this.btn_modificarInforme.Location = new System.Drawing.Point(270, 363);
            this.btn_modificarInforme.Name = "btn_modificarInforme";
            this.btn_modificarInforme.Size = new System.Drawing.Size(119, 40);
            this.btn_modificarInforme.TabIndex = 124;
            this.btn_modificarInforme.Text = "AÑADIR ";
            this.btn_modificarInforme.UseVisualStyleBackColor = false;
            this.btn_modificarInforme.Click += new System.EventHandler(this.btn_modificarInforme_Click);
            // 
            // txt_informe1
            // 
            this.txt_informe1.Enabled = false;
            this.txt_informe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_informe1.Location = new System.Drawing.Point(20, 50);
            this.txt_informe1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_informe1.Multiline = true;
            this.txt_informe1.Name = "txt_informe1";
            this.txt_informe1.Size = new System.Drawing.Size(369, 80);
            this.txt_informe1.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grilla_trayectoria);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 562);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            // 
            // grilla_trayectoria
            // 
            this.grilla_trayectoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_trayectoria.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grilla_trayectoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla_trayectoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grilla_trayectoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_trayectoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_trayectoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_trayectoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.dataGridViewTextBoxColumn12,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_trayectoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_trayectoria.Enabled = false;
            this.grilla_trayectoria.EnableHeadersVisualStyles = false;
            this.grilla_trayectoria.Location = new System.Drawing.Point(28, 74);
            this.grilla_trayectoria.Name = "grilla_trayectoria";
            this.grilla_trayectoria.ReadOnly = true;
            this.grilla_trayectoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla_trayectoria.RowHeadersVisible = false;
            this.grilla_trayectoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_trayectoria.Size = new System.Drawing.Size(553, 482);
            this.grilla_trayectoria.TabIndex = 118;
            this.grilla_trayectoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_trayectoria_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre Grupo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1er Informe";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2do Informe";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3er Informe";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Instancia Final";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_buscar.Location = new System.Drawing.Point(486, 21);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(109, 47);
            this.btn_buscar.TabIndex = 117;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 115;
            this.label1.Text = "INGRESE D.N.I: ";
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_dni.Location = new System.Drawing.Point(154, 26);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dni.MaxLength = 9;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(292, 28);
            this.txt_dni.TabIndex = 116;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Vamos a ver la trayectoria del alumno";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInforme";
            this.Text = "FrmInforme";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grup_final.ResumeLayout(false);
            this.grup_final.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_trayectoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grilla_trayectoria;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_informe1;
        private System.Windows.Forms.Button btn_modificarInforme;
        private System.Windows.Forms.TextBox txt_informe3;
        private System.Windows.Forms.TextBox txt_informe2;
        private System.Windows.Forms.CheckBox chk_final;
        private System.Windows.Forms.GroupBox grup_final;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_aproboNo;
        private System.Windows.Forms.RadioButton rb_aproboSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_añadirFinal;
        private System.Windows.Forms.CheckBox chk_informe3;
        private System.Windows.Forms.CheckBox chk_informe2;
        private System.Windows.Forms.CheckBox chk_informe1;
        private System.Windows.Forms.ErrorProvider errorProvider1;


    }
}