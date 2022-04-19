using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleChapter14Demo;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            Student newStu = new Student();
            newStu.Gpa = 4.21;
            Assert.AreEqual(newStu.Gpa, 0);
        }
        [TestMethod]
        public void TestMethod2()

        {
            Student newStu = new Student();
            newStu.Gpa = -1.0;
            Assert.AreEqual(newStu.Gpa, 0);
        }
    }
}
