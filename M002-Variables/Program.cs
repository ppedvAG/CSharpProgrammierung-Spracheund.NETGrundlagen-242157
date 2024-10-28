// Regions werden verwendet um Codebereiche zu gruppieren und aendern den Programmablauf nicht!
#region Variablen

int number = 20;
string word = "Hello";

int age; // Deklaration
age = 20; // Initialisierung

int doubleage = age * 2;
var anotherNumber = 42; // Zuweisung bei var erforderlich damit Typ ermittelt werden kann

char c = 'a'; // Char speichert ein einzelnes Zeichen ab und wird immer in einfache Anfuehrungszeichen eingesetzt
string sentence = "Hello, World!"; // Strings werden immer in Anfuehrungszeichen eingesetzt
var textWithLineBreak = "Hello, \r\nWorld!";

var composedText = "Text mit Variable " + number + " und Zeichen " + c;

// Hier werden die Platzhalter {0} und {1} durch die Werte number und c ersetzt
var formattedText = string.Format("Text mit Variablen {0} und {1}", number, c);

// Einfachere Alternative zu stirng.Format
var formattedTextSimpler = $"Text mit Variablen {number} und {c}";

#endregion

#region Eingabe

Console.WriteLine("Enter your name: ");
string input = Console.ReadLine();
Console.WriteLine($"Hello, {input}");

var info = Console.ReadKey(true);
Console.WriteLine($"Du hast {info.Key} eingetippt.l");

#endregion

#region Konvertierung 

int number_x = 10;
var numberAsString = number_x.ToString();
numberAsString = $"{number_x}";

// var y = numberAsString * 2; // Geht nicht weil jetzt ein string

int parsedNumber = int.Parse(numberAsString);
var doulbed = parsedNumber * 2;

double precisionNumber = 2.4;
float singlePrecisionNumber = 2.4f; // Wir muessen ein f angeben um es als float zu kennzeichnen

// Cast, Typecast, Casting: Unwandlung von einer Variable in einen anderen Typen erzwingen
int numberWithoutDecimal = (int)precisionNumber;
double doubleWithoutDecimal = (double)singlePrecisionNumber;

Console.WriteLine($"Casted {precisionNumber} to integer: {numberWithoutDecimal}");

#endregion

#region Arithmetische Operatoren

// Grundrechenarten +, -, *, /, %, ++, --

var even = 42 % 2; // event enthaelt 0 weil Rest 0 ist
var odd = 43 % 2; // odd enthaelt 1 weil Rest 1 ist

number++; // erhoehe den Wert um 1
number--; // verringere den Wert um 1

Math.Floor(4.56); // immer abrunden, unabhaengig von den Nachkommastellen
Math.Ceiling(4.5); // immer aufrunden, unabhaengig von den Nachkommastellen
Math.Round(4.5); // auf- oder abrunden, abhaengig von den Nachkommastellen
Math.Abs(-42); // berechne den Absolutbetrag
Math.Min(42, 43); // berechne den kleinsten Wert
Math.Max(42, 43); // berechne den groessten Wert

#endregion




Console.WriteLine("Press any key to exit...");
Console.ReadKey(true);