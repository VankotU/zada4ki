namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            int num1 = -20;
            int num2 = 6;
            Calculator elka11a = new Calculator();
            double result = elka11a.Sum(num1, num2);
            Assert.AreEqual(-50, result, "ne smqta");
        }

        [Test]
        public void Test1()
        {
            int num1 = 0;
            int num2 = 6;
            Calculator elka11a = new Calculator();
            double result = elka11a.Sum(num1, num2);
            Assert.AreEqual(6, result, "ne smqta");
            Assert.Pass();
        }

        
    }
}