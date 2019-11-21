using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainGames;
using System.Collections.Generic;

namespace BrainGames.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReverseArray()
        {
            //Arrange
            WeekOne weekOne = new WeekOne();
            var testArray = new int[] { 1, 2, 3, 4, 5 };
            //Act
            var result = weekOne.reverseArraySuperFunctional(testArray);
            //Assert
            Assert.IsTrue(result[0] == testArray[testArray.Length - 1]);

                /*
            
            print(DecToHex(25));
            int j = 25;
            var hasSeven = j.ToString().LastIndexOf("7") > -1 ? true : false;

            //2, 3, 5, 7, 11, 13, 17, 19, 23,29
            print(isPrimeNumer(j));



            ArrayShift();
            gradingStudents(new List<int> { 38 });

            var test = 38 % 5;
            print(test);

            reverseArray(new int[] { 1, 4, 3, 2 });
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] res = reverseArray(arr);

            textWriter.WriteLine(string.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();*/
        }

        [TestMethod]
        public void TestGradingStudents_ShouldRoundOffTo40()
        {
            //Arrange
            WeekOne weekOne = new WeekOne();
            //Act
            var result = weekOne.gradingStudents(new List<int> { 38 });
            //Assert
            Assert.AreEqual(40, result[0]);
        }
    }
}
