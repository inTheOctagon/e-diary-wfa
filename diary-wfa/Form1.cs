namespace diary_wfa
{
    public partial class Form1 : Form
    {
        public static string path;
        public static GeneralMechanism general;
        public Form1()
        {
            InitializeComponent();
            path = "Entries.json";
            general = new GeneralMechanism();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                if (File.ReadAllText(path) != string.Empty)
                {
                    GeneralMechanism.entries = general.Read(path);
                }

                general.Refresh(previousEntriesListBox, entryTitleBox, currentEntryRichTextBox);
            }

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (general.writingMode)
            {
                general.CreateEntry(entryTitleBox.Text, currentEntryRichTextBox.Text, DateTime.Now.ToString("dd/MM/yyyy"));
                general.Write(path, general.Serialize(GeneralMechanism.entries));
                general.Refresh(previousEntriesListBox, entryTitleBox, currentEntryRichTextBox);
            }
            else
            {
                general.writingMode = true;

                currentEntryRichTextBox.ReadOnly = false;
                currentEntryRichTextBox.Text = string.Empty;
                entryTitleBox.Visible = true;
                enterButton.Text = "Enter";
            }


        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void previousEntriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            general.writingMode = false;

            currentEntryRichTextBox.ReadOnly = true;
            general.ShowEntry(previousEntriesListBox, currentEntryRichTextBox);
            entryTitleBox.Visible = false;
            enterButton.Text = "Writing Mode";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            general.dragging = true;
            general.lastLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            general.dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (general.dragging)
            {
                general.Drag(this,e);
            }
        }

       

        private void previousEntriesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                general.DeleteEntry(sender);
                
                general.Write(path, general.Serialize(GeneralMechanism.entries));

                general.Refresh(previousEntriesListBox);
            }

        }

        
    }
}