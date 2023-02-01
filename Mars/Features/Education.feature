Feature: Education

As a user of mars portal I would be able to add,edit and delete education information

Scenario Outline: Add a new Education details
	Given I loggedin into mars portal
	And I enter education details '<university>', '<country>','<title>','<degree>' and '<year>'
	Then I should be able to see new education record created
	Examples: 
	| university         | country | title  | degree   | year |
	| Gujarat University | India   | B.Tech | Computer | 2012 |
	