using Microsoft.VisualStudio.TestTools.UnitTesting;
using caMcsdPractice.ChapterOne;


namespace caMcsdPractice.ChapterOne.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod]
        public void SwitchAndStuffTest()
        {
            //Arrange
            chapterone ch1 = new chapterone();
            //Act
            byte returnVar=ch1.SwitchAndStuff(chapterone.mxolisi.excited);
            //Assert
            Assert.AreEqual((byte)chapterone.mxolisi.excited, returnVar);
        }

        [TestMethod]
        public void TestIsPalindrome_ShouldReturnTrue()
        {
            //Arrange
            Class1 mxolisi = new Class1();
            //Act
            var result=mxolisi.IsPalindromeSuperFunctional("kayak");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsPalindrome_ShouldReturnFalse()
        {
            //Arrange
            Class1 mxolisi = new Class1();
            //Act
            var result = mxolisi.IsPalindromeSuperFunctional("mxolisi");
            //Assert
            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void RunCode()
        {
            //Arrange
            BitwiseOperators mxolisi = new BitwiseOperators();
            //Act
            mxolisi.UnaryVariantOperator();
            //Assert
        }

        [TestMethod]
        public void RunTypesBookPaging()
        {
            CsharpTypes csharpTypes = new ChapterOne.CsharpTypes();
            
        }
    }
}