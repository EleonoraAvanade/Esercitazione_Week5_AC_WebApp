using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.TagHelpers
{
    [HtmlTargetElement("e-mail", TagStructure = TagStructure.WithoutEndTag)]
    public class EmailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("Contattaci via e-mail!");
            output.Attributes.SetAttribute("class", "btn btn-primaryMine");
            output.Attributes.SetAttribute("href", $"mailto:{MailTo}@avanade.com");
        }
    }
}
