using LayGeneratorGUI.Models;
using System.Text.RegularExpressions;
using ListView = System.Windows.Forms.ListView;
using View = LayGeneratorGUI.Models.View;

namespace LayGeneratorGUI.Extensions;

internal static class FormExtensions
{
    private const string InputCannotBeEmptyError = "Error: The %element% textbox cannot be empty.";
    private const string InputWasNotNumberError = "Error: The %element% textbox only accepts numbers.";
    private const string ImageWasNotPng = "Error: The input was not a PNG file.";
    private static readonly Regex NumberRegex = new(@"\d+", RegexOptions.Compiled);

    public static bool EnsureInputContainsValue(string inputValue, string formElement)
    {
        if (!string.IsNullOrEmpty(inputValue))
        {
            return true;
        }

        DisplayErrorMessage(InputCannotBeEmptyError.Replace("%element%", formElement));
        return false;
    }

    public static bool EnsureImageIsPng(string file)
    {
        if (file.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        DisplayErrorMessage(ImageWasNotPng);
        return false;
    }

    public static bool EnsureInputContainsNumber(string input, string formElement)
    {
        if (NumberRegex.IsMatch(input))
        {
            return true;
        }

        DisplayErrorMessage(InputWasNotNumberError.Replace("%element%", formElement));
        return false;
    }

    public static void DisplayErrorMessage(string error)
    {
        MessageBox.Show(error);
    }

    public static void UpdateElementsListView(List<Element> elements, ref ListView elementsListView)
    {
        if (!elements.Any())
        {
            return;
        }

        elementsListView.Items.Clear();

        for (int count = 0; count < elements.Count; count++)
        {
            ListViewItem item = new(new []
            {
                (count + 1).ToString(),
                elements[count].Name,
                elements[count].Image.File
            });

            elementsListView.Items.Add(item);
        }

        ColourListViewItems(ref elementsListView);
    }

    public static void UpdateViewsListView(List<View> views, ref ListView viewsListView)
    {
        if (!views.Any())
        {
            return;
        }

        viewsListView.Items.Clear();

        int number = 1;
        foreach (View view in views)
        {
            ListViewItem item = new(new[]
            {
                number.ToString(),
                view.Name,
                view.Comment,
                view.Screen.Index,
                view.Screen.Bounds.X,
                view.Screen.Bounds.Y,
                view.Screen.Bounds.Width,
                view.Screen.Bounds.Height
            });

            viewsListView.Items.Add(item);

            number++;
        }

        ColourListViewItems(ref viewsListView);
    }

    public static void UpdateBezelsListView(List<View> views, ref ListView bezelsListView)
    {
        if (!views.Any())
        {
            return;
        }

        bezelsListView.Items.Clear();

        int number = 1;
        foreach (View view in views)
        {
            foreach (Bezel bezel in view.Bezels)
            {
                ListViewItem item = new(new []
                {
                    number.ToString(),
                    bezel.Element,
                    view.Name,
                    bezel.Bounds.X,
                    bezel.Bounds.Y,
                    bezel.Bounds.Width,
                    bezel.Bounds.Height
                });

                bezelsListView.Items.Add(item);

                number++;
            }
        }

        ColourListViewItems(ref bezelsListView);
    }

    private static void ColourListViewItems(ref ListView listView)
    {
        foreach (ListViewItem item in listView.Items)
        {
            item.ForeColor = Color.White;
        }
    }

    // TODO: Refactor usages of typeof(T):
    public static void UpdateListView<T>(List<T> list, ref ListView listView)
    {
        if (typeof(T) == typeof(Element))
        {
            UpdateElementsListView((list as List<Element>)!, ref listView);
        }
        else if (typeof(T) == typeof(View))
        {
            UpdateViewsListView((list as List<View>)!, ref listView);
        }
    }

    public static List<T> ReorderListAndListView<T>(List<T> list, ref ListView listView, int indexToMove, int newIndex, bool moveUp)
    {
        list.Insert(newIndex, list[indexToMove]);
        list.RemoveAt(moveUp ? indexToMove + 1 : indexToMove);
        UpdateListView(list, ref listView);
        return list;
    }

    //todo: Need to actually use the bezel delete, it's not been implemented yet
    //todo: Also need to add stuff for <backdrop> :(

    public static List<T> RemoveItemFromListAndListView<T>(List<T> list, ref ListView listView, int indexToDelete)
    {
        list.RemoveAt(indexToDelete);
        UpdateListView(list, ref listView);
        return list;
    }

    public static void CloseProgram()
    {
        Environment.Exit(0);
    }
}
