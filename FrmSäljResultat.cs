using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
 * Inlämningsuppgift 2, L0002B.
 * 
 * Designa formuläret:
 * Lägg till gruppbox för indata/säljare med label och textbox för varje uppgift/egenskap.
 * Lägg till label för antalet registrerade, samt textbox för utskrift.
 * Skapa händelse Klick till knapparna "Lägg till", "Visa resultat", "Rensa" samt "Avsluta".
 * Lägg till gruppbox för resultatet med textbox för utskrift. Sätt textboxen till multiline, samt readonly.
 * Lägg till labels över textboxen för varje egenskap som ska skrivas ut.
 * 
 * 
 * 
 * 
 * Skapa ny klass för objektet säljare.
 * Deklarera medlemsvariabler/egenskaper i klassen Säljare, returnera variablerna för utskrift.
 * 
 * FrmSäljResultat:
 * Deklarera lista/listor för alla säljare, alla säljnivåer samt sorterade nivåer(instanser av Säljare).
 * Variabler för antalet i varje nivå, samt registrerade.
 * Skriv ut 0 i textbox antalRegistrerade vid start av programmet.
 * 
 * Vid klick på "Lägg till": 
 *   Hämta användaruppgifterna, lägg till ny säljare i listan av säljare.
 *   Anropa metod som adderar säljaren i en av Nivålistorna utifrån antalet sålda artiklar.
 *   Förbered för nästa inmatning.
 *   Skriv ut nytt värde i antalRegistrerade.
 *   
 * Vid klick på "Visa resultat":
 *   Anropa metod som sorterar alla Nivålistor och adderar säljarna i en fallande ordning till sorterade Nivålistor.
 *   Gå igenom alla sorterade säljnivåer, fortsätt om det finns minst 1 i antalet för nivån:
 *     Anropa metod som skriver ut alla element i listan, samt deras variabelvärden.
 *     Skriv ut antalet i nivån, samt lämplig string.
 *   Anropa metod som skriver över resultatet i en textfil.
 *   
 * Vid klick på "Rensa":
 *   Töm textboxen Resultat.
 *   Töm alla listor, variabler för antal i varje nivå samt antal registrerade.
 *   
 * Vid klick på "Avsluta":
 *   Avsluta programmet.
 * 
 * 
 * @author: Liza Danielsson, lizdan-6.
 * 
 */
namespace Inlämningsuppgift_2
{
    public partial class FrmSäljResultat : Form
    {
            //Initiera medlemsvariabler samt lista/listor för hämtning av input, 4 olika nivåer samt sorterade nivåer.
        List<Säljare> ListaAvSäljare = new List<Säljare>();
        
        List<Säljare> Nivå1 = new List<Säljare>();
        List<Säljare> Nivå2 = new List<Säljare>();
        List<Säljare> Nivå3 = new List<Säljare>();
        List<Säljare> Nivå4 = new List<Säljare>();

        List<Säljare> SorteradNivå1 = new List<Säljare>();
        List<Säljare> SorteradNivå2 = new List<Säljare>();
        List<Säljare> SorteradNivå3 = new List<Säljare>();
        List<Säljare> SorteradNivå4 = new List<Säljare>();

            //Medlemsvariabler, antalet säljare i varje nivå.
        int antalNivå1 = 0;
        int antalNivå2 = 0;
        int antalNivå3 = 0;
        int antalNivå4 = 0;
        int antalRegistrerade = 0;

        
        public FrmSäljResultat()
        {
            InitializeComponent();
                //Skriv ut 0 i rutan för antalet registrerade vid start av programmet.
            tbxAntalRegistrerade.Text = antalRegistrerade.ToString();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
                //Skapa instans av listan Säljare, och lägg till instansen/en ny säljare.
                //Läs in uppgifter, för alla variabler som deklarerats i klassen.
            ListaAvSäljare.Add(new Säljare());
            ListaAvSäljare[antalRegistrerade].Namn = tbxNamn.Text;
            ListaAvSäljare[antalRegistrerade].PersNr = long.Parse(tbxPersNr.Text);
            ListaAvSäljare[antalRegistrerade].Distrikt = tbxDistrikt.Text;
            ListaAvSäljare[antalRegistrerade].SåldaArtiklar = int.Parse(tbxSåldaArtiklar.Text);

                //Anropa metod som delar in säljaren i en nivå.
            indelningAvSäljNivåer();

                //Förbered för nästa inmatning, rensa textboxarna.
            tbxNamn.Text = "";
            tbxPersNr.Text = "";
            tbxDistrikt.Text = "";
            tbxSåldaArtiklar.Text = "";
                //Uppdatera antalet registrerade med 1.
            antalRegistrerade++;
                //Skriv ut det nya värdet för antalet registrerade.
            tbxAntalRegistrerade.Text = antalRegistrerade.ToString();
                //Flytta markören till översta textboxen, Namn.
            tbxNamn.Focus();
        }


            //Metod som körs när användaren klickar på knappen "Visa Resultat".
        private void btnVisaResultat_Click(object sender, EventArgs e)
        {
                //Rensa textbox Resultat inför varje nytt knapptryck.
            tbxResultat.Text = "";
            
                //Anropa metod som sorterar säljarna i varje nivå utifrån antalet sålda artiklar.
            sortering_AntalSåldaArtiklar();

            //Om det finns minst 1 säljare i nivån, skriv ut resultaten för varje nivå.
            if (antalNivå1 > 0)
            {
                    //Anropa metod som tar emot varje sorterad Nivålista och skriver ut varje insats av Säljare.
                    //Skriv ut antalet i nivån samt info.
                    //Upprepa för varje nivå.
                utskrift(SorteradNivå1);
                tbxResultat.Text += antalNivå1 + (" säljare har nått upp till nivå 1: " +
                "1-49 sålda artiklar.\r\n\r\n");
            }

            if (antalNivå2 > 0)
            {
                utskrift(SorteradNivå2);
                tbxResultat.Text += antalNivå2 + (" säljare har nått upp till nivå 2: " +
                "50-99 sålda artiklar.\r\n\r\n");
            }

            if (antalNivå3 > 0)
            {
                utskrift(SorteradNivå3);
                tbxResultat.Text += antalNivå3 + (" säljare har nått upp till nivå 3: " +
                "100-199 sålda artiklar.\r\n\r\n");
            }

            if (antalNivå4 > 0)
            {
                utskrift(SorteradNivå4);
                tbxResultat.Text += antalNivå4 + (" säljare har nått upp till nivå 4: " +
                "Över 199 sålda artiklar.\r\n\r\n");
            }
                //Anropa metod som sparar resultatet i en textfil.
            sparaTillFil();
        }
         
       

            //Metod som delar in säljarna i 4:a nivåer direkt efter registrering.
            //Beroende på antalet sålda artiklar läggs säljaren in i en ny "Nivålista".
            //Antalet i nivån ökar med 1 för varje säljare som hamnar i den nivån.
        private void indelningAvSäljNivåer()
        {
            if (ListaAvSäljare[antalRegistrerade].SåldaArtiklar < 50) 
            {
                Nivå1.Add(ListaAvSäljare[antalRegistrerade]);
                antalNivå1++;
            }
            else if ((ListaAvSäljare[antalRegistrerade].SåldaArtiklar >= 50) 
                && (ListaAvSäljare[antalRegistrerade].SåldaArtiklar < 100))
            {
                Nivå2.Add(ListaAvSäljare[antalRegistrerade]);
                antalNivå2++;
            }
            else if ((ListaAvSäljare[antalRegistrerade].SåldaArtiklar >= 100)
                && (ListaAvSäljare[antalRegistrerade].SåldaArtiklar < 200))
            {
                Nivå3.Add(ListaAvSäljare[antalRegistrerade]);
                antalNivå3++;
            }
            else if (ListaAvSäljare[antalRegistrerade].SåldaArtiklar >= 199)
            {
                Nivå4.Add(ListaAvSäljare[antalRegistrerade]);
                antalNivå4++;
            }
        }


        //Metod som sorterar säljarna.
        private void sortering_AntalSåldaArtiklar()
        {
            //Anropa metod som sorterar Nivålistorna i en fallande ordning utifrån antalet sålda artiklar.
            //Spara säljarna i nya sorterade listor för varje nivå.
            SorteradNivå1 = Nivå1.OrderByDescending(o => o.SåldaArtiklar).ToList();
            SorteradNivå2 = Nivå2.OrderByDescending(o => o.SåldaArtiklar).ToList();
            SorteradNivå3 = Nivå3.OrderByDescending(o => o.SåldaArtiklar).ToList();
            SorteradNivå4 = Nivå4.OrderByDescending(o => o.SåldaArtiklar).ToList();
        }



        //Metod som hämtar en lista och skriver ut alla egenskaper för varje säljare.
        private void utskrift(List<Säljare> utskriftslista)
        {
            for (int i = 0; i < utskriftslista.Count; i++)
            {
                tbxResultat.Text += utskriftslista[i];
            }
        }

            //Metod som skriver över texten i textboxen "Resultat" till en textfil.
        private void sparaTillFil()
        {
            TextWriter writer = new StreamWriter("C:textfil_inl2.txt");
            writer.Write(tbxResultat.Text);
            writer.Close();
        }

            //Metod som körs när användern klickar på knappen "Rensa".
        private void btnRensa_Click(object sender, EventArgs e)
        {
                //Rensa textboxar, antal registrerade, antal i varje nivå samt alla listor.
            tbxResultat.Text = "";

            antalRegistrerade = 0;
            tbxAntalRegistrerade.Text = antalRegistrerade.ToString();

            antalNivå1 = 0;
            antalNivå2 = 0;
            antalNivå3 = 0;
            antalNivå4 = 0;

            ListaAvSäljare.Clear();
            Nivå1.Clear();
            Nivå2.Clear();
            Nivå3.Clear();
            Nivå4.Clear();
            SorteradNivå1.Clear();
            SorteradNivå2.Clear();
            SorteradNivå3.Clear();
            SorteradNivå4.Clear();
        }


            //Meotd som körs om användaren klickar på knappen "Avsluta".
        private void btnAvsluta_Click(object sender, EventArgs e)
        {
                //Avsluta programmet
            System.Windows.Forms.Application.ExitThread();
        }
    }
}

