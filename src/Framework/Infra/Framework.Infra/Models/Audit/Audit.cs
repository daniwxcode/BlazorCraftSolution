using Framework.Domain.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Infra.Models.Audit;

public class Audit : IEntity<int>
{
    public int Id { get; set; }
    public required string UserId { get; set; }
    public required string Type { get; set; }
    public required string TableName { get; set; }
    public required DateTime DateTime { get; set; }
    public required string OldValues { get; set; }
    public required string NewValues { get; set; }
    public required string AffectedColumns { get; set; }
    public required string PrimaryKey { get; set; }
}
