using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.WebDriver.Linq
{
    public static class WebElementExtensions
    {
        public static LinqWebElement AsLinqWebElement(this IWebElement element)
        {
            if (element == null)
                return null;

            var elem = (WebElement)element;
            string id = elem.GetAttribute("id");
            return new LinqWebElement(element, elem.WrappedDriver as OpenQA.Selenium.WebDriver, id);
        }
    }
}
