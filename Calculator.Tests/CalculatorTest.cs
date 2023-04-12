using Xunit;
using FluentAssertions;
using System.Security.Cryptography;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1,2,3)]
        public void AddTwoIntNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult =calculator.Add(a1,a2);

            //assert
            actualResult.Should().Be(result);

        }

        [Theory]
        [InlineData(1.3,2.3,3.6)]
        [InlineData(2.5,2.6,6.1)]
        public void AddTwoFloatNumberSuccess(float a1, float a2, float result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Add(a1, a2);

            //assert
            actualResult.Should().Be(result);

        }

        [Theory]
        [InlineData(3,2,1)]
        public void SubTwoIntNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Sub(a1, a2);

            //assert
            actualResult.Should().Be(result);
        }
    }
}