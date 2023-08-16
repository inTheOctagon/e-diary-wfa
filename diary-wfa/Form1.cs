namespace diary_wfa
{
    public partial class Form1 : Form
    {
        public static string path;

        public Form1()
        {
            InitializeComponent();
            path = "Entries.json";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                if(File.ReadAllText(path) != string.Empty)
                {
                    GeneralMechanism.entries = GeneralMechanism.Read(path);
                }

                GeneralMechanism.Refresh(previousEntriesListBox,entryTitleBox,currentEntryRichTextBox);
            }
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            GeneralMechanism.CreateEntry(entryTitleBox.Text, currentEntryRichTextBox.Text, DateTime.Now.ToString("dd/MM/yyyy"));
            GeneralMechanism.Write(path, GeneralMechanism.Serialize(GeneralMechanism.entries));
            GeneralMechanism.Refresh(previousEntriesListBox, entryTitleBox, currentEntryRichTextBox);

        }


    }
}