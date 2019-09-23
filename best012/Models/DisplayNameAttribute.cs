using System;

namespace best012.Models
{
    internal class DisplayNameAttribute : Attribute
    {
        private string v;

        public DisplayNameAttribute(string v)
        {
            this.v = v;
        }
    }
}