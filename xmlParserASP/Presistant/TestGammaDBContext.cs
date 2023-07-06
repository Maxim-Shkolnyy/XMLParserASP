using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities;
using xmlParserASP.Entities.GammaTables;

namespace xmlParserASP.Presistant;

public class TestGammaDBContext : DbContext
{
    public TestGammaDBContext(DbContextOptions<TestGammaDBContext> options)
    : base(options) { }


    public DbSet<OcAttributeDescription> GammaAttribute { get; set; }
    public DbSet<OcLanguage> GammaLanguage { get; set; }
    public DbSet<OcCategoryDescription> GammaCategory { get; set; }
}

