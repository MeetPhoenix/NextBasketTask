using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace NextBasketTask.Hooks
{
    [Binding]
    public sealed class BaseTest
    {
        public static IWebDriver driver;
        
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            

           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}