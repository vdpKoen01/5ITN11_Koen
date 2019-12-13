// 5ITN11 - 2019-12-13 - Koen Van der Plas - Statistiek
/*
 * OPGAVE:
 * =======
 *  Vraag aan de gebruiker de voor- en familienaam v/d leerling. 
 *  En laat de gebruiker resultaten invoeren (in %, max 1 na komma) tot die al zijn resultaten heeft ingevoert.
 *  Als hij/zij een lege invoer geeft, bereken dan
 *   -> Naam (vb. "J. VERMEULEN");
 *   -> Het aantal ingegeven resultaten;
 *   -> Het gemiddelde;
 *   -> Het laagste en grootste resultaat;
 *   -> Of hij/zij geslaagd is;
 *      (
 *      NIET GESLAAGD = gemiddelde < 50 % of meer dan 1 buis;
 *      GESLAAGD = max 1 buis, gemiddelde >= 50% of <= 70%;
 *      ONDERSCHEIDING = gemiddelde >= 70%, geen buizen;
 *      )
 *      
 * ANALYSE:
 * ========
 * VRAAG voornaam;
 * VRAAG familienaam;
 * VRAAG resultaat;
 * 
 * BEREKEN isInvoerLeeg 
 *  (ALS resultaat == "" 
 *  DAN
 *      BEREKEN naam (eerste letter voornaam in hoofdletter + ". " + achternaam in hoofdletters);
 *      BEREKEN totaal (totaal += resultaat);
 *      BEREKEN aantalIngegevenRes;
 *      BEREKEN gemmiddelde (totaal / aantalIngegevenRes);
 *      BEREKEN laagsteGetal;
 *      BEREKEN grootsteGetal;
 *      BEREKEN isGeslaagd 
 *      (
 *      NIET GESLAAGD = gemiddelde < 50 % of meer dan 1 buis;
 *      GESLAAGD = max 1 buis, gemiddelde >= 50% of <= 70%;
 *      ONDERSCHEIDING = gemiddelde >= 70%, geen buizen;
 *      )
 *      BEREKEN einde (naam + aantalIngegevenRes + gemiddelde + laagsteGetal + grootsteGetal + isGeslaagd);
 *  )
 *  
 * TOON einde;
 *      
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistiek
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATION
            string voornaam, familienaam, res, naam, einde;
            byte resultaat, aantalIngegevenRes = 1;
            ushort totaal, gemiddelde, laagsteGetal, grootsteGetal;
            bool isGeslaagd, isResultaatOk;


            //INPUT
            // Vraag voornaam
            voornaam = Vraag("Wat is je voornaam?: ");

            // Vraag familienaam
            familienaam = Vraag("Wat is je familienaam?: ");

            // Vraag resultaat
            res = Vraag("Geef het resultaat/de resultaten in, in procent (max 1 getal na komma): ");


            //PROCESSING
            while (res != "")
            {
                // resultaten blijven vragen tot het leeg word gelaten
                res = Vraag("Geef het resultaat/de resultaten in, in procent (max 1 getal na komma): ");
                
                // Bereken aantal resultaten dat worden ingegeven
                aantalIngegevenRes += 1;

                if (res == "" || res == " ")
                {
                    // Bereken naam (eerste letter voornaam in hoofdletter + ". " + achternaam in hoofdletters)
                    naam = voornaam.Substring(0, 1).ToUpper() + ". " + familienaam.ToUpper();
                    //BEREKEN totaal (totaal += resultaat);

                    //BEREKEN aantalIngegevenRes;
                    
                    //BEREKEN gemmiddelde (totaal / aantalIngegevenRes);
                    
                    //BEREKEN laagsteGetal;
                    
                    //BEREKEN grootsteGetal;
                    
                    //BEREKEN isGeslaagd 
                    //(
                    //NIET GESLAAGD = gemiddelde < 50 % of meer dan 1 buis;
                    //GESLAAGD = max 1 buis, gemiddelde >= 50% of <= 70%;
                    //ONDERSCHEIDING = gemiddelde >= 70%, geen buizen;
                    //)
                    
                    //BEREKEN einde (naam + aantalIngegevenRes + gemiddelde + laagsteGetal + grootsteGetal + isGeslaagd);
                }
            } 


            //OUPUT
            


        }

        // Kortere versie voor iets te tonen op het scherm
        private static string Vraag(string vrg)
        {
            Console.WriteLine(vrg);
            return Console.ReadLine();
        }
    }
}
