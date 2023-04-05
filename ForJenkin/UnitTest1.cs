using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ForJenkin
{
    public class UnitTest1
    {

        public UnitTest1()
        {

        }
        [Fact]
        public void Test1()
        {

            // Set chrome options to run in headless mode
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");



            // Set the path of the new ChromeDriver executable
            string chromeDriverPath = "C:\\Users\\hp\\Downloads\\Programs\\chromedriver_win32\\chromedriver.exe";



            // Create an instance of the ChromeDriver class with the new path
           // ChromeDriverService service = ChromeDriverService.CreateDefaultService(chromeDriverPath);
            IWebDriver driver = new ChromeDriver(chromeOptions);

            // Create a new instance of the Chrome driver
            // IWebDriver driver = new ChromeDriver();



            // Navigate to the website
            driver.Navigate().GoToUrl("https://courses.rahulshettyacademy.com/");

            // Wait for the page to load
            Thread.Sleep(5000);

            // Find the first button and click on it
            //IWebElement button1 = driver.FindElement(By.XPath("//a[normalize-space()='Courses']"));
            //button1.Click();

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
    }
}