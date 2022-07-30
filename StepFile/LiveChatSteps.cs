using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.POM;

namespace ComprehensiveSpecflow.StepFile
{
    [Binding]
    public class LiveChatSteps
    {
        LiveChat methodcall = new LiveChat();
        [Given(@"Load the Website")]
        public void GivenLoadTheWebsite()
        {
            methodcall.OpenURL();
        }

        [When(@"You click on Livechat")]
        public void WhenYouClickOnLivechat()
        {
            methodcall.ClickOnLiveChat();
        }

        [Then(@"Chat option is available in UTC timings")]
        public void ThenChatOptionIsAvailableInUTCTimings()
        {
            methodcall.AvailabilityVerification();
        }

    }
}
