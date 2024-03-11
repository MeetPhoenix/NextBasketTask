using NextBasketTask.Hooks;
using NextBasketTask.PageObject;
using System;
using TechTalk.SpecFlow;

namespace NextBasketTask.StepDefinitions
{
    [Binding]
    public class AmazonHomepageStepDefinitions: BaseTest
    {
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

        [When(@"the user input the item ""([^""]*)""")]
        public void WhenTheUserInputTheItem(string p0)
        {
            
        }

        [When(@"the user clicks on the search button")]
        public void WhenTheUserClicksOnTheSearchButton()
        {
            
        }

        [Then(@"the user should be able to view a list of similar products")]
        public void ThenTheUserShouldBeAbleToViewAListOfSimilarProducts()
        {
            
        }
    }
}
