using System;
using TechTalk.SpecFlow;
using TestProjectAdek21.PageObject;

namespace TestProjectAdek21.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();

        }







        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter username ""(.*)""")]
        public void GivenIEnterUsername(string Username)
        {
            dataDrivenWithParameterPage.EnterUsername(Username);
        }
        
        [Given(@"I enter email address ""(.*)""")]
        public void GivenIEnterEmailAddress(string Email)
        {
            dataDrivenWithParameterPage.EnterEmail(Email);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string Password)
        {
            dataDrivenWithParameterPage.EnterPassword(Password);
        }
    }
}
