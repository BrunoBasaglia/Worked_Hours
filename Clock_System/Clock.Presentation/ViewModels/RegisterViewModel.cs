using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clock.Presentation.ViewModels
{
    public class RegisterViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        //[Required(ErrorMessage = "Required.")]
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        //[Required(ErrorMessage = "Required.")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "Required.")]
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        [NotMapped]
        public bool KeepMeLogged { get; set; }

        [NotMapped]
        public string UserType { get; set; }
    }
}
