using static System.Runtime.InteropServices.JavaScript.JSType;
using BHZ;
using BHZ.Models.LandAnimals;
using BHZ.Models.AirAnimals;
using BHZ.Models.WaterAnimals;
using NUnit.Framework;

namespace BHZtest
{
    [TestFixture]
    public class AnimalTests
    {
        [Test]
        public void Ant_Move_ReturnsExpectedResult()
        {
            var ant = new Ant();
            var result = ant.move();
            NUnit.Framework.Assert.AreEqual("I run", result);
        }

        [Test]
        public void Ant_MakeSound_ReturnsExpectedResult()
        {
            var ant = new Ant();
            var result = ant.MakeSound();
            NUnit.Framework.Assert.AreEqual("Im a fast ant", result);
        }

        [Test]
        public void Crab_Move_ReturnsExpectedResult()
        {
            var crab = new Crab();
            var result = crab.move();
            NUnit.Framework.Assert.AreEqual("I swim", result);
        }

        [Test]
        public void Dragon_Move_ReturnsExpectedResult()
        {
            var dragon = new Dragon();
            var result = dragon.move();
            NUnit.Framework.Assert.AreEqual("I fly", result);
        }

        [Test]
        public void Dragon_MakeSound_ReturnsExpectedResult()
        {
            var dragon = new Dragon();
            var result = dragon.MakeSound();
            NUnit.Framework.Assert.AreEqual("RAWWR!", result);
        }
    }
}