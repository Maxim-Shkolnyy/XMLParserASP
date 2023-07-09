using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

public partial class OcAttributeGroupDescription
{
    public int AttributeGroupId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
