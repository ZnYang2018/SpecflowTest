Feature: ArithmeticFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I have reset calculator

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Subtract two numbers
	Given I have entered 100 into the calculator
	And I have entered 40 into the calculator
	When I press subtract
	Then the result should be 60 on the screen

Scenario: Multiply two numbers
	Given I have entered 3 into the calculator
	And I have entered 4 into the calculator
	When I press multiply
	Then the result should be 12 on the screen

Scenario: Divide two numbers
	Given I have entered 10 into the calculator
	And I have entered 5 into the calculator
	When I press divide
	Then the result should be 2 on the screen

Scenario: Divide two numbers with zero divisor
	Given I have entered two numbers into the calculator
		| numberA | numberB |
		| 3       | 0       |
	When I press divide
	Then it should show message
		"""
		Error:
		Zero can not be used as divisor!
		"""
@mytag
Scenario Outline: Two numbers arithmetic
	Given I have entered <numberA> into the calculator
	And I have entered <numberB> into the calculator
	When I press <operator>
	Then the result should be <result> on the screen
Examples: 
	| numberA | numberB | operator | result |
	| 50      | 70      | add      | 120    |
	| 100     | 2       | add      | 102    |
	| 100     | 40      | subtract | 60     |
	| 5       | 2       | subtract | 3      |
	| 3       | 4       | multiply | 12     |
	| 9       | 9       | multiply | 81     |
	| 10      | 5       | divide   | 2      |
	| 9       | 3       | divide   | 3      |