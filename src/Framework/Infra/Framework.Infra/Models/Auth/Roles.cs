using Framework.Domain.Contracts;

using Microsoft.AspNetCore.Identity;

namespace Framework.Infra.Models.Auth;

public class Role :IdentityRole, IAuditable<Guid>
{
    public Role(string rolename, string roleDescription) : base(rolename)
    {
        Description = roleDescription;
    }
    public required string Description { get; set; }       
    public DateTime CreatedOn { get; init; }
    public string CreatedBy { get; set; }
    public DateTime? LastUpdatedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? IsDeletedOn { get; set; }
    public string? IsDeletedBy { get; set; }
    Guid IEntity<Guid>.Id { get; }
}
