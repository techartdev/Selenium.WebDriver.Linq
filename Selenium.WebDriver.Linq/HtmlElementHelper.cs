using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using HtmlAgilityPack;

namespace Selenium.WebDriver.Linq
{
    internal static class HtmlElementHelper
    {
        internal static Dictionary<string, string> GetAttributes(string htmlElement)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(htmlElement))
                return attributes;

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlElement);

            foreach (var attribute in doc.DocumentNode.FirstChild.Attributes)
            {
                attributes.Add(attribute.Name, attribute.Value);
            }

            return attributes;
        }
    }
}
