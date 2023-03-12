namespace LayGeneratorGUI
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.AddBezelButton = new System.Windows.Forms.Button();
            this.GameTextbox = new System.Windows.Forms.TextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.MameVersionTextbox = new System.Windows.Forms.TextBox();
            this.MameVersionLabel = new System.Windows.Forms.Label();
            this.ElementsLabel = new System.Windows.Forms.Label();
            this.ElementNameTextbox = new System.Windows.Forms.TextBox();
            this.ElementNameLabel = new System.Windows.Forms.Label();
            this.ImageTextbox = new System.Windows.Forms.TextBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.ViewScreenIndexTextbox = new System.Windows.Forms.TextBox();
            this.ViewScreenIndexLabel = new System.Windows.Forms.Label();
            this.AddViewButton = new System.Windows.Forms.Button();
            this.ViewCommentTextbox = new System.Windows.Forms.TextBox();
            this.ViewCommentLabel = new System.Windows.Forms.Label();
            this.ViewNameTextbox = new System.Windows.Forms.TextBox();
            this.ViewNameLabel = new System.Windows.Forms.Label();
            this.ViewsLabel = new System.Windows.Forms.Label();
            this.ViewScreenXTextbox = new System.Windows.Forms.TextBox();
            this.ViewScreenLabel = new System.Windows.Forms.Label();
            this.ViewScreenXLabel = new System.Windows.Forms.Label();
            this.ViewScreenYLabel = new System.Windows.Forms.Label();
            this.ViewScreenYTextbox = new System.Windows.Forms.TextBox();
            this.ViewScreenHeightLabel = new System.Windows.Forms.Label();
            this.ViewScreenHeightTextbox = new System.Windows.Forms.TextBox();
            this.ViewScreenWidthLabel = new System.Windows.Forms.Label();
            this.ViewScreenWidthTextbox = new System.Windows.Forms.TextBox();
            this.AddBezelToViewLabel = new System.Windows.Forms.Label();
            this.BezelViewSearchTextbox = new System.Windows.Forms.TextBox();
            this.BezelViewNumberLabel = new System.Windows.Forms.Label();
            this.BezelViewNameTextbox = new System.Windows.Forms.TextBox();
            this.BezelViewNameLabel = new System.Windows.Forms.Label();
            this.ViewBezelHeightLabel = new System.Windows.Forms.Label();
            this.ViewBezelHeightTextbox = new System.Windows.Forms.TextBox();
            this.ViewBezelWidthLabel = new System.Windows.Forms.Label();
            this.ViewBezelWidthTextbox = new System.Windows.Forms.TextBox();
            this.ViewBezelYLabel = new System.Windows.Forms.Label();
            this.ViewBezelYTextbox = new System.Windows.Forms.TextBox();
            this.ViewBezelXLabel = new System.Windows.Forms.Label();
            this.ViewBezelXTextbox = new System.Windows.Forms.TextBox();
            this.ViewBezelLabel = new System.Windows.Forms.Label();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.GenerateLayFileButton = new System.Windows.Forms.Button();
            this.ElementsListview = new System.Windows.Forms.ListView();
            this.NumberHeader = new System.Windows.Forms.ColumnHeader();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.ImageHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewsListview = new System.Windows.Forms.ListView();
            this.ViewNumberHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewNameHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewCommentHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewIndexHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewXHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewYHeader = new System.Windows.Forms.ColumnHeader();
            this.ViewWidthHeader = new System.Windows.Forms.ColumnHeader();
            this.HeightHeader = new System.Windows.Forms.ColumnHeader();
            this.BezelsListview = new System.Windows.Forms.ListView();
            this.ElementMoveUpButton = new System.Windows.Forms.Button();
            this.ElementMoveDownButton = new System.Windows.Forms.Button();
            this.ElementDeleteButton = new System.Windows.Forms.Button();
            this.ViewDeleteButton = new System.Windows.Forms.Button();
            this.ViewMoveDownButton = new System.Windows.Forms.Button();
            this.ViewMoveUpButton = new System.Windows.Forms.Button();
            this.BezelDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBezelButton
            // 
            this.AddBezelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddBezelButton.FlatAppearance.BorderSize = 0;
            this.AddBezelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBezelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBezelButton.Location = new System.Drawing.Point(12, 519);
            this.AddBezelButton.Name = "AddBezelButton";
            this.AddBezelButton.Size = new System.Drawing.Size(622, 23);
            this.AddBezelButton.TabIndex = 1;
            this.AddBezelButton.Text = "Add Bezel";
            this.AddBezelButton.UseVisualStyleBackColor = false;
            this.AddBezelButton.Click += new System.EventHandler(this.AddBezelButton_Click);
            // 
            // GameTextbox
            // 
            this.GameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameTextbox.Location = new System.Drawing.Point(130, 56);
            this.GameTextbox.Name = "GameTextbox";
            this.GameTextbox.Size = new System.Drawing.Size(146, 16);
            this.GameTextbox.TabIndex = 5;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameLabel.Location = new System.Drawing.Point(13, 57);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(47, 17);
            this.GameLabel.TabIndex = 4;
            this.GameLabel.Text = "Game:";
            // 
            // MameVersionTextbox
            // 
            this.MameVersionTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MameVersionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MameVersionTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MameVersionTextbox.Location = new System.Drawing.Point(437, 56);
            this.MameVersionTextbox.Name = "MameVersionTextbox";
            this.MameVersionTextbox.Size = new System.Drawing.Size(26, 16);
            this.MameVersionTextbox.TabIndex = 7;
            this.MameVersionTextbox.Text = "2";
            this.MameVersionTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MameVersionLabel
            // 
            this.MameVersionLabel.AutoSize = true;
            this.MameVersionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MameVersionLabel.Location = new System.Drawing.Point(339, 59);
            this.MameVersionLabel.Name = "MameVersionLabel";
            this.MameVersionLabel.Size = new System.Drawing.Size(85, 15);
            this.MameVersionLabel.TabIndex = 6;
            this.MameVersionLabel.Text = "Mame version:";
            // 
            // ElementsLabel
            // 
            this.ElementsLabel.AutoSize = true;
            this.ElementsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ElementsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElementsLabel.Location = new System.Drawing.Point(12, 127);
            this.ElementsLabel.Name = "ElementsLabel";
            this.ElementsLabel.Size = new System.Drawing.Size(68, 17);
            this.ElementsLabel.TabIndex = 11;
            this.ElementsLabel.Text = "Elements:";
            // 
            // ElementNameTextbox
            // 
            this.ElementNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ElementNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElementNameTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElementNameTextbox.Location = new System.Drawing.Point(130, 150);
            this.ElementNameTextbox.Name = "ElementNameTextbox";
            this.ElementNameTextbox.Size = new System.Drawing.Size(146, 16);
            this.ElementNameTextbox.TabIndex = 13;
            // 
            // ElementNameLabel
            // 
            this.ElementNameLabel.AutoSize = true;
            this.ElementNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElementNameLabel.Location = new System.Drawing.Point(12, 153);
            this.ElementNameLabel.Name = "ElementNameLabel";
            this.ElementNameLabel.Size = new System.Drawing.Size(42, 15);
            this.ElementNameLabel.TabIndex = 12;
            this.ElementNameLabel.Text = "Name:";
            // 
            // ImageTextbox
            // 
            this.ImageTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ImageTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImageTextbox.Location = new System.Drawing.Point(437, 150);
            this.ImageTextbox.Name = "ImageTextbox";
            this.ImageTextbox.Size = new System.Drawing.Size(197, 16);
            this.ImageTextbox.TabIndex = 15;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImageLabel.Location = new System.Drawing.Point(346, 153);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(43, 15);
            this.ImageLabel.TabIndex = 14;
            this.ImageLabel.Text = "Image:";
            // 
            // AddElementButton
            // 
            this.AddElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddElementButton.FlatAppearance.BorderSize = 0;
            this.AddElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddElementButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddElementButton.Location = new System.Drawing.Point(12, 179);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(622, 23);
            this.AddElementButton.TabIndex = 16;
            this.AddElementButton.Text = "Add Element";
            this.AddElementButton.UseVisualStyleBackColor = false;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // ViewScreenIndexTextbox
            // 
            this.ViewScreenIndexTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewScreenIndexTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewScreenIndexTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenIndexTextbox.Location = new System.Drawing.Point(175, 317);
            this.ViewScreenIndexTextbox.Name = "ViewScreenIndexTextbox";
            this.ViewScreenIndexTextbox.Size = new System.Drawing.Size(26, 16);
            this.ViewScreenIndexTextbox.TabIndex = 18;
            this.ViewScreenIndexTextbox.Text = "0";
            this.ViewScreenIndexTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewScreenIndexLabel
            // 
            this.ViewScreenIndexLabel.AutoSize = true;
            this.ViewScreenIndexLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenIndexLabel.Location = new System.Drawing.Point(130, 320);
            this.ViewScreenIndexLabel.Name = "ViewScreenIndexLabel";
            this.ViewScreenIndexLabel.Size = new System.Drawing.Size(39, 15);
            this.ViewScreenIndexLabel.TabIndex = 17;
            this.ViewScreenIndexLabel.Text = "Index:";
            // 
            // AddViewButton
            // 
            this.AddViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddViewButton.FlatAppearance.BorderSize = 0;
            this.AddViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddViewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddViewButton.Location = new System.Drawing.Point(12, 346);
            this.AddViewButton.Name = "AddViewButton";
            this.AddViewButton.Size = new System.Drawing.Size(622, 23);
            this.AddViewButton.TabIndex = 24;
            this.AddViewButton.Text = "Add View";
            this.AddViewButton.UseVisualStyleBackColor = false;
            this.AddViewButton.Click += new System.EventHandler(this.AddViewButton_Click);
            // 
            // ViewCommentTextbox
            // 
            this.ViewCommentTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewCommentTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewCommentTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewCommentTextbox.Location = new System.Drawing.Point(419, 279);
            this.ViewCommentTextbox.Name = "ViewCommentTextbox";
            this.ViewCommentTextbox.Size = new System.Drawing.Size(215, 16);
            this.ViewCommentTextbox.TabIndex = 23;
            // 
            // ViewCommentLabel
            // 
            this.ViewCommentLabel.AutoSize = true;
            this.ViewCommentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewCommentLabel.Location = new System.Drawing.Point(328, 279);
            this.ViewCommentLabel.Name = "ViewCommentLabel";
            this.ViewCommentLabel.Size = new System.Drawing.Size(64, 15);
            this.ViewCommentLabel.TabIndex = 22;
            this.ViewCommentLabel.Text = "Comment:";
            // 
            // ViewNameTextbox
            // 
            this.ViewNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewNameTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewNameTextbox.Location = new System.Drawing.Point(130, 276);
            this.ViewNameTextbox.Name = "ViewNameTextbox";
            this.ViewNameTextbox.Size = new System.Drawing.Size(146, 16);
            this.ViewNameTextbox.TabIndex = 21;
            // 
            // ViewNameLabel
            // 
            this.ViewNameLabel.AutoSize = true;
            this.ViewNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewNameLabel.Location = new System.Drawing.Point(12, 282);
            this.ViewNameLabel.Name = "ViewNameLabel";
            this.ViewNameLabel.Size = new System.Drawing.Size(42, 15);
            this.ViewNameLabel.TabIndex = 20;
            this.ViewNameLabel.Text = "Name:";
            // 
            // ViewsLabel
            // 
            this.ViewsLabel.AutoSize = true;
            this.ViewsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewsLabel.Location = new System.Drawing.Point(12, 256);
            this.ViewsLabel.Name = "ViewsLabel";
            this.ViewsLabel.Size = new System.Drawing.Size(48, 17);
            this.ViewsLabel.TabIndex = 19;
            this.ViewsLabel.Text = "Views:";
            // 
            // ViewScreenXTextbox
            // 
            this.ViewScreenXTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewScreenXTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewScreenXTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenXTextbox.Location = new System.Drawing.Point(242, 317);
            this.ViewScreenXTextbox.Name = "ViewScreenXTextbox";
            this.ViewScreenXTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewScreenXTextbox.TabIndex = 26;
            // 
            // ViewScreenLabel
            // 
            this.ViewScreenLabel.AutoSize = true;
            this.ViewScreenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewScreenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenLabel.Location = new System.Drawing.Point(31, 320);
            this.ViewScreenLabel.Name = "ViewScreenLabel";
            this.ViewScreenLabel.Size = new System.Drawing.Size(93, 15);
            this.ViewScreenLabel.TabIndex = 25;
            this.ViewScreenLabel.Text = "Screen Bounds:";
            // 
            // ViewScreenXLabel
            // 
            this.ViewScreenXLabel.AutoSize = true;
            this.ViewScreenXLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenXLabel.Location = new System.Drawing.Point(219, 320);
            this.ViewScreenXLabel.Name = "ViewScreenXLabel";
            this.ViewScreenXLabel.Size = new System.Drawing.Size(17, 15);
            this.ViewScreenXLabel.TabIndex = 29;
            this.ViewScreenXLabel.Text = "X:";
            // 
            // ViewScreenYLabel
            // 
            this.ViewScreenYLabel.AutoSize = true;
            this.ViewScreenYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenYLabel.Location = new System.Drawing.Point(314, 320);
            this.ViewScreenYLabel.Name = "ViewScreenYLabel";
            this.ViewScreenYLabel.Size = new System.Drawing.Size(17, 15);
            this.ViewScreenYLabel.TabIndex = 31;
            this.ViewScreenYLabel.Text = "Y:";
            // 
            // ViewScreenYTextbox
            // 
            this.ViewScreenYTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewScreenYTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewScreenYTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenYTextbox.Location = new System.Drawing.Point(337, 317);
            this.ViewScreenYTextbox.Name = "ViewScreenYTextbox";
            this.ViewScreenYTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewScreenYTextbox.TabIndex = 30;
            // 
            // ViewScreenHeightLabel
            // 
            this.ViewScreenHeightLabel.AutoSize = true;
            this.ViewScreenHeightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenHeightLabel.Location = new System.Drawing.Point(530, 320);
            this.ViewScreenHeightLabel.Name = "ViewScreenHeightLabel";
            this.ViewScreenHeightLabel.Size = new System.Drawing.Size(46, 15);
            this.ViewScreenHeightLabel.TabIndex = 35;
            this.ViewScreenHeightLabel.Text = "Height:";
            // 
            // ViewScreenHeightTextbox
            // 
            this.ViewScreenHeightTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewScreenHeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewScreenHeightTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenHeightTextbox.Location = new System.Drawing.Point(582, 317);
            this.ViewScreenHeightTextbox.Name = "ViewScreenHeightTextbox";
            this.ViewScreenHeightTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewScreenHeightTextbox.TabIndex = 34;
            // 
            // ViewScreenWidthLabel
            // 
            this.ViewScreenWidthLabel.AutoSize = true;
            this.ViewScreenWidthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenWidthLabel.Location = new System.Drawing.Point(411, 320);
            this.ViewScreenWidthLabel.Name = "ViewScreenWidthLabel";
            this.ViewScreenWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.ViewScreenWidthLabel.TabIndex = 33;
            this.ViewScreenWidthLabel.Text = "Width:";
            // 
            // ViewScreenWidthTextbox
            // 
            this.ViewScreenWidthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewScreenWidthTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewScreenWidthTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewScreenWidthTextbox.Location = new System.Drawing.Point(458, 317);
            this.ViewScreenWidthTextbox.Name = "ViewScreenWidthTextbox";
            this.ViewScreenWidthTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewScreenWidthTextbox.TabIndex = 32;
            // 
            // AddBezelToViewLabel
            // 
            this.AddBezelToViewLabel.AutoSize = true;
            this.AddBezelToViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBezelToViewLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBezelToViewLabel.Location = new System.Drawing.Point(13, 427);
            this.AddBezelToViewLabel.Name = "AddBezelToViewLabel";
            this.AddBezelToViewLabel.Size = new System.Drawing.Size(124, 17);
            this.AddBezelToViewLabel.TabIndex = 36;
            this.AddBezelToViewLabel.Text = "Add Bezel to View:";
            // 
            // BezelViewSearchTextbox
            // 
            this.BezelViewSearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BezelViewSearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BezelViewSearchTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BezelViewSearchTextbox.Location = new System.Drawing.Point(130, 453);
            this.BezelViewSearchTextbox.Name = "BezelViewSearchTextbox";
            this.BezelViewSearchTextbox.Size = new System.Drawing.Size(42, 16);
            this.BezelViewSearchTextbox.TabIndex = 38;
            // 
            // BezelViewNumberLabel
            // 
            this.BezelViewNumberLabel.AutoSize = true;
            this.BezelViewNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BezelViewNumberLabel.Location = new System.Drawing.Point(12, 456);
            this.BezelViewNumberLabel.Name = "BezelViewNumberLabel";
            this.BezelViewNumberLabel.Size = new System.Drawing.Size(115, 15);
            this.BezelViewNumberLabel.TabIndex = 37;
            this.BezelViewNumberLabel.Text = "View number/name:";
            // 
            // BezelViewNameTextbox
            // 
            this.BezelViewNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BezelViewNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BezelViewNameTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BezelViewNameTextbox.Location = new System.Drawing.Point(437, 453);
            this.BezelViewNameTextbox.Name = "BezelViewNameTextbox";
            this.BezelViewNameTextbox.Size = new System.Drawing.Size(197, 16);
            this.BezelViewNameTextbox.TabIndex = 40;
            // 
            // BezelViewNameLabel
            // 
            this.BezelViewNameLabel.AutoSize = true;
            this.BezelViewNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BezelViewNameLabel.Location = new System.Drawing.Point(339, 456);
            this.BezelViewNameLabel.Name = "BezelViewNameLabel";
            this.BezelViewNameLabel.Size = new System.Drawing.Size(42, 15);
            this.BezelViewNameLabel.TabIndex = 39;
            this.BezelViewNameLabel.Text = "Name:";
            // 
            // ViewBezelHeightLabel
            // 
            this.ViewBezelHeightLabel.AutoSize = true;
            this.ViewBezelHeightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelHeightLabel.Location = new System.Drawing.Point(530, 493);
            this.ViewBezelHeightLabel.Name = "ViewBezelHeightLabel";
            this.ViewBezelHeightLabel.Size = new System.Drawing.Size(46, 15);
            this.ViewBezelHeightLabel.TabIndex = 51;
            this.ViewBezelHeightLabel.Text = "Height:";
            // 
            // ViewBezelHeightTextbox
            // 
            this.ViewBezelHeightTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewBezelHeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewBezelHeightTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelHeightTextbox.Location = new System.Drawing.Point(582, 490);
            this.ViewBezelHeightTextbox.Name = "ViewBezelHeightTextbox";
            this.ViewBezelHeightTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewBezelHeightTextbox.TabIndex = 50;
            // 
            // ViewBezelWidthLabel
            // 
            this.ViewBezelWidthLabel.AutoSize = true;
            this.ViewBezelWidthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelWidthLabel.Location = new System.Drawing.Point(389, 493);
            this.ViewBezelWidthLabel.Name = "ViewBezelWidthLabel";
            this.ViewBezelWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.ViewBezelWidthLabel.TabIndex = 49;
            this.ViewBezelWidthLabel.Text = "Width:";
            // 
            // ViewBezelWidthTextbox
            // 
            this.ViewBezelWidthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewBezelWidthTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewBezelWidthTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelWidthTextbox.Location = new System.Drawing.Point(436, 490);
            this.ViewBezelWidthTextbox.Name = "ViewBezelWidthTextbox";
            this.ViewBezelWidthTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewBezelWidthTextbox.TabIndex = 48;
            // 
            // ViewBezelYLabel
            // 
            this.ViewBezelYLabel.AutoSize = true;
            this.ViewBezelYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelYLabel.Location = new System.Drawing.Point(242, 493);
            this.ViewBezelYLabel.Name = "ViewBezelYLabel";
            this.ViewBezelYLabel.Size = new System.Drawing.Size(17, 15);
            this.ViewBezelYLabel.TabIndex = 47;
            this.ViewBezelYLabel.Text = "Y:";
            // 
            // ViewBezelYTextbox
            // 
            this.ViewBezelYTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewBezelYTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewBezelYTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelYTextbox.Location = new System.Drawing.Point(265, 490);
            this.ViewBezelYTextbox.Name = "ViewBezelYTextbox";
            this.ViewBezelYTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewBezelYTextbox.TabIndex = 46;
            // 
            // ViewBezelXLabel
            // 
            this.ViewBezelXLabel.AutoSize = true;
            this.ViewBezelXLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelXLabel.Location = new System.Drawing.Point(126, 493);
            this.ViewBezelXLabel.Name = "ViewBezelXLabel";
            this.ViewBezelXLabel.Size = new System.Drawing.Size(17, 15);
            this.ViewBezelXLabel.TabIndex = 45;
            this.ViewBezelXLabel.Text = "X:";
            // 
            // ViewBezelXTextbox
            // 
            this.ViewBezelXTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewBezelXTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewBezelXTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelXTextbox.Location = new System.Drawing.Point(149, 490);
            this.ViewBezelXTextbox.Name = "ViewBezelXTextbox";
            this.ViewBezelXTextbox.Size = new System.Drawing.Size(52, 16);
            this.ViewBezelXTextbox.TabIndex = 44;
            // 
            // ViewBezelLabel
            // 
            this.ViewBezelLabel.AutoSize = true;
            this.ViewBezelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewBezelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBezelLabel.Location = new System.Drawing.Point(31, 493);
            this.ViewBezelLabel.Name = "ViewBezelLabel";
            this.ViewBezelLabel.Size = new System.Drawing.Size(85, 15);
            this.ViewBezelLabel.TabIndex = 43;
            this.ViewBezelLabel.Text = "Bezel Bounds:";
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.OptionsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionsLabel.Location = new System.Drawing.Point(270, 9);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(111, 32);
            this.OptionsLabel.TabIndex = 52;
            this.OptionsLabel.Text = "Options:";
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ResultsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultsLabel.Location = new System.Drawing.Point(813, 9);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(102, 32);
            this.ResultsLabel.TabIndex = 53;
            this.ResultsLabel.Text = "Results:";
            // 
            // GenerateLayFileButton
            // 
            this.GenerateLayFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GenerateLayFileButton.FlatAppearance.BorderSize = 0;
            this.GenerateLayFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateLayFileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenerateLayFileButton.Location = new System.Drawing.Point(13, 562);
            this.GenerateLayFileButton.Name = "GenerateLayFileButton";
            this.GenerateLayFileButton.Size = new System.Drawing.Size(1247, 23);
            this.GenerateLayFileButton.TabIndex = 54;
            this.GenerateLayFileButton.Text = "Generate Lay File";
            this.GenerateLayFileButton.UseVisualStyleBackColor = false;
            this.GenerateLayFileButton.Click += new System.EventHandler(this.GenerateLayFileButton_Click);
            // 
            // ElementsListview
            // 
            this.ElementsListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ElementsListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElementsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberHeader,
            this.NameHeader,
            this.ImageHeader});
            this.ElementsListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ElementsListview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ElementsListview.Location = new System.Drawing.Point(655, 127);
            this.ElementsListview.Name = "ElementsListview";
            this.ElementsListview.Size = new System.Drawing.Size(605, 94);
            this.ElementsListview.TabIndex = 58;
            this.ElementsListview.UseCompatibleStateImageBehavior = false;
            this.ElementsListview.View = System.Windows.Forms.View.Details;
            this.ElementsListview.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ElementsListview_ItemChecked);
            this.ElementsListview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ElementsListview_ItemSelectionChanged);
            // 
            // NumberHeader
            // 
            this.NumberHeader.Text = "Number";
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 273;
            // 
            // ImageHeader
            // 
            this.ImageHeader.Text = "Image";
            this.ImageHeader.Width = 272;
            // 
            // ViewsListview
            // 
            this.ViewsListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewsListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ViewNumberHeader,
            this.ViewNameHeader,
            this.ViewCommentHeader,
            this.ViewIndexHeader,
            this.ViewXHeader,
            this.ViewYHeader,
            this.ViewWidthHeader,
            this.HeightHeader});
            this.ViewsListview.Location = new System.Drawing.Point(655, 256);
            this.ViewsListview.Name = "ViewsListview";
            this.ViewsListview.Size = new System.Drawing.Size(605, 139);
            this.ViewsListview.TabIndex = 59;
            this.ViewsListview.UseCompatibleStateImageBehavior = false;
            this.ViewsListview.View = System.Windows.Forms.View.Details;
            this.ViewsListview.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ViewsListview_ItemChecked);
            this.ViewsListview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ViewsListview_ItemSelectionChanged);
            // 
            // ViewNumberHeader
            // 
            this.ViewNumberHeader.Text = "Number";
            // 
            // ViewNameHeader
            // 
            this.ViewNameHeader.Text = "Name";
            this.ViewNameHeader.Width = 100;
            // 
            // ViewCommentHeader
            // 
            this.ViewCommentHeader.Text = "Comment";
            this.ViewCommentHeader.Width = 100;
            // 
            // ViewIndexHeader
            // 
            this.ViewIndexHeader.Text = "Index";
            this.ViewIndexHeader.Width = 70;
            // 
            // ViewXHeader
            // 
            this.ViewXHeader.Text = "X";
            this.ViewXHeader.Width = 70;
            // 
            // ViewYHeader
            // 
            this.ViewYHeader.Text = "Y";
            this.ViewYHeader.Width = 70;
            // 
            // ViewWidthHeader
            // 
            this.ViewWidthHeader.Text = "Width";
            this.ViewWidthHeader.Width = 70;
            // 
            // HeightHeader
            // 
            this.HeightHeader.Text = "Height";
            this.HeightHeader.Width = 70;
            // 
            // BezelsListview
            // 
            this.BezelsListview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BezelsListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BezelsListview.Location = new System.Drawing.Point(655, 448);
            this.BezelsListview.Name = "BezelsListview";
            this.BezelsListview.Size = new System.Drawing.Size(605, 94);
            this.BezelsListview.TabIndex = 60;
            this.BezelsListview.UseCompatibleStateImageBehavior = false;
            this.BezelsListview.View = System.Windows.Forms.View.Details;
            this.BezelsListview.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.BezelsListview_ItemChecked);
            this.BezelsListview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.BezelsListview_ItemSelectionChanged);
            // 
            // ElementMoveUpButton
            // 
            this.ElementMoveUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ElementMoveUpButton.Enabled = false;
            this.ElementMoveUpButton.FlatAppearance.BorderSize = 0;
            this.ElementMoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElementMoveUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElementMoveUpButton.Location = new System.Drawing.Point(1266, 133);
            this.ElementMoveUpButton.Name = "ElementMoveUpButton";
            this.ElementMoveUpButton.Size = new System.Drawing.Size(88, 23);
            this.ElementMoveUpButton.TabIndex = 61;
            this.ElementMoveUpButton.Text = "Move Up";
            this.ElementMoveUpButton.UseVisualStyleBackColor = false;
            this.ElementMoveUpButton.Click += new System.EventHandler(this.ElementMoveUpButton_Click);
            // 
            // ElementMoveDownButton
            // 
            this.ElementMoveDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ElementMoveDownButton.Enabled = false;
            this.ElementMoveDownButton.FlatAppearance.BorderSize = 0;
            this.ElementMoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElementMoveDownButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElementMoveDownButton.Location = new System.Drawing.Point(1266, 162);
            this.ElementMoveDownButton.Name = "ElementMoveDownButton";
            this.ElementMoveDownButton.Size = new System.Drawing.Size(88, 23);
            this.ElementMoveDownButton.TabIndex = 62;
            this.ElementMoveDownButton.Text = "Move Down";
            this.ElementMoveDownButton.UseVisualStyleBackColor = false;
            this.ElementMoveDownButton.Click += new System.EventHandler(this.ElementMoveDownButton_Click);
            // 
            // ElementDeleteButton
            // 
            this.ElementDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ElementDeleteButton.FlatAppearance.BorderSize = 0;
            this.ElementDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElementDeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElementDeleteButton.Location = new System.Drawing.Point(1266, 191);
            this.ElementDeleteButton.Name = "ElementDeleteButton";
            this.ElementDeleteButton.Size = new System.Drawing.Size(88, 23);
            this.ElementDeleteButton.TabIndex = 63;
            this.ElementDeleteButton.Text = "Delete";
            this.ElementDeleteButton.UseVisualStyleBackColor = false;
            this.ElementDeleteButton.Click += new System.EventHandler(this.ElementDeleteButton_Click);
            // 
            // ViewDeleteButton
            // 
            this.ViewDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewDeleteButton.FlatAppearance.BorderSize = 0;
            this.ViewDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewDeleteButton.Location = new System.Drawing.Point(1266, 341);
            this.ViewDeleteButton.Name = "ViewDeleteButton";
            this.ViewDeleteButton.Size = new System.Drawing.Size(88, 23);
            this.ViewDeleteButton.TabIndex = 66;
            this.ViewDeleteButton.Text = "Delete";
            this.ViewDeleteButton.UseVisualStyleBackColor = false;
            this.ViewDeleteButton.Click += new System.EventHandler(this.ViewDeleteButton_Click);
            // 
            // ViewMoveDownButton
            // 
            this.ViewMoveDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewMoveDownButton.Enabled = false;
            this.ViewMoveDownButton.FlatAppearance.BorderSize = 0;
            this.ViewMoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewMoveDownButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewMoveDownButton.Location = new System.Drawing.Point(1266, 312);
            this.ViewMoveDownButton.Name = "ViewMoveDownButton";
            this.ViewMoveDownButton.Size = new System.Drawing.Size(88, 23);
            this.ViewMoveDownButton.TabIndex = 65;
            this.ViewMoveDownButton.Text = "Move Down";
            this.ViewMoveDownButton.UseVisualStyleBackColor = false;
            this.ViewMoveDownButton.Click += new System.EventHandler(this.ViewMoveDownButton_Click);
            // 
            // ViewMoveUpButton
            // 
            this.ViewMoveUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ViewMoveUpButton.Enabled = false;
            this.ViewMoveUpButton.FlatAppearance.BorderSize = 0;
            this.ViewMoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewMoveUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewMoveUpButton.Location = new System.Drawing.Point(1266, 283);
            this.ViewMoveUpButton.Name = "ViewMoveUpButton";
            this.ViewMoveUpButton.Size = new System.Drawing.Size(88, 23);
            this.ViewMoveUpButton.TabIndex = 64;
            this.ViewMoveUpButton.Text = "Move Up";
            this.ViewMoveUpButton.UseVisualStyleBackColor = false;
            this.ViewMoveUpButton.Click += new System.EventHandler(this.ViewMoveUpButton_Click);
            // 
            // BezelDeleteButton
            // 
            this.BezelDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BezelDeleteButton.FlatAppearance.BorderSize = 0;
            this.BezelDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BezelDeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BezelDeleteButton.Location = new System.Drawing.Point(1266, 512);
            this.BezelDeleteButton.Name = "BezelDeleteButton";
            this.BezelDeleteButton.Size = new System.Drawing.Size(88, 23);
            this.BezelDeleteButton.TabIndex = 69;
            this.BezelDeleteButton.Text = "Delete";
            this.BezelDeleteButton.UseVisualStyleBackColor = false;
            this.BezelDeleteButton.Click += new System.EventHandler(this.BezelDeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1377, 608);
            this.Controls.Add(this.BezelDeleteButton);
            this.Controls.Add(this.ViewDeleteButton);
            this.Controls.Add(this.ViewMoveDownButton);
            this.Controls.Add(this.ViewMoveUpButton);
            this.Controls.Add(this.ElementDeleteButton);
            this.Controls.Add(this.ElementMoveDownButton);
            this.Controls.Add(this.ElementMoveUpButton);
            this.Controls.Add(this.BezelsListview);
            this.Controls.Add(this.ViewsListview);
            this.Controls.Add(this.ElementsListview);
            this.Controls.Add(this.GenerateLayFileButton);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.ViewBezelHeightLabel);
            this.Controls.Add(this.ViewBezelHeightTextbox);
            this.Controls.Add(this.ViewBezelWidthLabel);
            this.Controls.Add(this.ViewBezelWidthTextbox);
            this.Controls.Add(this.ViewBezelYLabel);
            this.Controls.Add(this.ViewBezelYTextbox);
            this.Controls.Add(this.ViewBezelXLabel);
            this.Controls.Add(this.ViewBezelXTextbox);
            this.Controls.Add(this.ViewBezelLabel);
            this.Controls.Add(this.BezelViewNameTextbox);
            this.Controls.Add(this.BezelViewNameLabel);
            this.Controls.Add(this.BezelViewSearchTextbox);
            this.Controls.Add(this.BezelViewNumberLabel);
            this.Controls.Add(this.AddBezelToViewLabel);
            this.Controls.Add(this.ViewScreenHeightLabel);
            this.Controls.Add(this.ViewScreenHeightTextbox);
            this.Controls.Add(this.ViewScreenWidthLabel);
            this.Controls.Add(this.ViewScreenWidthTextbox);
            this.Controls.Add(this.ViewScreenYLabel);
            this.Controls.Add(this.ViewScreenYTextbox);
            this.Controls.Add(this.ViewScreenXLabel);
            this.Controls.Add(this.ViewScreenXTextbox);
            this.Controls.Add(this.ViewScreenLabel);
            this.Controls.Add(this.AddViewButton);
            this.Controls.Add(this.ViewCommentTextbox);
            this.Controls.Add(this.ViewCommentLabel);
            this.Controls.Add(this.ViewNameTextbox);
            this.Controls.Add(this.ViewNameLabel);
            this.Controls.Add(this.ViewsLabel);
            this.Controls.Add(this.ViewScreenIndexTextbox);
            this.Controls.Add(this.ViewScreenIndexLabel);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.ImageTextbox);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ElementNameTextbox);
            this.Controls.Add(this.ElementNameLabel);
            this.Controls.Add(this.ElementsLabel);
            this.Controls.Add(this.MameVersionTextbox);
            this.Controls.Add(this.MameVersionLabel);
            this.Controls.Add(this.GameTextbox);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.AddBezelButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lay File Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ColumnHeader HeightHeader;
        private ColumnHeader ViewNumberHeader;
    }
}