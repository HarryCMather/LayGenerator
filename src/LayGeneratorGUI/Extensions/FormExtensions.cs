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

    public static void UpdateListView<T>(List<T> list, ref ListView listView)
    {
        if (!list.Any())
        {
            return;
        }

        listView.Items.Clear();

        for (int count = 0; count < list.Count; count++)
        {
            ListViewItem? item = null;
            if (typeof(T) == typeof(Element))
            {
                Element element = (list[count] as Element)!;
                item = new ListViewItem(new[]
                {
                    (count + 1).ToString(),
                    element.Name,
                    element.Image.File
                });
            }
            else if (typeof(T) == typeof(View))
            {
                View view = (list[count] as View)!;
                item = new ListViewItem(new[]
                {
                    (count + 1).ToString(),
                    view.Name,
                    view.Comment,
                    view.Screen.Index,
                    view.Screen.Bounds.X,
                    view.Screen.Bounds.Y,
                    view.Screen.Bounds.Width,
                    view.Screen.Bounds.Height
                });
            }
            else if (typeof(T) == typeof(Bezel))
            {
                Bezel bezel = (list[count] as Bezel)!;
                item = new ListViewItem(new []
                {
                    (count + 1).ToString(),
                    bezel.Element,
                    bezel.Bounds.X,
                    bezel.Bounds.Y,
                    bezel.Bounds.Width,
                    bezel.Bounds.Height
                });
            }

            if (item is null)
            {
                return;
            }

            listView.Items.Add(item);
        }

        ColourListViewItems(ref listView);
    }

    private static void ColourListViewItems(ref ListView listView)
    {
        foreach (ListViewItem item in listView.Items)
        {
            item.ForeColor = Color.White;
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
