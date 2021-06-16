using CoffeeApp.Services;
using NUnit.Framework;

namespace TestProject
{
    public class BeanServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SufficientAvailableBeans_ShouldBeTrue()
        {
            BeanService.AvailableBeans = 25;
            BeanService.BeansUsed = 5;

            var isSufficient = BeanService.HasSufficientAvailableBeans();

            Assert.IsTrue(isSufficient);
        }

        [Test]
        public void SufficientAvailableBeans_ShouldBeFalse()
        {
            BeanService.AvailableBeans = 0;
            BeanService.BeansUsed = 5;

            var isSufficient = BeanService.HasSufficientAvailableBeans();

            Assert.IsFalse(isSufficient);
        }

        [Test]
        public void SetRemainingBeans_ShouldBeEqual()
        {
            BeanService.AvailableBeans = 25;
            BeanService.BeansUsed = 5;
            var expectedOutput = 20;

            BeanService.SetRemainingBeans();

            Assert.AreEqual(BeanService.AvailableBeans, expectedOutput);
        }
    }
}