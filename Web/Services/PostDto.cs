using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PostDto
    {
        public PostDto(string title, string url, string text)
        {
            Title = title;
            Url = url;
            Text = text;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }
}
