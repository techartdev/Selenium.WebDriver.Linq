# Selenium.WebDriver.Linq

![Nuget](https://img.shields.io/nuget/v/VHDTools)

The LinqWebElement class extends the WebElement class and provides additional functionalities for interacting with web elements using LINQ expressions. It encapsulates an IWebElement object and enhances it with convenient methods and properties.


- webElement: The underlying IWebElement object to encapsulate.
- parentDriver: The parent driver associated with the web element.
- id: The unique identifier of the web element.

## Properties

#### Id
Gets or sets the ID attribute of the web element.

#### Class
Gets or sets the class attribute of the web element.

#### Style
Gets or sets the inline style attribute of the web element.

#### Parent
Gets the parent web element of the current web element as a LinqWebElement object.

#### Children
Gets the child web elements of the current web element as an enumerable collection of LinqWebElement objects.

#### Siblings
Gets the sibling web elements of the current web element as an enumerable collection of LinqWebElement objects.

#### Attributes
The Attributes property provides a dictionary of attributes and their values for the web element. The dictionary contains the attribute names as keys and their corresponding values as values.

## Methods

#### Delete()
Deletes the current web element.

#### SetAttribute(string attribute, string value)
Sets the value of the specified attribute for the web element.
- attribute: The name of the attribute.
- value: The value to set for the attribute.

#### HasAttribute(string attribute)
Checks if the web element has the specified attribute.

- attribute: The name of the attribute to check.

#### SetText(string text)
Sets the text content of the web element.

- text: The text to set.

#### AppendHtml(string html)

Appends the specified HTML content to the web element.

- html: The HTML content to append.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.

## Contact
Visit https://scrapeweb.site

Or join the **Web Scraping and Automation** community on Discord: https://discord.gg/f3EfBQamnT

## Disclaimer
The extensions provided by this library are subject to the reliability of the Selenium WebDriver and the browser being automated. Please ensure the elements are available and interactable before using these extension methods to avoid any unexpected exceptions or behavior.

---

If you find this app helpful and would like to support the development of more tools and projects, consider buying me a coffee. Your support is greatly appreciated!

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/techartdev)

Thank you for your support!

