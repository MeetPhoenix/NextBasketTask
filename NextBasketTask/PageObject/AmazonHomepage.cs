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
    }
}
