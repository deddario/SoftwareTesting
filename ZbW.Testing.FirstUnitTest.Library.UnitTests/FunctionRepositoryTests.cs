namespace ZbW.Testing.FirstUnitTest.Library.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class FunctionRepositoryTests
    {
        [Test]
        public void TestGreaterThan10()
        {
            var functionRepository = new FunctionRepository();

            Assert.IsTrue(functionRepository.GreaterThan10(11));
        }
    }
}