using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectAdek21.Utilities;

namespace TestProjectAdek21.PageObject
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement globalFeed => driver.FindElement(By.XPath("(//a[@class='nav-link'])[5]"));




        public void clickonSignupButton()
        {
            signUp.Click();
        }



        public void EnterUsername()
        {
            Random randonGenerator = new Random();
            int randomInt = randonGenerator.Next(1000);
            username.SendKeys("Murphy" + randomInt);
            //username.SendKeys("Murphex1");
        }


        
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmail()
        {
            Random randonGenerator = new Random();
            int randomInt = randonGenerator.Next(1000);
            email.SendKeys("murphex1" + randomInt + "yahoo.com");
            //email.SendKeys("murphex@yahoo.com");
        }



        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUp()
        {
            signUpButton.Click();
        }

        public bool IsGlobalFeedDisplayed()
        {
            return globalFeed.Displayed;
        }




    }


}
