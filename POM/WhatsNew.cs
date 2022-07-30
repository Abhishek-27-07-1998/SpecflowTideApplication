using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    public class WhatsNew
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }

        public void ClickOnWhatsNew()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[text()='What’s New']")).Click();
        }
        public void ClickonLearnmore()
        {
            BaseClass.driver.FindElement(By.XPath("(//a[text()='Learn More'])[2]")).Click();
        }

        public void PrintAllLinks()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> elements = BaseClass.driver.FindElements(By.XPath("//a"));
            int count = elements.Count;
            for (int i = 0; i < count; i++)
            {
                string text = elements[i].Text;
                Console.WriteLine(text);
            }
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\Whatsnew.png");
        
        }
    }
}
