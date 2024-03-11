Feature: AmazonProductpage

As a user on the product page
the user should be able to add the product to cart

@tag1
Scenario: Verify that user is able to add product to cart
	Given that the user is on the product page
	When the user clicks on the add to list button
	Then the item should be added to the user cart
