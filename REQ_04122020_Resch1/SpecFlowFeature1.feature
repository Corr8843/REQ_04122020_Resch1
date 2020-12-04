Feature: SpecFlowFeature1
    In order to avoid silly mistakes
    As a math idiot
    I want to add, subtract, multiply and divide

@mytag
Scenario: Add two numbers
    Given the first number is 70
    And the second number ist 50
    When the two numbers are added
    Then the result should be 120

Scenario: Subtract two numbers
    Given the first number is 70
    And the second number ist 50
    When the two numbers are subtracted
    Then the result should be 20

Scenario: Multiply two numbers
    Given the first number is 5
    And the second number ist 7
    When the two numbers are multiplied
    Then the result should be 35

Scenario: Divide two numbers
    Given the first number is 70
    And the second number ist 10
    When the first number is divided by the second number
    Then the result should be 7