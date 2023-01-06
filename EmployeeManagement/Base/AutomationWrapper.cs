using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EmployeeManagement.Base
{
    public class AutomationWrapper
    {
       protected IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {

            string browserName = "edge";
            if(browserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();

            }
            else if(browserName.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }

            else
            {
                driver = new ChromeDriver();
            }

            //browser launch
           // driver = new ChromeDriver();

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
