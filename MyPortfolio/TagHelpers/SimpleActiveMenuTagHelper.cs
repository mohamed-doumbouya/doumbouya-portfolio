using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyPortfolio.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "asp-controller")]
    public class SimpleActiveMenuTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context.AllAttributes.TryGetAttribute("asp-controller", out var controllerAttribute))
            {
                var targetController = controllerAttribute.Value.ToString();
                var currentController = ViewContext.RouteData.Values["controller"]?.ToString();

                if (currentController == targetController)
                {
                    var existingClass = output.Attributes.ContainsName("class")
                        ? output.Attributes["class"].Value.ToString()
                        : "";

                    if (!existingClass.Contains("active"))
                    {
                        var newClass = string.IsNullOrEmpty(existingClass)
                            ? "active"
                            : $"{existingClass} active";

                        output.Attributes.SetAttribute("class", newClass);
                    }
                }
            }
        }
    }
}
