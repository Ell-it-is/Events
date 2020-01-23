using System;
using System.Collections.Generic;
using System.Text;

namespace UcastniciMise
{
    public interface IHasic
    {
        string Name { get; set; }
        string Location { get; set; }
        bool HasEquipment { get; set; }
        string AccidentLocation { get; set; }

        void GetAccidentLocation(IOhrozenaOsoba _ohrozenaOsoba);
        void DriveToAccident();
        void SafeManInDifficulty();
    }


    public class Hasic : Clovek, IHasic
    {
        public bool HasEquipment { get; set; }
        public string AccidentLocation { get; set; }


        public Hasic(string _name, string _location, bool _hasEquipment)
        {
            this.Name = _name;
            this.Location = _location;
            this.HasEquipment = _hasEquipment;
        }

        public void GetAccidentLocation(IOhrozenaOsoba _ohrozenaOsoba)
        {
            AccidentLocation = _ohrozenaOsoba.Location;
            
        }

        public void DriveToAccident()
        {
            Console.WriteLine($"Hasič: {this.Name} nastupuje do auta.");
            this.Location = AccidentLocation;
            Console.WriteLine($"Hasič: Úspěšně jsem se dostal do {this.Location}.");
        }

        public void SafeManInDifficulty()
        {
            if (HasEquipment == true)
            {
                Console.WriteLine("Hasič: Osoba zachráněna.");
            }
            else
            {
                Console.WriteLine("Hasič: K osvobození osoby je potřeba náležité vybavení.");
            }
        }

        public void OnPersonInDanger(object source, EventArgs args)
        {
            Console.WriteLine("Hasič: Person needs a help!");
        }
    }
}
