using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingCollections
{
    public class Building : IHasValue
    {
        public string Tipo {get; }

        public float Value {get; }

        public float Area {get;}

        public Building(string tipo, float value, float area)
        {
            Tipo = tipo;

            Value = value;

            Area = area;

        }

        public bool Equals (IHasValue other)
        {
            if (other == null)
                return false;
            
            if (this.Value == other.Value)
                return true;
            else
                return false;
        }

        public override string ToString() =>
            $"{Tipo,-20}{Value,8:f2}${Area,8:f2}m2";
    
    }
}