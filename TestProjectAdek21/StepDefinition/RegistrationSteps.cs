using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectAdek21.PageObject;

namespace TestProjectAdek21.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();

        }






        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I click on sign up button")]
        public void GivenIClickOnSignUpButton()
        {
            Thread.Sleep(5000);
            registrationPage.clickonSignupButton();
        }
        
        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter email")]
       
        public void GivenIEnterEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on sign up")]
        public void WhenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsGlobalFeedDisplayed);
        }
    }
}
