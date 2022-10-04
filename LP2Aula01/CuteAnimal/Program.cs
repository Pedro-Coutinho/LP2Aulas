using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Ramsey");
            Cat c2 = new Cat("Varys");
            Cat c3 = new Cat("Theon");

            Console.WriteLine("\tName:{0} | Age:{1} | Food:{2} | Mood:{3}",
                c1.Name, c1.Age, c1.FeedStatus, c1.MoodStatus);
            Console.WriteLine("\tName:{0} | Age:{1} | Food:{2} | Mood:{3}",
                c2.Name, c2.Age, c2.FeedStatus, c2.MoodStatus);
            Console.WriteLine("\tName:{0} | Age:{1} | Food:{2} | Mood:{3}",
                c3.Name, c3.Age, c3.FeedStatus, c3.MoodStatus);
            
        }
    }
}
