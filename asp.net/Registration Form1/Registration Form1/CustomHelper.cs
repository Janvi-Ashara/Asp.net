using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration_Form1
{
    public class CustomHelper
    {
        public static IHtmlString MyTag(string val)
        {
            string ans = "img=";
            return new MvcHtmlString(ans);
        }
    }
}