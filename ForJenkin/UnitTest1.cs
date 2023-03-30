using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ForJenkin
{
    public class UnitTest1
    {

       public UnitTest1()       {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the website
            driver.Navigate().GoToUrl("https://courses.rahulshettyacademy.com/");

            // Wait for the page to load
            Thread.Sleep(5000);

            // Find the first button and click on it
            IWebElement button1 = driver.FindElement(By.XPath("//a[normalize-space()='Courses']"));
            button1.Click();

            // Wait for the page to load
            Thread.Sleep(5000);

            // Find the second button and click on it
           IWebElement button2 = driver.FindElement(By.XPath("//div[@title='All-Access Membership']"));
            button2.Click();

            // Wait for the page to load
            Thread.Sleep(5000);

            // Close the browser
            driver.Quit();
        }
        [Fact]
        public void Test1()
        {


        }
    }
}