using Bogus;
using Fahrzeugpark;

namespace FahrzeugGUI
{
    public partial class Form1 : Form
    {
        Faker faker = new Faker();

        //Liste zum Speichern der erstellten Fahrzeuge
        public List<Fahrzeug> Fahrzeugliste { get; set; }

        //Konstruktor zur Initalisierung des Fensters
        public Form1()
        {
            //Erstellung der im Designer definierten Elemente
            InitializeComponent();
            //Initialisierung der Liste
            this.Fahrzeugliste = new List<Fahrzeug>();
        }

        #region EventHandler-Methoden

        //Event-Handler f�r das Click-Event des Men�eintrags 'Beenden'
        private void MeI_Beenden_Click(object sender, EventArgs e)
        {
            //Nachfrage per MessageBox
            string dialogText = "M�chtest du wirklich beenden?\nNicht gespeicherte �nderungen werden verworfen.";
            DialogResult result = MessageBox.Show(dialogText, "Programm schlie�en", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Testen des in MessageBox geklickten Buttons
            if (result == DialogResult.Yes)
                //Schlie�en des Fensters
                this.Close();
        }

        //Events-Handler des 'Neu'-Buttons
        private void Btn_Neu_Click(object sender, EventArgs e)
        {
            //Erstellen eines neuen Fahrzeuges und Einf�gen in die Liste
            this.Fahrzeugliste.Add(GeneriereFahrzeug());
            //Aktualisierung der ListBox
            this.UpdateGui();
        }

        private Fahrzeug GeneriereFahrzeug()
        {
            var name = $"{faker.Vehicle.Manufacturer()} {faker.Vehicle.Model()}";
            var topSpeed = faker.Random.Int(50, 300);
            var price = Math.Round(faker.Random.Double(1e4, 1e5));
            return new Fahrzeug(name, topSpeed, price);
        }

        //Event-Handler des 'L�schen'-Buttons
        private void Btn_L�schen_Click(object sender, EventArgs e)
        {
            //Pr�fung, ob ein Eintrag ausgew�hlt ist
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //L�schen des in der ListBox markierten Items aus der Personenliste
                L�scheFz(Lbx_Fahrzeuge.SelectedItem as Fahrzeug);

            //Aktualisierung der ListBox
            UpdateGui();
        }

        //EventHandler der ListBox (bei Auswahl-Ver�nderung)
        private void Lbx_Fahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pr�fun, ob eine Auswahl in ListBox besteht
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Anzeige der Info()-Methode in Label
                Lbl_Info.Text = (Lbx_Fahrzeuge.SelectedItem as Fahrzeug).Info();
        }
        #endregion

        #region zus�tzliche Methoden

        //Methode zum L�schen von Fahrzeugen
        private void L�scheFz(Fahrzeug fz)
        {
            Fahrzeugliste.Remove(fz);
        }

        //Methode zur Synchronisation von ListBox.Items und Fahrzeugliste
        private void UpdateGui()
        {
            //L�schend des ListBox-Inhalts
            this.Lbx_Fahrzeuge.Items.Clear();

            //Neubef�llung der ListBox anhand der Liste
            foreach (var item in this.Fahrzeugliste)
            {
                this.Lbx_Fahrzeuge.Items.Add(item);
            }
        }
        #endregion
    }
}
