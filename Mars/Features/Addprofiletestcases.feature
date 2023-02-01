Feature: Addprofiletestcases

A short summary of the feature

 Scenario: Login into mars portal
	Given I login into mars portal using valid credentials
	Then I should be able to validate that I logged in successfully
	Scenario Outline: Add a new discription
	Given I loggedin into mars portal
	And I add description
	Then I should be able to see description record created
	Scenario Outline: Add a new language
	Given I loggedin into mars portal
	And I enter language details 
	Then I should be able to see new language record created
	Scenario Outline: Add a new Skill
	Given I loggedin into mars portal
	And I enter new Skill details 
	Then I should be able to see new Skill record created
	Scenario Outline: Add a new Education details
	Given I loggedin into mars portal
	And I enter education details 
	Then I should be able to see new education record created
	Scenario Outline: Add a new Certifications
	Given I loggedin into mars portal
	And I enter certificate details 
	Then I should be able to see new certificate record created
	Scenario Outline: Add an Availability
	Given I loggedin into mars portal
	And I select Availability type
	Then I should be able to see Availability record created
Scenario Outline: Add an Hours
	Given I loggedin into mars portal
	And I select Hours type 
	Then I should be able to see hours record created
	Scenario Outline: Add an Earn Target
	Given I loggedin into mars portal
	And I select Earn Target type 
	Then I should be able to see Earn Target record created

	
