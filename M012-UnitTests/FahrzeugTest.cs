using M006_OOP.Lab;

namespace M012_UnitTests
{
    // Attribut welches die Klasse als Testklasse kennzeichnet
    [TestClass]
    public class FahrzeugTest
    {
        // Benennung der Testmethode:
        // ZuTestendendeMethode_Szeario_ErwarteteErgebnis

        [TestMethod]
        public void Beschleunige_MehrAlsMaxGeschwindigkeit_SetztMaxGeschwindigkeit()
        {
            var auto = new Fahrzeug("Volvo V70", 240, 23e3);

            auto.StarteMotor();
            auto.Beschleunige(300);

            // Jede Test-Methode benoetigt mindestens einen Aufruf der Assert-Klasse
            // in welcher die Erfolgsbedingung des Tests geprueft wird
            Assert.AreEqual(auto.MaxGeschwindigkeit, auto.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_NegativeWerte_Setzt0()
        {
            var auto = new Fahrzeug("Volvo V70", 240, 23e3);

            auto.StarteMotor();
            auto.Beschleunige(200);
            auto.Beschleunige(-300);

            // Jede Test-Methode benoetigt mindestens einen Aufruf der Assert-Klasse
            // in welcher die Erfolgsbedingung des Tests geprueft wird
            Assert.AreEqual(0, auto.AktGeschwindigkeit);
        }
    }
}