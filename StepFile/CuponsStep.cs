using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class CuponsStep
    {
        CuponAndRewards methodcall = new CuponAndRewards();
        [Given(@"You load the URL")]
        public void GivenYouLoadTheURL()
        {
            methodcall.OpenURL();
        }

        [When(@"I Click on Cupons and Rewards")]
        public void WhenIClickOnCuponsAndRewards()
        {
            methodcall.ClickonCupons();
        }

        [When(@"Click on save now")]
        public void WhenClickOnSaveNow()
        {
            methodcall.ClickonSave();
        }

        [When(@"Login to your account")]
        public void WhenLoginToYourAccount()
        {
            methodcall.LoginToAccount();
        }

        [Then(@"save cupon successfully")]
        public void ThenSaveCuponSuccessfully()
        {
            methodcall.SaveSuccessful();
        }

    }
}
