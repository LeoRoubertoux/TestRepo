using Microsoft.VisualStudio.TestTools.UnitTesting;
using windows_media_player;
namespace ClassLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            test TestClass = new test();
            Assert.AreEqual(TestClass.addCount(), 1);
        }
    }
}
