using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    public class LoginwithInvalidCredentials
    {
        public void OpenLink()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }

        public void ClickOnRegister()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[text()='Register']")).Click();
        }

        public void ClickOnSignUp()
        {
            int location = BaseClass.driver.FindElement(By.XPath("(//picture/img[@loading='lazy'])[2]")).Location.Y;
            IJavaScriptExecutor j = (IJavaScriptExecutor)BaseClass.driver;
            j.ExecuteScript("window.scrollTo(0," + location + ")");
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='sticker_close']")).Click();
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();
        }

        public void ClickOnLogin()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            BaseClass.driver.FindElement(By.XPath("//button[text()='Log in']")).Click();

        }
        public void EnterInValidCredentials()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys("abhishek@gmail.com");
            BaseClass.driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys("Abhi@123");
        }
        public void ClickOnLoginButton()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Console.WriteLine("Enter valid password");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\Login2.png");
        }
    }
}
