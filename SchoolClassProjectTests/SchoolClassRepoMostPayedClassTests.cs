using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassRepoMostPayedClassTests
    {
        [TestMethod()]
        public void MostPayedClassTestEmptyList()
        {
            SchoolClassRepo classRepo = new SchoolClassRepo(new List<SchoolClass>());

            string actualClassName = classRepo.MostPayedClass();
            string expectedClassName=string.Empty;

            Assert.AreEqual(expectedClassName, actualClassName);
        }
        [TestMethod()]
        public void MostPayedClassTestFirstIsTheMostPayed()
        {
            SchoolClassRepo classRepo = new SchoolClassRepo(new List<SchoolClass>
            {
                new SchoolClass(9,"a",7000,30),
                new SchoolClass(9,"b",6000,30),
                new SchoolClass(9,"c",5000,30),

            });

            string actualClassName = classRepo.MostPayedClass();
            string expectedClassName = "9a";

            Assert.AreEqual(expectedClassName, actualClassName);
        }
        [TestMethod()]
        public void MostPayedClassTestLastIsTheMostPayed()
        {
            SchoolClassRepo classRepo = new SchoolClassRepo(new List<SchoolClass>
            {
                new SchoolClass(9,"a",7000,30),
                new SchoolClass(9,"b",7000,30),
                new SchoolClass(9,"c",8000,30),

            });

            string actualClassName = classRepo.MostPayedClass();
            string expectedClassName = "9c";

            Assert.AreEqual(expectedClassName, actualClassName);
        }
        [TestMethod()]
        public void MostPayedClassTestMiddleIsTheMostPayed()
        {
            SchoolClassRepo classRepo = new SchoolClassRepo(new List<SchoolClass>
            {
                new SchoolClass(9,"a",7000,30),
                new SchoolClass(9,"b",8000,30),
                new SchoolClass(9,"c",5000,30),

            });

            string actualClassName = classRepo.MostPayedClass();
            string expectedClassName = "9b";

            Assert.AreEqual(expectedClassName, actualClassName);
        }
    }
}