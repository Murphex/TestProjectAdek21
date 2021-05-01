using System;
using TechTalk.SpecFlow;

namespace TestProjectAdek21.Features
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
