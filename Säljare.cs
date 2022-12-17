using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
        //Skapa en klass för objektet säljare.
    class Säljare
    {
            //Deklarera medlemsvariabler för namn, persnr, distrikt och såldaartiklar.
        public string Namn;
        public long PersNr;
        public string Distrikt;
        public int SåldaArtiklar;

            //Returnera värden i variablerna för varje säljare.
            //Skriv ut utskrifter med olika många "tab" beroende på längden av variablerna Namn och Distrikt,
            //i syfte att få en jämn kolumnliknande utskrift.
        public override string ToString()
        {
            if(Distrikt.Length > 8)
            {
                return (Namn + ("\t\t") + PersNr + ("\t\t") + Distrikt + ("\t") + SåldaArtiklar + ("\r\n"));
            }
            else if ((Distrikt.Length < 5) && (Namn.Length > 10))
            {
                return (Namn + ("\t\t") + PersNr + ("\t\t") + Distrikt + ("\t\t\t") + SåldaArtiklar + ("\r\n"));
            }
            else if ((Distrikt.Length < 5) && (Namn.Length < 10))
            {
                return (Namn + ("\t\t\t") + PersNr + ("\t\t") + Distrikt + ("\t\t") + SåldaArtiklar + ("\r\n"));
            }
            else if ((Namn.Length < 10) && (Distrikt.Length > 5))
            {
                return (Namn + ("\t\t\t") + PersNr + ("\t\t") + Distrikt + ("\t\t") + SåldaArtiklar + ("\r\n"));
            }
            else
            {
                return (Namn + ("\t\t") + PersNr + ("\t\t") + Distrikt + ("\t\t") + SåldaArtiklar + ("\r\n"));
            }
            
        }
        
    }
}
