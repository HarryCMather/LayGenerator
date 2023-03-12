using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

public class Screen
{
    [XmlAttribute("index")]
    public string Index { get; set; }
    
    [XmlElement("bounds")]
    public Bounds Bounds { get; set; }
}