using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SemestriProject.Pages.Extensions {
    public static class TableRowForHtmlExtension {
        public static IHtmlContent TableRowFor(
            this IHtmlHelper htmlHelper, string page, object index,
            params IHtmlContent[] values) {
            var htmlStrings = new List<object>();
            foreach (var value in values) AddValue(htmlStrings, value);
            htmlStrings.Add(new HtmlString("<td>"));
            
            htmlStrings.Add(new HtmlString("</td>"));
            return new HtmlContentBuilder(htmlStrings);
        }

        public static IHtmlContent TableRowFor(
            this IHtmlHelper htmlHelper, string page, object index,
            string fixedFilter, string fixedValue,
            params IHtmlContent[] values)
        {
            var htmlStrings = new List<object>();
            foreach (var value in values) AddValue(htmlStrings, value);
            htmlStrings.Add(new HtmlString("<td>"));
           
            htmlStrings.Add(new HtmlString("</td>"));
            return new HtmlContentBuilder(htmlStrings);
        }

        internal static void AddValue(List<object> htmlStrings, IHtmlContent value) {
            if (htmlStrings is null) return;
            if (value is null) return;
            htmlStrings.Add(new HtmlString("<td>"));
            htmlStrings.Add(value);
            htmlStrings.Add(new HtmlString("</td>"));
        }
    }
}
