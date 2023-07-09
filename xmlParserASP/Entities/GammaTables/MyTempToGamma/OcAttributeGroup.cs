using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.GammaTables.MyTempToGamma;

public partial class OcAttributeGroup
{
    [Key]
    public int AttributeGroupId { get; set; }

    public int SortOrder { get; set; }
}