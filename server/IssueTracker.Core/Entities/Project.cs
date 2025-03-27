using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Core.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public Guid OrganizationId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<Issue> Issues { get; set; } = [];
    }
}
