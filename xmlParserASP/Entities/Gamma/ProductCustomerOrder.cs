namespace xmlParserASP.Entities.Gamma;

public partial class ProductCustomerOrder
{
    public string? Статус { get; set; }

    public string? ФИО { get; set; }

    public string? ОтКомпании { get; set; }

    public string? Телефон { get; set; }

    public string? Email { get; set; }

    public string? Артикул { get; set; }

    public string НазваниеТовара { get; set; } = null!;

    public int Количество { get; set; }

    public decimal? СуммаUah { get; set; }
}
