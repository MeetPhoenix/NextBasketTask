using NextBasketTask.Hooks;
using NextBasketTask.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NextBasketTask.StepDefinitions
{
    [Binding]
    public class AmazonSearchStepDefinitions : BaseTest
    {

        // Initialize Page Object
        AmazonHomepage amazonHomepage = new AmazonHomepage();
        AmazonSearchpage amazonSearchpage = new AmazonSearchpage(); 

        [Given(@"I am on the search page for my desired product")]
        public void GivenIAmOnTheSearchPageForMyDesiredProduct()
        {
            amazonSearchpage.navigateToamazonHomepage();
        }

        [When(@"I click on the product")]
        public void WhenIClickOnTheProduct()
        {
            amazonSearchpage.ClickProduct();
        }

        [Then(@"I should see the details of the product i want to add to my cart")]
        public void ThenIShouldSeeTheDetailsOfTheProductIWantToAddToMyCart()
        {
            Assert.IsTrue(amazonSearchpage.SearchPageIsDisplayed());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
