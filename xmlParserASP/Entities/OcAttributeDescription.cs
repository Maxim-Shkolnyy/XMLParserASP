using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

    public class OcAttributeDescription
    {
        [Required]
        public int AttributeId { get; set; }

        public int LanguageId { get; set; }

        public string Name { get; set; }
    }

