using LayGeneratorGUI.Extensions;
using LayGeneratorGUI.Models;
using LayGeneratorGUI.Serialization;
using Image = LayGeneratorGUI.Models.Image;
using Screen = LayGeneratorGUI.Models.Screen;
using View = LayGeneratorGUI.Models.View;

namespace LayGeneratorGUI;

public sealed partial class Form1 : Form
{
    private readonly MameLayout _mameInputs = new();

    public Form1(string version)
    {
        InitializeComponent();
        ColourListViewHeader(ref ElementsListview, Color.FromArgb(40, 40, 40), Color.White);
        ColourListViewHeader(ref ViewsListview, Color.FromArgb(40, 40, 40), Color.White);
        ColourListViewHeader(ref BezelsListview, Color.FromArgb(40, 40, 40), Color.White);

        if (!string.IsNullOrEmpty(version))
        {
            Text += $@" V-{version}";
        }
    }

    public static void ColourListViewHeader(ref ListView list, Color backColor, Color foreColor)
    {
        list.OwnerDraw = true;
        list.DrawColumnHeader += (_, e) => HeaderDraw(e, backColor, foreColor);
        list.DrawItem += BodyDraw;
    }

    //public static void ColourListViewItem(ref ListView list, Color backColor, Color foreColor)
    //{
    //    list.OwnerDraw = true;
    //    list.DrawItem += (_, e) => ItemDraw(e, backColor, foreColor);
    //    list.DrawItem += BodyDraw;
    //}

    private static void HeaderDraw(DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
    {
        if (e.Header is null || e.Font is null)
        {
            MessageBox.Show(@"Error: An internal error occurred preventing the results headers from displaying.");
            return;
        }

        using SolidBrush backBrush = new(backColor);
        e.Graphics.FillRectangle(backBrush, e.Bounds);

        using SolidBrush foreBrush = new(foreColor);
        e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
    }

    //public static void ItemDraw(DrawListViewItemEventArgs e, Color backColor, Color foreColor)
    //{
    //    if (e.Item.Font is null)
    //    {
    //        MessageBox.Show(@"Error: An internal error occurred preventing the results items from displaying.");
    //        return;
    //    }

    //    using SolidBrush backBrush = new(backColor);
    //    e.Graphics.FillRectangle(backBrush, e.Bounds);

    //    using SolidBrush foreBrush = new(foreColor);
    //    e.Graphics.DrawString(e.Item.Text, e.Item.Font, foreBrush, e.Bounds);
    //}

    public static void BodyDraw(object? sender, DrawListViewItemEventArgs e)
    {
        e.DrawDefault = true;
    }

    private void AddElementButton_Click(object sender, EventArgs e)
    {
        //Ensure the elements are not empty:
        if (!FormExtensions.EnsureInputContainsValue(ElementNameTextbox.Text, "Elements name"))
        {
            return;
        }
        else if (!FormExtensions.EnsureInputContainsValue(ImageTextbox.Text, "Elements image"))
        {
            return;
        }
        else if (!FormExtensions.EnsureImageIsPng(ImageTextbox.Text))
        {
            return;
        }

        _mameInputs.Elements.Add(new Element
        {
            Name = ElementNameTextbox.Text,
            Image = new Image
            {
                File = ImageTextbox.Text
            }
        });

        FormExtensions.UpdateListView(_mameInputs.Elements, ref ElementsListview);
    }

    private void AddViewButton_Click(object sender, EventArgs e)
    {
        //Ensure the elements are not empty:
        if (!FormExtensions.EnsureInputContainsValue(ViewNameTextbox.Text, "View name") ||
            !FormExtensions.EnsureInputContainsNumber(ViewScreenIndexTextbox.Text, "Screen bounds Index") ||
            !FormExtensions.EnsureInputContainsNumber(ViewScreenXTextbox.Text, "Screen bounds 'X'") ||
            !FormExtensions.EnsureInputContainsNumber(ViewScreenYTextbox.Text, "Screen bounds 'Y'") ||
            !FormExtensions.EnsureInputContainsNumber(ViewScreenWidthTextbox.Text, "Screen bounds 'Width'") ||
            !FormExtensions.EnsureInputContainsNumber(ViewScreenHeightTextbox.Text, "Screen bounds 'Height'"))
        {
            return;
        }

        _mameInputs.Views.Add(new View
        {
            Name = ViewNameTextbox.Text,
            Screen = new Screen
            {
                Index = ViewScreenIndexTextbox.Text,
                Bounds = new Bounds
                {
                    X = ViewScreenXTextbox.Text,
                    Y = ViewScreenYTextbox.Text,
                    Width = ViewScreenWidthTextbox.Text,
                    Height = ViewScreenHeightTextbox.Text
                }
            },
            Comment = ViewCommentTextbox.Text
        });

        FormExtensions.UpdateListView(_mameInputs.Views, ref ViewsListview);
    }

    private void AddBezelButton_Click(object sender, EventArgs e)
    {
        // Check the specified view number/name exists:
        // Check view name:
        int viewIndex = _mameInputs.Views.FindIndex(view => view.Name == BezelViewSearchTextbox.Text);

        // Check view number:
        if (viewIndex == -1 && int.TryParse(BezelViewSearchTextbox.Text, out viewIndex))
        {
            viewIndex--;

            // Check the view index is in range:
            if (viewIndex < 0 || viewIndex >= _mameInputs.Views.Count)
            {
                FormExtensions.DisplayErrorMessage("Error: The specified view number was invalid.");
                return;
            }
        }
        else if (viewIndex == -1)
        {
            FormExtensions.DisplayErrorMessage("Error: The specified view name/number was invalid.");
            return;
        }

        if (!FormExtensions.EnsureInputContainsValue(BezelViewNameTextbox.Text, "Bezel name") ||
            !FormExtensions.EnsureInputContainsNumber(ViewBezelXTextbox.Text, "Bezel Bound X") ||
            !FormExtensions.EnsureInputContainsNumber(ViewBezelYTextbox.Text, "Bezel Bound Y") ||
            !FormExtensions.EnsureInputContainsNumber(ViewBezelWidthTextbox.Text, "Bezel Bound Width") ||
            !FormExtensions.EnsureInputContainsNumber(ViewBezelHeightTextbox.Text, "Bezel Bound Height"))
        {
            return;
        }

        // Check the element that the bezel references exists:
        string? elementName = _mameInputs.Elements.FirstOrDefault(element => element.Name == BezelViewNameTextbox.Text)?.Name;

        if (elementName is null)
        {
            FormExtensions.DisplayErrorMessage("Error: The specified bezel name (referring to the Element name) does not exist.");
            return;
        }

        _mameInputs.Views[viewIndex].Bezels.Add(new Bezel
        {
            Element = elementName,
            Bounds = new Bounds
            {
                X = ViewBezelXTextbox.Text,
                Y = ViewBezelYTextbox.Text,
                Width = ViewBezelWidthTextbox.Text,
                Height = ViewBezelHeightTextbox.Text
            }
        });

        // Get a list of all Views (contains ViewName) and update list view:
        FormExtensions.UpdateBezelsListView(_mameInputs.Views, ref BezelsListview);
    }

    private void GenerateLayFileButton_Click(object sender, EventArgs e)
    {
        //Ensure game section inputs are valid:
        if (!FormExtensions.EnsureInputContainsValue(GameTextbox.Text, "Game"))
        {
            return;
        }
        else if (!FormExtensions.EnsureInputContainsNumber(MameVersionTextbox.Text, "Mame version"))
        {
            return;
        }

        _mameInputs.Version = MameVersionTextbox.Text;
        _mameInputs.Comment = GameTextbox.Text;

        if (!_mameInputs.Comment.EndsWith(".lay"))
        {
            _mameInputs.Comment += ".lay";
        }

        //Ensure 'MameInputs' values contain at least 1 view (each must contain 1 screen and at least 1 bezel) and 1 element:
        if (!_mameInputs.Elements.Any())
        {
            FormExtensions.DisplayErrorMessage("Error: No elements were specified.");
            return;
        }
        else if (!MameExtensions.EnsureAllViewsContainOneScreenAndBezels(_mameInputs))
        {
            //no error message display, as this is handled in the above function
            return;
        }

        // TODO: Potentially add more checks here...
        LaySerializer laySerializer = new();
        string xml = laySerializer.Serialize(_mameInputs);

        SaveFileDialog saveFileDialog = new();
        saveFileDialog.Filter = "Lay file|*.lay";
        saveFileDialog.Title = "Save lay file";
        saveFileDialog.ShowDialog();

        if (string.IsNullOrEmpty(saveFileDialog.FileName))
        {
            FormExtensions.DisplayErrorMessage("Error: File name cannot be empty.");
            return;
        }

        if (!saveFileDialog.FileName.EndsWith(".lay", StringComparison.OrdinalIgnoreCase))
        {
            saveFileDialog.FileName += ".lay";
        }

        File.WriteAllText(saveFileDialog.FileName, xml);
    }

    //Fix for Windows Forms applications randomly not closing when performing IO/thread-locked tasks:
    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        FormExtensions.CloseProgram();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        FormExtensions.CloseProgram();
    }

    private void ElementsListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        if (ElementsListview.SelectedItems.Count == 0)
        {
            return;
        }

        ElementMoveUpButton.Enabled = ElementsListview.SelectedItems[0].Text != "1";
        ElementMoveDownButton.Enabled = ElementsListview.SelectedItems[0].Text != _mameInputs.Elements.Count.ToString();
    }

    private void ElementsListview_ItemChecked(object sender, ItemCheckedEventArgs e) { }

    private void ViewsListview_ItemChecked(object sender, ItemCheckedEventArgs e) { }

    private void ViewsListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        if (ViewsListview.SelectedItems.Count == 0)
        {
            return;
        }

        ViewMoveUpButton.Enabled = ViewsListview.SelectedItems[0].Text != "1";
        ViewMoveDownButton.Enabled = ViewsListview.SelectedItems[0].Text != _mameInputs.Elements.Count.ToString();
    }

    private void BezelsListview_ItemChecked(object sender, ItemCheckedEventArgs e) { }

    private void BezelsListview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {

    }

    private void ElementMoveUpButton_Click(object sender, EventArgs e)
    {
        if (ElementsListview.SelectedItems.Count == 0 || !int.TryParse(ElementsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        _mameInputs.Elements = FormExtensions.ReorderListAndListView(_mameInputs.Elements, ref ElementsListview, selectedItem - 1, selectedItem - 2, true);
    }

    private void ElementMoveDownButton_Click(object sender, EventArgs e)
    {
        if (ElementsListview.SelectedItems.Count == 0 || !int.TryParse(ElementsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        _mameInputs.Elements = FormExtensions.ReorderListAndListView(_mameInputs.Elements, ref ElementsListview, selectedItem - 1, selectedItem + 1, false);
    }

    private void ElementDeleteButton_Click(object sender, EventArgs e)
    {
        if (ElementsListview.SelectedItems.Count == 0 || !int.TryParse(ElementsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        _mameInputs.Elements = FormExtensions.RemoveItemFromListAndListView(_mameInputs.Elements, ref ElementsListview, selectedItem - 1);
    }

    private void ViewMoveUpButton_Click(object sender, EventArgs e)
    {
        if (ViewsListview.SelectedItems.Count == 0 || !int.TryParse(ViewsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        _mameInputs.Views = FormExtensions.ReorderListAndListView(_mameInputs.Views, ref ViewsListview, selectedItem - 1, selectedItem - 2, true);
    }

    private void ViewMoveDownButton_Click(object sender, EventArgs e)
    {
        if (ViewsListview.SelectedItems.Count == 0 || !int.TryParse(ViewsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        _mameInputs.Views = FormExtensions.ReorderListAndListView(_mameInputs.Views, ref ViewsListview, selectedItem - 1, selectedItem + 1, false);
    }

    private void ViewDeleteButton_Click(object sender, EventArgs e)
    {
        if (ViewsListview.SelectedItems.Count == 0 || !int.TryParse(ViewsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        _mameInputs.Views = FormExtensions.RemoveItemFromListAndListView(_mameInputs.Views, ref ViewsListview, selectedItem - 1);
    }

    private void BezelDeleteButton_Click(object sender, EventArgs e)
    {
        if (BezelsListview.SelectedItems.Count == 0 || !int.TryParse(BezelsListview.SelectedItems[0].Text, out int selectedItem))
        {
            return;
        }

        //todo: Additional step: Get the View containing the list of bezels and pass in the list of bezels, before overwriting the original value
        //todo: Check if there is any point adding back move up/down for bezels?

        _mameInputs.Views = FormExtensions.RemoveItemFromListAndListView(_mameInputs.Views, ref BezelsListview, selectedItem - 1);
    }
}
