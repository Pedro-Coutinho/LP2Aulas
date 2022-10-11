using System;

namespace GameInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasValue[] unitsAndBuildings = new IHasValue[5];
            unitsAndBuildings[0] = new Building("Casa",10, 30);
            unitsAndBuildings[1] = new SettlerUnit(2, 10);
            unitsAndBuildings[2] = new MilitaryUnit(7, 20, 1);
            unitsAndBuildings[3] = new SettlerUnit(4, 7);
            unitsAndBuildings[4] = new Building("Prédio",100, 20);

            foreach (IHasValue something in unitsAndBuildings)
            {
                Console.WriteLine(something);
            }
        }
    }
}
