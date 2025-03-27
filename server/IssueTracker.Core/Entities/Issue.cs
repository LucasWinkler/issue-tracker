using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTracker.Core.Enums;

namespace IssueTracker.Core.Entities
{
    public class Issue : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IssueStatus Status { get; set; } = IssueStatus.Open;
        public IssuePriority Priority { get; set; } = IssuePriority.Medium;

        public Guid ProjectId { get; set; }
        public Guid ReporterId { get; set; }
        public Guid? AssigneeId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual ApplicationUser Reporter { get; set; } = null!;
        public virtual ApplicationUser? Assignee { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } = [];
    }
}
