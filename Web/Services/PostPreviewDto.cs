using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PostPreviewDto
    {
        public PostPreviewDto(string title, string url, int v, int c, int l, int d)
        {
            Title = title;
            Url = url;
            ViewsCount = v;
            CommentsCount = c;
            LikesCount = l;
            DislikesCount = d;
        }

        public string Title { get; set; }
        public string Url { get; set; }

        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}
