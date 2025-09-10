namespace ST10070933_PROG7312POE.Forms
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.Button btnRemoveAttachment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar progressReport;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Label lblLocation;

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
            lblTitle = new Label();
            lblEngagement = new Label();
            txtLocation = new TextBox();
            cmbCategory = new ComboBox();
            rtbDescription = new RichTextBox();
            lstAttachments = new ListBox();
            btnAddAttachment = new Button();
            btnRemoveAttachment = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            progressReport = new ProgressBar();
            lblCategory = new Label();
            lblDescription = new Label();
            lblAttachments = new Label();
            lblLocation = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MediumSlateBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Report an Issue";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEngagement
            // 
            lblEngagement.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblEngagement.ForeColor = Color.Gray;
            lblEngagement.Location = new Point(100, 560);
            lblEngagement.Name = "lblEngagement";
            lblEngagement.Size = new Size(300, 40);
            lblEngagement.TabIndex = 10;
            lblEngagement.Text = "Start filling out the form...";
            lblEngagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F);
            txtLocation.Location = new Point(100, 100);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(300, 29);
            txtLocation.TabIndex = 1;
            txtLocation.TextChanged += AnyInputChanged_UpdateProgress;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.Location = new Point(100, 150);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 29);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += AnyInputChanged_UpdateProgress;
            // 
            // rtbDescription
            // 
            rtbDescription.Font = new Font("Segoe UI", 12F);
            rtbDescription.Location = new Point(100, 200);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(300, 120);
            rtbDescription.TabIndex = 3;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += AnyInputChanged_UpdateProgress;
            // 
            // lstAttachments
            // 
            lstAttachments.Font = new Font("Segoe UI", 10F);
            lstAttachments.Location = new Point(100, 340);
            lstAttachments.Name = "lstAttachments";
            lstAttachments.Size = new Size(300, 72);
            lstAttachments.TabIndex = 4;
            // 
            // btnAddAttachment
            // 
            btnAddAttachment.BackColor = Color.LightSteelBlue;
            btnAddAttachment.FlatStyle = FlatStyle.Flat;
            btnAddAttachment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAttachment.Location = new Point(100, 430);
            btnAddAttachment.Name = "btnAddAttachment";
            btnAddAttachment.Size = new Size(145, 35);
            btnAddAttachment.TabIndex = 5;
            btnAddAttachment.Text = "Add Attachment";
            btnAddAttachment.UseVisualStyleBackColor = false;
            btnAddAttachment.Click += btnAddAttachment_Click;
            // 
            // btnRemoveAttachment
            // 
            btnRemoveAttachment.BackColor = Color.LightCoral;
            btnRemoveAttachment.FlatStyle = FlatStyle.Flat;
            btnRemoveAttachment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoveAttachment.Location = new Point(255, 430);
            btnRemoveAttachment.Name = "btnRemoveAttachment";
            btnRemoveAttachment.Size = new Size(145, 35);
            btnRemoveAttachment.TabIndex = 6;
            btnRemoveAttachment.Text = "Remove Attachment";
            btnRemoveAttachment.UseVisualStyleBackColor = false;
            btnRemoveAttachment.Click += btnRemoveAttachment_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.MediumSlateBlue;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(100, 520);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(300, 45);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.Location = new Point(10, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 35);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // progressReport
            // 
            progressReport.Location = new Point(100, 480);
            progressReport.Name = "progressReport";
            progressReport.Size = new Size(300, 20);
            progressReport.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Location = new Point(100, 130);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(300, 20);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(100, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(300, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // lblAttachments
            // 
            lblAttachments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAttachments.ForeColor = Color.DimGray;
            lblAttachments.Location = new Point(100, 320);
            lblAttachments.Name = "lblAttachments";
            lblAttachments.Size = new Size(300, 20);
            lblAttachments.TabIndex = 13;
            lblAttachments.Text = "Attachments";
            // 
            // lblLocation
            // 
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DimGray;
            lblLocation.Location = new Point(100, 80);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(300, 20);
            lblLocation.TabIndex = 14;
            lblLocation.Text = "Location";
            // 
            // ReportIssueForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 650);
            Controls.Add(lblTitle);
            Controls.Add(txtLocation);
            Controls.Add(cmbCategory);
            Controls.Add(rtbDescription);
            Controls.Add(lstAttachments);
            Controls.Add(btnAddAttachment);
            Controls.Add(btnRemoveAttachment);
            Controls.Add(progressReport);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            Controls.Add(lblEngagement);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblAttachments);
            Controls.Add(lblLocation);
            Name = "ReportIssueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report an Issue";
            Load += ReportIssueForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}