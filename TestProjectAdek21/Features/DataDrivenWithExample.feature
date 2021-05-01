Feature: DataDrivenWithExample
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sign up button
	And the user enter username "<Username>"
	And the user enter email address "<Email>"
	And the user enter password "<Password>"
	When I click on sign up
	Then I should be able to sign up successfully

	Examples: 
	| Username | Email            | Password       |
	| Miji7890     | miji9870@gmail.com   | PasswordSecure |
	| Kelly2450    | kelly3120@roland.com | PaswordSecure  |
	| Richard2310  | richie3440@demo.com  | PasswordSecure |