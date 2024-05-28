using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.DOM;

namespace Facebook
{
    internal class Utills
    {
        
        IWebDriver driver = new ChromeDriver();

        public static string getValueFromXML(string attribute)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string xmlFilePath = Path.Combine(baseDirectory, @"..\..\..\..\Facebook\XMLFile1.xml");
            XDocument doc = XDocument.Load(xmlFilePath);
            var user = doc.Descendants("User").FirstOrDefault();
            return user.Element(attribute)?.Value; ;
        }
        public void launchURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("URL launched");

        }

        public void inputUserNameAndPassword(string userName, string password) {
            driver.FindElement(By.Id("username")).SendKeys(userName);
            Console.WriteLine("User entered user name");
            driver.FindElement(By.Id("password")).SendKeys(password);
            Console.WriteLine("User entered password");
        }

        public void clickOnSubmitButton()
        {
            driver.FindElement(By.Id("submit")).Click();
            Console.WriteLine("User clicked on Submit button");
        }

        public bool verifyLogOutButtonIsVisible()
        {
            Boolean status;
            status = driver.FindElement(By.CssSelector("[href*=\"practice-\"]")).Displayed;
            return status;
        }
        public String verifyTextOnPage()
        {
          return  driver.FindElement(By.CssSelector("[class=\"post-title\"]")).Text;
        }
        public String getCurrentPageUrl()
        {
            return driver.Url;
        }

        public void closeWindow()
        {
            driver.Close();
        }

       
    }
}
