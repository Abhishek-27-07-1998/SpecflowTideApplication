using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ComprehensiveSpecflow.Hooks;
using OpenQA.Selenium;

namespace ComprehensiveSpecflow.POM
{
    public class LocationDropDown
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
        }

        public void ClickOnDropdown()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//button[text()='US - English']")).Click();
        }

        public void SelectCanadaFrench()
        {
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[text()='Canada - French']")).Click();
            
        }

        public void VerifyText()
        {
            string frenchhtext = BaseClass.driver.FindElement(By.XPath("//a[text()='Magasiner les produits']")).Text;
            string expected = "Magasiner les produits";

            if (frenchhtext == expected)
            {
                Console.WriteLine("The location got changed to Canada-French and the text for verification is:" + frenchhtext);
            }
            else
            {
                Console.WriteLine("The location didnot change");
            }
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\Location.png");
        }
    }
}
