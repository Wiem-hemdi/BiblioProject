namespace GestionEtudiant
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            welcomelabel = new Label();
            txtUsername = new TextBox();
            labelUsername = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(796, 442);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.BackColor = SystemColors.ControlLightLight;
            welcomelabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelabel.Location = new Point(37, 29);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(326, 23);
            welcomelabel.TabIndex = 1;
            welcomelabel.Text = "Bienvenue  à votre bibliothèque en ligne!";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(40, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 27);
            txtUsername.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.ControlLightLight;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(37, 128);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(117, 28);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 211);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 5;
            label1.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(40, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(22, 413);
            lblError.Name = "lblError";
            lblError.Size = new Size(275, 28);
            lblError.TabIndex = 7;
            lblError.Text = "Invalid username or password.";
            lblError.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(labelUsername);
            Controls.Add(txtUsername);
            Controls.Add(welcomelabel);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label welcomelabel;
        private TextBox txtUsername;
        private Label labelUsername;
        private Label label1;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblError;
    }
}