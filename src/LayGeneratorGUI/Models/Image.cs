using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

public class Image
{
    [XmlElement("file")]
    public string File { get; set; }
}