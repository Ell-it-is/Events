using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcastniciMise;

namespace ZachrannaMise
{    
    class Program
    {
        /* Člověk
         * Ohrožená osoba
         * Dům
         * Hořící dům
         * Alarm
         * Hasič
         * Enum: Stav Ohrožení
         */

        static void Main(string[] args)
        {
            //Učástníci
            Dum vilaNadJezerem;
            OhrozenaOsoba osoba;
            Hasic mistniHasic;

            //"Pribeh"
            vilaNadJezerem = new HoriciDum("vilaNadJezerem 192", BuildingState.New, true);
            mistniHasic = new Hasic("Joseph", "Stanice", true);
            osoba = new OhrozenaOsoba("Natalia", vilaNadJezerem.Adress)
            {
                PersonState = DangerState.Alright
            };

            Console.WriteLine($"Osoba: {osoba.Name} sees a beggining of fire in the house");

            osoba.PersonState = DangerState.Danger;
            osoba.GetPersonState();
            osoba.PersonInDanger += mistniHasic.OnPersonInDanger;
            osoba.CallForHelp();

            mistniHasic.GetAccidentLocation(osoba);
            mistniHasic.DriveToAccident();
            mistniHasic.SafeManInDifficulty(); 
            
            Console.ReadKey();
        }
    }
}
