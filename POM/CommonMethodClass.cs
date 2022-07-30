using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    public class CommonMethodClass
    {
        public void LoadURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }

        public void ClickonRegister()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[text()='Register']")).Click();
        }

        public void ClickonSignUp()
        {
            int location = BaseClass.driver.FindElement(By.XPath("(//picture/img[@loading='lazy'])[2]")).Location.Y;
            IJavaScriptExecutor j = (IJavaScriptExecutor)BaseClass.driver;
            j.ExecuteScript("window.scrollTo(0," + location + ")");
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close']")).Click();
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();   
        }

        public void EnterValidCredentials()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(2000);
            BaseClass. driver.FindElement(By.Id("name")).SendKeys("Abhishek");
            BaseClass.driver.FindElement(By.Id("email")).SendKeys("bsabhi123@gmail.com");
            BaseClass.driver.FindElement(By.Id("password")).SendKeys("Bsabhi@123");
        }

        public void ClickOnCreate()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
        }

        public void AccountCreated()
        {
            Console.WriteLine("Account Created Successfuly");
           ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\SignUp1.png");
            //BaseClass.CloseBrowser();
        }
        
    }
}
