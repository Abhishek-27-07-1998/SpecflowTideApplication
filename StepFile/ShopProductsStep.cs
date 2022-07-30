using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class ShopProductsStep
    {
        ShopProducts methodcall = new ShopProducts();
        [Given(@"I load the URL")]
        public void GivenILoadTheURL()
        {
            methodcall.OpenURL();
        }

        [When(@"I hover on the shop products")]
        public void WhenIHoverOnTheShopProducts()
        {
            methodcall.HoverOnSHopProducts();
        }

        [When(@"I Click on Liquids")]
        public void WhenIClickOnLiquids()
        {
            methodcall.ClickOnLiquids();
        }

        [When(@"Click on Buy now from available retailers")]
        public void WhenClickOnBuyNowFromAvailableRetailers()
        {
            methodcall.ClickOnBuy();
        }

        [Then(@"Check for product availability")]
        public void ThenCheckForProductAvailability()
        {
            methodcall.CheckAvailability();
        }

    }
}
