using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace WebApplication3
{
    public static class CustomHelper
    {
        public static IHtmlString Mytag(string txt)
        {
            // string ans = "<b>" + txt + "<b>";
            string ans = "<img src='" + txt + "' alt = 'no data' >";
            return new MvcHtmlString(ans);
        }
        public static IHtmlString my(this HtmlHelper helper,string txt)
        {
            string ans = "<img src='" + txt + "' alt = 'no data' >";
            return new MvcHtmlString(ans);
        }
        public static IHtmlString Myt(this HtmlHelper helper,string txt)
        {

            TagBuilder t = new TagBuilder("img");
            t.Attributes.Add("src", txt);
            t.Attributes.Add("alt", "no data");
            return new MvcHtmlString(t.ToString());
        }
        public static MvcHtmlString Country1(this HtmlHelper htmlHelper, string[] items)
        {
            var sb = new StringBuilder("<ul class=list-group>");
                foreach(var item in items)
            {
                sb.AppendFormat("<li class=list-group-item>{0}</li>", item);
            }
            return new MvcHtmlString(sb.ToString());
        }
    }
}