using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_04122020
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double v1;
        double v2;
        double res;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            v1 = p0;
        }

        [Given(@"the second number ist (.*)")]
        public void GivenTheSecondNumberIst(int p0)
        {
            v2 = p0;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            res = v1 + v2;
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            res = v1 - v2;
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            res = v1 * v2;
        }

        [When(@"the first number is divided by the second number")]
        public void WhenTheFirstNumberIsDividedByTheSecondNumber()
        {
            res = v1 / v2;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, res, 5);
        }

    }
}