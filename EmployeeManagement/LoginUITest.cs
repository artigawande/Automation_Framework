using EmployeeManagement.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest : AutomationWrapper
    {
       
        [Test]
        public void ValidateTitleTest()
        {

            string actualtitle = driver.Title;
            Assert.That(actualtitle, Is.EqualTo("OrangeHRM"));
        }

        public void ValidatePlaceholderTest()
        {


            string actualUsernamePlaceholder = driver.FindElement(By.XPath("//input[@placeholder='Username']")).GetAttribute("placeholder");
            string actualPasswordPlaceholder = driver.FindElement(By.XPath("//input[@type='password']")).GetAttribute("placeholder");

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));

        }
    }
}