using Framework.Domain.Contracts;

using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Infra.Models.Auth;

public class User : IdentityUser<Guid>, IAuditable<Guid>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    [Column(TypeName = "text")]
    public string PhotoPictureUrl { get; set; } = string.Empty;
    public DateTime? LastPasswordChangeDate { get; set; }
    public DateTime CreatedOn { get; init; }
    public string CreatedBy { get; set; }
    public DateTime? LastUpdatedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? IsDeletedOn { get; set; }
    public string? IsDeletedBy { get; set; }
}
