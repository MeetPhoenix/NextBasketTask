Feature: AmazonSearch

As a user on the Amazon searchpage
i want to select my prefered product
so i can add the product to my cart

@tag1
Scenario: Verify rhat a user can search for an item
	Given I am on the search page for my desired product
	When I click on the product
	Then I should see the details of the product i want to add to my cart
