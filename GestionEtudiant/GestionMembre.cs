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

namespace GestionEtudiant
{
    public partial class GestionMembre : Form
    {
        private readonly LibraryContext _context;
        private readonly MemberRepository _memberRepo;

        public GestionMembre(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            _memberRepo = new MemberRepository(context);
            LoadMembers();
        }

        private void LoadMembers()
        {
            var members = _memberRepo.GetAll().Select(m => new
            {
                m.Id,
                m.FullName,
                m.Email,
                SubscriptionDate = m.SubscriptionDate.ToShortDateString(),
                Loans = m.Loans?.Count() ?? 0  // Use null-conditional operator to avoid null reference
            }).ToList();

            dataGridView1.DataSource = members;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            var newMember = new Member
            {
                FullName = txtUsername.Text,
                Email = txtEmail.Text,
                SubscriptionDate = DateTime.Now
            };

            _memberRepo.Add(newMember);
            LoadMembers();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Ensure that the "Id" column exists
                if (dataGridView1.CurrentRow.Cells["Id"] != null)
                {
                    int memberId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                    // Call your repository method to delete the member
                    _memberRepo.Delete(memberId);

                    // Refresh the DataGridView
                    LoadMembers();
                }
                else
                {
                    MessageBox.Show("Column 'Id' not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Ensure that the "Id" column exists
                if (dataGridView1.CurrentRow.Cells["Id"] != null)
                {
                    int memberId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    var member = _memberRepo.GetById(memberId);

                    if (member != null)
                    {
                        // Modify the member details here
                        member.FullName = txtUsername.Text;
                        member.Email = txtEmail.Text;

                        _memberRepo.Update(member);
                        LoadMembers();
                    }
                }
                else
                {
                    MessageBox.Show("Column 'Id' not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to modify.");
            }
        }


        private void buttonRefraichir_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int memberId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var member = _memberRepo.GetById(memberId);

                if (member != null)
                {
                    txtUsername.Text = member.FullName;
                    txtEmail.Text = member.Email;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
