using System.Xml.Serialization;

namespace xmlParserASP.Entities.Gamma;

[XmlType("P")]
public class Mm_ProductToXml  // Не додавати до контексту. Клас потрібен тільки для формування xml
{
    public string Sku { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    [XmlElement("Qty")]
    public int Quantity { get; set; }
    [XmlElement("Cat")]
    public int Category { get; set; }
}