using NUnit.Framework;

namespace MyMath
{
    public class Operations
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(98,1)]
        [TestCase(20,3)]
        [TestCase(13,37)]
        [TestCase(-58,8)]
        [TestCase(-69,60)]
        [TestCase(9,0)]

        public void Test1(int int1, int int2)
        {
            var res = MyMath.Operations.Add(int1, int2);
            Asset.AreEqual(9, res);
        }
    }
}