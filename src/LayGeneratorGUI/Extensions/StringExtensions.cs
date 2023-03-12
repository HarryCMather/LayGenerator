namespace LayGeneratorGUI.Extensions;

internal static class StringExtensions
{
    public static string ReplaceComments(this string xml)
    {
        return xml
            .Replace("<comment>", "<!-- ")
            .Replace("</comment>", " -->");
    }

    public static string RemoveElementsTags(this string xml)
    {
        return xml
            .Replace("<elements>", string.Empty)
            .Replace("</elements>", string.Empty);
    }

    public static string RemoveViewsTags(this string xml)
    {
        return xml
            .Replace("<views>", string.Empty)
            .Replace("</views>", string.Empty);
    }

    public static string RemoveBezelsTags(this string xml)
    {
        return xml
            .Replace("<bezels>", string.Empty)
            .Replace("</bezels>", string.Empty);
    }

    public static string RemoveXmlSchema(this string xml)
    {
        return xml
            .Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", string.Empty);
    }
}