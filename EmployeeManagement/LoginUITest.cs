using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest
    {
        IWebDriver driver;

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
        [Test]
        public void ValidateTitleTest()
        {

            string actualtitle = driver.Title;
            Assert.That(actualtitle, Is.EqualTo("OrangeHRM"));
        }

        public void ValidatePlaceholderTest()
        {


            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));

        }
    }
}