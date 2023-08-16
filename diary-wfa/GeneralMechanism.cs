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

        public static void CreateEntry(string title, string text, string date)
        {
            Entry entry = new Entry(title, text, date);
            entries.Add(entry);
        }

        public static string Serialize(List<Entry> entry)
        {
            string jsonString = JsonSerializer.Serialize(entry);
            return jsonString;
        }

        public static void Write(string path, string jsonString)
        {
            File.WriteAllText(path, jsonString);
        }

        public static List<Entry> Read(string path)
        {
            return JsonSerializer.Deserialize<List<Entry>>(File.ReadAllText(path));
        }

        public static void Refresh(ListBox listBox, TextBox textBox, RichTextBox richTextBox)
        {
            listBox.Items.Clear();

            foreach (Entry entry in entries)
            {
                listBox.Items.Add(entry.Title+" - "+entry.Date);
            }

            textBox.Clear();
            richTextBox.Clear();
            
        }
    }
}
