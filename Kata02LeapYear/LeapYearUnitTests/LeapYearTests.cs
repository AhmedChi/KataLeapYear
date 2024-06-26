using LeapYearConsoleApp.Businesslogic;

namespace LeapYearUnitTests
{
    public class LeapYearTests
    {
        private ILeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            leapYear = new LeapYear();
        }

        [Test]
        [TestCase(2001, false)]
        [TestCase(2007, false)]
        [TestCase(2015, false)]
        [TestCase(2021, false)]
        [TestCase(2025, false)]
        public void GivenTheCurrentYearIsNotLeapYear_WhenYearIsNotDivisbleByFour_ThenReturnFalse(int year, bool isLeapYearExpected)
        {
            //Act
            var isLeapYearActual = leapYear.IsLeapYear(year);

            //Assert
            Assert.AreEqual(isLeapYearExpected, isLeapYearActual);
        }

        [Test]
        [TestCase(1700, false)]
        [TestCase(1800, false)]
        [TestCase(1900, false)]
        [TestCase(2100, false)]
        [TestCase(2200, false)]
        public void GivenTheCurrentYearIsNotLeapYear_WhenYearIsDivisbleByFourAndDivibleByHundred_ThenReturnFalse(int year, bool isLeapYearExpected)
        {
            //Act
            var isLeapYearActual = leapYear.IsLeapYear(year);

            //Assert
            Assert.AreEqual(isLeapYearExpected, isLeapYearActual);
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

        [Test]
        [TestCase(1600, true)]
        [TestCase(2000, true)]
        [TestCase(2400, true)]
        [TestCase(2800, true)]
        [TestCase(2020, true)]
        public void GivenTheCurrentYearIsLeapYear_WhenYearIsDivisbleByFourAndHourHundredNotDivibleByHundred_ThenReturnTrue(int year, bool isLeapYearExpected)
        {
            //Act
            var isLeapYearActual = leapYear.IsLeapYear(year);

            //Assert
            Assert.AreEqual(isLeapYearExpected, isLeapYearActual);
        }

    }
}