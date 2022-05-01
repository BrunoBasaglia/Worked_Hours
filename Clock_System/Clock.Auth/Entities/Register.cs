using Microsoft.AspNetCore.Identity;

namespace Clock.Auth.Entities
{
    public class Register : IdentityUser
    {
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool KeepMeLogged { get; set; }
        public string CompanyName { get; set; }
    }
}
