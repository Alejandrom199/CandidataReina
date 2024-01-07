namespace CapaVisual
{
    partial class frmOpciones
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
            lblUsuario = new Label();
            btnAddCandidata = new Button();
            btnConsResultados = new Button();
            btnVisitCandidatas = new Button();
            btnVotaciones = new Button();
            lblVisitaCandidatas = new Label();
            lblAddCandidatas = new Label();
            lblVotaciones = new Label();
            lblConsulResultados = new Label();
            btnGaleria = new Button();
            lblGaleria = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(8, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // btnAddCandidata
            // 
            btnAddCandidata.Location = new Point(182, 163);
            btnAddCandidata.Name = "btnAddCandidata";
            btnAddCandidata.Size = new Size(120, 120);
            btnAddCandidata.TabIndex = 2;
            btnAddCandidata.Text = "Agregar Candidatas";
            btnAddCandidata.UseVisualStyleBackColor = true;
            btnAddCandidata.Click += btnAddCandidata_Click;
            // 
            // btnConsResultados
            // 
            btnConsResultados.Location = new Point(506, 163);
            btnConsResultados.Name = "btnConsResultados";
            btnConsResultados.Size = new Size(120, 120);
            btnConsResultados.TabIndex = 3;
            btnConsResultados.Text = "Consultar Resultados";
            btnConsResultados.UseVisualStyleBackColor = true;
            // 
            // btnVisitCandidatas
            // 
            btnVisitCandidatas.Location = new Point(226, 163);
            btnVisitCandidatas.Name = "btnVisitCandidatas";
            btnVisitCandidatas.Size = new Size(120, 120);
            btnVisitCandidatas.TabIndex = 4;
            btnVisitCandidatas.Text = "Visita de Candidatas";
            btnVisitCandidatas.UseVisualStyleBackColor = true;
            // 
            // btnVotaciones
            // 
            btnVotaciones.Location = new Point(448, 163);
            btnVotaciones.Name = "btnVotaciones";
            btnVotaciones.Size = new Size(120, 120);
            btnVotaciones.TabIndex = 5;
            btnVotaciones.Text = "Votaciones";
            btnVotaciones.UseVisualStyleBackColor = true;
            // 
            // lblVisitaCandidatas
            // 
            lblVisitaCandidatas.AutoSize = true;
            lblVisitaCandidatas.Location = new Point(203, 291);
            lblVisitaCandidatas.Name = "lblVisitaCandidatas";
            lblVisitaCandidatas.Size = new Size(172, 25);
            lblVisitaCandidatas.TabIndex = 6;
            lblVisitaCandidatas.Text = "Visita de Candidatas";
            // 
            // lblAddCandidatas
            // 
            lblAddCandidatas.AutoSize = true;
            lblAddCandidatas.Location = new Point(155, 291);
            lblAddCandidatas.Name = "lblAddCandidatas";
            lblAddCandidatas.Size = new Size(169, 25);
            lblAddCandidatas.TabIndex = 7;
            lblAddCandidatas.Text = "Agregar Candidatas";
            // 
            // lblVotaciones
            // 
            lblVotaciones.AutoSize = true;
            lblVotaciones.Location = new Point(460, 291);
            lblVotaciones.Name = "lblVotaciones";
            lblVotaciones.Size = new Size(98, 25);
            lblVotaciones.TabIndex = 8;
            lblVotaciones.Text = "Votaciones";
            // 
            // lblConsulResultados
            // 
            lblConsulResultados.AutoSize = true;
            lblConsulResultados.Location = new Point(481, 291);
            lblConsulResultados.Name = "lblConsulResultados";
            lblConsulResultados.Size = new Size(178, 25);
            lblConsulResultados.TabIndex = 9;
            lblConsulResultados.Text = "Consultar Resultados";
            // 
            // btnGaleria
            // 
            btnGaleria.Location = new Point(342, 163);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Size = new Size(120, 120);
            btnGaleria.TabIndex = 10;
            btnGaleria.Text = "Galeria de fotos";
            btnGaleria.UseVisualStyleBackColor = true;
            btnGaleria.Click += btnGaleria_Click;
            // 
            // lblGaleria
            // 
            lblGaleria.AutoSize = true;
            lblGaleria.Location = new Point(338, 291);
            lblGaleria.Name = "lblGaleria";
            lblGaleria.Size = new Size(137, 25);
            lblGaleria.TabIndex = 11;
            lblGaleria.Text = "Galeria de fotos";
            // 
            // frmOpciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGaleria);
            Controls.Add(btnGaleria);
            Controls.Add(lblConsulResultados);
            Controls.Add(lblVotaciones);
            Controls.Add(lblAddCandidatas);
            Controls.Add(lblVisitaCandidatas);
            Controls.Add(btnConsResultados);
            Controls.Add(btnAddCandidata);
            Controls.Add(lblUsuario);
            Controls.Add(btnVisitCandidatas);
            Controls.Add(btnVotaciones);
            Name = "frmOpciones";
            Text = "Form Opciones";
            FormClosed += frmOpciones_FormClosed;
            Load += FormGestor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private Button btnAddCandidata;
        private Button btnConsResultados;
        private Button btnVisitCandidatas;
        private Button btnVotaciones;
        private Label lblVisitaCandidatas;
        private Label lblAddCandidatas;
        private Label lblVotaciones;
        private Label lblConsulResultados;
        private Button btnGaleria;
        private Label lblGaleria;
    }
}