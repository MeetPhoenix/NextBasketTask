using NextBasketTask.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBasketTask.PageObject
{
    class AmazonProductpage : BaseTest
    {
        private By AddItem = By.CssSelector("a[title='Add to List']");

        public void ClickAddItem()
        {
            driver.FindElement(AddItem).Click();
        }

        public bool ProductPageIsDisplayed()
        {
            return driver.Url.Contains("https://www.amazon.com/ap/signin?openid.return_to=https%3A%2F%2Fwww.amazon.com%2Fgp%2Faw%2Fd%2FB003Y5RYNY&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=usflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&");
        }

        internal void navigateToamazonSearchpage()
        {
            throw new NotImplementedException();
        }
    }
}
