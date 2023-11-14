using Microsoft.AspNetCore.Identity;

namespace xmlParserASP.Entities.Gamma;

public class MmUser
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}