using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.GammaTables.MyTempToGamma;


public class OcAttribute
{
    [Key]
    [Required]
    public int AttributeId { get; set; }

    public int AttributeGroupId { get; set; }

    public int SortOrder { get; set; }
}
