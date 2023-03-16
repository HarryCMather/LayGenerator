using System.Text;
using LayGeneratorGUI.Models;
using View = LayGeneratorGUI.Models.View;

namespace LayGeneratorGUI.Serialization;

// This is essentially XML, but the in-built XML serializer has issues generating the correct style and formatting with nested complex types.
public class LaySerializer
{
    private readonly StringBuilder _layCode = new();

    public string Serialize(MameLayout mameInputs)
    {
        // Add the Game comment:
        _layCode.AppendLine($"<!-- {mameInputs.Comment} -->");

        // Add the opening mame layout tag:
        _layCode.AppendLine($"<mamelayout version=\"{mameInputs.Version}\">");

        // Add all elements:
        AddElements(mameInputs.Elements);

        // Add all views:
        AddViews(mameInputs.Views);

        // Add the closing mame layout tag:
        _layCode.AppendLine("</mamelayout>");

        return _layCode.ToString();
    }

    private void AddElements(List<Element> elements)
    {
        foreach (Element element in elements)
        {
            // Add the element name and image file path:
            _layCode.AppendLine();
            _layCode.AppendLine($"  <element name=\"{element.Name}\">");
            _layCode.AppendLine($"    <image file=\"{element.Image.File}\" />");
            _layCode.AppendLine("  </element>");
        }
    }

    private void AddViews(List<View> views)
    {
        foreach (View view in views)
        {
            // Add the view, including the screen, bezel (with bounds) and the initial comment (if specified):
            _layCode.AppendLine();
            if (!string.IsNullOrEmpty(view.Comment))
            {
                _layCode.AppendLine($"<!-- {view.Comment} -->");
                _layCode.AppendLine();
            }

            _layCode.AppendLine($"  <view name=\"{view.Name}\">");
            _layCode.AppendLine($"    <screen index=\"{view.Screen.Index}\">");
            _layCode.AppendLine($"      <bounds x=\"{view.Screen.Bounds.X}\" y=\"{view.Screen.Bounds.Y}\" width=\"{view.Screen.Bounds.Width}\" height=\"{view.Screen.Bounds.Height}\" />");
            _layCode.AppendLine("    </screen>");

            foreach (Bezel bezel in view.Bezels)
            {
                _layCode.AppendLine();
                _layCode.AppendLine($"    <bezel element=\"{bezel.Element}\">");
                _layCode.AppendLine($"      <bounds x=\"{bezel.Bounds.X}\" y=\"{bezel.Bounds.Y}\" width=\"{bezel.Bounds.Width}\" height=\"{bezel.Bounds.Height}\" />");
                _layCode.AppendLine("    </bezel>");
            }

            _layCode.AppendLine("  </view>");
        }
    }
}
