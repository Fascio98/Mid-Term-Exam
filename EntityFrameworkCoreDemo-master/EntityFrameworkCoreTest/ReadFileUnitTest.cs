using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System;

namespace EntityFrameworkCoreTest
{
    
    [TestClass]
    public class ReadFileUnitTest
    {
        public const string ArraySize = "Mustn't Be Zero";
        [TestMethod]
        public void TestReadFile()
        {
            string[] m = new string[15] ;
            int z = m.Length;
            try
            {
                Program.ReadFile(m,z);
            }
            catch(System.ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, ArraySize);
            }
        }         
    }
}
