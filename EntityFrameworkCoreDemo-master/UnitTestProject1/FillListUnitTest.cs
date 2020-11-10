using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class FillListUnitTest
    {
        public const string ListSize = "Must Be Zero!";
        public const string ListSize11 = "Array Length Is Zero or List Length is More than zero";
        [TestMethod]
        public void TestFillList()
        {
            List<StudentSubject> k = new List<StudentSubject>();
            string[] k1 = new string[] { };
            k1 = File.ReadAllLines("C:/Users/Nikusha/Desktop/EntityFrameworkCoreDemo-master/EntityFrameworkCore/Grades.csv");
            //k.Add(new StudentSubject() { StudentId = 5, SubjectId = 5, Grade = 9 });
            try
            {
                Program.FillList(k,k1);
            }
            catch (System.ArgumentOutOfRangeException ez)
            {
                StringAssert.Contains(ez.Message, ListSize11);
            }
        }
    }
}
