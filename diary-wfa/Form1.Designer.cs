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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            currentEntryRichTextBox = new RichTextBox();
            previousEntriesListBox = new ListBox();
            entryTitleBox = new TextBox();
            enterButton = new Button();
            settingsButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            minimizeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // currentEntryRichTextBox
            // 
            currentEntryRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            currentEntryRichTextBox.BackColor = SystemColors.ControlLight;
            currentEntryRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            currentEntryRichTextBox.Location = new Point(288, 42);
            currentEntryRichTextBox.Margin = new Padding(4, 5, 4, 5);
            currentEntryRichTextBox.MaxLength = 3255;
            currentEntryRichTextBox.Name = "currentEntryRichTextBox";
            currentEntryRichTextBox.Size = new Size(759, 629);
            currentEntryRichTextBox.TabIndex = 0;
            currentEntryRichTextBox.Text = "";
            // 
            // previousEntriesListBox
            // 
            previousEntriesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            previousEntriesListBox.BackColor = SystemColors.ControlLight;
            previousEntriesListBox.BorderStyle = BorderStyle.FixedSingle;
            previousEntriesListBox.ForeColor = SystemColors.WindowText;
            previousEntriesListBox.FormattingEnabled = true;
            previousEntriesListBox.ItemHeight = 19;
            previousEntriesListBox.Location = new Point(13, 42);
            previousEntriesListBox.Margin = new Padding(4, 5, 4, 5);
            previousEntriesListBox.Name = "previousEntriesListBox";
            previousEntriesListBox.Size = new Size(267, 629);
            previousEntriesListBox.TabIndex = 1;
            previousEntriesListBox.MouseDoubleClick += previousEntriesListBox_MouseDoubleClick;
            previousEntriesListBox.MouseDown += previousEntriesListBox_MouseDown;
            // 
            // entryTitleBox
            // 
            entryTitleBox.Location = new Point(410, 631);
            entryTitleBox.Margin = new Padding(4, 5, 4, 5);
            entryTitleBox.Name = "entryTitleBox";
            entryTitleBox.PlaceholderText = "Entry Title:";
            entryTitleBox.Size = new Size(128, 26);
            entryTitleBox.TabIndex = 2;
            // 
            // enterButton
            // 
            enterButton.AutoSize = true;
            enterButton.Location = new Point(300, 630);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(103, 29);
            enterButton.TabIndex = 3;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(922, 630);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(113, 29);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(1017, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 5;
            exitButton.TextAlign = ContentAlignment.TopCenter;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 6;
            label1.Text = "E-Diary";
            // 
            // minimizeButton
            // 
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.Location = new Point(981, 4);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.TabIndex = 5;
            minimizeButton.TextAlign = ContentAlignment.TopCenter;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1060, 685);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(minimizeButton);
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(enterButton);
            Controls.Add(entryTitleBox);
            Controls.Add(previousEntriesListBox);
            Controls.Add(currentEntryRichTextBox);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "E-Diary";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox currentEntryRichTextBox;
        private ListBox previousEntriesListBox;
        private TextBox entryTitleBox;
        private Button enterButton;
        private Button settingsButton;
        private Button exitButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Button minimizeButton;
    }
}