using System;
using System.Collections.Generic;
using System.Text;
using ComprehensiveSpecflow.POM;
using TechTalk.SpecFlow;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class SignUpwithInvalidStepdefinition
    {
        SignUpWithInvaliddetails methodcall = new SignUpWithInvaliddetails();
        [Given(@"Open the URL")]
        public void GivenOpenTheURL()
        {
            methodcall.LoadURL();
        }

        [When(@"Click on RegisterLink")]
        public void GivenClickOnRegisterLink()
        {
            methodcall.ClickonRegister();
        }

        [When(@"You Click on SignUpFeature")]
        public void WhenYouClickOnSignUpFeature()
        {
            methodcall.ClickonSignUp();
        }

        [When(@"Enter invalid FirstName,Email,Password")]
        public void WhenEnterInvalidFirstNameEmailPassword()
        {
            methodcall.EnterinValidCredentials();
        }

        [When(@"Click on Create Account button")]
        public void ThenClickOnCreateAccountButton()
        {
            methodcall.ClickOnCreate();
        }
        [Then(@"Account is not created and error message is displayed and take Screenshot")]
        public void ThenAccountIsNotCreatedAndErrorMessageIsDisplayedAndTakeScreenshot()
        {
            methodcall.AccountNotCreated();
        }


    }
}
