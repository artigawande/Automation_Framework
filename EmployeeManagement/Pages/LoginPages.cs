using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class LoginPages
    {
        private IWebDriver driver;
        public LoginPages(IWebDriver driver) 
        { 
            this.driver = driver;
        }
        public void EnterUserName(string username)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);
        }

        public void EnterPassword( string password)
        {
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
        }
    }
}
