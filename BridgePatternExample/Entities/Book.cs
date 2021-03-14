using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternExample.Entities
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string PreviewExcerpt { get; set; }
        public string BackDescription { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
    }
}
