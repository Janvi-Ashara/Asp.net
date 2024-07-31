using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Registration_Form
{
    public class CustomHelper
    {
        public static IHtmlString MyTag(string val)
        {
            string ans = "<b>" + val + "<b/>";
            return new MvcHtmlString(ans);
        }
    }
}