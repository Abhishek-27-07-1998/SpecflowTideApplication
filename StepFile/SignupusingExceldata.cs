using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class SignupusingExceldata
    {
        SignupusingExcelData methodCall =new  SignupusingExcelData();
        [Given(@"User load the Link")]
        public void GivenUserLoadTheLink()
        {
            methodCall.URLOpen();
        }

        [When(@"Clicks on Register")]
        public void WhenClicksOnRegister()
        {
            methodCall.ClickonRegister();
        }

        [When(@"user clicks upon Signup")]
        public void WhenUserClicksUponSignup()
        {
            methodCall.ClickonSignUp();
        }

        [When(@"Enter Firstname,Email,Password values from excel")]
        public void WhenEnterFirstnameEmailPasswordValuesFromExcel()
        {
            methodCall.ReadExcelData();
        }

        [When(@"Click on create account")]
        public void WhenClickOnCreateAccount()
        {
            methodCall.ClickOnCreate();
        }

        [Then(@"account is created successfully")]
        public void ThenAccountIsCreatedSuccessfully()
        {
            methodCall.AccountCreated();
        }

    }
}
