using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

[XmlRoot("element")]
internal class Element
{
    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlAttribute("image")]
    public Image Image { get; set; }
}