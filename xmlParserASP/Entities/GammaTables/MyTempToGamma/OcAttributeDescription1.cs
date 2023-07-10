using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.GammaTables.MyTempToGamma;

public class OcAttributeDescription1
{
    [Required]
    public int AttributeId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; }
}

