using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;


public class OcAttribute
{
    [Key]
    [Required]
    public int AttributeId { get; set; }

    public int AttributeGroupId { get; set; }    
    
    public int SortOrder { get; set; }
}
