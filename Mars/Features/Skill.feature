Feature: Skill

As a user I would beable to create,edit and delete skill


Scenario Outline: Add a new Skill
	Given I loggedin into mars portal
	And I enter new Skill details '<skill>'and '<skilllevel>'
	Then I should be able to see new Skill record created
	Examples: 
	| skill   | skilllevel |
	| C#	  | Beginner|
	