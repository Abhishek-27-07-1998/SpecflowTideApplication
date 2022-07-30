using System;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class SignUpSteps
    {
        CommonMethodClass methodcall = new CommonMethodClass();

        [Given(@"Load the URL")]
        public void GivenLoadTheURL()
        {
            methodcall.LoadURL();
        }
        
        [When(@"Click on Register")]
        public void GivenClickOnRegister()
        {
            methodcall.ClickonRegister();
        }
        
        [When(@"You Click on SignUp")]
        public void WhenYouClickOnSignUp()
        {
            methodcall.ClickonSignUp();
        }
        
        [When(@"Enter FirstName,Email,Password")]
        public void WhenEnterFirstNameEmailPassword()
        {
            methodcall.EnterValidCredentials();
        }
        
        [When(@"Click on Create Account")]
        public void ThenClickOnCreateAccount()
        {
            methodcall.ClickOnCreate();
        }

        [Then(@"Account created and take Screenshot")]
        public void ThenAccountCreatedAndTakeScreenshot()
        {
            methodcall.AccountCreated();
        }
    }
}
