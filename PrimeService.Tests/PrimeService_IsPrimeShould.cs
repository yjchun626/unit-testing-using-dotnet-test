using System;
using Prime.Services;
using Xunit;


namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        // [Fact]
        // // [Fact] - Test Runner에서 실행하는 테스트 메서드 선언
        // public void IsPrime_InputIs1_ReturnFalse()
        // {
        //     var primeService = new PrimeService();
        //     bool result = primeService.IsPrime(1);

        //     Assert.False(result, "1 should not be prime");
        // }

        #region SampleTest
        [Theory]   // [Theory] - 데이터를 사용하여 여러 테스트를 실행하는 테스트 메서드 선언
        [InlineData(-1)]   // [InlineData] - 데이터를 제공하는 테스트 메서드의 매개 변수 선언
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}