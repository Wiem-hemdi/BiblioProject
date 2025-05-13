using System;
using System.Windows.Forms;
using GestionLivre;
using Microsoft.Extensions.DependencyInjection;

namespace GestionEtudiant
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private GestionLivresForm _livresForm;
        private GestionMembre _membreForm;
        private LoanForm _loanForm;
        private ImportExportForm _importExportForm;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            // Set this form as MDI container
            this.IsMdiContainer = true;
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLivresForm();
        }

        private void membreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMembreForm();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoanForm();
        }

        private void importexportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowImportExportForm();
        }

        // --- Private MDI display methods ---

        private void ShowLivresForm()
        {
            if (_livresForm == null || _livresForm.IsDisposed)
            {
                _livresForm = _serviceProvider.GetRequiredService<GestionLivresForm>();
                _livresForm.MdiParent = this;
                _livresForm.WindowState = FormWindowState.Maximized;
            }
            _livresForm.Show();
            _livresForm.Activate();
        }

        private void ShowMembreForm()
        {
            if (_membreForm == null || _membreForm.IsDisposed)
            {
                _membreForm = _serviceProvider.GetRequiredService<GestionMembre>();
                _membreForm.MdiParent = this;
                _membreForm.WindowState = FormWindowState.Maximized;
            }
            _membreForm.Show();
            _membreForm.Activate();
        }

        private void ShowLoanForm()
        {
            if (_loanForm == null || _loanForm.IsDisposed)
            {
                _loanForm = _serviceProvider.GetRequiredService<LoanForm>();
                _loanForm.MdiParent = this;
                _loanForm.WindowState = FormWindowState.Maximized;
            }
            _loanForm.Show();
            _loanForm.Activate();
        }
        private void ShowImportExportForm()
        {
            if (_importExportForm == null || _importExportForm.IsDisposed)
            {
                _importExportForm = _serviceProvider.GetRequiredService<ImportExportForm>();
                _importExportForm.MdiParent = this;
                _importExportForm.WindowState = FormWindowState.Maximized;
            }
            _importExportForm.Show();
            _importExportForm.Activate();
        }
    }
}
