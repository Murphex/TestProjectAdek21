Feature: Registration
	In order to use the website and get all benefits
	I will need to first register

@mytag
Scenario: Valid Registration
	Given I navigate to website
	And I click on sign up button
	And I enter username
	And I enter email address
	And I enter password
	When I click on sign up
	Then I should be able to sign up successfully