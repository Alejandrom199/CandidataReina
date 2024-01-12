namespace CapaVisual.ModuloDocente
{
    partial class frmGaleriaFotos
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
            dgvCandidatasInfo = new DataGridView();
            label1 = new Label();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            tbxDescripcion = new TextBox();
            tbxTitulo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pbxMayor = new PictureBox();
            btnEliminarTodo = new Button();
            groupBox3 = new GroupBox();
            btnFoto4 = new Button();
            btnFoto3 = new Button();
            btnFoto2 = new Button();
            pbxFoto4 = new PictureBox();
            btnFoto1 = new Button();
            pbxFoto3 = new PictureBox();
            pbxFoto2 = new PictureBox();
            pbxFoto1 = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatasInfo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMayor).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFoto4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto1).BeginInit();
            SuspendLayout();
            // 
            // dgvCandidatasInfo
            // 
            dgvCandidatasInfo.AllowUserToAddRows = false;
            dgvCandidatasInfo.AllowUserToDeleteRows = false;
            dgvCandidatasInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatasInfo.Location = new Point(32, 97);
            dgvCandidatasInfo.Name = "dgvCandidatasInfo";
            dgvCandidatasInfo.ReadOnly = true;
            dgvCandidatasInfo.RowHeadersWidth = 62;
            dgvCandidatasInfo.RowTemplate.Height = 33;
            dgvCandidatasInfo.Size = new Size(290, 441);
            dgvCandidatasInfo.TabIndex = 0;
            dgvCandidatasInfo.CellClick += dgvCandidatasInfo_CellClick;
            dgvCandidatasInfo.CellPainting += dgvCandidatasInfo_CellPainting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(233, 23);
            label1.TabIndex = 1;
            label1.Text = "Selecciona una candidata";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(452, 537);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvCandidatasInfo);
            groupBox1.Location = new Point(16, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 591);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Candidatas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(btnEliminarTodo);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Location = new Point(385, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(665, 591);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visor de Imagenes";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbxDescripcion);
            groupBox4.Controls.Add(tbxTitulo);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(pbxMayor);
            groupBox4.Location = new Point(18, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(630, 410);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(332, 165);
            tbxDescripcion.Multiline = true;
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(275, 225);
            tbxDescripcion.TabIndex = 5;
            // 
            // tbxTitulo
            // 
            tbxTitulo.Location = new Point(332, 58);
            tbxTitulo.Multiline = true;
            tbxTitulo.Name = "tbxTitulo";
            tbxTitulo.Size = new Size(275, 47);
            tbxTitulo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 137);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 2;
            label2.Text = "Título";
            // 
            // pbxMayor
            // 
            pbxMayor.BorderStyle = BorderStyle.Fixed3D;
            pbxMayor.Location = new Point(15, 30);
            pbxMayor.Name = "pbxMayor";
            pbxMayor.Size = new Size(292, 360);
            pbxMayor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMayor.TabIndex = 1;
            pbxMayor.TabStop = false;
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(452, 492);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(128, 34);
            btnEliminarTodo.TabIndex = 9;
            btnEliminarTodo.Text = "Eliminar todo";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFoto4);
            groupBox3.Controls.Add(btnFoto3);
            groupBox3.Controls.Add(btnFoto2);
            groupBox3.Controls.Add(pbxFoto4);
            groupBox3.Controls.Add(btnFoto1);
            groupBox3.Controls.Add(pbxFoto3);
            groupBox3.Controls.Add(pbxFoto2);
            groupBox3.Controls.Add(pbxFoto1);
            groupBox3.Location = new Point(18, 433);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 143);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // btnFoto4
            // 
            btnFoto4.Location = new Point(270, 89);
            btnFoto4.Name = "btnFoto4";
            btnFoto4.Size = new Size(40, 40);
            btnFoto4.TabIndex = 9;
            btnFoto4.Text = "+";
            btnFoto4.UseVisualStyleBackColor = true;
            btnFoto4.Click += btnFoto4_Click;
            // 
            // btnFoto3
            // 
            btnFoto3.Location = new Point(188, 89);
            btnFoto3.Name = "btnFoto3";
            btnFoto3.Size = new Size(40, 40);
            btnFoto3.TabIndex = 8;
            btnFoto3.Text = "+";
            btnFoto3.UseVisualStyleBackColor = true;
            btnFoto3.Click += btnFoto3_Click;
            // 
            // btnFoto2
            // 
            btnFoto2.Location = new Point(110, 89);
            btnFoto2.Name = "btnFoto2";
            btnFoto2.Size = new Size(40, 40);
            btnFoto2.TabIndex = 7;
            btnFoto2.Text = "+";
            btnFoto2.UseVisualStyleBackColor = true;
            btnFoto2.Click += btnFoto2_Click;
            // 
            // pbxFoto4
            // 
            pbxFoto4.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto4.Location = new Point(260, 22);
            pbxFoto4.Name = "pbxFoto4";
            pbxFoto4.Size = new Size(60, 58);
            pbxFoto4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto4.TabIndex = 3;
            pbxFoto4.TabStop = false;
            pbxFoto4.Click += pbxFoto4_Click;
            // 
            // btnFoto1
            // 
            btnFoto1.Location = new Point(24, 89);
            btnFoto1.Name = "btnFoto1";
            btnFoto1.Size = new Size(40, 40);
            btnFoto1.TabIndex = 6;
            btnFoto1.Text = "+";
            btnFoto1.UseVisualStyleBackColor = true;
            btnFoto1.Click += btnFoto1_Click;
            // 
            // pbxFoto3
            // 
            pbxFoto3.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto3.Location = new Point(177, 22);
            pbxFoto3.Name = "pbxFoto3";
            pbxFoto3.Size = new Size(60, 58);
            pbxFoto3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto3.TabIndex = 2;
            pbxFoto3.TabStop = false;
            pbxFoto3.Click += pbxFoto3_Click;
            // 
            // pbxFoto2
            // 
            pbxFoto2.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto2.Location = new Point(99, 22);
            pbxFoto2.Name = "pbxFoto2";
            pbxFoto2.Size = new Size(60, 58);
            pbxFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto2.TabIndex = 1;
            pbxFoto2.TabStop = false;
            pbxFoto2.Click += pbxFoto2_Click;
            // 
            // pbxFoto1
            // 
            pbxFoto1.BorderStyle = BorderStyle.FixedSingle;
            pbxFoto1.Location = new Point(13, 22);
            pbxFoto1.Name = "pbxFoto1";
            pbxFoto1.Size = new Size(60, 58);
            pbxFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto1.TabIndex = 0;
            pbxFoto1.TabStop = false;
            pbxFoto1.Click += pbxFoto1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(452, 449);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmGaleriaFotos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 608);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmGaleriaFotos";
            Text = "frmGaleriaFotos";
            Load += frmGaleriaFotos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCandidatasInfo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMayor).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxFoto4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCandidatasInfo;
        private Label label1;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pbxMayor;
        private GroupBox groupBox3;
        private PictureBox pbxFoto4;
        private PictureBox pbxFoto3;
        private PictureBox pbxFoto2;
        private PictureBox pbxFoto1;
        private Button btnGuardar;
        private Button btnFoto1;
        private Button btnFoto4;
        private Button btnFoto3;
        private Button btnFoto2;
        private Button btnEliminarTodo;
        private GroupBox groupBox4;
        private TextBox tbxDescripcion;
        private TextBox tbxTitulo;
        private Label label3;
        private Label label2;
    }
}