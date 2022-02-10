using NUnit.Framework;
using DemoGitActions;
using System;

namespace DemoGitActionsTest
{
    public class Tests
    {
        [Test]
        public void TestAddTwoNumbersCorrect()
        {
            int res = Program.AddTwoNumbers(91, 10);
            Assert.AreEqual(101, res);
        }


        [Test]
        public void TestAddTwoNumbersWrong()
        {
            int res = Program.AddTwoNumbers(91, 10);
            Assert.AreNotEqual(111, res);
        }


        [Test]
        public void TestAddTwoNumbersException()
        {
            //Assert
            //Added
            Assert.Throws<NullReferenceException>(AddTwoNumbeDelegate);
        }

        public void AddTwoNumbeDelegate()
        {
            //Added 
            Program.AddTwoNumbers(int.MaxValue, 1);
        }



        [Test]
        public void TestSubtarctTwoNumbersCorrect()
        {
         
            int res = Program.SubtractTwoNumbers(91, 10);
            Assert.AreEqual(81, res);
        }


        [Test]
        public void TestSubtarctTwoNumbersWrong()
        {
            int res = Program.SubtractTwoNumbers(91, 10);
            Assert.AreNotEqual(111, res);
        }


        [Test]
        public void TestSubtarctTwoNumbersException()
        {
            Assert.Throws<OverflowException>(SubtractTwoNumberDelegate);
        }

        public void SubtractTwoNumberDelegate()
        {
            Program.SubtractTwoNumbers(int.MinValue, 1);
        }
    }
}