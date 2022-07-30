using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    public class LiveChat
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }
        public void ClickOnLiveChat()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[text()='Live Chat']")).Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\Livechat.png");
        }

        public void AvailabilityVerification()
        {
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine("LiveChat is available between 10Am and 6Pm UTC only");
            
        }

    }
}
