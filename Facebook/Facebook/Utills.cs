using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Facebook
{
    internal class Utills
    {
        
        IWebDriver driver = new ChromeDriver();

        public static string getValueFromXML(string attribute)
        {
            string xmlFilePath = "C:\\Users\\Vivek.gupta\\source\\repos\\Facebook\\Facebook\\XMLFile1.xml";
            XDocument doc = XDocument.Load(xmlFilePath);
            var user = doc.Descendants("User").FirstOrDefault();
            return user.Element(attribute)?.Value; ;
        }
        public void launchURL(string url)
        {
            driver.Navigate().GoToUrl(url);

        }

        public void inputUserNameAndPassword(string userName, string password) {
            driver.FindElement(By.Id("email")).SendKeys(userName);
            Console.WriteLine("User entered user name");
            driver.FindElement(By.Id("pass")).SendKeys(password);
            Console.WriteLine("User entered password");
        }

        public void clickOnLoginButton()
        {
            driver.FindElement(By.Id("loginbutton")).Click();
            Console.WriteLine("User clicked on login button");
        }

        public void closeWindow()
        {
            driver.Close();
        }

       
    }
}
