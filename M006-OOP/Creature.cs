using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_OOP
{
    public class Creature
    {
        #region Fields

        // Mit dem private Modifier schuetzen wir das Feld von Zugriff von außen
        // Mit readonly koennen wir den Namen nur einmalig bei der Initialisierung zuweisen (direkt oder im Konstruktor)
        private readonly string _name = "Unknown";
        private int _size = 1;

        private string _favoriteFood;

        #endregion

        #region Properties

        public string FavoriteFood 
        { 
            get // void Get()
            {
                return _favoriteFood;
            } 
            set // void Set(string value)
            {
                _favoriteFood = value;
            }
        }

        // Syntactic Sugar: vereinfachte Kurzform fuer ausgeschriebenes Muster wie bei der Eigenschaft FavoriteFood
        public string FavoriteDrink { get; set; }

        // Kurzschreibweise fuer GetSize() { return _size; }
        public int Size => _size;

        public string Name => _name;

        #endregion

        #region Constructors

        // Ein Konstruktor ist eine spezielle Methode die beim Erzeugen einer Objekt-Instanz aufgerufen wird
        public Creature(string name)
        {
            _name = name;
        }

        // Default Konstruktor ist ein Konstruktor ohne Parameter
        public Creature()
        {
        }

        #endregion

        #region Methods

        public void Talk()
        {
            Console.WriteLine($"I am {_name} and I like {_favoriteFood}");
        }

        public void Grow()
        {
            _size += 1;
        }

        // Neue Instanz zurueckgeben
        public static Creature Create(string name)
        {
            // Statische Methoden gelten fuer die gesamte Klasse
            // Sie koennen aber nicht auf Member zugreifen
            
            // _name = name;
            // Talk();

            return new Creature(name);
        }

        #endregion
    }
}
