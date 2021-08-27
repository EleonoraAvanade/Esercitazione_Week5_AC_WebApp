using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.TagHelpers
{
    [HtmlTargetElement("e-mail")]
    public class EmailTagHelper : TagHelper
    {
        public string To { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("Contact us!");
            output.Attributes.SetAttribute("class", "btn btn-primaryMine");
            output.Attributes.SetAttribute("href", $"mailto:{To}@avanade.com");
        }
    }
}
