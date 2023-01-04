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


        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credentials";

            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credentials";

            string[] dataSet3 = new string[3];
            dataSet3[0] = "saul";
            dataSet3[1] = "saul123";
            dataSet3[2] = "Invalid credentials";

            object[] allDataSet = new object[3];
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;



            return allDataSet;
        }

        [Test, TestCaseSource(nameof(InvalidLoginData))]
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
