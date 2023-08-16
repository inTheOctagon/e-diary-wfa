using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary_wfa
{
    public class Entry
    {
        public string Title { get; set; }
        
        public string Text { get; set; }

        public string Date { get; set; }

        public Entry(string title, string text, string date)
        {
            Title = title;
            Text = text;
            Date = date;
        }
    }
}
