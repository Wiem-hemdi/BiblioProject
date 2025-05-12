using System;
using System.Linq;
using System.Windows.Forms;
using GestionLivre.Data.Context;
using GestionLivre.Data.Entities;

namespace GestionLivre
{
    public partial class GestionLivresForm : Form
    {
        private readonly LibraryContext _context;

        public GestionLivresForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            ConfigurerDataGridView();
            RafraichirGrille();
        }

        // --- Méthodes d'initialisation ---  
        private void ConfigurerDataGridView()
        {
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Titre", "Titre");
            dataGridView.Columns.Add("Auteur", "Auteur");
            dataGridView.Columns.Add("Disponible", "Disponible");
        }

        private void RafraichirGrille()
        {
            dataGridView.Rows.Clear();
            var livres = _context.Books.ToList();
            foreach (var livre in livres)
            {
                dataGridView.Rows.Add(
                    livre.Id,
                    livre.Title,
                    livre.Author,
                    livre.AvailableCopies > 0 ? "Oui" : "Non"
                );
            }
        }

        // --- Méthodes CRUD ---
        private void AjouterLivre(string titre, string auteur, string disponible)
        {
            var livre = new Book
            {
                Title = titre,
                Author = auteur,
                TotalCopies = 1,
                AvailableCopies = disponible.ToLower() == "oui" ? 1 : 0
            };
            _context.Books.Add(livre);
            _context.SaveChanges();
        }

        private void ModifierLivre(int id, string titre, string auteur, string disponible)
        {
            var livre = _context.Books.Find(id);
            if (livre != null)
            {
                livre.Title = titre;
                livre.Author = auteur;
                livre.AvailableCopies = disponible.ToLower() == "oui" ? livre.TotalCopies : 0;
                _context.SaveChanges();
            }
        }

        private void SupprimerLivre(int id)
        {
            var livre = _context.Books.Find(id);
            if (livre != null)
            {
                _context.Books.Remove(livre);
                _context.SaveChanges();
            }
        }

        // --- Tri et Recherche ---
        private void TrierParNom()
        {
            var livresTries = _context.Books.OrderBy(l => l.Title).ToList();
            dataGridView.Rows.Clear();
            foreach (var livre in livresTries)
            {
                dataGridView.Rows.Add(
                    livre.Id,
                    livre.Title,
                    livre.Author,
                    livre.AvailableCopies > 0 ? "Oui" : "Non"
                );
            }
        }

        private void RechercherParNom(string titre)
        {
            var resultats = _context.Books
                .Where(b => b.Title.ToLower().Contains(titre.ToLower()))
                .ToList();

            if (resultats.Any())
            {
                dataGridView.Rows.Clear();
                foreach (var livre in resultats)
                {
                    dataGridView.Rows.Add(
                        livre.Id,
                        livre.Title,
                        livre.Author,
                        livre.AvailableCopies > 0 ? "Oui" : "Non"
                    );
                }
            }
            else
            {
                MessageBox.Show("Aucun résultat.");
            }
        }

        // --- Gestionnaires d'événements ---
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitre.Text) &&
                !string.IsNullOrEmpty(textBoxAuteur.Text) &&
                !string.IsNullOrEmpty(textBoxDisponible.Text))
            {
                AjouterLivre(textBoxTitre.Text, textBoxAuteur.Text, textBoxDisponible.Text);
                RafraichirGrille();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                ModifierLivre(id, textBoxTitre.Text, textBoxAuteur.Text, textBoxDisponible.Text);
                RafraichirGrille();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                SupprimerLivre(id);
                RafraichirGrille();
            }
        }

        private void buttonTrier_Click(object sender, EventArgs e)
        {
            TrierParNom();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            RechercherParNom(textBoxRecherche.Text);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Fill fields when selecting a row
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBoxTitre.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxAuteur.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxDisponible.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
