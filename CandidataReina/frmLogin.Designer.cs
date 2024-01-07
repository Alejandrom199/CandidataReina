namespace CandidataReina
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            tbxUsername = new TextBox();
            tbxClave = new TextBox();
            btnVerClave = new Button();
            panel1 = new Panel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Location = new Point(180, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 114);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 207);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Clave:";
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(187, 114);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(178, 31);
            tbxUsername.TabIndex = 3;
            // 
            // tbxClave
            // 
            tbxClave.Location = new Point(187, 207);
            tbxClave.Name = "tbxClave";
            tbxClave.Size = new Size(150, 31);
            tbxClave.TabIndex = 4;
            // 
            // btnVerClave
            // 
            btnVerClave.Location = new Point(331, 205);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(34, 34);
            btnVerClave.TabIndex = 5;
            btnVerClave.Text = "o";
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = CapaVisual.Properties.Resources.ug_reina;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 451);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 45);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 7;
            label3.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(280, 422);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(179, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvide mi contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnVerClave);
            panel2.Controls.Add(tbxClave);
            panel2.Controls.Add(tbxUsername);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(358, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 449);
            panel2.TabIndex = 9;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox tbxUsername;
        private TextBox tbxClave;
        private Button btnVerClave;
        private Panel panel1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Panel panel2;
    }
}
