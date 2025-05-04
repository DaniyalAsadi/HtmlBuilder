using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder.Tags.Structural_Tags
{
    public class Html : DoubleTagWithChildren
    {
        public Html() : base("html")
        {
        }

        public Html SetLang(string lang)
        {
            AddAttribute("lang" , lang);
            return this;
        }

        public Html SetMainfest(string mainfestUrl)
        {
            AddAttribute("mainfest", mainfestUrl);
            return this;
        }
    }
}
