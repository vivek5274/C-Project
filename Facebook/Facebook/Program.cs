using System.Xml.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.WebAuthn;

namespace Facebook
{
    internal class Program : Utills
        
    {
            
        static void Main(string[] args)
        {
            Program facebookLogin= new();
            facebookLogin.launchURL(getValueFromXML("Url"));
            facebookLogin.inputUserNameAndPassword(getValueFromXML("Username"), getValueFromXML("Password"));
            facebookLogin.clickOnSubmitButton();
            Assert.That(facebookLogin.getCurrentPageUrl().Contains("practicetestautomation.com/logged-in-successfully/"));
            Assert.That(facebookLogin.verifyTextOnPage().Equals("Logged In Successfully"));
            Assert.That(facebookLogin.verifyLogOutButtonIsVisible());
            facebookLogin.closeWindow();
        }
    
    }
}
