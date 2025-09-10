using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ST10070933_PROG7312POE.Models;
using ST10070933_PROG7312POE.Services;

namespace ST10070933_PROG7312POE.Forms
{
    public partial class ReportIssueForm : Form
    {
        private readonly List<string> _attachments = new();
        private readonly string[] _encouragements = new[]
        {
            "Great start! Add a few more details.",
            "You're doing awesome—this helps the whole community.",
            "Almost there! Attach a photo if you have one.",
            "Thanks for taking the time to report this.",
            "Ready to submit? Hit the button when you're done."
        };

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void ReportIssueForm_Load(object? sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(IssueCategory));
            UpdateProgress();
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Select images or documents",
                Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.txt|All files|*.*",
                Multiselect = true,
                CheckFileExists = true
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var path in dlg.FileNames)
                {
                    if (!_attachments.Contains(path))
                    {
                        _attachments.Add(path);
                        lstAttachments.Items.Add(Path.GetFileName(path));
                    }
                }
                UpdateProgress();
            }
        }

        private void btnRemoveAttachment_Click(object sender, EventArgs e)
        {
            var indices = lstAttachments.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();
            foreach (var i in indices)
            {
                lstAttachments.Items.RemoveAt(i);
                _attachments.RemoveAt(i);
            }
            UpdateProgress();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out var error))
            {
                MessageBox.Show(this, error, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var issue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = (IssueCategory)cmbCategory.SelectedItem!,
                Description = rtbDescription.Text.Trim(),
                Attachments = new List<string>(_attachments)
            };

            IssuesRepository.Add(issue);
            MessageBox.Show(this, "Thank you! Your issue has been submitted successfully.",
                "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form for next report
            txtLocation.Clear();
            cmbCategory.SelectedIndex = 0;
            rtbDescription.Clear();
            _attachments.Clear();
            lstAttachments.Items.Clear();
            UpdateProgress();
        }

        private bool ValidateInputs(out string error)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                error = "Please enter the location of the issue.";
                return false;
            }
            if (cmbCategory.SelectedItem is null)
            {
                error = "Please select a category.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                error = "Please provide a brief description.";
                return false;
            }
            error = string.Empty;
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnyInputChanged_UpdateProgress(object? sender, EventArgs e) => UpdateProgress();

        private void UpdateProgress()
        {
            int steps = 3; // location, category, description
            int score = 0;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) score++;
            if (cmbCategory.SelectedItem != null) score++;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) score++;

            int percent = (int)(score / (double)steps * 100);
            if (_attachments.Count > 0) percent = Math.Min(100, percent + 10);

            progressReport.Value = percent;
            lblEngagement.Text = _encouragements[Math.Min(_encouragements.Length - 1, percent / 25)];
        }
    }
}