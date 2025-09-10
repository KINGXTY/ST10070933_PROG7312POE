using System;
using System.Windows.Forms;

namespace ST10070933_PROG7312POE.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            using var form = new ReportIssueForm();
            form.ShowDialog(this);
        }
    }
}