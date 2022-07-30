using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    public class CuponAndRewards
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }

        public void ClickonCupons()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[text()='Coupons and Rewards']")).Click();
        }

        public void ClickonSave()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[text()='Save Now']")).Click();
        }

        public void LoginToAccount()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//button[text()='Log in']")).Click();
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("abhi@gmail.com");
            BaseClass.driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Abhi@1234");
            BaseClass.driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        public void SaveSuccessful()
        {
            Console.WriteLine("Cupon saved successfully on choosing a desired product");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\CuponAndRewards.png");
        }
    }
}
