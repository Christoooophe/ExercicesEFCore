using Microsoft.AspNetCore.Identity;

namespace ExercicesEFCore.Models
{
    public class User : IdentityUser
    {
        public string ?FullName { get; set; }
    }
}
