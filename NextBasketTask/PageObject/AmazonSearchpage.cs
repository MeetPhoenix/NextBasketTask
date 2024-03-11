using NextBasketTask.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBasketTask.PageObject
{
    class AmazonSearchpage: BaseTest
    {

        private By Product = By.CssSelector("img[alt='TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)']");

        public void ClickProduct()
        {
            driver.FindElement(Product).Click();
        }

        public bool ProductPageIsDisplayed()
        {
            return driver.Url.Contains("https://www.amazon.com/TP-Link-N450-Wi-Fi-Router-TL-WR940N/dp/B003Y5RYNY/ref=sr_1_1?crid=11KZYRLU15QF6&dib=eyJ2IjoiMSJ9.0rxeV92ZRf5pk11vYCLSr8Fmk7-_BxJFLtZDrnIKOBJwuJeoJgZmLTV5BDBy3BSGSCKTnOo8h9TYXSPhOG8spoBsrwNREXcX6_o0pLO8qunrIzt6tkfDfKoP-PjGXTmUrucoEpKT43g-1f9yuQXUVcLaq1pfzk6DPMm5ygVvQcLOKZyC040vBsM2gxS3idV6kjyTMoUvvdc177wkyx2_AEw-eoPIs7rW4zUDN8hT5Lw.QhfQ_7iWIKR0AfmAAAKJm-3Z84WRjM4eszB09d78IOs&dib_tag=se&keywords=tp-link+n450+wifi+router+-+wireless+internet+router+for+home+%28tl-wr940n%29&qid=1710128371&sprefix=%2Caps%2C879&sr=8-1");

        }

        internal void navigateToamazonHomepage()
        {
            throw new NotImplementedException();
        }

        internal void navigateToamazonHomePage()
        {
            throw new NotImplementedException();
        }

        internal void navigateToamazonProductPage()
        {
            throw new NotImplementedException();
        }

        internal bool? SearchPageIsDisplayed()
        {
            throw new NotImplementedException();
        }
    }
}
