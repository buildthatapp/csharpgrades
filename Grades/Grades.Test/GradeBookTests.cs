using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Test
{
    [TestClass]
    class GradeBookTests
    {
        [TestMethod]
        public void CreateGradeBook()
        {
            GradeBook newBook = new GradeBook(5);
            newBook.AddGrade(50);
            newBook.AddGrade(99);
            GradeStatistics result = newBook.ComputeStatistics();
            Assert.AreEqual(99, result.HighestGrade);
            Assert.AreEqual(50, result.LowestGrade);
        }
    }
}
