using System.Xml.Serialization;
using LayGeneratorGUI.Models;

namespace LayGeneratorGUI.Extensions;

internal static class XmlExtensions
{
    public static string ParseXml(this MameLayout mameObject)
    {
        XmlSerializer serializer = new(typeof(MameLayout));

        using StringWriter sw = new();
        serializer.Serialize(sw, mameObject);

        return sw
            .ToString()
            .RemoveViewsTags()
            .RemoveBezelsTags()
            .RemoveElementsTags()
            .ReplaceComments()
            .RemoveXmlSchema();
    }
}
