namespace GestionEtudiant
{
    partial class DetailLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailLivre));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(796, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 19);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 2;
            label1.Text = "Details Livre";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(670, 92);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Returned";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(61, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(336, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 188);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.add_icon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(61, 409);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 9;
            button1.Text = "    Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(365, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(286, 28);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(61, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 28);
            comboBox1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(426, 144);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(336, 27);
            dateTimePicker2.TabIndex = 13;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.remove_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(256, 409);
            button2.Name = "button2";
            button2.Size = new Size(141, 29);
            button2.TabIndex = 14;
            button2.Text = "    Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.pencil_small_icon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(443, 409);
            button3.Name = "button3";
            button3.Size = new Size(141, 29);
            button3.TabIndex = 15;
            button3.Text = "    Modifier";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Image = Properties.Resources.arrow_double_down_icon;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(620, 409);
            button4.Name = "button4";
            button4.Size = new Size(141, 29);
            button4.TabIndex = 16;
            button4.Text = "    Retour";
            button4.UseVisualStyleBackColor = false;
            // 
            // DetailLivre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DetailLivre";
            Text = "DetailLivre";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}