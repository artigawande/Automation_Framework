using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Base
{
    public class AutomationWrapper
    {
       protected IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {
            //browser launch
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [TearDown]

        public void AfterMethod()
        {
            //browser close
           driver.Quit();

        }
    }
}
