namespace CapaVisual.ModuloDocente
{
    partial class frmConsultaResultados
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
            dgvCandidatas = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCandidatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvCandidatas
            // 
            dgvCandidatas.AllowUserToAddRows = false;
            dgvCandidatas.AllowUserToDeleteRows = false;
            dgvCandidatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidatas.Location = new Point(11, 316);
            dgvCandidatas.Margin = new Padding(2);
            dgvCandidatas.Name = "dgvCandidatas";
            dgvCandidatas.ReadOnly = true;
            dgvCandidatas.RowHeadersWidth = 62;
            dgvCandidatas.RowTemplate.Height = 33;
            dgvCandidatas.Size = new Size(1019, 234);
            dgvCandidatas.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(424, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 252);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(793, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 202);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(92, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 202);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 279);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 16;
            label1.Text = "PRIMER LUGAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(814, 279);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 17;
            label2.Text = "SEGUNDO LUGAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 279);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 18;
            label3.Text = "TERCER LUGAR";
            // 
            // button1
            // 
            button1.Location = new Point(11, 12);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 19;
            button1.Text = "ATRAS";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmConsultaResultados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 561);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvCandidatas);
            Name = "frmConsultaResultados";
            Text = "frmConsultaResultados";
            ((System.ComponentModel.ISupportInitialize)dgvCandidatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCandidatas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}