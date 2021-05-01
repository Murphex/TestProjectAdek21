using System;
using TechTalk.SpecFlow;
using TestProjectAdek21.PageObject;

namespace TestProjectAdek21.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();

        }






        [Given(@"the user enter username ""(.*)""")]
        public void GivenTheUserEnterUsername(string Username)
        {
            dataDrivenWithExamplePage.EnterUsename(Username);
        }
        
        [Given(@"the user enter email address ""(.*)""")]
        public void GivenTheUserEnterEmailAddress(string Email)
        {
            dataDrivenWithExamplePage.EnterEmail(Email);
        }
        
        [Given(@"the user enter password ""(.*)""")]
        public void GivenTheUserEnterPassword(string Password)
        {
            dataDrivenWithExamplePage.EnterPassword(Password);
        }
    }
}
