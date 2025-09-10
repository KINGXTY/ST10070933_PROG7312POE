using System;
using System.Collections.Generic;

namespace ST10070933_PROG7312POE.Models
{
    public enum IssueCategory
    {
        Sanitation,
        Roads,
        Utilities,
        Safety,
        Parks,
        Other
    }

    public sealed class Issue
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.Now;

        public string Location { get; set; } = string.Empty;
        public IssueCategory Category { get; set; } = IssueCategory.Other;
        public string Description { get; set; } = string.Empty;
        public List<string> Attachments { get; set; } = new();
    }
}
