using System;

namespace best012.Models
{
    internal class displayFormatAttribute : Attribute
    {
        public string DataFormatString { get; set; }
        public string NullDisplayText { get; set; }
        public bool ApplyFormatInEditMode { get; set; }
    }
}