using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder.Tags.Structural_Tags
{
    public class Body : DoubleTagWithChildren
    {
        public Body() : base("body")
        {
        }

        public Body SetOnLoad(string script)
        {
            AddAttribute("onload", script);
            return this;
        }

        public Body SetOnUnload(string script)
        {
            AddAttribute("onunload" , script); 
            return this;
        }
    }
}
