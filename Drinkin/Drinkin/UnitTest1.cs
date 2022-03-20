using NUnit.Framework;

namespace Drinkin
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Drank1Drink()
        {
            var drinks = new NightOut();
            var result = drinks.Hydrate("1 beer");
            Assert.AreEqual("1 glass of water", result);
        }
        [Test]
        public void Drank10Drinks()
        {
            var drinks = new NightOut();
            var result = drinks.Hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
            Assert.AreEqual("10 glasses of water", result);
        }
        
        [Test]
        public void Drank12Drinks()
        {
            var drinks = new NightOut();
            var result = drinks.Hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer, 2 sangrias");
            Assert.AreEqual("12 glasses of water", result);
        }

    }
}