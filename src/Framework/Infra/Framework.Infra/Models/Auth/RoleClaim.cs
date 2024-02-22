using Framework.Domain.Contracts;

using Microsoft.AspNetCore.Identity;

namespace Framework.Infra.Models.Auth;

public class RoleClaim : IdentityRoleClaim<string>, IAuditable<int>
{
    public required string Description { get; set; }
    public required string Group {  get; set; }
    public required string Application {  get; set; }
      public virtual Role Role { get; set; }

    public RoleClaim(string description, string group, string application): base()
    {
        Description = description;
        Group = group;
        Application = application;
    }

    public DateTime CreatedOn { get; init; }
    public string CreatedBy { get; set; }
    public DateTime? LastUpdatedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? IsDeletedOn { get; set; }
    public string? IsDeletedBy { get; set; }
}
