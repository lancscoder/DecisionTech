Feature: PriceCalculation
	In order to calculate prices
	As the checkout
	I want to be told the sum of the basket

Scenario: No offers
	Given the basket has 1 bread
	And the basket has 1 butter
	And the basket has 1 milk
	When I total the basket
	Then the total should be £2.95
	
Scenario: Bread offer
	Given the basket has 2 butter
	And the basket has 2 bread
	When I total the basket
	Then the total should be £3.10
	
Scenario: Milk offer
	Given the basket has 4 milk
	When I total the basket
	Then the total should be £3.45
	
Scenario: Combined offers
	Given the basket has 2 butter
	And the basket has 1 bread
	And the basket has 8 milk
	When I total the basket
	Then the total should be £9.00
