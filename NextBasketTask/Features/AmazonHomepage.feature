Feature: AmazonHomepage

As a user on Amazon
I want to go to the homepage
So that i can search for rhe required Item

@tag1
Scenario: Verify that a user can view the Amazon Homepage
	Given an unregistered user navigates to the website 'https://www.amazon.com/'
	When the user clicks on the search bar
	And the user input the item 'TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)'
	And the user clicks on the search button
	Then the user should be able to view a list of similar products
