using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLivre.Data.Context;
using GestionLivre.Data.Entities;
using GestionLivre.Data.Repositories;
using Microsoft.EntityFrameworkCore;


namespace GestionEtudiant
{
    public partial class LoanForm : Form
    {
        private readonly LibraryContext _context;
        private readonly LoanRepository _loanRepo;

        public LoanForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            _loanRepo = new LoanRepository(context);
            LoadComboBoxes();
            LoadLoans();
        }
        private void LoadComboBoxes()
        {
            cmbBooks.DataSource = _context.Books.ToList();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Id";

            cmbMembers.DataSource = _context.Members.ToList();
            cmbMembers.DisplayMember = "FullName";
            cmbMembers.ValueMember = "Id";
        }
        public IEnumerable<Loan> GetAllLoansWithDetails()
        {
            return _context.Loans
                .Include(l => l.Book)  // Include the related Book entity
                .Include(l => l.Member) // Include the related Member entity
                .ToList();              // Execute the query and return the result as a list
        }
        private void LoadLoans()
        {
            
            // Use the method to get loans with related data
            var loans = _loanRepo.GetAllLoansWithDetails()
                .Select(l => new
                {
                    Id = l.Id,
                    Book = l.Book?.Title,     // Access the Book title
                    Member = l.Member?.FullName, // Access the Member full name
                    LoanDate = l.LoanDate.ToShortDateString(),
                    ReturnDate = l.ReturnDate?.ToShortDateString() ?? "Not Returned",
                    Returned = l.IsReturned
                })
                .ToList();

            // Bind the data to the DataGridView
            dgvLoans.DataSource = loans;
        }




        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int bookId = (int)cmbBooks.SelectedValue;
            int memberId = (int)cmbMembers.SelectedValue;

            _loanRepo.BorrowBook(bookId, memberId);
            LoadLoans();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null)
            {
                int loanId = (int)dgvLoans.CurrentRow.Cells["Id"].Value;

                var loan = _context.Loans.Find(loanId);

                if (loan != null)
                {
                    _context.Loans.Remove(loan);
                    _context.SaveChanges();
                    LoadLoans();
                }
            }
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null)
            {
                int loanId = (int)dgvLoans.CurrentRow.Cells["Id"].Value;
                var loan = _loanRepo.GetById(loanId);

                if (loan != null)
                {
                    loan.BookId = (int)cmbBooks.SelectedValue;
                    loan.MemberId = (int)cmbMembers.SelectedValue;
                    loan.LoanDate = dtLoanDate.Value;
                    loan.ReturnDate = chkReturned.Checked ? dtReturnDate.Value : null;

                    _context.SaveChanges();
                    LoadLoans();
                }
            }
        }


        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null)
            {
                int loanId = (int)dgvLoans.CurrentRow.Cells["Id"].Value;
                _loanRepo.ReturnBook(loanId);
                LoadLoans();
            }
        }


        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkReturned_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtLoanDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null)
            {
                int loanId = (int)dgvLoans.CurrentRow.Cells["Id"].Value;
                var loan = _loanRepo.GetById(loanId);

                if (loan != null)
                {
                    cmbBooks.SelectedValue = loan.BookId;
                    cmbMembers.SelectedValue = loan.MemberId;
                    dtLoanDate.Value = loan.LoanDate;
                    chkReturned.Checked = loan.IsReturned;
                    dtReturnDate.Value = loan.ReturnDate ?? DateTime.Now;
                }
            }
        }

    }
}
