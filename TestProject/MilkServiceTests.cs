using CoffeeApp.Services;
using NUnit.Framework;

namespace TestProject
{
    public class MilkServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SetRemainingBeans_ShouldBeEqual()
        {
            MilkService.AvailableMilk = 20;
            MilkService.MilkUsed = 3;
            var expectedOutput = 17;

            MilkService.SetRemainingMilk();

            Assert.AreEqual(MilkService.AvailableMilk, expectedOutput);
        }

        [Test]
        public void SetRemainingBeans_ShouldNotBeEqual()
        {
            MilkService.AvailableMilk = 15;
            MilkService.MilkUsed = 1;
            var expectedOutput = 12;

            MilkService.SetRemainingMilk();

            Assert.AreNotEqual(MilkService.AvailableMilk, expectedOutput);
        }
    }
}
