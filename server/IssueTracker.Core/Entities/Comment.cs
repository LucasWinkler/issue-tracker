using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IssueTracker.Core.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        public Guid IssueId { get; set; }
        public Guid AuthorId { get; set; }

        public virtual Issue Issue { get; set; } = null!;
        public virtual ApplicationUser Author { get; set; } = null!;
    }
}
