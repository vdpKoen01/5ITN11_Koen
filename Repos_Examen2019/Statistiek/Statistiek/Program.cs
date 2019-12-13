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
 *      BEREKEN onvoldoendes
 *      BEREKEN geslaagdOfNiet 
 *      (
 *      NIET GESLAAGD = gemiddelde < 50 % of meer dan 1 buis;
 *      GESLAAGD = max 1 buis, gemiddelde >= 50% of <= 70%;
 *      ONDERSCHEIDING = gemiddelde >= 70%, geen buizen;
 *      )
 *      BEREKEN einde (naam + aantalIngegevenRes + gemiddelde + laagsteGetal + grootsteGetal + geslaagdOfNiet);
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
            string voornaam, familienaam, res, naam, geslaagdOfNiet, einde = "";
            byte aantalIngegevenRes = 0, onvoldoendes = 0;
            decimal resultaat, gemiddelde, laagsteGetal, grootsteGetal, totaal = 0;
            bool isResultaatOk;


            //INPUT
            // Vraag voornaam
            voornaam = Vraag("Wat is je voornaam?: ");

            // Vraag familienaam
            familienaam = Vraag("Wat is je familienaam?: ");

            // Vraag resultaat
            res = Vraag("Geef het resultaat/de resultaten in, in procent (max 1 getal na komma): ");

            isResultaatOk = decimal.TryParse(res, out resultaat);


            //PROCESSING
            if (!isResultaatOk)
            {
                einde = "Probeer opnieuw en geef een geldig resultaat in.";
            }
            else
            {
                while (res != "")
                {
                    // Bereken totaal
                    totaal += resultaat;

                    // resultaten blijven vragen tot het leeg word gelaten
                    res = Vraag("Geef het resultaat/de resultaten in, in procent (max 1 getal na komma): ");

                    // Berkenen totaal (totaal += resultaat)
                    isResultaatOk = decimal.TryParse(res, out resultaat);

                    if (isResultaatOk == false)
                    {
                        res = "";
                        einde = "Geef een geldig resultaat in, aub.";
                    }
                    else
                    {

                        // Berkenen onvoldoendes
                        if (resultaat < 50)
                        {
                            onvoldoendes += 1;
                        }

                        // Bereken aantal resultaten dat worden ingegeven
                        aantalIngegevenRes += 1;

                        if (res == "" || res == " ")
                        {
                            // Bereken naam (eerste letter voornaam in hoofdletter + ". " + achternaam in hoofdletters)
                            naam = voornaam.Substring(0, 1).ToUpper() + ". " + familienaam.ToUpper();

                            // Berkenen gemmiddelde (totaal / aantalIngegevenRes)
                            gemiddelde = totaal / aantalIngegevenRes;

                            // Berkenen laagsteGetal
                            // weet ik niet meer
                            laagsteGetal = 0;

                            // Berkenen grootsteGetal
                            // weet ik niet meer
                            grootsteGetal = 100;

                            // Berkenen isGeslaagd 
                            //(
                            //  NIET GESLAAGD = gemiddelde < 50 % of meer dan 1 buis
                            //  GESLAAGD = max 1 buis, gemiddelde >= 50% of <= 70%
                            //  ONDERSCHEIDING = gemiddelde >= 70%, geen buizen
                            //)
                            if (gemiddelde < 50 || onvoldoendes > 1)
                            {
                                geslaagdOfNiet = "Niet geslaagd!";
                            }
                            else if (onvoldoendes <= 1 && (gemiddelde >= 50 || gemiddelde <= 70))
                            {
                                geslaagdOfNiet = "Geslaagd!";
                            }
                            else if (gemiddelde >= 70)
                            {
                                geslaagdOfNiet = "Onderscheiding!";
                            }
                            else
                            {
                                geslaagdOfNiet = "Iets is mis gegaan in deze toepassing. Probeer opnieuw!";
                            }

                            // Berkenen einde (naam + aantalIngegevenRes + gemiddelde + laagsteGetal + grootsteGetal + geslaagdOfNiet)
                            einde = $"Naam: {naam}{Environment.NewLine}" +
                                $"Aantal ingegeven resultaten:  {aantalIngegevenRes}{Environment.NewLine}" +
                                $"Gemiddelde:                   {gemiddelde}{Environment.NewLine}" +
                                $"Kleinste resultaat:           {laagsteGetal}{Environment.NewLine}" +
                                $"Grootste resultaat:           {grootsteGetal.ToString("##,#")}{Environment.NewLine}" +
                                $"Conclusie:                    {geslaagdOfNiet}{Environment.NewLine}";
                        }
                    }
                }
            }

            //OUPUT
            // Toon einde
            Console.WriteLine(einde);
            Console.ReadLine();


        }

        // Kortere versie voor iets te tonen op het scherm
        private static string Vraag(string vrg)
        {
            Console.WriteLine(vrg);
            return Console.ReadLine();
        }
    }
}
