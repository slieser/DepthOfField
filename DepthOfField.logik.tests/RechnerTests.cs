using NUnit.Framework;

namespace DepthOfField.logik.tests
{
    [TestFixture]
    public class RechnerTests
    {
        [Test]
        public void Blende_10() {
            var blende = Rechner.Blende(70, 700, 3000, 0.0192);
            Assert.That(blende, Is.EqualTo(10));

            var schärfentiefe = Rechner.Schärfentiefe(70, 10, 3000, 0.0192);
            Assert.That(schärfentiefe, Is.EqualTo(698));
        }

        [Test]
        public void Blende_5_komma_6() {
            var blende = Rechner.Blende(70, 400, 3000, 0.0192);
            Assert.That(blende, Is.EqualTo(5.6));

            var schärfentiefe = Rechner.Schärfentiefe(70, 5.6, 3000, 0.0192);
            Assert.That(schärfentiefe, Is.EqualTo(387.4));
        }

        [Test]
        public void Blende_4() {
            var blende = Rechner.Blende(70, 279.79, 3000, 0.0192);
            Assert.That(blende, Is.EqualTo(4));

            var schärfentiefe = Rechner.Schärfentiefe(70, 4, 3000, 0.0192);
            Assert.That(schärfentiefe, Is.EqualTo(276.1));
        }
    }
}