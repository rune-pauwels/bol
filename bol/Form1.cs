using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace bol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Functie oppervlakte berekenen======
*1. Invoer: Welke invoer mag je verwachten voor jouw functie? Geef zowel een naam/beschrijving als een datatype.
        een straal - double
*
*2. Bewerking: Hoe bereken je de oppervlakte van een bol?
*       Oppervlakte = 4 * pi * straal²
*
*3. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
*       een Oppervlakte - double
*       
*4. Naamgeving: Welke naam ga je deze functie geven?
*       BerekenOppervlakte
*       
*=======Analyse Functie inhoud berekenen======
*1. Invoer: Welke invoer mag je verwachten voor jouw functie? Geef zowel een naam/beschrijving als een datatype.
*       een straal - double
*       
*2. Bewerking: Hoe ga je inhoud van een bol berekenen?
*       inhoud = straal³ * pi * 4 / 3
*       
*3. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
*       een inhoud - double
*       
*4. Naamgeving: Welke naam ga je deze functie geven?
*       BerekenInhoud
*       
*==========Testdata=========
*5. Testdata: Verzin en noteer (of zoek op internet) testgegevens voor alle gevallen. Zo weet je of je oefening klopt.
*       als de straal 10.03 is
*       worden de uitkomsten:
*       Oppervlakte = 1264.19 cm²
*       Inhoud = 4226.6 cm³
*===========================*/
        private void BerekenButton_Click(object sender, EventArgs e)
        {
            double straal = Convert.ToDouble(StraalTextBox.Text);
            if (OppervlakteRadioButton.Checked)
            {
                MessageBox.Show("De oppervlakte van de bol is " + BerekenOppervlakte(straal) + "cm²", "Oppervlakte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (InhoudRadioButton.Checked) 
                {
                    MessageBox.Show("De inhoud van de bol is " + BerekenInhoud(straal) + "cm³", "Inhoud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private double BerekenOppervlakte(double straal)
        {
            return Math.Round((4 * Math.PI * Math.Pow(straal, 2)), 2);
        }


        private double BerekenInhoud(double straal) 
        {
            return Math.Round((Math.Pow(straal, 3) * Math.PI * 4 / 3), 2);
        }
    }
}
