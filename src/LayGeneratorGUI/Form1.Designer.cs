namespace LayGeneratorGUI
{
    sealed partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            AddBezelButton = new Button();
            GameTextbox = new TextBox();
            GameLabel = new Label();
            MameVersionTextbox = new TextBox();
            MameVersionLabel = new Label();
            ElementsLabel = new Label();
            ElementNameTextbox = new TextBox();
            ElementNameLabel = new Label();
            ImageTextbox = new TextBox();
            ImageLabel = new Label();
            AddElementButton = new Button();
            ViewScreenIndexTextbox = new TextBox();
            ViewScreenIndexLabel = new Label();
            AddViewButton = new Button();
            ViewCommentTextbox = new TextBox();
            ViewCommentLabel = new Label();
            ViewNameTextbox = new TextBox();
            ViewNameLabel = new Label();
            ViewsLabel = new Label();
            ViewScreenXTextbox = new TextBox();
            ViewScreenLabel = new Label();
            ViewScreenXLabel = new Label();
            ViewScreenYLabel = new Label();
            ViewScreenYTextbox = new TextBox();
            ViewScreenHeightLabel = new Label();
            ViewScreenHeightTextbox = new TextBox();
            ViewScreenWidthLabel = new Label();
            ViewScreenWidthTextbox = new TextBox();
            AddBezelToViewLabel = new Label();
            BezelViewSearchTextbox = new TextBox();
            BezelViewNumberLabel = new Label();
            BezelViewNameTextbox = new TextBox();
            BezelViewNameLabel = new Label();
            ViewBezelHeightLabel = new Label();
            ViewBezelHeightTextbox = new TextBox();
            ViewBezelWidthLabel = new Label();
            ViewBezelWidthTextbox = new TextBox();
            ViewBezelYLabel = new Label();
            ViewBezelYTextbox = new TextBox();
            ViewBezelXLabel = new Label();
            ViewBezelXTextbox = new TextBox();
            ViewBezelLabel = new Label();
            OptionsLabel = new Label();
            ResultsLabel = new Label();
            GenerateLayFileButton = new Button();
            ElementsListview = new ListView();
            NumberHeader = new ColumnHeader();
            NameHeader = new ColumnHeader();
            ImageHeader = new ColumnHeader();
            ViewsListview = new ListView();
            ViewNumberHeader = new ColumnHeader();
            ViewNameHeader = new ColumnHeader();
            ViewCommentHeader = new ColumnHeader();
            ViewIndexHeader = new ColumnHeader();
            ViewXHeader = new ColumnHeader();
            ViewYHeader = new ColumnHeader();
            ViewWidthHeader = new ColumnHeader();
            ViewHeightHeader = new ColumnHeader();
            BezelsListview = new ListView();
            BezelNumberHeader = new ColumnHeader();
            BezelElementName = new ColumnHeader();
            BezelViewName = new ColumnHeader();
            BezelXHeader = new ColumnHeader();
            BezelYHeader = new ColumnHeader();
            BezelWidthHeader = new ColumnHeader();
            BezelHeightHeader = new ColumnHeader();
            ElementMoveUpButton = new Button();
            ElementMoveDownButton = new Button();
            ElementDeleteButton = new Button();
            ViewDeleteButton = new Button();
            ViewMoveDownButton = new Button();
            ViewMoveUpButton = new Button();
            BezelDeleteButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddBezelButton
            // 
            AddBezelButton.BackColor = Color.FromArgb(40, 40, 40);
            AddBezelButton.FlatAppearance.BorderSize = 0;
            AddBezelButton.FlatStyle = FlatStyle.Flat;
            AddBezelButton.ForeColor = SystemColors.ButtonHighlight;
            AddBezelButton.Location = new Point(12, 519);
            AddBezelButton.Name = "AddBezelButton";
            AddBezelButton.Size = new Size(622, 23);
            AddBezelButton.TabIndex = 1;
            AddBezelButton.Text = "Add Bezel";
            AddBezelButton.UseVisualStyleBackColor = false;
            AddBezelButton.Click += AddBezelButton_Click;
            // 
            // GameTextbox
            // 
            GameTextbox.BackColor = Color.FromArgb(40, 40, 40);
            GameTextbox.BorderStyle = BorderStyle.None;
            GameTextbox.ForeColor = SystemColors.ButtonHighlight;
            GameTextbox.Location = new Point(130, 56);
            GameTextbox.Name = "GameTextbox";
            GameTextbox.Size = new Size(146, 16);
            GameTextbox.TabIndex = 5;
            // 
            // GameLabel
            // 
            GameLabel.AutoSize = true;
            GameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GameLabel.ForeColor = SystemColors.ButtonHighlight;
            GameLabel.Location = new Point(13, 57);
            GameLabel.Name = "GameLabel";
            GameLabel.Size = new Size(47, 17);
            GameLabel.TabIndex = 4;
            GameLabel.Text = "Game:";
            // 
            // MameVersionTextbox
            // 
            MameVersionTextbox.BackColor = Color.FromArgb(40, 40, 40);
            MameVersionTextbox.BorderStyle = BorderStyle.None;
            MameVersionTextbox.ForeColor = SystemColors.ButtonHighlight;
            MameVersionTextbox.Location = new Point(437, 56);
            MameVersionTextbox.Name = "MameVersionTextbox";
            MameVersionTextbox.Size = new Size(26, 16);
            MameVersionTextbox.TabIndex = 7;
            MameVersionTextbox.Text = "2";
            MameVersionTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // MameVersionLabel
            // 
            MameVersionLabel.AutoSize = true;
            MameVersionLabel.ForeColor = SystemColors.ButtonHighlight;
            MameVersionLabel.Location = new Point(339, 59);
            MameVersionLabel.Name = "MameVersionLabel";
            MameVersionLabel.Size = new Size(85, 15);
            MameVersionLabel.TabIndex = 6;
            MameVersionLabel.Text = "Mame version:";
            // 
            // ElementsLabel
            // 
            ElementsLabel.AutoSize = true;
            ElementsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ElementsLabel.ForeColor = SystemColors.ButtonHighlight;
            ElementsLabel.Location = new Point(12, 127);
            ElementsLabel.Name = "ElementsLabel";
            ElementsLabel.Size = new Size(68, 17);
            ElementsLabel.TabIndex = 11;
            ElementsLabel.Text = "Elements:";
            // 
            // ElementNameTextbox
            // 
            ElementNameTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ElementNameTextbox.BorderStyle = BorderStyle.None;
            ElementNameTextbox.ForeColor = SystemColors.ButtonHighlight;
            ElementNameTextbox.Location = new Point(130, 150);
            ElementNameTextbox.Name = "ElementNameTextbox";
            ElementNameTextbox.Size = new Size(146, 16);
            ElementNameTextbox.TabIndex = 13;
            // 
            // ElementNameLabel
            // 
            ElementNameLabel.AutoSize = true;
            ElementNameLabel.ForeColor = SystemColors.ButtonHighlight;
            ElementNameLabel.Location = new Point(12, 153);
            ElementNameLabel.Name = "ElementNameLabel";
            ElementNameLabel.Size = new Size(42, 15);
            ElementNameLabel.TabIndex = 12;
            ElementNameLabel.Text = "Name:";
            // 
            // ImageTextbox
            // 
            ImageTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ImageTextbox.BorderStyle = BorderStyle.None;
            ImageTextbox.ForeColor = SystemColors.ButtonHighlight;
            ImageTextbox.Location = new Point(437, 150);
            ImageTextbox.Name = "ImageTextbox";
            ImageTextbox.Size = new Size(197, 16);
            ImageTextbox.TabIndex = 15;
            // 
            // ImageLabel
            // 
            ImageLabel.AutoSize = true;
            ImageLabel.ForeColor = SystemColors.ButtonHighlight;
            ImageLabel.Location = new Point(346, 153);
            ImageLabel.Name = "ImageLabel";
            ImageLabel.Size = new Size(43, 15);
            ImageLabel.TabIndex = 14;
            ImageLabel.Text = "Image:";
            // 
            // AddElementButton
            // 
            AddElementButton.BackColor = Color.FromArgb(40, 40, 40);
            AddElementButton.FlatAppearance.BorderSize = 0;
            AddElementButton.FlatStyle = FlatStyle.Flat;
            AddElementButton.ForeColor = SystemColors.ButtonHighlight;
            AddElementButton.Location = new Point(12, 179);
            AddElementButton.Name = "AddElementButton";
            AddElementButton.Size = new Size(622, 23);
            AddElementButton.TabIndex = 16;
            AddElementButton.Text = "Add Element";
            AddElementButton.UseVisualStyleBackColor = false;
            AddElementButton.Click += AddElementButton_Click;
            // 
            // ViewScreenIndexTextbox
            // 
            ViewScreenIndexTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewScreenIndexTextbox.BorderStyle = BorderStyle.None;
            ViewScreenIndexTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenIndexTextbox.Location = new Point(175, 317);
            ViewScreenIndexTextbox.Name = "ViewScreenIndexTextbox";
            ViewScreenIndexTextbox.Size = new Size(26, 16);
            ViewScreenIndexTextbox.TabIndex = 18;
            ViewScreenIndexTextbox.Text = "0";
            ViewScreenIndexTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewScreenIndexLabel
            // 
            ViewScreenIndexLabel.AutoSize = true;
            ViewScreenIndexLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenIndexLabel.Location = new Point(130, 320);
            ViewScreenIndexLabel.Name = "ViewScreenIndexLabel";
            ViewScreenIndexLabel.Size = new Size(39, 15);
            ViewScreenIndexLabel.TabIndex = 17;
            ViewScreenIndexLabel.Text = "Index:";
            // 
            // AddViewButton
            // 
            AddViewButton.BackColor = Color.FromArgb(40, 40, 40);
            AddViewButton.FlatAppearance.BorderSize = 0;
            AddViewButton.FlatStyle = FlatStyle.Flat;
            AddViewButton.ForeColor = SystemColors.ButtonHighlight;
            AddViewButton.Location = new Point(12, 346);
            AddViewButton.Name = "AddViewButton";
            AddViewButton.Size = new Size(622, 23);
            AddViewButton.TabIndex = 24;
            AddViewButton.Text = "Add View";
            AddViewButton.UseVisualStyleBackColor = false;
            AddViewButton.Click += AddViewButton_Click;
            // 
            // ViewCommentTextbox
            // 
            ViewCommentTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewCommentTextbox.BorderStyle = BorderStyle.None;
            ViewCommentTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewCommentTextbox.Location = new Point(419, 281);
            ViewCommentTextbox.Name = "ViewCommentTextbox";
            ViewCommentTextbox.Size = new Size(215, 16);
            ViewCommentTextbox.TabIndex = 23;
            // 
            // ViewCommentLabel
            // 
            ViewCommentLabel.AutoSize = true;
            ViewCommentLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewCommentLabel.Location = new Point(325, 282);
            ViewCommentLabel.Name = "ViewCommentLabel";
            ViewCommentLabel.Size = new Size(64, 15);
            ViewCommentLabel.TabIndex = 22;
            ViewCommentLabel.Text = "Comment:";
            // 
            // ViewNameTextbox
            // 
            ViewNameTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewNameTextbox.BorderStyle = BorderStyle.None;
            ViewNameTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewNameTextbox.Location = new Point(130, 282);
            ViewNameTextbox.Name = "ViewNameTextbox";
            ViewNameTextbox.Size = new Size(146, 16);
            ViewNameTextbox.TabIndex = 21;
            // 
            // ViewNameLabel
            // 
            ViewNameLabel.AutoSize = true;
            ViewNameLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewNameLabel.Location = new Point(12, 282);
            ViewNameLabel.Name = "ViewNameLabel";
            ViewNameLabel.Size = new Size(42, 15);
            ViewNameLabel.TabIndex = 20;
            ViewNameLabel.Text = "Name:";
            // 
            // ViewsLabel
            // 
            ViewsLabel.AutoSize = true;
            ViewsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewsLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewsLabel.Location = new Point(12, 256);
            ViewsLabel.Name = "ViewsLabel";
            ViewsLabel.Size = new Size(48, 17);
            ViewsLabel.TabIndex = 19;
            ViewsLabel.Text = "Views:";
            // 
            // ViewScreenXTextbox
            // 
            ViewScreenXTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewScreenXTextbox.BorderStyle = BorderStyle.None;
            ViewScreenXTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenXTextbox.Location = new Point(242, 317);
            ViewScreenXTextbox.Name = "ViewScreenXTextbox";
            ViewScreenXTextbox.Size = new Size(52, 16);
            ViewScreenXTextbox.TabIndex = 26;
            // 
            // ViewScreenLabel
            // 
            ViewScreenLabel.AutoSize = true;
            ViewScreenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ViewScreenLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenLabel.Location = new Point(31, 320);
            ViewScreenLabel.Name = "ViewScreenLabel";
            ViewScreenLabel.Size = new Size(93, 15);
            ViewScreenLabel.TabIndex = 25;
            ViewScreenLabel.Text = "Screen Bounds:";
            // 
            // ViewScreenXLabel
            // 
            ViewScreenXLabel.AutoSize = true;
            ViewScreenXLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenXLabel.Location = new Point(219, 320);
            ViewScreenXLabel.Name = "ViewScreenXLabel";
            ViewScreenXLabel.Size = new Size(17, 15);
            ViewScreenXLabel.TabIndex = 29;
            ViewScreenXLabel.Text = "X:";
            // 
            // ViewScreenYLabel
            // 
            ViewScreenYLabel.AutoSize = true;
            ViewScreenYLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenYLabel.Location = new Point(314, 320);
            ViewScreenYLabel.Name = "ViewScreenYLabel";
            ViewScreenYLabel.Size = new Size(17, 15);
            ViewScreenYLabel.TabIndex = 31;
            ViewScreenYLabel.Text = "Y:";
            // 
            // ViewScreenYTextbox
            // 
            ViewScreenYTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewScreenYTextbox.BorderStyle = BorderStyle.None;
            ViewScreenYTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenYTextbox.Location = new Point(337, 317);
            ViewScreenYTextbox.Name = "ViewScreenYTextbox";
            ViewScreenYTextbox.Size = new Size(52, 16);
            ViewScreenYTextbox.TabIndex = 30;
            // 
            // ViewScreenHeightLabel
            // 
            ViewScreenHeightLabel.AutoSize = true;
            ViewScreenHeightLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenHeightLabel.Location = new Point(530, 320);
            ViewScreenHeightLabel.Name = "ViewScreenHeightLabel";
            ViewScreenHeightLabel.Size = new Size(46, 15);
            ViewScreenHeightLabel.TabIndex = 35;
            ViewScreenHeightLabel.Text = "Height:";
            // 
            // ViewScreenHeightTextbox
            // 
            ViewScreenHeightTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewScreenHeightTextbox.BorderStyle = BorderStyle.None;
            ViewScreenHeightTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenHeightTextbox.Location = new Point(582, 317);
            ViewScreenHeightTextbox.Name = "ViewScreenHeightTextbox";
            ViewScreenHeightTextbox.Size = new Size(52, 16);
            ViewScreenHeightTextbox.TabIndex = 34;
            // 
            // ViewScreenWidthLabel
            // 
            ViewScreenWidthLabel.AutoSize = true;
            ViewScreenWidthLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenWidthLabel.Location = new Point(411, 320);
            ViewScreenWidthLabel.Name = "ViewScreenWidthLabel";
            ViewScreenWidthLabel.Size = new Size(42, 15);
            ViewScreenWidthLabel.TabIndex = 33;
            ViewScreenWidthLabel.Text = "Width:";
            // 
            // ViewScreenWidthTextbox
            // 
            ViewScreenWidthTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewScreenWidthTextbox.BorderStyle = BorderStyle.None;
            ViewScreenWidthTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewScreenWidthTextbox.Location = new Point(458, 317);
            ViewScreenWidthTextbox.Name = "ViewScreenWidthTextbox";
            ViewScreenWidthTextbox.Size = new Size(52, 16);
            ViewScreenWidthTextbox.TabIndex = 32;
            // 
            // AddBezelToViewLabel
            // 
            AddBezelToViewLabel.AutoSize = true;
            AddBezelToViewLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBezelToViewLabel.ForeColor = SystemColors.ButtonHighlight;
            AddBezelToViewLabel.Location = new Point(13, 427);
            AddBezelToViewLabel.Name = "AddBezelToViewLabel";
            AddBezelToViewLabel.Size = new Size(124, 17);
            AddBezelToViewLabel.TabIndex = 36;
            AddBezelToViewLabel.Text = "Add Bezel to View:";
            // 
            // BezelViewSearchTextbox
            // 
            BezelViewSearchTextbox.BackColor = Color.FromArgb(40, 40, 40);
            BezelViewSearchTextbox.BorderStyle = BorderStyle.None;
            BezelViewSearchTextbox.ForeColor = SystemColors.ButtonHighlight;
            BezelViewSearchTextbox.Location = new Point(130, 456);
            BezelViewSearchTextbox.Name = "BezelViewSearchTextbox";
            BezelViewSearchTextbox.Size = new Size(100, 16);
            BezelViewSearchTextbox.TabIndex = 38;
            // 
            // BezelViewNumberLabel
            // 
            BezelViewNumberLabel.AutoSize = true;
            BezelViewNumberLabel.ForeColor = SystemColors.ButtonHighlight;
            BezelViewNumberLabel.Location = new Point(12, 456);
            BezelViewNumberLabel.Name = "BezelViewNumberLabel";
            BezelViewNumberLabel.Size = new Size(115, 15);
            BezelViewNumberLabel.TabIndex = 37;
            BezelViewNumberLabel.Text = "View number/name:";
            // 
            // BezelViewNameTextbox
            // 
            BezelViewNameTextbox.BackColor = Color.FromArgb(40, 40, 40);
            BezelViewNameTextbox.BorderStyle = BorderStyle.None;
            BezelViewNameTextbox.ForeColor = SystemColors.ButtonHighlight;
            BezelViewNameTextbox.Location = new Point(437, 456);
            BezelViewNameTextbox.Name = "BezelViewNameTextbox";
            BezelViewNameTextbox.Size = new Size(197, 16);
            BezelViewNameTextbox.TabIndex = 40;
            // 
            // BezelViewNameLabel
            // 
            BezelViewNameLabel.AutoSize = true;
            BezelViewNameLabel.ForeColor = SystemColors.ButtonHighlight;
            BezelViewNameLabel.Location = new Point(339, 456);
            BezelViewNameLabel.Name = "BezelViewNameLabel";
            BezelViewNameLabel.Size = new Size(88, 15);
            BezelViewNameLabel.TabIndex = 39;
            BezelViewNameLabel.Text = "Element Name:";
            // 
            // ViewBezelHeightLabel
            // 
            ViewBezelHeightLabel.AutoSize = true;
            ViewBezelHeightLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelHeightLabel.Location = new Point(530, 493);
            ViewBezelHeightLabel.Name = "ViewBezelHeightLabel";
            ViewBezelHeightLabel.Size = new Size(46, 15);
            ViewBezelHeightLabel.TabIndex = 51;
            ViewBezelHeightLabel.Text = "Height:";
            // 
            // ViewBezelHeightTextbox
            // 
            ViewBezelHeightTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewBezelHeightTextbox.BorderStyle = BorderStyle.None;
            ViewBezelHeightTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelHeightTextbox.Location = new Point(582, 490);
            ViewBezelHeightTextbox.Name = "ViewBezelHeightTextbox";
            ViewBezelHeightTextbox.Size = new Size(52, 16);
            ViewBezelHeightTextbox.TabIndex = 50;
            // 
            // ViewBezelWidthLabel
            // 
            ViewBezelWidthLabel.AutoSize = true;
            ViewBezelWidthLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelWidthLabel.Location = new Point(389, 493);
            ViewBezelWidthLabel.Name = "ViewBezelWidthLabel";
            ViewBezelWidthLabel.Size = new Size(42, 15);
            ViewBezelWidthLabel.TabIndex = 49;
            ViewBezelWidthLabel.Text = "Width:";
            // 
            // ViewBezelWidthTextbox
            // 
            ViewBezelWidthTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewBezelWidthTextbox.BorderStyle = BorderStyle.None;
            ViewBezelWidthTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelWidthTextbox.Location = new Point(436, 490);
            ViewBezelWidthTextbox.Name = "ViewBezelWidthTextbox";
            ViewBezelWidthTextbox.Size = new Size(52, 16);
            ViewBezelWidthTextbox.TabIndex = 48;
            // 
            // ViewBezelYLabel
            // 
            ViewBezelYLabel.AutoSize = true;
            ViewBezelYLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelYLabel.Location = new Point(242, 493);
            ViewBezelYLabel.Name = "ViewBezelYLabel";
            ViewBezelYLabel.Size = new Size(17, 15);
            ViewBezelYLabel.TabIndex = 47;
            ViewBezelYLabel.Text = "Y:";
            // 
            // ViewBezelYTextbox
            // 
            ViewBezelYTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewBezelYTextbox.BorderStyle = BorderStyle.None;
            ViewBezelYTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelYTextbox.Location = new Point(265, 490);
            ViewBezelYTextbox.Name = "ViewBezelYTextbox";
            ViewBezelYTextbox.Size = new Size(52, 16);
            ViewBezelYTextbox.TabIndex = 46;
            // 
            // ViewBezelXLabel
            // 
            ViewBezelXLabel.AutoSize = true;
            ViewBezelXLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelXLabel.Location = new Point(126, 493);
            ViewBezelXLabel.Name = "ViewBezelXLabel";
            ViewBezelXLabel.Size = new Size(17, 15);
            ViewBezelXLabel.TabIndex = 45;
            ViewBezelXLabel.Text = "X:";
            // 
            // ViewBezelXTextbox
            // 
            ViewBezelXTextbox.BackColor = Color.FromArgb(40, 40, 40);
            ViewBezelXTextbox.BorderStyle = BorderStyle.None;
            ViewBezelXTextbox.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelXTextbox.Location = new Point(149, 490);
            ViewBezelXTextbox.Name = "ViewBezelXTextbox";
            ViewBezelXTextbox.Size = new Size(52, 16);
            ViewBezelXTextbox.TabIndex = 44;
            // 
            // ViewBezelLabel
            // 
            ViewBezelLabel.AutoSize = true;
            ViewBezelLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBezelLabel.ForeColor = SystemColors.ButtonHighlight;
            ViewBezelLabel.Location = new Point(31, 493);
            ViewBezelLabel.Name = "ViewBezelLabel";
            ViewBezelLabel.Size = new Size(85, 15);
            ViewBezelLabel.TabIndex = 43;
            ViewBezelLabel.Text = "Bezel Bounds:";
            // 
            // OptionsLabel
            // 
            OptionsLabel.AutoSize = true;
            OptionsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            OptionsLabel.ForeColor = SystemColors.ButtonHighlight;
            OptionsLabel.Location = new Point(270, 9);
            OptionsLabel.Name = "OptionsLabel";
            OptionsLabel.Size = new Size(111, 32);
            OptionsLabel.TabIndex = 52;
            OptionsLabel.Text = "Options:";
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ResultsLabel.ForeColor = SystemColors.ButtonHighlight;
            ResultsLabel.Location = new Point(813, 9);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(102, 32);
            ResultsLabel.TabIndex = 53;
            ResultsLabel.Text = "Results:";
            // 
            // GenerateLayFileButton
            // 
            GenerateLayFileButton.BackColor = Color.FromArgb(40, 40, 40);
            GenerateLayFileButton.FlatAppearance.BorderSize = 0;
            GenerateLayFileButton.FlatStyle = FlatStyle.Flat;
            GenerateLayFileButton.ForeColor = SystemColors.ButtonHighlight;
            GenerateLayFileButton.Location = new Point(13, 562);
            GenerateLayFileButton.Name = "GenerateLayFileButton";
            GenerateLayFileButton.Size = new Size(1247, 23);
            GenerateLayFileButton.TabIndex = 54;
            GenerateLayFileButton.Text = "Generate Lay File";
            GenerateLayFileButton.UseVisualStyleBackColor = false;
            GenerateLayFileButton.Click += GenerateLayFileButton_Click;
            // 
            // ElementsListview
            // 
            ElementsListview.BackColor = Color.FromArgb(40, 40, 40);
            ElementsListview.BorderStyle = BorderStyle.None;
            ElementsListview.Columns.AddRange(new ColumnHeader[] { NumberHeader, NameHeader, ImageHeader });
            ElementsListview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ElementsListview.Items.AddRange(new ListViewItem[] { listViewItem1 });
            ElementsListview.Location = new Point(655, 127);
            ElementsListview.Name = "ElementsListview";
            ElementsListview.Size = new Size(605, 94);
            ElementsListview.TabIndex = 58;
            ElementsListview.UseCompatibleStateImageBehavior = false;
            ElementsListview.View = View.Details;
            ElementsListview.ItemChecked += ElementsListview_ItemChecked;
            ElementsListview.ItemSelectionChanged += ElementsListview_ItemSelectionChanged;
            // 
            // NumberHeader
            // 
            NumberHeader.Text = "Number";
            // 
            // NameHeader
            // 
            NameHeader.Text = "Name";
            NameHeader.Width = 273;
            // 
            // ImageHeader
            // 
            ImageHeader.Text = "Image";
            ImageHeader.Width = 272;
            // 
            // ViewsListview
            // 
            ViewsListview.BackColor = Color.FromArgb(40, 40, 40);
            ViewsListview.BorderStyle = BorderStyle.None;
            ViewsListview.Columns.AddRange(new ColumnHeader[] { ViewNumberHeader, ViewNameHeader, ViewCommentHeader, ViewIndexHeader, ViewXHeader, ViewYHeader, ViewWidthHeader, ViewHeightHeader });
            ViewsListview.Location = new Point(655, 256);
            ViewsListview.Name = "ViewsListview";
            ViewsListview.Size = new Size(605, 139);
            ViewsListview.TabIndex = 59;
            ViewsListview.UseCompatibleStateImageBehavior = false;
            ViewsListview.View = View.Details;
            ViewsListview.ItemChecked += ViewsListview_ItemChecked;
            ViewsListview.ItemSelectionChanged += ViewsListview_ItemSelectionChanged;
            // 
            // ViewNumberHeader
            // 
            ViewNumberHeader.Text = "Number";
            // 
            // ViewNameHeader
            // 
            ViewNameHeader.Text = "Name";
            ViewNameHeader.Width = 100;
            // 
            // ViewCommentHeader
            // 
            ViewCommentHeader.Text = "Comment";
            ViewCommentHeader.Width = 100;
            // 
            // ViewIndexHeader
            // 
            ViewIndexHeader.Text = "Index";
            ViewIndexHeader.Width = 70;
            // 
            // ViewXHeader
            // 
            ViewXHeader.Text = "X";
            ViewXHeader.Width = 70;
            // 
            // ViewYHeader
            // 
            ViewYHeader.Text = "Y";
            ViewYHeader.Width = 70;
            // 
            // ViewWidthHeader
            // 
            ViewWidthHeader.Text = "Width";
            ViewWidthHeader.Width = 70;
            // 
            // ViewHeightHeader
            // 
            ViewHeightHeader.Text = "Height";
            ViewHeightHeader.Width = 70;
            // 
            // BezelsListview
            // 
            BezelsListview.BackColor = Color.FromArgb(40, 40, 40);
            BezelsListview.BorderStyle = BorderStyle.None;
            BezelsListview.Columns.AddRange(new ColumnHeader[] { BezelNumberHeader, BezelElementName, BezelViewName, BezelXHeader, BezelYHeader, BezelWidthHeader, BezelHeightHeader });
            BezelsListview.Location = new Point(655, 448);
            BezelsListview.Name = "BezelsListview";
            BezelsListview.Size = new Size(605, 94);
            BezelsListview.TabIndex = 60;
            BezelsListview.UseCompatibleStateImageBehavior = false;
            BezelsListview.View = View.Details;
            BezelsListview.ItemChecked += BezelsListview_ItemChecked;
            BezelsListview.ItemSelectionChanged += BezelsListview_ItemSelectionChanged;
            // 
            // BezelNumberHeader
            // 
            BezelNumberHeader.Text = "Number";
            // 
            // BezelElementName
            // 
            BezelElementName.Text = "Element Name";
            BezelElementName.Width = 127;
            // 
            // BezelViewName
            // 
            BezelViewName.Text = "View Name";
            BezelViewName.Width = 127;
            // 
            // BezelXHeader
            // 
            BezelXHeader.Text = "X";
            BezelXHeader.Width = 73;
            // 
            // BezelYHeader
            // 
            BezelYHeader.Text = "Y";
            BezelYHeader.Width = 73;
            // 
            // BezelWidthHeader
            // 
            BezelWidthHeader.Text = "Width";
            BezelWidthHeader.Width = 73;
            // 
            // BezelHeightHeader
            // 
            BezelHeightHeader.Text = "Height";
            BezelHeightHeader.Width = 73;
            // 
            // ElementMoveUpButton
            // 
            ElementMoveUpButton.BackColor = Color.FromArgb(40, 40, 40);
            ElementMoveUpButton.Enabled = false;
            ElementMoveUpButton.FlatAppearance.BorderSize = 0;
            ElementMoveUpButton.FlatStyle = FlatStyle.Flat;
            ElementMoveUpButton.ForeColor = SystemColors.ButtonHighlight;
            ElementMoveUpButton.Location = new Point(1266, 133);
            ElementMoveUpButton.Name = "ElementMoveUpButton";
            ElementMoveUpButton.Size = new Size(88, 23);
            ElementMoveUpButton.TabIndex = 61;
            ElementMoveUpButton.Text = "Move Up";
            ElementMoveUpButton.UseVisualStyleBackColor = false;
            ElementMoveUpButton.Click += ElementMoveUpButton_Click;
            // 
            // ElementMoveDownButton
            // 
            ElementMoveDownButton.BackColor = Color.FromArgb(40, 40, 40);
            ElementMoveDownButton.Enabled = false;
            ElementMoveDownButton.FlatAppearance.BorderSize = 0;
            ElementMoveDownButton.FlatStyle = FlatStyle.Flat;
            ElementMoveDownButton.ForeColor = SystemColors.ButtonHighlight;
            ElementMoveDownButton.Location = new Point(1266, 162);
            ElementMoveDownButton.Name = "ElementMoveDownButton";
            ElementMoveDownButton.Size = new Size(88, 23);
            ElementMoveDownButton.TabIndex = 62;
            ElementMoveDownButton.Text = "Move Down";
            ElementMoveDownButton.UseVisualStyleBackColor = false;
            ElementMoveDownButton.Click += ElementMoveDownButton_Click;
            // 
            // ElementDeleteButton
            // 
            ElementDeleteButton.BackColor = Color.FromArgb(40, 40, 40);
            ElementDeleteButton.FlatAppearance.BorderSize = 0;
            ElementDeleteButton.FlatStyle = FlatStyle.Flat;
            ElementDeleteButton.ForeColor = SystemColors.ButtonHighlight;
            ElementDeleteButton.Location = new Point(1266, 191);
            ElementDeleteButton.Name = "ElementDeleteButton";
            ElementDeleteButton.Size = new Size(88, 23);
            ElementDeleteButton.TabIndex = 63;
            ElementDeleteButton.Text = "Delete";
            ElementDeleteButton.UseVisualStyleBackColor = false;
            ElementDeleteButton.Click += ElementDeleteButton_Click;
            // 
            // ViewDeleteButton
            // 
            ViewDeleteButton.BackColor = Color.FromArgb(40, 40, 40);
            ViewDeleteButton.FlatAppearance.BorderSize = 0;
            ViewDeleteButton.FlatStyle = FlatStyle.Flat;
            ViewDeleteButton.ForeColor = SystemColors.ButtonHighlight;
            ViewDeleteButton.Location = new Point(1266, 341);
            ViewDeleteButton.Name = "ViewDeleteButton";
            ViewDeleteButton.Size = new Size(88, 23);
            ViewDeleteButton.TabIndex = 66;
            ViewDeleteButton.Text = "Delete";
            ViewDeleteButton.UseVisualStyleBackColor = false;
            ViewDeleteButton.Click += ViewDeleteButton_Click;
            // 
            // ViewMoveDownButton
            // 
            ViewMoveDownButton.BackColor = Color.FromArgb(40, 40, 40);
            ViewMoveDownButton.Enabled = false;
            ViewMoveDownButton.FlatAppearance.BorderSize = 0;
            ViewMoveDownButton.FlatStyle = FlatStyle.Flat;
            ViewMoveDownButton.ForeColor = SystemColors.ButtonHighlight;
            ViewMoveDownButton.Location = new Point(1266, 312);
            ViewMoveDownButton.Name = "ViewMoveDownButton";
            ViewMoveDownButton.Size = new Size(88, 23);
            ViewMoveDownButton.TabIndex = 65;
            ViewMoveDownButton.Text = "Move Down";
            ViewMoveDownButton.UseVisualStyleBackColor = false;
            ViewMoveDownButton.Click += ViewMoveDownButton_Click;
            // 
            // ViewMoveUpButton
            // 
            ViewMoveUpButton.BackColor = Color.FromArgb(40, 40, 40);
            ViewMoveUpButton.Enabled = false;
            ViewMoveUpButton.FlatAppearance.BorderSize = 0;
            ViewMoveUpButton.FlatStyle = FlatStyle.Flat;
            ViewMoveUpButton.ForeColor = SystemColors.ButtonHighlight;
            ViewMoveUpButton.Location = new Point(1266, 283);
            ViewMoveUpButton.Name = "ViewMoveUpButton";
            ViewMoveUpButton.Size = new Size(88, 23);
            ViewMoveUpButton.TabIndex = 64;
            ViewMoveUpButton.Text = "Move Up";
            ViewMoveUpButton.UseVisualStyleBackColor = false;
            ViewMoveUpButton.Click += ViewMoveUpButton_Click;
            // 
            // BezelDeleteButton
            // 
            BezelDeleteButton.BackColor = Color.FromArgb(40, 40, 40);
            BezelDeleteButton.Enabled = false;
            BezelDeleteButton.FlatAppearance.BorderSize = 0;
            BezelDeleteButton.FlatStyle = FlatStyle.Flat;
            BezelDeleteButton.ForeColor = SystemColors.ButtonHighlight;
            BezelDeleteButton.Location = new Point(1266, 512);
            BezelDeleteButton.Name = "BezelDeleteButton";
            BezelDeleteButton.Size = new Size(88, 23);
            BezelDeleteButton.TabIndex = 69;
            BezelDeleteButton.Text = "Delete";
            BezelDeleteButton.UseVisualStyleBackColor = false;
            BezelDeleteButton.Click += BezelDeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1250, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 70;
            label1.Text = "© HarryCM01 #5796";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1377, 608);
            Controls.Add(label1);
            Controls.Add(BezelDeleteButton);
            Controls.Add(ViewDeleteButton);
            Controls.Add(ViewMoveDownButton);
            Controls.Add(ViewMoveUpButton);
            Controls.Add(ElementDeleteButton);
            Controls.Add(ElementMoveDownButton);
            Controls.Add(ElementMoveUpButton);
            Controls.Add(BezelsListview);
            Controls.Add(ViewsListview);
            Controls.Add(ElementsListview);
            Controls.Add(GenerateLayFileButton);
            Controls.Add(ResultsLabel);
            Controls.Add(OptionsLabel);
            Controls.Add(ViewBezelHeightLabel);
            Controls.Add(ViewBezelHeightTextbox);
            Controls.Add(ViewBezelWidthLabel);
            Controls.Add(ViewBezelWidthTextbox);
            Controls.Add(ViewBezelYLabel);
            Controls.Add(ViewBezelYTextbox);
            Controls.Add(ViewBezelXLabel);
            Controls.Add(ViewBezelXTextbox);
            Controls.Add(ViewBezelLabel);
            Controls.Add(BezelViewNameTextbox);
            Controls.Add(BezelViewNameLabel);
            Controls.Add(BezelViewSearchTextbox);
            Controls.Add(BezelViewNumberLabel);
            Controls.Add(AddBezelToViewLabel);
            Controls.Add(ViewScreenHeightLabel);
            Controls.Add(ViewScreenHeightTextbox);
            Controls.Add(ViewScreenWidthLabel);
            Controls.Add(ViewScreenWidthTextbox);
            Controls.Add(ViewScreenYLabel);
            Controls.Add(ViewScreenYTextbox);
            Controls.Add(ViewScreenXLabel);
            Controls.Add(ViewScreenXTextbox);
            Controls.Add(ViewScreenLabel);
            Controls.Add(AddViewButton);
            Controls.Add(ViewCommentTextbox);
            Controls.Add(ViewCommentLabel);
            Controls.Add(ViewNameTextbox);
            Controls.Add(ViewNameLabel);
            Controls.Add(ViewsLabel);
            Controls.Add(ViewScreenIndexTextbox);
            Controls.Add(ViewScreenIndexLabel);
            Controls.Add(AddElementButton);
            Controls.Add(ImageTextbox);
            Controls.Add(ImageLabel);
            Controls.Add(ElementNameTextbox);
            Controls.Add(ElementNameLabel);
            Controls.Add(ElementsLabel);
            Controls.Add(MameVersionTextbox);
            Controls.Add(MameVersionLabel);
            Controls.Add(GameTextbox);
            Controls.Add(GameLabel);
            Controls.Add(AddBezelButton);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Lay File Generator";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBezelButton;
        private TextBox GameTextbox;
        private Label GameLabel;
        private TextBox MameVersionTextbox;
        private Label MameVersionLabel;
        private Label ElementsLabel;
        private TextBox ElementNameTextbox;
        private Label ElementNameLabel;
        private TextBox ImageTextbox;
        private Label ImageLabel;
        private Button AddElementButton;
        private TextBox ViewScreenIndexTextbox;
        private Label ViewScreenIndexLabel;
        private Button AddViewButton;
        private TextBox ViewCommentTextbox;
        private Label ViewCommentLabel;
        private TextBox ViewNameTextbox;
        private Label ViewNameLabel;
        private Label ViewsLabel;
        private TextBox ViewScreenXTextbox;
        private Label ViewScreenLabel;
        private Label ViewScreenXLabel;
        private Label ViewScreenYLabel;
        private TextBox ViewScreenYTextbox;
        private Label ViewScreenHeightLabel;
        private TextBox ViewScreenHeightTextbox;
        private Label ViewScreenWidthLabel;
        private TextBox ViewScreenWidthTextbox;
        private Label AddBezelToViewLabel;
        private TextBox BezelViewSearchTextbox;
        private Label BezelViewNumberLabel;
        private TextBox BezelViewNameTextbox;
        private Label BezelViewNameLabel;
        private Label ViewBezelHeightLabel;
        private TextBox ViewBezelHeightTextbox;
        private Label ViewBezelWidthLabel;
        private TextBox ViewBezelWidthTextbox;
        private Label ViewBezelYLabel;
        private TextBox ViewBezelYTextbox;
        private Label ViewBezelXLabel;
        private TextBox ViewBezelXTextbox;
        private Label ViewBezelLabel;
        private Label OptionsLabel;
        private Label ResultsLabel;
        private Button GenerateLayFileButton;
        private ListView ElementsListview;
        private ListView ViewsListview;
        private ListView BezelsListview;
        private Button ElementMoveUpButton;
        private Button ElementMoveDownButton;
        private Button ElementDeleteButton;
        private Button ViewDeleteButton;
        private Button ViewMoveDownButton;
        private Button ViewMoveUpButton;
        private Button BezelDeleteButton;
        private ColumnHeader NumberHeader;
        private ColumnHeader NameHeader;
        private ColumnHeader ImageHeader;
        private ColumnHeader ViewNameHeader;
        private ColumnHeader ViewCommentHeader;
        private ColumnHeader ViewIndexHeader;
        private ColumnHeader ViewXHeader;
        private ColumnHeader ViewYHeader;
        private ColumnHeader ViewWidthHeader;
        private ColumnHeader ViewHeightHeader;
        private ColumnHeader ViewNumberHeader;
        private ColumnHeader BezelNumberHeader;
        private ColumnHeader BezelElementName;
        private ColumnHeader BezelViewName;
        private ColumnHeader BezelXHeader;
        private ColumnHeader BezelYHeader;
        private ColumnHeader BezelWidthHeader;
        private ColumnHeader BezelHeightHeader;
        private Label label1;
    }
}