using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Tests
{
    [TestClass()]
    public class MyListTests
    {
        [TestMethod]
        public void IntAddTest()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Expected integer at the specified index
            int expected = 1;

            //Populate the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            //Compare values of the expected value and specified index
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void IntAddTestCount()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Expected count of numbers in list
            int expected = 4;

            //Populate the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            //Compare the values of the expected count and total count of list
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void IntAddTestValues()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Populate the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //Compare the values of expected values to the respective indices
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(3, list[2]);
            Assert.AreEqual(4, list[3]);
            Assert.AreEqual(5, list[4]);
            Assert.AreEqual(5, list.Count);
        }

        [TestMethod]
        public void StringAddTest()
        {
            //Generate a list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");

            //Expected value
            string expected = "Six";

            //Actual value
            string actual = list[5];

            //Compare the two
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringAddTestValues()
        {
            //Generate a new list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            //Compare the individual values of the list
            Assert.AreEqual("One", list[0]);
            Assert.AreEqual("Two", list[1]);
            Assert.AreEqual("Three", list[2]);

            //Compare the count
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void StringAddTestCount()
        {
            //Generate a new list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");

            //Expected count of the list of strings
            int expectedCount = 5;

            //Compare the values
            Assert.AreEqual(expectedCount, list.Count);
        }

        [TestMethod]
        public void StringRemoveValueTest()
        {
            //Generate a list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");

            //Remove the first string from the list
            list.Remove("One");

            //Compare the expected word to the first index
            Assert.AreEqual("Two", list[0]);

            //Compare the count
            Assert.AreEqual(5, list.Count);
        }

        [TestMethod]
        public void StringRemoveValueCompareTest()
        {
            //Generate a list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");

            //Remove values from the list
            list.Remove("Three");
            list.Remove("Five");

            //Compare the values
            Assert.AreEqual("One", list[0]);
            Assert.AreEqual("Two", list[1]);
            Assert.AreEqual("Four", list[2]);
            Assert.AreEqual("Six", list[3]);

            //Compare the count
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void IntRemoveTest()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Populate the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            //Remove from list test
            Console.WriteLine("Remove test");
            int actual = list[0];
            list.Remove(4);

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(3, list[2]);
            Assert.AreEqual(5, list[3]);
            Assert.AreEqual(6, list[4]);
            Assert.AreEqual(7, list[5]);
        }

        [TestMethod]
        public void IntRemoveTestCompareValues()
        {
            MyList<int> list = new MyList<int>();

            //Populate the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            list.Remove(1);

            Assert.AreEqual(6, list[4]);
            Assert.AreEqual(5, list[3]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(3, list[1]);
            Assert.AreEqual(2, list[0]);
        }

        [TestMethod]
        public void PlusOperator()
        {
            MyList<int> myList1 = new MyList<int> { 1, 2, 3, 4 };
            MyList<int> myList2 = new MyList<int> { 5, 6, 7, 8 };
            MyList<int> addList;

            int expectedCount = 8;

            addList = myList1 + myList2;

            Assert.AreEqual(5, addList[4]);
            Assert.AreEqual(6, addList[5]);
            Assert.AreEqual(7, addList[6]);
            Assert.AreEqual(8, addList[7]);
            Assert.AreEqual(addList.Count, expectedCount);
        }

        [TestMethod]
        public void PlusOperator2()
        {
            MyList<int> myList1 = new MyList<int> { 1, 2, 3 };
            MyList<int> myList2 = new MyList<int> { 4, 5, 6 };
            MyList<int> addList;

            int expectedCount = 6;

            addList = myList1 + myList2;

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(myList1[i], addList[i]);
                Assert.AreEqual(myList2[i], addList[i + 3]);
                Assert.AreEqual(addList.Count, expectedCount);
            }
        }

        [TestMethod]
        public void PlusOperator3()
        {
            MyList<int> list1 = new MyList<int> { 1, 2 };
            MyList<int> list2 = new MyList<int> { 3, 4, 5 };
            MyList<int> addList;

            addList = list1 + list2;

            Assert.AreEqual(1, addList[0]);
            Assert.AreEqual(2, addList[1]);
            Assert.AreEqual(3, addList[2]);
            Assert.AreEqual(4, addList[3]);
            Assert.AreEqual(5, addList[4]);
            Assert.AreEqual(5, addList.Count);
        }

        [TestMethod]
        public void PlusOperator4()
        {
            MyList<int> list1 = new MyList<int> { 1, 2, 3 };
            MyList<int> list2 = new MyList<int> { 3, 4, 5 };
            MyList<int> addList;

            addList = list1 + list2;

            Assert.AreEqual(1, addList[0]);
            Assert.AreEqual(2, addList[1]);
            Assert.AreEqual(3, addList[2]);
            Assert.AreEqual(3, addList[3]);
            Assert.AreEqual(4, addList[4]);
            Assert.AreEqual(5, addList[5]);
            Assert.AreEqual(6, addList.Count);
        }

        [TestMethod]
        public void IntegerSubtractCountTest()
        {
            int expectedCount = 4;
            MyList<int> myList1 = new MyList<int> { 1, 2, 3, 4, 5 };
            MyList<int> myList2 = new MyList<int> { 1 };
            MyList<int> myList3 = myList1 - myList2;

            Assert.AreEqual(expectedCount, myList3.Count);
        }

        [TestMethod]
        public void IntegerSubtractValueTest()
        {
            MyList<int> myList1 = new MyList<int> { 1, 2, 3 };
            MyList<int> myList2 = new MyList<int> { 2 };
            MyList<int> myList3 = myList1 - myList2;

            Assert.AreEqual(1, myList3[0]);
            Assert.AreEqual(3, myList3[1]);
        }

        [TestMethod]
        public void IntegerSubtractMultipleValueTest()
        {
            MyList<int> myList1 = new MyList<int> { 1, 2, 3, 4 };
            MyList<int> myList2 = new MyList<int> { 3, 4 };
            MyList<int> subtractList;

            int expectedCount = 2;

            subtractList = myList1 - myList2;

            Assert.AreEqual(1, subtractList[0]);
            Assert.AreEqual(2, subtractList[1]);
            Assert.AreEqual(expectedCount, subtractList.Count);
        }

        [TestMethod]
        public void IntegerSubtractAllValueTest()
        {
            MyList<int> myList1 = new MyList<int> { 1, 1, 1, 2, 2, 2 };
            MyList<int> myList2 = new MyList<int> { 1, 2 };
            MyList<int> subtractList;

            int expectedCount = 0;

            subtractList = myList1 - myList2;

            Assert.AreEqual(expectedCount, subtractList.Count);
        }

        [TestMethod]
        public void StringSubtractCountTest()
        {
            int expectedCount = 4;
            MyList<string> myList1 = new MyList<string> { "one", "two", "three", "four", "five" };
            MyList<string> myList2 = new MyList<string> { "five" };
            MyList<string> myList3 = myList1 - myList2;

            Assert.AreEqual(expectedCount, myList3.Count);
        }

        [TestMethod]
        public void StringSubtractValueTest()
        {
            int expectedCount = 4;
            MyList<string> myList1 = new MyList<string> { "one", "two", "three", "four", "five" };
            MyList<string> myList2 = new MyList<string> { "three" };
            MyList<string> myList3 = myList1 - myList2;

            Assert.AreEqual(myList3[0], "one");
            Assert.AreEqual(myList3[1], "two");
            Assert.AreEqual(myList3[2], "four");
            Assert.AreEqual(myList3[3], "five");
            Assert.AreEqual(expectedCount, myList3.Count);
        }

        [TestMethod]
        public void ToStringNumbers()
        {
            string expectedValue = "12345";
            string actualValue;
            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            actualValue = myList.ToString();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ToStringNumbers2()
        {
            string expectedValue = "12345678910";
            string actualValue;
            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

            actualValue = myList.ToString();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ToStringWords()
        {
            MyList<string> myList = new MyList<string>();
            string expectedValue = "Helloworld";
            string actualValue;

            myList.Add("Hello");
            myList.Add("world");

            actualValue = myList.ToString();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ToStringWords2()
        {
            MyList<string> myList = new MyList<string>();
            string expectedValue = "PeterLi";
            string actualValue;

            myList.Add("Peter");
            myList.Add("Li");

            actualValue = myList.ToString();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ZipTwoIntegersCount()
        {
            MyList<int> list1 = new MyList<int> { 1, 3, 5, 7, 9 };
            MyList<int> list2 = new MyList<int> { 2, 4, 6, 8, 10 };
            MyList<int> zipList;
            int expectedCount = 10;

            zipList = list1.Zip(list2);

            Assert.AreEqual(expectedCount, zipList.Count);
        }

        [TestMethod]
        public void ZipTwoIntegersValues()
        {
            MyList<int> list1 = new MyList<int> { 1, 2, 3 };
            MyList<int> list2 = new MyList<int> { 4, 5, 6 };
            MyList<int> zipList;

            int expectedCount = 6;

            zipList = list1.Zip(list2);
            Assert.AreEqual(1, zipList[0]);
            Assert.AreEqual(4, zipList[1]);
            Assert.AreEqual(2, zipList[2]);
            Assert.AreEqual(5, zipList[3]);
            Assert.AreEqual(3, zipList[4]);
            Assert.AreEqual(6, zipList[5]);
            Assert.AreEqual(expectedCount, zipList.Count);
        }

        [TestMethod]
        public void ZipTwoIntegersValues2()
        {
            MyList<int> list1 = new MyList<int> { 1, 3, 5 };
            MyList<int> list2 = new MyList<int> { 2, 4, 6 };
            MyList<int> zipList;

            int expectedCount = 6;

            zipList = list1.Zip(list2);

            Assert.AreEqual(1, zipList[0]);
            Assert.AreEqual(2, zipList[1]);
            Assert.AreEqual(3, zipList[2]);
            Assert.AreEqual(4, zipList[3]);
            Assert.AreEqual(5, zipList[4]);
            Assert.AreEqual(6, zipList[5]);
            Assert.AreEqual(expectedCount, zipList.Count);
        }

        [TestMethod]
        public void ZipTwoStrings()
        {
            MyList<string> list1 = new MyList<string> { "One", "Three", "Five" };
            MyList<string> list2 = new MyList<string> { "Two", "Four", "Six" };
            MyList<string> zipList;

            int expectedCount = 6;

            zipList = list1.Zip(list2);

            Assert.AreEqual(expectedCount, zipList.Count);
            Assert.AreEqual("One", zipList[0]);
            Assert.AreEqual("Two", zipList[1]);
            Assert.AreEqual("Three", zipList[2]);
            Assert.AreEqual("Four", zipList[3]);
            Assert.AreEqual("Five", zipList[4]);
            Assert.AreEqual("Six", zipList[5]);
        }

        [TestMethod]
        public void ZipTwoStringsCount()
        {
            MyList<string> list1 = new MyList<string> { "One", "Three", "Five", "Seven", "Nine" };
            MyList<string> list2 = new MyList<string> { "Two", "Four", "Six", "Eight", "Ten" };
            MyList<string> zipList;

            int expectedCount = 10;

            zipList = list1.Zip(list2);

            Assert.AreEqual(expectedCount, zipList.Count);
        }

        [TestMethod]
        public void ZipTwoStringsValues()
        {
            MyList<string> list1 = new MyList<string> { "Peter", "Li" };
            MyList<string> list2 = new MyList<string> { "Liu" };
            MyList<string> zipList;

            int expectedCount = 3;

            zipList = list1.Zip(list2);

            Assert.AreEqual("Peter", zipList[0]);
            Assert.AreEqual("Liu", zipList[1]);
            Assert.AreEqual("Li", zipList[2]);
            Assert.AreEqual(expectedCount, zipList.Count);
        }
    }
}