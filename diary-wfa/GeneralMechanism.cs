using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace diary_wfa
{
    public class GeneralMechanism
    {

        public static List<Entry> entries = new List<Entry>();
        public static Form entryForm = new Form();

        public bool writingMode = true;
        public bool lightTheme = true;
        public bool dragging = false; 

        public Point lastLocation = new Point();
        public void CreateEntry(string title, string text, string date)
        {
            Entry entry = new Entry(title, text, date);
            entries.Add(entry);
        }

        public string Serialize(List<Entry> entry)
        {
            string jsonString = JsonSerializer.Serialize(entry);
            return jsonString;
        }

        public void Write(string path, string jsonString)
        {
            File.WriteAllText(path, jsonString);
        }

        public List<Entry> Read(string path) => JsonSerializer.Deserialize<List<Entry>>(File.ReadAllText(path));
        

        public void Refresh(ListBox listBox, TextBox textBox, RichTextBox richTextBox)
        {
            listBox.Items.Clear();

            foreach (Entry entry in entries)
            {
                listBox.Items.Add(entry.Title+" - "+entry.Date);
            }

            textBox.Clear();
            richTextBox.Clear();

            
            
        }

        public void Refresh(ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (Entry entry in entries)
            {
                listBox.Items.Add(entry.Title + " - " + entry.Date);
            }

        }

        public void ShowEntry(ListBox listBox, RichTextBox richTextBox)
        {
            richTextBox.Text = entries[listBox.SelectedIndex].Text;
        }

        public void DeleteEntry(object sender)
        {
            ListBox listBox = (ListBox)sender;
            if(listBox.SelectedIndex != -1) entries.RemoveAt(listBox.SelectedIndex);

        }

        public void Drag(Form form, MouseEventArgs e)
        {
            form.Location = new Point(form.Location.X - lastLocation.X + e.X, +form.Location.Y - lastLocation.Y + e.Y);
            form.Update();
        }

        //public void ChangeTheme(Form form, RichTextBox richTextBox, ListBox listBox)
        //{
        //    if(lightTheme)
        //    {
        //        richTextBox.BackColor = Color.FromArgb(45, 45, 45);
        //        listBox.BackColor = Color.FromArgb(45, 45, 45);
        //        richTextBox.ForeColor = Color.FromArgb(240, 240, 240);
        //        listBox.ForeColor = Color.FromArgb(240, 240, 240);
        //        form.BackColor = Color.FromArgb(45, 45, 45);
        //        form.ForeColor = Color.FromArgb(240, 240, 240);
        //        lightTheme = !lightTheme;
        //    }
        //    else
        //    {
        //        richTextBox.BackColor = SystemColors.Control;
        //        listBox.BackColor = SystemColors.Control;
        //        richTextBox.ForeColor = SystemColors.ControlText;
        //        listBox.ForeColor = SystemColors.ControlText;
        //        form.BackColor = SystemColors.Control;
        //        form.ForeColor = SystemColors.ControlText;
        //        lightTheme = !lightTheme;
        //    }
        //}
    }
}
