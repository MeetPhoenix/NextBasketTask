using NextBasketTask.Hooks;
using NextBasketTask.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NextBasketTask.StepDefinitions
{
    [Binding]
    public class AmazonProductpageStepDefinitions : BaseTest
    {

        // Initialize Page Object
        AmazonHomepage amazonHomepage = new AmazonHomepage();
        AmazonSearchpage amazonSearchpage = new AmazonSearchpage();
        AmazonProductpage amazonProductpage = new AmazonProductpage();

        [Given(@"that the user is on the product page")]
        public void GivenThatTheUserIsOnTheProductPage()
        {
            amazonSearchpage.navigateToamazonHomePage();
            amazonProductpage.navigateToamazonSearchpage();
            
        }

        [When(@"the user clicks on the add to list button")]
        public void WhenTheUserClicksOnTheAddToListButton()
        {
            amazonProductpage.ClickAddItem();
        }

        [Then(@"the item should be added to the user cart")]
        public void ThenTheItemShouldBeAddedToTheUserCart()
        {
            Assert.IsTrue(amazonProductpage.ProductPageIsDisplayed());
        }
    }
}
