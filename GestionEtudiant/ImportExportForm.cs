using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GestionLivre.Data.Repositories;
using GestionLivre.Data.Entities; // Assuming you have Book, Member, etc.
using System.Text.Json;
using System.Linq;


namespace GestionEtudiant
{
    public partial class ImportExportForm : Form
    {
        private readonly BookRepository _bookRepo;

        public ImportExportForm(BookRepository bookRepo)
        {
            InitializeComponent();
            _bookRepo = bookRepo;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|CSV files (*.csv)|*.csv",
                Title = "Exporter les livres"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var books = _bookRepo.GetAll().ToList();

                if (saveDialog.FileName.EndsWith(".json"))
                {
                    File.WriteAllText(saveDialog.FileName, JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true }));
                }
                else if (saveDialog.FileName.EndsWith(".csv"))
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Title,Author,TotalCopies,AvailableCopies");
                    foreach (var book in books)
                    {
                        sb.AppendLine($"{Escape(book.Title)},{Escape(book.Author)},{book.TotalCopies},{book.AvailableCopies}");
                    }
                    File.WriteAllText(saveDialog.FileName, sb.ToString());
                }

                MessageBox.Show("Export terminé avec succès !");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|CSV files (*.csv)|*.csv",
                Title = "Importer des livres"
            };

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var importedBooks = new List<Book>();
                var file = openDialog.FileName;

                try
                {
                    if (file.EndsWith(".json"))
                    {
                        var json = File.ReadAllText(file);
                        importedBooks = JsonSerializer.Deserialize<List<Book>>(json);
                    }
                    else if (file.EndsWith(".csv"))
                    {
                        var lines = File.ReadAllLines(file).Skip(1); // skip header
                        foreach (var line in lines)
                        {
                            var parts = line.Split(',');

                            if (parts.Length >= 4)
                            {
                                importedBooks.Add(new Book
                                {
                                    Title = parts[0],
                                    Author = parts[1],
                                    TotalCopies = int.TryParse(parts[2], out int total) ? total : 0,
                                    AvailableCopies = int.TryParse(parts[3], out int available) ? available : 0
                                });
                            }
                        }
                    }

                    foreach (var book in importedBooks)
                    {
                        _bookRepo.Add(book);
                    }

                    MessageBox.Show("Importation terminée !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur d'import : {ex.Message}");
                }
            }
        }

        private string Escape(string value)
        {
            return value.Contains(",") ? $"\"{value}\"" : value;
        }
    }
}