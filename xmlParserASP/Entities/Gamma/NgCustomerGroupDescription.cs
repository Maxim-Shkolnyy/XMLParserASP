namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerGroupDescription
{
    public int CustomerGroupId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}
