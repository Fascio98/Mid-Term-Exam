using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System;

namespace WriteInDatabaseTest
{
    [TestClass]
    public class WriteInDatabaseUnitTest
    {
        public const string ListSize1 = "Must Be More Than Zero!";
        [TestMethod]
        public void TestWriteInDatabase()
        {
            Mid_Exam7 db = new Mid_Exam7();
            List<StudentSubject> lst = new List<StudentSubject>();
            //lst.Add(new StudentSubject() { StudentId = 5, SubjectId = 5, Grade = 9 });
            try
            {
                Program.WriteInDatabase(lst,lst.Count, db);
            }
            catch (System.ArgumentOutOfRangeException es)
            {
                StringAssert.Contains(es.Message, ListSize1);
            }
        }
    }
}
