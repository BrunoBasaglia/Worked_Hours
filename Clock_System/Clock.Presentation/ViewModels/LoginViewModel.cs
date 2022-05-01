using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clock.Presentation.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "This field is required!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Password { get; set; }
        [NotMapped]
        public bool KeepMeLogged { get; set; }
    }
}
