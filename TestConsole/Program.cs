using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.WebDriver.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://abv.bg");

            var elem = driver.FindElement(By.TagName("body")).AsLinqWebElement();

            var test = elem.Children.First(w=> w.Id == "siteContent");

            var cc = test.Children.ToList();

            
        }
    }
}