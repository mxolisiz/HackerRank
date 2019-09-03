using Microsoft.VisualStudio.TestTools.UnitTesting;
using caMcsdPractice.ChapterOne;


namespace caMcsdPractice.ChapterOne.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void SwitchAndStuffTest()
        {
            //Arrange
            chapterone ch1 = new chapterone();
            //Act
            byte returnVar=ch1.SwitchAndStuff(chapterone.mxolisi.excited);
            //Assert
            Assert.AreEqual((byte)chapterone.mxolisi.excited, returnVar);
        }
    }
}