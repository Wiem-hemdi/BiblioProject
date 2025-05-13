namespace GestionEtudiant
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            livreToolStripMenuItem = new ToolStripMenuItem();
            membreToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            importexportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { livreToolStripMenuItem, membreToolStripMenuItem, loanToolStripMenuItem, importexportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // livreToolStripMenuItem
            // 
            livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            livreToolStripMenuItem.Size = new Size(54, 24);
            livreToolStripMenuItem.Text = "Livre";
            livreToolStripMenuItem.Click += livreToolStripMenuItem_Click;
            // 
            // membreToolStripMenuItem
            // 
            membreToolStripMenuItem.Name = "membreToolStripMenuItem";
            membreToolStripMenuItem.Size = new Size(79, 24);
            membreToolStripMenuItem.Text = "Membre";
            membreToolStripMenuItem.Click += membreToolStripMenuItem_Click;
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(55, 24);
            loanToolStripMenuItem.Text = "Loan";
            loanToolStripMenuItem.Click += loanToolStripMenuItem_Click;
            // 
            // importexportToolStripMenuItem
            // 
            importexportToolStripMenuItem.Name = "importexportToolStripMenuItem";
            importexportToolStripMenuItem.Size = new Size(117, 24);
            importexportToolStripMenuItem.Text = "Import/export";
            importexportToolStripMenuItem.Click += importexportToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem livreToolStripMenuItem;
        private ToolStripMenuItem membreToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem importexportToolStripMenuItem;
    }
}