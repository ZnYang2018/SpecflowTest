using NUnit.Framework;
using SpecflowSample.UnderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowSample.StepDefinitions
{
    [Binding]
    public sealed class ArithmeticFeatureStepDefinition
    {
        private Calculator calculator = new Calculator();

        [Given(@"I have reset calculator")]
        public void GivenIHaveResetCalculator()
        {
            calculator.Reset();
        }

        [Given(@"I have entered (\d+) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            calculator.EnterNumber(number);
        }

        // 正则表达式中变化量为(add|substract)
        [When("I press (add|subtract|multiply|divide)")]
        public void WhenIPressAdd(string opt)
        {
            calculator.Operate(opt);
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, calculator.Result);
        }

        [Given(@"I have entered two numbers into the calculator")]
        public void GivenIHaveEnteredTwoNumbersIntoTheCalculator(Table table)
        {
            // 获取table单元格的值
            string cell00 = table.Rows[0][0];
            string cell01 = table.Rows[0][1];

            // 转为int
            int numberA = int.Parse(cell00);
            int numberB = int.Parse(cell01);

            // enter two numbers into calculator
            calculator.EnterNumber(numberA);
            calculator.EnterNumber(numberB);
        }

        [Then(@"it should show message")]
        public void ThenItShouldShowMessage(string multilineText)
        {
            Assert.AreEqual(multilineText, calculator.Message);
        }

    }
}
