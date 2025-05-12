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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMembre));
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            groupBoxLivre = new GroupBox();
            button1 = new Button();
            txtUsername = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBoxLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // groupBoxLivre
            // 
            groupBoxLivre.AutoSize = true;
            groupBoxLivre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxLivre.BackColor = Color.PaleGoldenrod;
            groupBoxLivre.BackgroundImageLayout = ImageLayout.None;
            groupBoxLivre.Controls.Add(label1);
            groupBoxLivre.Controls.Add(textBox1);
            groupBoxLivre.Controls.Add(label2);
            groupBoxLivre.Controls.Add(dataGridView1);
            groupBoxLivre.Controls.Add(txtUsername);
            groupBoxLivre.Controls.Add(button1);
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
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            button1.Image = Properties.Resources.arrow_double_up_icon;
            button1.Location = new Point(595, 43);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(165, 54);
            button1.TabIndex = 8;
            button1.Text = "&Refraichir";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(305, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(432, 27);
            txtUsername.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 204);
            dataGridView1.TabIndex = 13;
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
            // textBox1
            // 
            textBox1.Location = new Point(305, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 27);
            textBox1.TabIndex = 15;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private GroupBox groupBoxLivre;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtUsername;
    }
}