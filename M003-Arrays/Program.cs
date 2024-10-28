#region Arrays

int[] numbers = new int[10]; // Neues Array mit einer Größe von 10, d. h. es passen 10 Zahlen hinein
Console.WriteLine(numbers.Length); // Gibt die Größe 10 aus

// Seit C# 12 lassen sich Arrays so initialisieren
int[] filledNumberArray = [56, 344, 345, 90, -12];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
numbers[5] = 6;
numbers[6] = 7;
numbers[7] = 8;
numbers[8] = 9;
numbers[9] = 10;

var sum = numbers.Sum();
Console.WriteLine("Summe des Zahlenarrays: " + sum);
var avg = numbers.Average();
Console.WriteLine("Durchschnitt des Zahlenarrays: " + avg);

char[] helloArray = new char[] { 'H', 'e', 'l', 'l', 'o' };
char[] helloArray2 = ['H', 'e', 'l', 'l', 'o'];

string hello = "Hello"; // intern ist ein String auch "nur" ein Array von chars

Console.WriteLine("Vierter Buchstabe von \"Hello\" ist: {0}", helloArray[3]);
Console.WriteLine("Vierter Buchstabe von \"Hello\" ist: {0}", hello[3]);

// 2D Array muss immer "rechteckig" sein
var array2d = new int[,] 
{ 
    { 1, 2 }, 
    { 3, 4 }, 
    { 5, 6 }, // 7, } 
};

// Aneinander gehaengtes Array, also ein Array von Arrays
var arrayNested = new int[3][];

Console.ReadKey();

#endregion

#region Listen

var listOfNumbers = new List<int>() { 1, 2, 3 };
listOfNumbers.Add(sum);

var listFromNumbers = numbers.ToList();
var foundResult = listOfNumbers.Find(x => x == 3);

#endregion

#region Bedingungen
// Boolsche Operatoren
// ==, !=, >=, <=, >, <,
// Logische Operatoren
// &&, ||, ^, !

int n1 = 4, n2 = 5;

if (n1 == n2)
{
    Console.WriteLine("n1 ist gleich n2");
}
else
{
    Console.WriteLine("n1 ist nicht gleich n2");
}

if (n1 > 0 ^ n2 > 0)
{
    Console.WriteLine("n1 oder n2 aber nicht beide groeßer als 0");
}

var randomInt = Random.Shared.Next(1, 10);

if (randomInt % 2 == 1)
{
    Console.WriteLine($"Heutige Glueckszahl ist {randomInt}");
}
else
{
    Console.WriteLine($"Heute keine Glueckszahl dabei!");
}

#endregion