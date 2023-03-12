using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

public class Bounds
{
    [XmlAttribute("x")]
    public string X { get; set; }

    [XmlAttribute("y")]
    public string Y { get; set; }

    [XmlAttribute("width")]
    public string Width { get; set; }

    [XmlAttribute("height")]
    public string Height { get; set; }
}