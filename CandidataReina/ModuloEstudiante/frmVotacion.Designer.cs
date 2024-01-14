namespace CapaVisual.ModuloEstudiante
{
    partial class frmVotacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotacion));
            pbxFotoCandidata = new PictureBox();
            tbxId = new TextBox();
            label1 = new Label();
            btnVotar = new Button();
            tbxPasatiempos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbxNombre = new TextBox();
            tbxApellidos = new TextBox();
            label12 = new Label();
            tbxCarrera = new TextBox();
            label4 = new Label();
            tbxEdad = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            tbxAspiraciones = new TextBox();
            tbxHabilidades = new TextBox();
            tbxIntereses = new TextBox();
            btnBuscar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxFotoCandidata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbxFotoCandidata
            // 
            pbxFotoCandidata.BackColor = SystemColors.ControlLightLight;
            pbxFotoCandidata.BorderStyle = BorderStyle.Fixed3D;
            pbxFotoCandidata.Location = new Point(28, 24);
            pbxFotoCandidata.Margin = new Padding(4);
            pbxFotoCandidata.Name = "pbxFotoCandidata";
            pbxFotoCandidata.Size = new Size(357, 446);
            pbxFotoCandidata.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFotoCandidata.TabIndex = 0;
            pbxFotoCandidata.TabStop = false;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(718, 24);
            tbxId.Margin = new Padding(4);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(98, 31);
            tbxId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 25);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el numero de la candidata";
            // 
            // btnVotar
            // 
            btnVotar.BackColor = Color.PaleTurquoise;
            btnVotar.BackgroundImage = (Image)resources.GetObject("btnVotar.BackgroundImage");
            btnVotar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVotar.Cursor = Cursors.Hand;
            btnVotar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVotar.Location = new Point(149, 482);
            btnVotar.Margin = new Padding(4);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(117, 69);
            btnVotar.TabIndex = 3;
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // tbxPasatiempos
            // 
            tbxPasatiempos.Location = new Point(430, 230);
            tbxPasatiempos.Margin = new Padding(2);
            tbxPasatiempos.Multiline = true;
            tbxPasatiempos.Name = "tbxPasatiempos";
            tbxPasatiempos.Size = new Size(293, 120);
            tbxPasatiempos.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 21;
            label2.Text = "nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 124);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 22;
            label3.Text = "Apellidos:";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(529, 78);
            tbxNombre.Margin = new Padding(2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(212, 31);
            tbxNombre.TabIndex = 23;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(529, 121);
            tbxApellidos.Margin = new Padding(2);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(212, 31);
            tbxApellidos.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(818, 80);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 25);
            label12.TabIndex = 25;
            label12.Text = "Carrera:";
            // 
            // tbxCarrera
            // 
            tbxCarrera.Location = new Point(898, 78);
            tbxCarrera.Margin = new Padding(2);
            tbxCarrera.Name = "tbxCarrera";
            tbxCarrera.Size = new Size(262, 31);
            tbxCarrera.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(834, 127);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 27;
            label4.Text = "Edad:";
            // 
            // tbxEdad
            // 
            tbxEdad.Location = new Point(898, 123);
            tbxEdad.Margin = new Padding(2);
            tbxEdad.Name = "tbxEdad";
            tbxEdad.Size = new Size(86, 31);
            tbxEdad.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(516, 186);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 29;
            label7.Text = "Pasatiempos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(939, 186);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 30;
            label8.Text = "Habilidades:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(516, 381);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(116, 25);
            label10.TabIndex = 31;
            label10.Text = "Aspiraciones:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(939, 381);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 32;
            label9.Text = "Intereses:";
            // 
            // tbxAspiraciones
            // 
            tbxAspiraciones.Location = new Point(430, 427);
            tbxAspiraciones.Margin = new Padding(2);
            tbxAspiraciones.Multiline = true;
            tbxAspiraciones.Name = "tbxAspiraciones";
            tbxAspiraciones.Size = new Size(293, 120);
            tbxAspiraciones.TabIndex = 33;
            // 
            // tbxHabilidades
            // 
            tbxHabilidades.Location = new Point(857, 230);
            tbxHabilidades.Margin = new Padding(2);
            tbxHabilidades.Multiline = true;
            tbxHabilidades.Name = "tbxHabilidades";
            tbxHabilidades.Size = new Size(293, 120);
            tbxHabilidades.TabIndex = 34;
            // 
            // tbxIntereses
            // 
            tbxIntereses.Location = new Point(857, 427);
            tbxIntereses.Margin = new Padding(2);
            tbxIntereses.Multiline = true;
            tbxIntereses.Name = "tbxIntereses";
            tbxIntereses.Size = new Size(293, 120);
            tbxIntereses.TabIndex = 35;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(914, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1048, 21);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnVotar);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1195, 564);
            panel1.TabIndex = 38;
            // 
            // frmVotacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 564);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(tbxIntereses);
            Controls.Add(tbxHabilidades);
            Controls.Add(tbxAspiraciones);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbxEdad);
            Controls.Add(tbxCarrera);
            Controls.Add(label12);
            Controls.Add(tbxApellidos);
            Controls.Add(tbxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxPasatiempos);
            Controls.Add(label1);
            Controls.Add(tbxId);
            Controls.Add(pbxFotoCandidata);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmVotacion";
            Text = "frmVotacion";
            Load += frmVotacion_Load;
            ((System.ComponentModel.ISupportInitialize)pbxFotoCandidata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxFotoCandidata;
        private TextBox tbxId;
        private Label label1;
        private Button btnVotar;
        private TextBox tbxPasatiempos;
        private Label label2;
        private Label label3;
        private TextBox tbxNombre;
        private TextBox tbxApellidos;
        private Label label12;
        private TextBox tbxCarrera;
        private Label label4;
        private TextBox tbxEdad;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private TextBox tbxAspiraciones;
        private TextBox tbxHabilidades;
        private TextBox tbxIntereses;
        private Button btnBuscar;
        private Button btnCancelar;
        private Panel panel1;
    }
}