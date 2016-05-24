Feature: PriceCalculation
	In order to calculate prices
	As the checkout
	I want to be told the sum of the basket

Scenario: No discounts
	Given the basket has 1 bread
	And the basket has 1 butter
	And the basket has 1 milk
	When I total the basket
	Then the total should be £2.95
	
Scenario: Bread discount
	Given the basket has 2 butter
	And the basket has 2 bread
	When I total the basket
	Then the total should be £3.10
	
Scenario: Milk discount
	Given the basket has 4 milk
	When I total the basket
	Then the total should be £3.45
	
Scenario: Combined discount
	Given the basket has 2 butter
	And the basket has 1 bread
	And the basket has 8 milk
	When I total the basket
	Then the total should be £9.00
