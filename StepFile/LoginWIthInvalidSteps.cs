using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class LoginWIthInvalidSteps
    {
        LoginwithInvalidCredentials methodcall = new LoginwithInvalidCredentials();
        [Given(@"User load the URL")]
        public void GivenUserLoadTheURL()
        {
            methodcall.OpenLink();
        }

        [When(@"Click on the Register")]
        public void GivenClickOnTheRegister()
        {
            methodcall.ClickOnRegister();
        }

        [When(@"user click on Signup")]
        public void WhenIClickOnSignup()
        {
            methodcall.ClickOnSignUp();
        }

        [When(@"Click upon login")]
        public void WhenClickUponLogin()
        {
            methodcall.ClickOnLogin();
        }

        [When(@"Enter invalid login credentials")]
        public void ThenEnterInvalidLoginCredentials()
        {
            methodcall.EnterInValidCredentials();
        }

        [Then(@"User is unable to login")]
        public void ThenUserIsUnableToLogin()
        {
            methodcall.ClickOnLoginButton();
        }

    }
}
