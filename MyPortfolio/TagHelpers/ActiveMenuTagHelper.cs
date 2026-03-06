using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyPortfolio.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "asp-active-by")]
    public class ActiveMenuTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-active-by")]
        public string ActiveBy { get; set; }

        [HtmlAttributeName("asp-active-type")]
        public string ActiveType { get; set; } = "action";

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var currentAction = ViewContext.RouteData.Values["action"]?.ToString();

            var currentAnchor = ViewContext.HttpContext.Request.Query["anchor"].ToString();

            bool shouldBeActive = false;

            if (ActiveType == "action")
            {
                shouldBeActive = currentAction == ActiveBy;
            }
            else if (ActiveType == "anchor")
            {
                shouldBeActive = currentAction == "Index" && ActiveBy == currentAnchor;
            }

            if (shouldBeActive)
            {
                if (output.Attributes.ContainsName("class"))
                {
                    var existingClass = output.Attributes["class"].Value.ToString();
                    if (!existingClass.Contains("active"))
                    {
                        output.Attributes.SetAttribute("class", $"{existingClass} active");
                    }
                }
                else
                {
                    output.Attributes.SetAttribute("class", "active");
                }
            }
        }
    }
}
