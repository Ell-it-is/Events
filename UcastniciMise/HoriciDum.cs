using System;
using System.Collections.Generic;
using System.Text;

namespace UcastniciMise
{
    public enum BuildingState
    {
        New,
        Renovated,
        Older,
        VeryOld
    }

    public class HoriciDum : Dum
    {
        public BuildingState HouseState { get; set; }
        public bool ArePeopleInside { get; set; }

        public HoriciDum(string _adress, BuildingState _houseState, bool _peopleInside)
        {
            this.Adress = _adress;
            this.HouseState = _houseState;
            this.ArePeopleInside = _peopleInside;
        }
    }
}
