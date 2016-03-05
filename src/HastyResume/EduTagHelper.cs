using Microsoft.AspNet.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastyResume
{
    public class EduTagHelper : TagHelper
    {
        static int n = 1;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent(String.Format("Edu{0}",n));
            n++;
        }
    }
}
