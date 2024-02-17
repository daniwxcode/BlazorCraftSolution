using Framework.Domain.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain.Models
{
    public abstract class Entity : IEntity<Guid>
    {
        public Guid Id { get; }
    }
    public abstract class AuditableEntity: IAuditable<Guid> {
        public Guid Id { get; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? LastUpdatedOn { get; set; }
        public string? LastUpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? IsDeletedOn { get; set; }
        public string? IsDeletedBy { get; set; }
        
    }
}
