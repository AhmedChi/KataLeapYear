using LeapYearConsoleApp.Businesslogic;

namespace LeapYearUnitTests
{
    public class LeapYearTests
    {
        private LeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            leapYear = new LeapYear();
        }

        [Test]
        [TestCase(2004, true)]
        [TestCase(2008, true)]
        [TestCase(2012, true)]
        [TestCase(2016, true)]
        [TestCase(2020, true)]
        public void GivenTheCurrentYearIsLeapYear_WhenYearIsDivisbleByFourNotDivibleByHundred_ThenReturnTrue(int year, bool isLeapYearExpected)
        {
            //Act
            var isLeapYearActual = leapYear.IsLeapYear(year);

            //Assert
            Assert.AreEqual(isLeapYearExpected, isLeapYearActual);
        }
    }
}