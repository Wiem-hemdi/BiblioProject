namespace GestionEtudiant
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            chkReturned = new CheckBox();
            dtLoanDate = new DateTimePicker();
            dgvLoans = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LoanDate = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            IsReturned = new DataGridViewCheckBoxColumn();
            loanBindingSource = new BindingSource(components);
            memberBindingSource = new BindingSource(components);
            btnAdd = new Button();
            cmbMembers = new ComboBox();
            cmbBooks = new ComboBox();
            dtReturnDate = new DateTimePicker();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnReturn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bookBindingSource = new BindingSource(components);
            Book = new DataGridViewTextBoxColumn();
            Member = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
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
            // chkReturned
            // 
            chkReturned.AutoSize = true;
            chkReturned.Location = new Point(670, 92);
            chkReturned.Name = "chkReturned";
            chkReturned.Size = new Size(91, 24);
            chkReturned.TabIndex = 5;
            chkReturned.Text = "Returned";
            chkReturned.UseVisualStyleBackColor = true;
            chkReturned.CheckedChanged += chkReturned_CheckedChanged;
            // 
            // dtLoanDate
            // 
            dtLoanDate.Location = new Point(61, 144);
            dtLoanDate.MaxDate = new DateTime(2029, 5, 13, 0, 0, 0, 0);
            dtLoanDate.MinDate = new DateTime(2025, 5, 13, 0, 0, 0, 0);
            dtLoanDate.Name = "dtLoanDate";
            dtLoanDate.Size = new Size(336, 27);
            dtLoanDate.TabIndex = 6;
            dtLoanDate.Value = new DateTime(2025, 5, 13, 0, 0, 0, 0);
            dtLoanDate.ValueChanged += dtLoanDate_ValueChanged;
            // 
            // dgvLoans
            // 
            dgvLoans.AutoGenerateColumns = false;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, LoanDate, ReturnDate, IsReturned, Book, Member });
            dgvLoans.DataSource = loanBindingSource;
            dgvLoans.Location = new Point(3, 177);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.Size = new Size(796, 188);
            dgvLoans.TabIndex = 8;
            dgvLoans.CellContentClick += dgvLoans_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // LoanDate
            // 
            LoanDate.DataPropertyName = "LoanDate";
            LoanDate.HeaderText = "LoanDate";
            LoanDate.MinimumWidth = 6;
            LoanDate.Name = "LoanDate";
            LoanDate.Width = 125;
            // 
            // ReturnDate
            // 
            ReturnDate.DataPropertyName = "ReturnDate";
            ReturnDate.HeaderText = "ReturnDate";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Width = 125;
            // 
            // IsReturned
            // 
            IsReturned.DataPropertyName = "IsReturned";
            IsReturned.HeaderText = "IsReturned";
            IsReturned.MinimumWidth = 6;
            IsReturned.Name = "IsReturned";
            IsReturned.Width = 125;
            // 
            // loanBindingSource
            // 
            loanBindingSource.DataSource = typeof(GestionLivre.Data.Entities.Loan);
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(GestionLivre.Data.Entities.Member);
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.add_icon;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(61, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "    Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // cmbMembers
            // 
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(365, 92);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(286, 28);
            cmbMembers.TabIndex = 11;
            cmbMembers.SelectedIndexChanged += cmbMembers_SelectedIndexChanged;
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(61, 92);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(286, 28);
            cmbBooks.TabIndex = 12;
            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(426, 144);
            dtReturnDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtReturnDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(336, 27);
            dtReturnDate.TabIndex = 13;
            dtReturnDate.Value = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtReturnDate.ValueChanged += dtReturnDate_ValueChanged;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.remove_icon;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(256, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "    Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.pencil_small_icon;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(443, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "    Modifier";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.White;
            btnReturn.Image = Properties.Resources.arrow_double_down_icon;
            btnReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturn.Location = new Point(620, 409);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(141, 29);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "    Retour";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 69);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 17;
            label2.Text = "Choisir Livre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 69);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 18;
            label3.Text = "Choisir Membre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 123);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 19;
            label4.Text = "Loan Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 121);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 20;
            label5.Text = "Return Date:";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(GestionLivre.Data.Entities.Book);
            // 
            // Book
            // 
            Book.DataPropertyName = "Book";
            Book.HeaderText = "Book";
            Book.MinimumWidth = 6;
            Book.Name = "Book";
            Book.Width = 125;
            // 
            // Member
            // 
            Member.DataPropertyName = "Member";
            Member.HeaderText = "Member";
            Member.MinimumWidth = 6;
            Member.Name = "Member";
            Member.Width = 125;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnReturn);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dtReturnDate);
            Controls.Add(cmbBooks);
            Controls.Add(cmbMembers);
            Controls.Add(btnAdd);
            Controls.Add(dgvLoans);
            Controls.Add(dtLoanDate);
            Controls.Add(chkReturned);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoanForm";
            Text = "DetailLivre";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox chkReturned;
        private DateTimePicker dtLoanDate;
        private DataGridView dgvLoans;
        private Button btnAdd;
        private ComboBox cmbMembers;
        private ComboBox cmbBooks;
        private DateTimePicker dtReturnDate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnReturn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource bookBindingSource;
        private BindingSource loanBindingSource;
        private BindingSource memberBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LoanDate;
        private DataGridViewTextBoxColumn ReturnDate;
        private DataGridViewCheckBoxColumn IsReturned;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn Member;
    }
}