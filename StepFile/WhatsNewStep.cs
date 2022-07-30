using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class WhatsNewStep
    {
        WhatsNew methodcall = new WhatsNew();
        [Given(@"Load the ApplicationURL")]
        public void GivenLoadTheApplicationURL()
        {
            methodcall.OpenURL();
        }

        [When(@"You Click on Whats new")]
        public void WhenYouClickOnWhatsNew()
        {
            methodcall.ClickOnWhatsNew();
        }

        [When(@"Click on Learn more")]
        public void WhenClickOnLearnMore()
        {
            methodcall.ClickonLearnmore();
        }

        [Then(@"Print all the links displayed")]
        public void ThenPrintAllTheLinksDisplayed()
        {
            methodcall.PrintAllLinks();
        }

    }
}
