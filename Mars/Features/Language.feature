Feature: Language

As a user I would be able to create,edit and delete language

Scenario Outline: Add a new language
	Given I loggedin into mars portal
	And I enter language details '<language>'and '<languagelevel>'
	Then I should be able to see new language record created
	Examples: 
	| language | languagelevel |
	| English      | Basic|
	