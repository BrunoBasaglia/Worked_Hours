using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Clock.Auth.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string UserType { get; set; }
    }
}
