namespace diary_wfa
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
            currentEntryRichTextBox = new RichTextBox();
            previousEntriesListBox = new ListBox();
            entryTitleBox = new TextBox();
            enterButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // currentEntryRichTextBox
            // 
            currentEntryRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            currentEntryRichTextBox.BackColor = SystemColors.Window;
            currentEntryRichTextBox.Location = new Point(303, 14);
            currentEntryRichTextBox.Margin = new Padding(4, 5, 4, 5);
            currentEntryRichTextBox.MaxLength = 3255;
            currentEntryRichTextBox.Name = "currentEntryRichTextBox";
            currentEntryRichTextBox.Size = new Size(744, 631);
            currentEntryRichTextBox.TabIndex = 0;
            currentEntryRichTextBox.Text = "";
            // 
            // previousEntriesListBox
            // 
            previousEntriesListBox.FormattingEnabled = true;
            previousEntriesListBox.ItemHeight = 19;
            previousEntriesListBox.Location = new Point(13, 14);
            previousEntriesListBox.Margin = new Padding(4, 5, 4, 5);
            previousEntriesListBox.Name = "previousEntriesListBox";
            previousEntriesListBox.ScrollAlwaysVisible = true;
            previousEntriesListBox.Size = new Size(267, 631);
            previousEntriesListBox.TabIndex = 1;
            // 
            // entryTitleBox
            // 
            entryTitleBox.Location = new Point(311, 611);
            entryTitleBox.Margin = new Padding(4, 5, 4, 5);
            entryTitleBox.Name = "entryTitleBox";
            entryTitleBox.PlaceholderText = "Entry Title:";
            entryTitleBox.Size = new Size(128, 26);
            entryTitleBox.TabIndex = 2;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(446, 611);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(69, 26);
            enterButton.TabIndex = 3;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(521, 611);
            button1.Name = "button1";
            button1.Size = new Size(113, 26);
            button1.TabIndex = 4;
            button1.Text = "Dark Theme";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 659);
            Controls.Add(button1);
            Controls.Add(enterButton);
            Controls.Add(entryTitleBox);
            Controls.Add(previousEntriesListBox);
            Controls.Add(currentEntryRichTextBox);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1076, 698);
            MinimumSize = new Size(1076, 698);
            Name = "Form1";
            Text = "E-Diary";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox currentEntryRichTextBox;
        public ListBox previousEntriesListBox;
        public TextBox entryTitleBox;
        public Button enterButton;
        public Button button1;
    }
}