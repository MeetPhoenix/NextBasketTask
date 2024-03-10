using NextBasketTask.Hooks;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace NextBasketTask.StepDefinitions
{
    [Binding]
    public class AmazonHomepageStepDefinitions : BaseTest
    {
        [Given(@"a user navigates to the website '([^']*)'")]
        public void GivenAUserNavigatesToTheWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
            
        }
    }
}
