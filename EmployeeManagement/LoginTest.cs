using EmployeeManagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys("Admin");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualUrl = driver.Url;

            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test]

        public void InvalidLoginTest()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys("username123");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("user@123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

          string actualerror=  driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            Console.WriteLine(actualerror.ToUpper());


            //Assert the error ,essage Invalid Credential
            Assert.That(actualerror, Is.EqualTo("Invalid credential"),"Assertion on error message");

            Assert.That(true);
        }
    }
}
