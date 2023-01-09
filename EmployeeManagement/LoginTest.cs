using EmployeeManagement.Base;
using EmployeeManagement.Pages;
using EmployeeManagement.Utilities;
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
        [Test, Retry(2)]
        public void ValidLoginTest()
        {
            LoginPages loginpage = new LoginPages(driver);
            loginpage.EnterUserName("Admin");
            loginpage.EnterPassword("admin123");


            /*driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys("Admin");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("admin123");*/
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualUrl = driver.Url;

            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));


        }

        //using array 

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvaliLoginData2))]
      
        // [Test, TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData))]
        //[TestCase("john", "john345", "Invalid credentials")]
        //[TestCase("peter", "peter123", "Invalid credentials")]
        //[TestCase("saul", "saul123", "Invalid credentials")]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

          string actualerror=  driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            Console.WriteLine(actualerror.ToUpper());


            //Assert the error ,essage Invalid Credential
            Assert.That(actualerror, Is.EqualTo(expectedError),"Assertion on error message");

            Assert.That(true);
        }
    }
}
