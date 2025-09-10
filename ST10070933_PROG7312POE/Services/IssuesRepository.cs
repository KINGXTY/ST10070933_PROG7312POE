using System.Collections.Generic;
using ST10070933_PROG7312POE.Models;

namespace ST10070933_PROG7312POE.Services
{  
    /// In-memory repository for demo purposes. Replace with persistence later.
    public static class IssuesRepository
    {
        private static readonly List<Issue> _issues = new();

        public static IReadOnlyList<Issue> Issues => _issues.AsReadOnly();

        public static void Add(Issue issue) => _issues.Add(issue);
    }
}