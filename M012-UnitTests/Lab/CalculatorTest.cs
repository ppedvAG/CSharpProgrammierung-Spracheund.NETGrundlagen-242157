using Lab12_ExcpetionHandling.Variante2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace M012_UnitTests.Lab
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calc = new Calculator();

        [TestMethod]
        [DataRow("2+2", 4)]
        [DataRow("2 + 2", 4)] // Leerzeichen im Ausdruck
        [DataRow("2-8", -6)]
        [DataRow("8*19", 152)]
        [DataRow("80/8", 10)]
        public void TryExecute_CalculateTerm_Success(string term, int expected)
        {
            int result = calc.TryExecute(term, out var error);

            Assert.AreEqual(string.Empty, error, $"Fehler aufgetreten: {error}");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(" 2 + 2 ", 4)] // Leerzeichen im Ausdruck
        [DataRow("\n2 + 2 ", 4)] // Leerzeichen im Ausdruck
        [DataRow("0x2+0x2", 4)] // Hexadezimalzahlen
        [DataRow("2x2", "")] // Falscher Operator
        [DataRow("2+k", "")] // Falsche Zahl
        [DataRow("2/0", "")] // Division durch 0
        [DataRow("2.2*0", "")] // Gleitkommazahl
        [DataRow("8", "")] // Nur eine Zahl
        [DataRow("2147483647*8", "")] // Overflow
        //[Ignore] // Dieser Test ist nur dafuer da um verschiedene Fehlerfaelle zu pruefen
        public void TryExecute_CalculateTerm_Fails(string term, string expected)
        {
            int result = calc.TryExecute(term, out var error);

            Assert.AreEqual(expected, error, $"Fehler aufgetreten: {error}");
        }

        [TestMethod]
        public void TryExecute_InvalidNumber_FormatExceptionIsHandled()
        {
            int result = calc.TryExecute("2+k", out var error);

            Assert.IsTrue(error.StartsWith("Ungueltiges Zeichen in der Eingabe"), error);
        }

        [TestMethod]
        public void TryExecute_DivisionByZero_ExceptionIsHandled()
        {
            int result = calc.TryExecute("2/0", out var error);

            Assert.IsTrue(error.StartsWith("Division durch 0 nicht erlaubt"), error);
        }
    }
}
