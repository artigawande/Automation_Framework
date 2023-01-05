using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public class EmployeeTest:AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.AddValidEmployeeTest1))]
        public void AddValidEmployeeTest(string username, string password, string FirstName, string MiddleName, string LastName, string ActualResult)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();

            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(FirstName);
            driver.FindElement(By.XPath("//input[@placeholder='Middle Name']")).SendKeys(MiddleName);
            driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(LastName);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string Employee = driver.FindElement(By.CssSelector("[class='oxd-text oxd-text--h6 --strong']")).Text;
            Console.WriteLine(Employee.ToCharArray());

            Assert.That(ActualResult.Contains(Employee), "Employee details");

            Console.WriteLine(ActualResult);

          //  Assert.That(true);
        }

        
    }
}
