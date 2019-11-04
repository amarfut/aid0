using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PostPreviewDto
    {
        public PostPreviewDto(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
    }
}
