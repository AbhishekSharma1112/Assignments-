
namespace UnitTest1
{
    using ConsoleApp1;
    using ClassLibraryProject;
    public class UnitTest1
    {
        [Theory]
        [InlineData("qwerty", 6)]
        [InlineData("hell", 4)]
        [InlineData("OK", 2)]
        public void Return_StringLenght(string word, int result)
        {
            LenghtHelper obj = new LenghtHelper();
            int length = obj.findlenght(word);
            Assert.Equal(result, length);
        }
        [Fact]
        public void Return_NullException()
        {
            LenghtHelper obj = new LenghtHelper();
            var exception = Assert.Throws<Exception>(() => obj.findlenght(null));
            Assert.Equal("Please enter value", exception.Message);

        }
        //Unit Test for Assignment 3
        [Fact]
        public void Increment_IncreaseCounterValue()
        {
            var counter = Counter.GetInstance();
            counter.Increment();
            Assert.Equal(1, counter.getCounter);
        }
        [Fact]
        public void Decrement_DecreaseCounterValue()
        {
            var counter = Counter.GetInstance();
            counter.Decrement();
            Assert.Equal(0, counter.getCounter);
        }
        [Fact]
        public void Returns_SameInstance()
        {
            var obj1 = Counter.GetInstance();
            var obj2 = Counter.GetInstance();

            Assert.Same(obj1,obj2);
        }

        //Unit test for Assigment 4 
        [Fact]
        public void Returns_FormattedString()
        {
            string input = "333.5";
            string output = input.ToCurrency();
            Assert.Equal("$ 333.50", output);
        }

        [Fact]
        public void Returns_FormatException()
        {
            string input = "abc";
            Assert.Throws<FormatException>(() => input.ToCurrency());
        }

    }
}