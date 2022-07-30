using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    
    class SignUpWithInvaliddetails
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

        public void EnterinValidCredentials()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.Id("name")).SendKeys("1234");
            string Actual = BaseClass.driver.FindElement(By.XPath("//p[text()='First Name is invalid.']")).Text;
            string Expected = "First Name is invalid.";
            bool testing = true;
            if (Expected.Equals(Actual))
            {
                testing = true;
                Console.WriteLine("The text: First Name is invalid is displayed");
            }
            else
            {
                testing = false;
                Console.WriteLine("The text: Error message is not displayed");
            }

            BaseClass.driver.FindElement(By.Id("email")).SendKeys("bsabhi123@.com");
            string ActualEmail = BaseClass.driver.FindElement(By.XPath("//p[text()='Email Not Valid']")).Text;
            string ExpectedEmail = "Email Not Valid";
            bool testEmail = true;
            if (ExpectedEmail.Equals(ActualEmail))
            {
                testEmail = true;
                Console.WriteLine("The text: Email Not Valid is displayed");
            }
            else
            {
                testEmail = false;
                Console.WriteLine("The text: Error message is not displayed");
            }

            BaseClass.driver.FindElement(By.Id("password")).SendKeys("Bsabhi123");
            Thread.Sleep(4000);
            String ActualText = BaseClass.driver.FindElement(By.XPath("//p[contains(text(),'Must contain at least one of the following')]")).Text;
            string ExpectedText = "Must contain at least one of the following  ! @ $ % & ? *";
            bool testText = true;
            if (ExpectedText.Equals(ActualText))
            {
                testText = true;
                Console.WriteLine("The text: Must contain at least one of the following  ! @ $ % & ? * is displayed");
            }
            else
            {
                testText = false;
                Console.WriteLine("The text: Error message is not displayed");
            }
        }

        public void ClickOnCreate()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
        }

        public void AccountNotCreated()
        {
            Console.WriteLine("Account not created");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\SignUp.png");
            //BaseClass.CloseBrowser();
        }
    }
}
