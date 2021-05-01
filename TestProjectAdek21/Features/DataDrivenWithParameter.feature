Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sign up button
	And I enter username "Adekunle12345"
	And I enter email address "murphex134@yahoo.com"
	And I enter password "PasswordSecure"
	When I click on sign up
	Then I should be able to sign up successfully