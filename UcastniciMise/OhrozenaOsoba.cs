using System;
using System.Collections.Generic;
using System.Text;

namespace UcastniciMise
{
    public enum DangerState
    {
        Alright,
        Threat,
        Danger,
        NotSafe
    }

    public interface IOhrozenaOsoba
    {
        string Name { get; set; }
        string Location { get; set; }
        DangerState PersonState { get; set; }

        void GetPersonState();
        void CallForHelp();
    }

    public class OhrozenaOsoba : Clovek, IOhrozenaOsoba
    {
        public DangerState PersonState { get; set; }

        public delegate void PersonInDangerEventHandler(object source, EventArgs args);

        public event PersonInDangerEventHandler PersonInDanger;


        public OhrozenaOsoba(string _name, string _location)
        {
            this.Name = _name;
            this.Location = _location;
        }

        public void GetPersonState()
        {
            Console.WriteLine($"Osoba: Nacházím se v: {Location} a svuj stav bych zhodnotil/a jako {PersonState}");
        }

        public void CallForHelp()
        {
            Console.WriteLine("Osoba: Oh hello... Is this a fire station? I might need some help.");
            OnPersonInDanger();
        }

        protected virtual void OnPersonInDanger()
        {
            PersonInDanger?.Invoke(this, EventArgs.Empty);
        }
    }
}
