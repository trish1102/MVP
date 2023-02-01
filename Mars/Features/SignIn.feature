Feature: Signin into mars portal

As a mars portal user I want to be able to login into mars portal successfully

 Scenario: Login into mars portal
	Given I login into mars portal using valid credentials
	Then I should be able to validate that I logged in successfully
	