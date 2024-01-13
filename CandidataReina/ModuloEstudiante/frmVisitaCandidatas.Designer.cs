namespace CapaVisual.ModuloEstudiante
{
    partial class frmVisitaCandidatas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitaCandidatas));
            groupBox1 = new GroupBox();
            dgvCandidatasInfo = new DataGridView();
            label1 = new Label();
            btnCancelar = new Button();
            groupBox2 = new GroupBox();
            panelContenido = new Panel();
            tbxDescripcion = new TextBox();
            tbxTitulo = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            pbxFoto4 = new PictureBox();
            pbxFoto3 = new PictureBox();
            pbxFoto2 = new PictureBox();
            groupBox5 = new GroupBox();
            pbxFoto1 = new PictureBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            tbxAspiraciones = new TextBox();
            tbxHabilidades = new TextBox();
            tbxIntereses = new TextBox();
            tbxPasatiempos = new TextBox();
            tbxSemestre = new TextBox();
            tbxCarrera = new TextBox();
            tbxProvincia = new TextBox();
            tbxTelefono = new TextBox();
            tbxEdad = new TextBox();
            tbxApellidos = new TextBox();
            tbxNombre = new TextBox();
            label13 = new Label();
            label9 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pbxMaster = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatasInfo).BeginInit();
            groupBox2.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFoto4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMaster).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(dgvCandidatasInfo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 518);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Candidatas";
            // 
            // dgvCandidatasInfo
            // 
            dgvCandidatasInfo.AllowUserToAddRows = false;
            dgvCandidatasInfo.AllowUserToDeleteRows = false;
            dgvCandidatasInfo.BackgroundColor = SystemColors.InactiveBorder;
            dgvCandidatasInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatasInfo.Location = new Point(32, 97);
            dgvCandidatasInfo.Name = "dgvCandidatasInfo";
            dgvCandidatasInfo.ReadOnly = true;
            dgvCandidatasInfo.RowHeadersWidth = 62;
            dgvCandidatasInfo.RowTemplate.Height = 33;
            dgvCandidatasInfo.Size = new Size(290, 388);
            dgvCandidatasInfo.TabIndex = 2;
            dgvCandidatasInfo.CellClick += dgvCandidatasInfo_CellClick;
            dgvCandidatasInfo.CellContentClick += dgvCandidatasInfo_CellContentClick;
            dgvCandidatasInfo.CellPainting += dgvCandidatasInfo_CellPainting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(233, 23);
            label1.TabIndex = 2;
            label1.Text = "Selecciona una candidata";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(128, 552);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(panelContenido);
            groupBox2.Location = new Point(383, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(685, 585);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información";
            // 
            // panelContenido
            // 
            panelContenido.AutoScroll = true;
            panelContenido.BackColor = SystemColors.ButtonHighlight;
            panelContenido.BorderStyle = BorderStyle.FixedSingle;
            panelContenido.Controls.Add(tbxDescripcion);
            panelContenido.Controls.Add(tbxTitulo);
            panelContenido.Controls.Add(label16);
            panelContenido.Controls.Add(label15);
            panelContenido.Controls.Add(label14);
            panelContenido.Controls.Add(pbxFoto4);
            panelContenido.Controls.Add(pbxFoto3);
            panelContenido.Controls.Add(pbxFoto2);
            panelContenido.Controls.Add(groupBox5);
            panelContenido.Controls.Add(pbxFoto1);
            panelContenido.Controls.Add(groupBox3);
            panelContenido.Controls.Add(tbxAspiraciones);
            panelContenido.Controls.Add(tbxHabilidades);
            panelContenido.Controls.Add(tbxIntereses);
            panelContenido.Controls.Add(tbxPasatiempos);
            panelContenido.Controls.Add(tbxSemestre);
            panelContenido.Controls.Add(tbxCarrera);
            panelContenido.Controls.Add(tbxProvincia);
            panelContenido.Controls.Add(tbxTelefono);
            panelContenido.Controls.Add(tbxEdad);
            panelContenido.Controls.Add(tbxApellidos);
            panelContenido.Controls.Add(tbxNombre);
            panelContenido.Controls.Add(label13);
            panelContenido.Controls.Add(label9);
            panelContenido.Controls.Add(label12);
            panelContenido.Controls.Add(label11);
            panelContenido.Controls.Add(label10);
            panelContenido.Controls.Add(label8);
            panelContenido.Controls.Add(label7);
            panelContenido.Controls.Add(label6);
            panelContenido.Controls.Add(label5);
            panelContenido.Controls.Add(label4);
            panelContenido.Controls.Add(pbxMaster);
            panelContenido.Controls.Add(label3);
            panelContenido.Controls.Add(label2);
            panelContenido.Location = new Point(16, 36);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(661, 538);
            panelContenido.TabIndex = 0;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.AllowDrop = true;
            tbxDescripcion.Location = new Point(341, 974);
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.ReadOnly = true;
            tbxDescripcion.Size = new Size(259, 31);
            tbxDescripcion.TabIndex = 34;
            // 
            // tbxTitulo
            // 
            tbxTitulo.AllowDrop = true;
            tbxTitulo.Location = new Point(40, 974);
            tbxTitulo.Name = "tbxTitulo";
            tbxTitulo.ReadOnly = true;
            tbxTitulo.Size = new Size(252, 31);
            tbxTitulo.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(341, 928);
            label16.Name = "label16";
            label16.Size = new Size(104, 25);
            label16.TabIndex = 32;
            label16.Text = "Descripcion";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 928);
            label15.Name = "label15";
            label15.Size = new Size(56, 25);
            label15.TabIndex = 31;
            label15.Text = "Titulo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(304, 1681);
            label14.Name = "label14";
            label14.Size = new Size(32, 25);
            label14.TabIndex = 30;
            label14.Text = ".....";
            // 
            // pbxFoto4
            // 
            pbxFoto4.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto4.Location = new Point(341, 1356);
            pbxFoto4.Name = "pbxFoto4";
            pbxFoto4.Size = new Size(259, 302);
            pbxFoto4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto4.TabIndex = 29;
            pbxFoto4.TabStop = false;
            // 
            // pbxFoto3
            // 
            pbxFoto3.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto3.Location = new Point(33, 1356);
            pbxFoto3.Name = "pbxFoto3";
            pbxFoto3.Size = new Size(259, 302);
            pbxFoto3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto3.TabIndex = 28;
            pbxFoto3.TabStop = false;
            // 
            // pbxFoto2
            // 
            pbxFoto2.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto2.Location = new Point(341, 1025);
            pbxFoto2.Name = "pbxFoto2";
            pbxFoto2.Size = new Size(259, 302);
            pbxFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto2.TabIndex = 27;
            pbxFoto2.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(33, 914);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(567, 2);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            // 
            // pbxFoto1
            // 
            pbxFoto1.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto1.Location = new Point(33, 1025);
            pbxFoto1.Name = "pbxFoto1";
            pbxFoto1.Size = new Size(259, 302);
            pbxFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto1.TabIndex = 25;
            pbxFoto1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(33, 451);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(567, 2);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(0, 450);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(567, 2);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            // 
            // tbxAspiraciones
            // 
            tbxAspiraciones.Location = new Point(341, 726);
            tbxAspiraciones.Multiline = true;
            tbxAspiraciones.Name = "tbxAspiraciones";
            tbxAspiraciones.ReadOnly = true;
            tbxAspiraciones.Size = new Size(259, 135);
            tbxAspiraciones.TabIndex = 23;
            // 
            // tbxHabilidades
            // 
            tbxHabilidades.Location = new Point(40, 726);
            tbxHabilidades.Multiline = true;
            tbxHabilidades.Name = "tbxHabilidades";
            tbxHabilidades.ReadOnly = true;
            tbxHabilidades.Size = new Size(259, 135);
            tbxHabilidades.TabIndex = 22;
            // 
            // tbxIntereses
            // 
            tbxIntereses.Location = new Point(341, 529);
            tbxIntereses.Multiline = true;
            tbxIntereses.Name = "tbxIntereses";
            tbxIntereses.ReadOnly = true;
            tbxIntereses.Size = new Size(259, 135);
            tbxIntereses.TabIndex = 21;
            // 
            // tbxPasatiempos
            // 
            tbxPasatiempos.Location = new Point(40, 529);
            tbxPasatiempos.Multiline = true;
            tbxPasatiempos.Name = "tbxPasatiempos";
            tbxPasatiempos.ReadOnly = true;
            tbxPasatiempos.Size = new Size(259, 135);
            tbxPasatiempos.TabIndex = 20;
            // 
            // tbxSemestre
            // 
            tbxSemestre.Location = new Point(376, 371);
            tbxSemestre.Name = "tbxSemestre";
            tbxSemestre.ReadOnly = true;
            tbxSemestre.Size = new Size(91, 31);
            tbxSemestre.TabIndex = 19;
            // 
            // tbxCarrera
            // 
            tbxCarrera.Location = new Point(105, 368);
            tbxCarrera.Name = "tbxCarrera";
            tbxCarrera.ReadOnly = true;
            tbxCarrera.Size = new Size(150, 31);
            tbxCarrera.TabIndex = 18;
            // 
            // tbxProvincia
            // 
            tbxProvincia.Location = new Point(376, 310);
            tbxProvincia.Name = "tbxProvincia";
            tbxProvincia.ReadOnly = true;
            tbxProvincia.Size = new Size(150, 31);
            tbxProvincia.TabIndex = 17;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(376, 254);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.ReadOnly = true;
            tbxTelefono.Size = new Size(150, 31);
            tbxTelefono.TabIndex = 16;
            // 
            // tbxEdad
            // 
            tbxEdad.Location = new Point(376, 194);
            tbxEdad.Name = "tbxEdad";
            tbxEdad.ReadOnly = true;
            tbxEdad.Size = new Size(150, 31);
            tbxEdad.TabIndex = 15;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(376, 134);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.ReadOnly = true;
            tbxApellidos.Size = new Size(208, 31);
            tbxApellidos.TabIndex = 14;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(376, 74);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.ReadOnly = true;
            tbxNombre.Size = new Size(208, 31);
            tbxNombre.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 371);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 12;
            label13.Text = "Carrera:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 684);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 8;
            label9.Text = "Habilidades:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(280, 371);
            label12.Name = "label12";
            label12.Size = new Size(89, 25);
            label12.TabIndex = 11;
            label12.Text = "Semestre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(341, 684);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 10;
            label11.Text = "Aspiraciones";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 478);
            label10.Name = "label10";
            label10.Size = new Size(86, 25);
            label10.TabIndex = 9;
            label10.Text = "Intereses:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 478);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 7;
            label8.Text = "Pasatiempos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 316);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 6;
            label7.Text = "Provincia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 257);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 197);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 4;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 136);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // pbxMaster
            // 
            pbxMaster.BorderStyle = BorderStyle.FixedSingle;
            pbxMaster.Location = new Point(27, 77);
            pbxMaster.Name = "pbxMaster";
            pbxMaster.Size = new Size(222, 264);
            pbxMaster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMaster.TabIndex = 2;
            pbxMaster.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(437, 45);
            label3.TabIndex = 1;
            label3.Text = "PORFOLIO DE CANDIDATA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 608);
            panel1.TabIndex = 4;
            // 
            // frmVisitaCandidatas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 608);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVisitaCandidatas";
            Text = "frmVisitaCandidatas";
            Load += frmVisitaCandidatas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatasInfo).EndInit();
            groupBox2.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFoto4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxMaster).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dgvCandidatasInfo;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private Panel panelContenido;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pbxMaster;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private TextBox tbxAspiraciones;
        private TextBox tbxHabilidades;
        private TextBox tbxIntereses;
        private TextBox tbxPasatiempos;
        private TextBox tbxSemestre;
        private TextBox tbxCarrera;
        private TextBox tbxProvincia;
        private TextBox tbxTelefono;
        private TextBox tbxEdad;
        private TextBox tbxApellidos;
        private TextBox tbxNombre;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private PictureBox pbxFoto1;
        private GroupBox groupBox4;
        private Label label14;
        private PictureBox pbxFoto4;
        private PictureBox pbxFoto3;
        private PictureBox pbxFoto2;
        private TextBox tbxDescripcion;
        private TextBox tbxTitulo;
        private Label label16;
        private Label label15;
        private Panel panel1;
    }
}