using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class LocationDropdownStep
    {
        LocationDropDown methodcall = new LocationDropDown();
        [Given(@"Load the URL given")]
        public void GivenLoadTheURLGiven()
        {
            methodcall.OpenURL();
        }

        [When(@"You select location dropdown")]
        public void WhenYouSelectLocationDropdown()
        {
            methodcall.ClickOnDropdown();
        }

        [When(@"Select Canada-French")]
        public void WhenSelectCanada_French()
        {
            methodcall.SelectCanadaFrench();
        }

        [Then(@"verify if the page is displayed in French")]
        public void ThenVerifyIfThePageIsDisplayedInFrench()
        {
            methodcall.VerifyText();
        }

    }
}
