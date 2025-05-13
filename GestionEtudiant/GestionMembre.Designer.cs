namespace GestionEtudiant
{
    partial class GestionMembre
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMembre));
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            groupBoxLivre = new GroupBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subscriptionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loansDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberBindingSource = new BindingSource(components);
            txtUsername = new TextBox();
            buttonRefraichir = new Button();
            groupBoxLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonAjouter
            // 
            buttonAjouter.AutoSize = true;
            buttonAjouter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAjouter.Cursor = Cursors.Hand;
            buttonAjouter.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonAjouter.Image = Properties.Resources.add_icon;
            buttonAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAjouter.Location = new Point(44, 43);
            buttonAjouter.Margin = new Padding(4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(145, 54);
            buttonAjouter.TabIndex = 5;
            buttonAjouter.Text = "&Ajouter";
            buttonAjouter.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.AutoSize = true;
            buttonModifier.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonModifier.Cursor = Cursors.Hand;
            buttonModifier.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonModifier.Image = Properties.Resources.pencil_small_icon;
            buttonModifier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModifier.Location = new Point(211, 43);
            buttonModifier.Margin = new Padding(4);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(156, 54);
            buttonModifier.TabIndex = 6;
            buttonModifier.Text = "&Modifier";
            buttonModifier.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.AutoSize = true;
            buttonSupprimer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonSupprimer.Image = (Image)resources.GetObject("buttonSupprimer.Image");
            buttonSupprimer.Location = new Point(396, 43);
            buttonSupprimer.Margin = new Padding(4);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(174, 54);
            buttonSupprimer.TabIndex = 7;
            buttonSupprimer.Text = "&Supprimer";
            buttonSupprimer.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonDelete_Click;
            // 
            // groupBoxLivre
            // 
            groupBoxLivre.AutoSize = true;
            groupBoxLivre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxLivre.BackColor = Color.PaleGoldenrod;
            groupBoxLivre.BackgroundImageLayout = ImageLayout.None;
            groupBoxLivre.Controls.Add(label1);
            groupBoxLivre.Controls.Add(txtEmail);
            groupBoxLivre.Controls.Add(label2);
            groupBoxLivre.Controls.Add(dataGridView1);
            groupBoxLivre.Controls.Add(txtUsername);
            groupBoxLivre.Controls.Add(buttonRefraichir);
            groupBoxLivre.Controls.Add(buttonSupprimer);
            groupBoxLivre.Controls.Add(buttonModifier);
            groupBoxLivre.Controls.Add(buttonAjouter);
            groupBoxLivre.Dock = DockStyle.Fill;
            groupBoxLivre.Location = new Point(0, 0);
            groupBoxLivre.Margin = new Padding(4);
            groupBoxLivre.Name = "groupBoxLivre";
            groupBoxLivre.Padding = new Padding(4);
            groupBoxLivre.Size = new Size(800, 450);
            groupBoxLivre.TabIndex = 8;
            groupBoxLivre.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 193);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 16;
            label1.Text = "Email du membre :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(305, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(432, 27);
            txtEmail.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 142);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 14;
            label2.Text = "Nom du membre :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, subscriptionDateDataGridViewTextBoxColumn, loansDataGridViewTextBoxColumn });
            dataGridView1.DataSource = memberBindingSource;
            dataGridView1.Location = new Point(-5, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 204);
            dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // subscriptionDateDataGridViewTextBoxColumn
            // 
            subscriptionDateDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionDate";
            subscriptionDateDataGridViewTextBoxColumn.HeaderText = "SubscriptionDate";
            subscriptionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            subscriptionDateDataGridViewTextBoxColumn.Name = "subscriptionDateDataGridViewTextBoxColumn";
            subscriptionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // loansDataGridViewTextBoxColumn
            // 
            loansDataGridViewTextBoxColumn.DataPropertyName = "Loans";
            loansDataGridViewTextBoxColumn.HeaderText = "Loans";
            loansDataGridViewTextBoxColumn.MinimumWidth = 6;
            loansDataGridViewTextBoxColumn.Name = "loansDataGridViewTextBoxColumn";
            loansDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(GestionLivre.Data.Entities.Member);
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(305, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(432, 27);
            txtUsername.TabIndex = 9;
            // 
            // buttonRefraichir
            // 
            buttonRefraichir.AutoSize = true;
            buttonRefraichir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRefraichir.Cursor = Cursors.Hand;
            buttonRefraichir.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonRefraichir.Image = Properties.Resources.arrow_double_up_icon;
            buttonRefraichir.Location = new Point(595, 43);
            buttonRefraichir.Margin = new Padding(4);
            buttonRefraichir.Name = "buttonRefraichir";
            buttonRefraichir.Size = new Size(165, 54);
            buttonRefraichir.TabIndex = 8;
            buttonRefraichir.Text = "&Refraichir";
            buttonRefraichir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRefraichir.UseVisualStyleBackColor = true;
            buttonRefraichir.Click += buttonRefraichir_Click;
            // 
            // GestionMembre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxLivre);
            Name = "GestionMembre";
            Text = "GestionMembre";
            groupBoxLivre.ResumeLayout(false);
            groupBoxLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private GroupBox groupBoxLivre;
        private Button buttonRefraichir;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtUsername;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subscriptionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loansDataGridViewTextBoxColumn;
        private BindingSource memberBindingSource;
    }
}