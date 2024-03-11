using NextBasketTask.Hooks;
using NextBasketTask.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NextBasketTask.StepDefinitions
{
    [Binding]
    public class AmazonHomepageStepDefinitions: BaseTest
    {
        // Initialize Page Object
        AmazonHomepage amazonHomepage = new AmazonHomepage();
 
        [Given(@"an unregistered user navigates to the website '([^']*)'")]
        public void GivenAnUnregisteredUserNavigatesToTheWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"the user clicks on the search bar")]
        public void WhenTheUserClicksOnTheSearchBar()
        {
            amazonHomepage.ClickSearchBar();
        }

        [When(@"the user input the item '([^']*)'")]
        public void WhenTheUserInputTheItem(string ItemName)
        {
            amazonHomepage.EnterInputProductName();
        }


        [When(@"the user clicks on the search button")]
        public void WhenTheUserClicksOnTheSearchButton()
        {
            amazonHomepage.ClickSearch();
        }

        [Then(@"the user should be able to view a list of similar products")]
        public void ThenTheUserShouldBeAbleToViewAListOfSimilarProducts()
        {
            Assert.IsTrue(amazonHomepage.ProductPageIsDisplayed());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
