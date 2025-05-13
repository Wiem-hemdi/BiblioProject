namespace GestionEtudiant
{
    partial class ImportExportForm
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
            btnExport = new Button();
            btnImport = new Button();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.Location = new Point(99, 163);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(213, 109);
            btnExport.TabIndex = 0;
            btnExport.Text = "Exporter";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(473, 163);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(213, 109);
            btnImport.TabIndex = 1;
            btnImport.Text = "Importer";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // ImportExportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Name = "ImportExportForm";
            Text = "ImportExportForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExport;
        private Button btnImport;
    }
}