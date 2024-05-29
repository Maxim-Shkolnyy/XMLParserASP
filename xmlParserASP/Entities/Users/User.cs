using Microsoft.AspNetCore.Identity;

namespace xmlParserASP.Entities.Users;

public class User : IdentityUser   
{
    public string Initials { get; set; }
}