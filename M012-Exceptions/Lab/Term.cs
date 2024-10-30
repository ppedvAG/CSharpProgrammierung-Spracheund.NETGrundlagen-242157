namespace Lab12_ExcpetionHandling
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

            //Parsing kann FormatExceptions und OverflowExceptions verursachen
            this.Zahl1 = int.Parse(zahlen[0]);
            this.Zahl2 = int.Parse(zahlen[1]);
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
            return null; //Null-Rückgabe kann später eine NullReferenceException verursachen
        }
    }
}

