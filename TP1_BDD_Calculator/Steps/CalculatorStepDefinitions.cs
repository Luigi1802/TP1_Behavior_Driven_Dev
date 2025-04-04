﻿using CalculatorProject;
 using FluentAssertions;

 namespace TP1_BDD_Calculator.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private Calculator _calculator;
    // private int _firstNumber;
    // private int _secondNumber;
    private int _result;
    private Exception _exception;

   [Given("the first number is (.*)")]
   public void GivenTheFirstNumberIs(int number)
   {
       //_firstNumber = number;
   }

   [Given("the second number is (.*)")]
   public void GivenTheSecondNumberIs(int number)
   {
       //_secondNumber = number;
    }
   
   [When(@"the addition is applied")]
   public void WhenTheAdditionIsApplied()
   {
       _result = _calculator.Add();
   }

   [When("the subtraction is applied")]
   public void WhenTheSubtractionIsApplied()
   {
       // Calculator calculator = new Calculator();
       // _result = calculator.Subtract(_firstNumber, _secondNumber);
       _result = _calculator.Subtract();
   }
   
   [When(@"the multiplication is applied")]
   public void WhenTheMultiplicationIsApplied()
   {
       //Calculator calculator = new Calculator();
       //_result = calculator.Multiply(_firstNumber, _secondNumber);
       _result = _calculator.Multiply();
   }
   
   [When(@"the division is applied")]
   public void WhenTheDivisionIsApplied()
   {
       //Calculator calculator = new Calculator();
       try
       {
           //_result = calculator.Divide(_firstNumber, _secondNumber);
           _result = _calculator.Divide();
       }
       catch (Exception e)
       {
           _exception = e;
       }
       
   }

   [Then("the result should be (.*)")]
   public void ThenTheResultShouldBe(int result)
   {
       _result.Should().Be(result);
   }

   [Then(@"an exception is thrown")]
   public void ThenAnExceptionIsThrown()
   {
       _exception.Should().NotBeNull("No exception was thrown.");
       _exception.Should().BeOfType<DivideByZeroException>("The exception was thrown but isn't DivideByZeroException.");
   }

   [Given(@"the operands are (.*)")]
   public void GivenTheOperandsAre(String list)
   {
       _calculator = new Calculator();
       _calculator.Operands = list.Split(',').Select(int.Parse).ToList();
   }
}
