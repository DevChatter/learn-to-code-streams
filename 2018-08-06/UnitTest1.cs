using System;
using System.Collections.Generic;
using Xunit;

namespace _2018_08_06
{
    public class UnitTest1
    {
        [Fact]
        public void FirstNumber_ShouldBe_One()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("1", numbers[0]);
        }

        [Fact]
        public void SecondNumber_ShouldBe_Two()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("2", numbers[1]);
        }

        [Fact]
        public void EigthNumber_ShouldBe_Eight()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("8", numbers[7]);
        }

        [Fact]
        public void ThirdNumber_ShouldBe_Fizz()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("Fizz", numbers[2]);
        }

        [Fact]
        public void SixthNumber_ShouldBe_Fizz()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("Fizz", numbers[5]);
        }

        [Fact]
        public void FifthNumber_ShouldBe_Buzz()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("Buzz", numbers[4]);
        }

        [Fact]
        public void TenthNumber_ShouldBe_Buzz()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("Buzz", numbers[9]);
        }

        [Fact]
        public void FifteenthNumber_ShouldBe_FizzBuzz()
        {
            List<string> numbers = FizzBuzzer.FizzBuzz();
            Assert.Equal("FizzBuzz", numbers[14]);
        }
    }

    public static class FizzBuzzer
    {
        public static List<string> FizzBuzz()
        {
            List<string> numbers = new List<string>();
            
            for (int i = 1; i < 100; i++)
            {
                if (i % (3 * 5) == 0)
                {
                    numbers.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    numbers.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    numbers.Add("Buzz");
                }
                else
                {
                    numbers.Add(i.ToString());
                }
            }
            
            return numbers;
        }
    }
}
