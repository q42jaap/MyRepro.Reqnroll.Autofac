using System;
using Reqnroll;

namespace MyRepro.Reqnroll.Autofac.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions(IMyImpl myImpl)
{
    [Given("the first number is {int}")]
    public void GivenTheFirstNumberIs(int number)
    {
        Console.WriteLine(myImpl);
    }

    [Given("the second number is {int}")]
    public void GivenTheSecondNumberIs(int number)
    {
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
    }
}
