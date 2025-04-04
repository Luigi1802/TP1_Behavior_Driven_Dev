Feature: Calculator
	
Scenario: Subtract two numbers
	Given the operands are 70, 50
	When the subtraction is applied
	Then the result should be 20
	
Scenario: Multiply two numbers
	Given the operands are 2, 9
	When the multiplication is applied
	Then the result should be 18
	
Scenario: Multiply two numbers (one is negative)
	Given the operands are 4, -2
	When the multiplication is applied
	Then the result should be -8
	
Scenario: Divide two numbers
	Given the operands are 42, 2
	When the division is applied
	Then the result should be 21

Scenario: Divide a number by zero
	Given the operands are 64, 0
	When the division is applied
	Then an exception is thrown

Scenario: Add 3 numbers together
	Given the operands are 18, 2, 7
	When the addition is applied
	Then the result should be 27