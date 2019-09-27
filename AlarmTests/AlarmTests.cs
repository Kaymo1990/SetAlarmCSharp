using NUnit.Framework;
using SetAlarm;

namespace Tests
{
    public class AlarmTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmployedAndNotVacation_ReturnsTrue_WhenPassedInput()
        {
            var employed = true;
            var vacation = false;
            bool output = Alarm.SetAlarm(employed, vacation);

            Assert.IsTrue(output);
        }

        [Test]
        public void EmployedAndNotVacation_ReturnsFalse_WhenPassedFF()
        {
            var employed = false;
            var vacation = false;
            bool output = Alarm.SetAlarm(employed, vacation);

            Assert.IsFalse(output);
        }

        [Test]
        public void EmployedAndNotVacation_ReturnsFalse_WhenPassedFT()
        {
            var employed = false;
            var vacation = true;
            bool output = Alarm.SetAlarm(employed, vacation);

            Assert.IsFalse(output);
        }

        [Test]
        public void EmployedAndNotVacation_ReturnsFalse_WhenPassedTT()
        {
            var employed = true;
            var vacation = true;
            bool output = Alarm.SetAlarm(employed, vacation);

            Assert.IsFalse(output);
        }
    }
}