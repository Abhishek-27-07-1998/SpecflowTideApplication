using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ComprehensiveSpecflow.POM
{
    public class ShopProducts
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }

        public void HoverOnSHopProducts()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Thread.Sleep(2000);
            IWebElement path = BaseClass.driver.FindElement(By.XPath("//a[text()='Shop Products']"));
            Actions action = new Actions(BaseClass.driver);
            action.MoveToElement(path).Perform();
        }

        public void ClickOnLiquids()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("(//span[text()='Liquid'])[1]")).Click();
        }
        public void ClickOnBuy()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("(//div[@aria-label='Find where to buy this product'])[1]")).Click();
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='ps-online-buy-button unavailable ps-online-seller-button']")).Click();
        }

        public void CheckAvailability()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs =BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(10000);
            string content = BaseClass.driver.FindElement(By.XPath("(//p)[1]")).Text;
            Console.WriteLine("Print the prodict is not availavble and reason for unavailability");
            Console.WriteLine(content);
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\Shopproducts.png");
        }
    }
}
