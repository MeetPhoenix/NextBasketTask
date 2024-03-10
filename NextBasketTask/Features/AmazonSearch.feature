Feature: AmazonSearch

A short summary of the feature

@tag1
Scenario: Search for an item and add it to cart
	Given I am on the Amazon home page as an unregistered user
	When I search for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
	And I add the corresponding item to the cart
	Then I should see the correct item and amount in the cart
