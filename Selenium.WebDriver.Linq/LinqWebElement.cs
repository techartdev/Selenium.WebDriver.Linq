using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using Selenium.WebDriver.SimpleExtensions;
using System.Linq;
using System.Xml.Linq;

namespace Selenium.WebDriver.Linq
{
    public class LinqWebElement : WebElement
    {
        private readonly IWebElement _webElement;

        public LinqWebElement(IWebElement webElement,OpenQA.Selenium.WebDriver parentDriver, string id) : base(parentDriver, id)
        {
            _webElement = webElement;
        }

        public string Id
        {
            get { return _webElement.GetAttribute("id"); }
            set
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)base.WrappedDriver;
                js.ExecuteScript($"arguments[0].setAttribute('id', '{value}')", _webElement);
            }
        }

        public string Class
        {
            get { return _webElement.GetAttribute("class"); }
            set
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)base.WrappedDriver;
                js.ExecuteScript($"arguments[0].setAttribute('class', '{value}')", _webElement);
            }
        }

        public string Style
        {
            get { return _webElement.GetAttribute("style"); }
            set
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)base.WrappedDriver;
                js.ExecuteScript($"arguments[0].setAttribute('style', '{value}')", _webElement);
            }
        }

        public LinqWebElement Parent => _webElement.GetParent().AsLinqWebElement();

        public IEnumerable<LinqWebElement> Children => _webElement.GetChildren().Select(s => s.AsLinqWebElement());

        public IEnumerable<LinqWebElement> Siblings => _webElement.GetSiblings().Select(s => s.AsLinqWebElement());

        public void Delete()
        {
            _webElement.Delete();
        }

        public void SetAttribute(string attribute, string value)
        {
            _webElement.SetAttribute(attribute, value);
        }

        public bool HasAttribute(string attribute)
        {
            if (string.IsNullOrEmpty(attribute))
                return false;

            return Attributes.Any(a=>a.Key == attribute.ToLower());
        }

        public void SetText(string text)
        {
            _webElement.SetText(text);
        }

        public void AppendHtml(string html)
        {
            _webElement.AppendHtml(html);
        }

        public Dictionary<string,string> Attributes
        {
            get
            {
                var html = _webElement.GetAttribute("outerHTML");
                return HtmlElementHelper.GetAttributes(html);
            }
        }
    }
}
