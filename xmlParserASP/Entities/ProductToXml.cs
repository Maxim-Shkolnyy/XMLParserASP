using System.Xml.Serialization;

namespace xmlParserASP.Entities;

[XmlType("P")]
public class ProductToXml
{
    public string Sku { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    [XmlElement("Qty")]
    public int Quantity { get; set; }
    [XmlElement("Cat")]
    public int Category { get; set; }
}