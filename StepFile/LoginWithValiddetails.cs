using ComprehensiveSpecflow.POM;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class LoginWithValiddetails
    {
        LoginWIthValiddetails methodcall = new LoginWIthValiddetails();
        [Given(@"Open the Link")]
        public void GivenOpenTheLink()
        {
            methodcall.OpenLink();
        }

        [When(@"Click upon Register")]
        public void GivenClickUponRegister()
        {
            methodcall.ClickOnRegister();
        }

        [When(@"you Click on SignUpFeature")]
        public void WhenYouClickOnSignUpFeature()
        {
            methodcall.ClickOnSignUp();
        }

        [When(@"Click on login")]
        public void WhenClickOnLogin()
        {
            methodcall.ClickOnLogin();
        }

        [When(@"Enter the valid login credentials")]
        public void ThenEnterTheValidLoginCredentials()
        {
            methodcall.EnterValidCredentials();
        }

        [Then(@"logged in successfully")]
        public void ThenLoggedInSuccessfully()
        {
            methodcall.ClickOnLoginButton();
        }

    }
}
