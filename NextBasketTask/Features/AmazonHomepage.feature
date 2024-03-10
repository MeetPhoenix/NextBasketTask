Feature: AmazonHomepage

As a user on Amazon
I want to go to the homepage
So that i can search for rhe required Item

@tag1
Scenario: Verify that a user can view the Amazon Homepage
	Given a user navigates to the website 'https://www.amazon.com/'
	When a user clicks on the search bar
	And input the item "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
	And 
	Then 
