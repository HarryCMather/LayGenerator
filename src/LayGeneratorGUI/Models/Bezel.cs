using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

public class Bezel
{
    [XmlAttribute("element")]
    public string Element { get; set; }

    [XmlAttribute("bounds")]
    public Bounds Bounds { get; set; }
}