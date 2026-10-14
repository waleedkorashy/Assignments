
using Assignment_7;
namespace Assignment_7_UnitTest
{
    //Q12.In a separate xUnit test project, create a test class FineCalculatorTests. Create the FineCalculator instance in the
    //constructor(stored in a readonly field), follow the AAA pattern(Arrange – Act – Assert), and write:

    public class FineCalculatorTests
    {
        private readonly FineCalculator _fineCalculator;
        public FineCalculatorTests() 
        {
            _fineCalculator = new FineCalculator();
        }


            
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //AAA
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            int result = _fineCalculator.Add(a, b);

            //Assert
            Assert.Equal(3, result);
        }


        [Fact]
        public void Add_ShouldReturnNotEqual()
        {
            //AAA
            //Arrange
            int a = 8;
            int b = 15;

            //Act
            int result = _fineCalculator.Add(a, b);

            //Assert
            Assert.NotEqual(3, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //AAA
            //Arrange
            int a = 15;
            int b = 3;

            //Act
            int result = _fineCalculator.Subtract(a, b);

            //Assert
            Assert.Equal(12, result);
        }


        [Theory]
        [InlineData(5, 6, 30)]
        [InlineData(10, 2, 20)]
        [InlineData(7, 2, 14)]
        public void Multiply_ShouldReturnCorrectResultl(int a, int b, int actual)
        {

            //Act
            int result = _fineCalculator.Multiply(a, b);

            //Assert
            Assert.Equal(actual, result);
        }


        [Theory]
        [InlineData(5, 6, 70)]
        [InlineData(10, 2, 87)]
        [InlineData(7, 2, 19)]
        public void Multiply_ShouldReturnNotEqual(int a, int b, int actual)
        {

            //Act
            int result = _fineCalculator.Add(a, b);

            //Assert
            Assert.NotEqual(actual, result);
        }
        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            int a = 5;
            int b = 0;

            Assert.Throws<DivideByZeroException>(() =>
            {
                return _fineCalculator.Divide(a, b);
            });
        }
    }
}
