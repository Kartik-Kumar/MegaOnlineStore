using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MegaOnlineStore.Web.HtmlHelpers
{
    public static class MVCHtmlHelper
    {
        public static MvcHtmlString Submit(this HtmlHelper htmlHelper, string display, string name )
        {
            string submitButton = $"<input type='submit' name='{name}' class='btn - danger' value='{display}' />";
            //alternative way to create tag
            /*TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("name", name);
            tb.Attributes.Add("type", "submit");
            tb.Attributes.Add("value", display);*/
            return new MvcHtmlString(submitButton);
        }

        public static MvcHtmlString ActionLinks(this HtmlHelper htmlHelper, List<string> model)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in model)
            {
                sb.Append($"<a href ='/Products/List?name={item}'>{item}</a> | ");
            }
            return new MvcHtmlString(sb.ToString());
        }
        public static MvcHtmlString DisplaySort(this HtmlHelper htmlHelper, string dis, int len)
        {
            
            if (dis.Length > len)
            {
                string s = dis.Substring(0, len) + "...";
                return new MvcHtmlString(s);
            }
                
            else return new MvcHtmlString(dis);
        }
    }
}