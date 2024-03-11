using NextBasketTask.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBasketTask.PageObject
{
    class AmazonHomepage : BaseTest
    {

        private By SearchBar = By.CssSelector("#twotabsearchtextbox");

        public void ClickSearchBar() 
        { 
            driver.FindElement(SearchBar).Click();
        }

        private By InputProductName = By.CssSelector("#twotabsearchtextbox");
        private string itemName;

        public void EnterInputProductName() 
        {
            driver.FindElement(InputProductName).SendKeys(itemName);
        }

        private By Search = By.CssSelector("#nav-search-submit-button");

        public void ClickSearch() 
        {
            driver.FindElement(Search).Click();
        }


        public bool ProductPageIsDisplayed() 
        {
            return driver.Url.Contains("https://www.amazon.com/s?k=tp-link+n450+wifi+router+-+wireless+internet+router+for+home+%28tl-wr940n%29&crid=38DO54O42D7FL&sprefix=%2Caps%2C1200&ref=nb_sb_ss_recent_1_0_recent");
        }

        internal void navigateToAmazonHomepage()
        {
            throw new NotImplementedException();
        }
    }
}
