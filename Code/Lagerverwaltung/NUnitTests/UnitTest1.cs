using Lagerverwaltung;

namespace NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void getArticleCountReturnsSomething()
        {
            Tools tools = tools.Instance;
            Assert.That(tools.GetArticleCount(1), Is.Not.Null);
        }
    }
}