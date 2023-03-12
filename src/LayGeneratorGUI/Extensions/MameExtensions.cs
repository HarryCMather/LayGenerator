using LayGeneratorGUI.Models;
using Screen = LayGeneratorGUI.Models.Screen;
using View = LayGeneratorGUI.Models.View;

namespace LayGeneratorGUI.Extensions;

internal static class MameExtensions
{
    private const string ViewDoesNotContainValue = "Error: One or more views does not contain a '%value%'";

    public static bool EnsureAllViewsContainOneScreenAndBezels(MameLayout mameInputs)
    {
        foreach (View view in mameInputs.Views)
        {
            if (Equals(view.Screen, default(Screen)))
            {
                FormExtensions.DisplayErrorMessage(ViewDoesNotContainValue.Replace("%value%", "screen"));
                return false;
            }
            else if (!view.Bezels.Any())
            {
                FormExtensions.DisplayErrorMessage(ViewDoesNotContainValue.Replace("%value%", "bezel"));
                return false;
            }
        }

        return true;
    }
}
