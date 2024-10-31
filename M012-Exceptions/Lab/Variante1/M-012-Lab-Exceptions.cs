using M012_Exceptions.Lab;
using System;

namespace Lab12_ExcpetionHandling.Variante1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Variable, welche Wiederholung definiert
            bool wiederholen;
            //Schleife f�r Wiederholung
            do
            {
                wiederholen = false;

                //Eingabe durch Benutzer
                string eingabe = GetEingabe();

                //Try-Block f�r Code, welche m�glicherweise Fehler verursacht
                try
                {
                    Term term = new Term(eingabe);

                    int ergebnis = BerechneTerm(term);

                    Console.WriteLine($"\t={ergebnis}");
                }
                //Catch-Bl�cke zur Bearbeitung der Fehler
                catch (OverflowException)
                {
                    Console.WriteLine("Eine deiner Zahlen ist zu gro� oder zu klein.\n");
                    //Variablenzuweisung f�r Wiederholung
                    wiederholen = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du hast ein nicht-erlaubtes Zeichen verwendet.\n");
                    wiederholen = true;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Du hast versucht durch 0 zu teilen.\n");
                    wiederholen = true;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Du hast ein nicht-erlaubtes Rechenzeichen verwendet.\n");
                    wiederholen = true;
                }
                catch (Exception)
                {

                }
            } while (wiederholen);
        }

        static string GetEingabe()
        {
            Console.WriteLine("Bitte gib einen Term mit zwei Zahlen und einem Grundrechenoperator (+ - * /) ein (z.B.: 25+13):");
            return Console.ReadLine();
        }

        static int BerechneTerm(Term term)
        {
            switch (term.Operation)
            {
                case Rechenoperation.Addition:
                    return term.Zahl1 + term.Zahl2;
                case Rechenoperation.Subtraktion:
                    return term.Zahl1 - term.Zahl2;
                case Rechenoperation.Multiplikation:
                    return term.Zahl1 * term.Zahl2;
                default:
                    //Teilung kann DivideByZeroException verursachen
                    return term.Zahl1 / term.Zahl2;
            }
        }
    }
}

