
namespace UnitTest1
{
    using ConsoleApp1; 
    public class UnitTest1
    {
        [Theory]
        [InlineData("qwerty",6)]
        [InlineData("hell",4)]
        [InlineData("OK",2)]
        public void Return_StringLenght(string word,int result)
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
    }
}