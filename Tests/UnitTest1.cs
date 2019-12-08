using Group15.EventManager.Data.Context;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            SqlContext context = new SqlContext(null, null);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}