namespace ST10070933_PROG7312POE.Forms
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnServiceStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citizen Services";

            // Title Label
            this.lblTitle.Text = "Citizen Services";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 100;

            // Report Issues Button
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.Size = new System.Drawing.Size(250, 50);
            this.btnReportIssues.Location = new System.Drawing.Point(75, 150);
            this.btnReportIssues.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // Local Events Button
            this.btnEvents.Text = "Local Events (Coming Soon)";
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEvents.Size = new System.Drawing.Size(250, 50);
            this.btnEvents.Location = new System.Drawing.Point(75, 230);
            this.btnEvents.Enabled = false;
            this.btnEvents.BackColor = System.Drawing.Color.LightGray;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.FlatAppearance.BorderSize = 0;

            // Service Requests Button
            this.btnServiceStatus.Text = "Service Requests (Coming Soon)";
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnServiceStatus.Size = new System.Drawing.Size(250, 50);
            this.btnServiceStatus.Location = new System.Drawing.Point(75, 310);
            this.btnServiceStatus.Enabled = false;
            this.btnServiceStatus.BackColor = System.Drawing.Color.LightGray;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.FlatAppearance.BorderSize = 0;

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnServiceStatus);

            this.ResumeLayout(false);
        }
    }
}