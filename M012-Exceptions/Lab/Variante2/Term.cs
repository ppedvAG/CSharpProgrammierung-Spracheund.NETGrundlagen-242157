using M012_Exceptions.Lab;

namespace Lab12_ExcpetionHandling.Variante2
{
    public class Term
    {
        public string Eingabe { get; set; }
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }
        public Rechenoperation Operation { get; set; }

        public Term(string term)
        {
            this.Eingabe = term;
            this.Operation = this.GetRechenoperation();


            //SplitTerm kann Null zurückgeben (führt bei Zugriff auf Array in nächster Zeile zu NullReferenceException)
            string[] zahlen = this.SplitTerm();

            if (zahlen.Length == 2)
            {
                //Parsing kann FormatExceptions und OverflowExceptions verursachen
                // mit string.Trim() entfernen wir whitespaces
                this.Zahl1 = int.TryParse(zahlen[0].Trim(), out var zahl1) ? zahl1 : 0;
                this.Zahl2 = int.TryParse(zahlen[1].Trim(), out var zahl2) ? zahl2 : 0;
            }
        }

        private Rechenoperation GetRechenoperation()
        {
            if (this.Eingabe.Contains('+'))
                return Rechenoperation.Addition;
            else if (this.Eingabe.Contains('-'))
                return Rechenoperation.Subtraktion;
            else if (this.Eingabe.Contains('*'))
                return Rechenoperation.Multiplikation;
            else if (this.Eingabe.Contains('/'))
                return Rechenoperation.Division;
            else
                return 0;
        }

        private string[] SplitTerm()
        {
            switch (this.Operation)
            {
                case Rechenoperation.Addition:
                    return this.Eingabe.Split('+');
                case Rechenoperation.Subtraktion:
                    return this.Eingabe.Split('-');
                case Rechenoperation.Multiplikation:
                    return this.Eingabe.Split('*');
                case Rechenoperation.Division:
                    return this.Eingabe.Split('/');
            }
            return [];
        }
    }
}

