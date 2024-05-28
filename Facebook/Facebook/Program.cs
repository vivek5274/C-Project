using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Facebook
{
    internal class Program : Utills
        
    {
  
        static void Main(string[] args)
        {
            Program facebookLogin= new Program();
            facebookLogin.launchURL(getValueFromXML("Url"));
            facebookLogin.inputUserNameAndPassword(getValueFromXML("Username"), getValueFromXML("Password"));
            facebookLogin.clickOnLoginButton();
            facebookLogin.closeWindow();
            
        }

       
    }
}
