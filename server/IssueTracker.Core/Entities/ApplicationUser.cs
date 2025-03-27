using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IssueTracker.Core.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ProfileImageUrl { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; } = [];
        public virtual ICollection<Issue> ReportedIssues { get; set; } = [];
        public virtual ICollection<Issue> AssignedIssues { get; set; } = [];
        public virtual ICollection<Comment> Comments {  get; set; } = [];
    }
}
