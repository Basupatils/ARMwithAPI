using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        
        [SetUp]
#pragma warning disable S1186 // Methods should not be empty
        public void Setup()
#pragma warning restore S1186 // Methods should not be empty
        {
        }

        [Test]
        public void Test1()
        {
//abcde

            Assert.Pass();
        }

        [Test]
        public void Test2()
        {

            //abcde
            Assert.Pass();
        }
    }
}
