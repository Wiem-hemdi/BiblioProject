using System;
using System.Collections.Generic;

namespace GestionLivre
{
    public partial class GestionLivresForm : Form
    {
        private List<Livre> _livresListe = new List<Livre>();

        public GestionLivresForm()
        {
            InitializeComponent();
            ConfigurerDataGridView();
            InitialiserDonneesTest();
            RafraichirGrille();
        }

        // --- Méthodes d'initialisation ---  

        private void ConfigurerDataGridView()
        {
            // Création manuelle des colonnes
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Titre", "Titre");
            dataGridView.Columns.Add("Auteur", "Auteur");
            dataGridView.Columns.Add("Disponible", "Disponible");

        }

        private void InitialiserDonneesTest()
        {
            AjouterLivre("book1", "A1", "oui");
            AjouterLivre("book2", "A2", "Non");
            AjouterLivre("book3", "A3", "Oui");

        }

        private void RafraichirGrille()
        {
            dataGridView.Rows.Clear();
            foreach (var livre in _livresListe)
            {
                dataGridView.Rows.Add(livre.Id, livre.Titre, livre.Auteur, livre.Disponible);
            }
        }

        // --- Méthodes CRUD ---
        private void AjouterLivre(string titre, string auteur, string disponible)
        {
            _livresListe.Add(new Livre(titre, auteur, disponible));
        }

        private void ModifierLivre(int id, string titre, string auteur, string disponible)
        {
            foreach (var livre in _livresListe)
            {
                if (livre.Id == id)
                {
                    livre.Titre = titre;
                    livre.Auteur = auteur;
                    livre.Disponible = disponible;

                    break;
                }
            }
        }

        private void SupprimerLivre(int id)
        {
            _livresListe.RemoveAll(e => e.Id == id);
        }

        // --- Tri et Recherche ---
        private void TrierParNom()
        {
            _livresListe.Sort((a, b) => a.Titre.CompareTo(b.Titre));
        }

        private void RechercherParNom(string titre)
        {
            foreach (var livre in _livresListe)
            {
                if (livre.Titre.ToLower().Contains(titre.ToLower()))
                {
                    MessageBox.Show($"Trouvé : {livre.Titre} (ID: {livre.Id})");
                    return;
                }
            }
            MessageBox.Show("Aucun résultat.");
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
                int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                ModifierLivre(id, textBoxTitre.Text, textBoxAuteur.Text, textBoxDisponible.Text);
                RafraichirGrille();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                SupprimerLivre(id);
                RafraichirGrille();
            }
        }

        private void buttonTrier_Click(object sender, EventArgs e)
        {
            TrierParNom();
            RafraichirGrille();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            RechercherParNom(textBoxRecherche.Text);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
