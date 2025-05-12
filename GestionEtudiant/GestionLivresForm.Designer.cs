namespace GestionLivre
{
    partial class GestionLivresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLivresForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            groupBoxLivre = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelTitre = new Label();
            labelAuteur = new Label();
            textBoxTitre = new TextBox();
            Disponible = new Label();
            textBoxAuteur = new TextBox();
            textBoxDisponible = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            textBoxRecherche = new TextBox();
            buttonRechercher = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonTrier = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBoxLivre.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBoxLivre, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1100, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.PaleGoldenrod;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 310);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1092, 316);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // groupBoxLivre
            // 
            groupBoxLivre.AutoSize = true;
            groupBoxLivre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxLivre.BackColor = Color.PaleGoldenrod;
            groupBoxLivre.BackgroundImageLayout = ImageLayout.None;
            groupBoxLivre.Controls.Add(tableLayoutPanel2);
            groupBoxLivre.Dock = DockStyle.Fill;
            groupBoxLivre.Location = new Point(4, 76);
            groupBoxLivre.Margin = new Padding(4);
            groupBoxLivre.Name = "groupBoxLivre";
            groupBoxLivre.Padding = new Padding(4);
            groupBoxLivre.Size = new Size(1092, 158);
            groupBoxLivre.TabIndex = 4;
            groupBoxLivre.TabStop = false;
            groupBoxLivre.Text = "Détails Livre";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 395F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelTitre, 0, 0);
            tableLayoutPanel2.Controls.Add(labelAuteur, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxTitre, 1, 0);
            tableLayoutPanel2.Controls.Add(Disponible, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxAuteur, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxDisponible, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 31);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1084, 123);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Dock = DockStyle.Fill;
            labelTitre.Location = new Point(4, 0);
            labelTitre.Margin = new Padding(4, 0, 4, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(139, 45);
            labelTitre.TabIndex = 7;
            labelTitre.Text = "&Titre : ";
            labelTitre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAuteur
            // 
            labelAuteur.AutoSize = true;
            labelAuteur.Dock = DockStyle.Fill;
            labelAuteur.Location = new Point(4, 45);
            labelAuteur.Margin = new Padding(4, 0, 4, 0);
            labelAuteur.Name = "labelAuteur";
            labelAuteur.Size = new Size(139, 42);
            labelAuteur.TabIndex = 9;
            labelAuteur.Text = "Auteur :";
            labelAuteur.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTitre
            // 
            textBoxTitre.Dock = DockStyle.Fill;
            textBoxTitre.Location = new Point(151, 4);
            textBoxTitre.Margin = new Padding(4);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(387, 34);
            textBoxTitre.TabIndex = 8;
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.Location = new Point(3, 87);
            Disponible.Name = "Disponible";
            Disponible.Size = new Size(122, 30);
            Disponible.TabIndex = 11;
            Disponible.Text = "Disponible :";
            // 
            // textBoxAuteur
            // 
            textBoxAuteur.Location = new Point(150, 48);
            textBoxAuteur.Name = "textBoxAuteur";
            textBoxAuteur.Size = new Size(389, 34);
            textBoxAuteur.TabIndex = 13;
            // 
            // textBoxDisponible
            // 
            textBoxDisponible.Location = new Point(150, 90);
            textBoxDisponible.Name = "textBoxDisponible";
            textBoxDisponible.Size = new Size(389, 34);
            textBoxDisponible.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.PaleGoldenrod;
            flowLayoutPanel1.Controls.Add(buttonAjouter);
            flowLayoutPanel1.Controls.Add(buttonModifier);
            flowLayoutPanel1.Controls.Add(buttonSupprimer);
            flowLayoutPanel1.Controls.Add(textBoxRecherche);
            flowLayoutPanel1.Controls.Add(buttonRechercher);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1092, 64);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonAjouter
            // 
            buttonAjouter.AutoSize = true;
            buttonAjouter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAjouter.Cursor = Cursors.Hand;
            buttonAjouter.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonAjouter.Image = Properties.Resources.add_icon;
            buttonAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAjouter.Location = new Point(4, 4);
            buttonAjouter.Margin = new Padding(4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(145, 54);
            buttonAjouter.TabIndex = 0;
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
            buttonModifier.Location = new Point(157, 4);
            buttonModifier.Margin = new Padding(4);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(156, 54);
            buttonModifier.TabIndex = 1;
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
            buttonSupprimer.Location = new Point(321, 4);
            buttonSupprimer.Margin = new Padding(4);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(174, 54);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "&Supprimer";
            buttonSupprimer.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Location = new Point(502, 15);
            textBoxRecherche.Margin = new Padding(3, 15, 3, 3);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(289, 34);
            textBoxRecherche.TabIndex = 4;
            // 
            // buttonRechercher
            // 
            buttonRechercher.AutoSize = true;
            buttonRechercher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRechercher.Cursor = Cursors.Hand;
            buttonRechercher.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRechercher.Image = Properties.Resources.spyglass_icon;
            buttonRechercher.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRechercher.Location = new Point(797, 3);
            buttonRechercher.Name = "buttonRechercher";
            buttonRechercher.Size = new Size(179, 54);
            buttonRechercher.TabIndex = 3;
            buttonRechercher.Text = "&Rechercher";
            buttonRechercher.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRechercher.UseVisualStyleBackColor = true;
            buttonRechercher.Click += buttonRechercher_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.Controls.Add(buttonTrier);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(4, 242);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1092, 60);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonTrier
            // 
            buttonTrier.AutoSize = true;
            buttonTrier.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonTrier.Cursor = Cursors.Hand;
            buttonTrier.Image = Properties.Resources.arrow_double_up_icon;
            buttonTrier.Location = new Point(890, 4);
            buttonTrier.Margin = new Padding(4);
            buttonTrier.Name = "buttonTrier";
            buttonTrier.Size = new Size(198, 54);
            buttonTrier.TabIndex = 11;
            buttonTrier.Text = "&Trier par Nom";
            buttonTrier.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTrier.UseVisualStyleBackColor = true;
            buttonTrier.Click += buttonTrier_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(927, 62);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // GestionLivresForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "GestionLivresForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Livres";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBoxLivre.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private GroupBox groupBoxLivre;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelId;
        private TextBox textBoxID;
        private Label labelTitre;
        private Label labelAuteur;
        private TextBox textBoxTitre;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonTrier;
        private Button buttonSupprimer;
        private Button buttonAjouter;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonModifier;
        private Button buttonRechercher;
        private TextBox textBoxRecherche;
        private Label Disponible;
        private TextBox textBoxDisponible;
        private TextBox textBoxAuteur;
        private PictureBox pictureBox1;
    }
}
