using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {

        //Variáveis 
        private int age;
        private Feed feedStatus;
        private Feed[] possibleFeedStatus;
        private Mood[] possibleMoodStatus;
        private Random rnd;

        
        //Propriedades
        public string Name {get; }
        public int Age {get; private set; } = 0;
        public Feed FeedStatus 
        {
            get => feedStatus;
            private set
            {
                feedStatus = value;
                if (feedStatus < Feed.Starving)
                    feedStatus = Feed.Starving;
                else if (feedStatus > Feed.AboutToExplode)
                    feedStatus = Feed.AboutToExplode;
            }
        }

        public Mood MoodStatus {get; private set; }

        // Construtor privado que inicializa o estado comum aos outros dois
        // construtores públicos
        private Cat(){

            rnd = new Random();

            Age = rnd.Next(22);
            possibleFeedStatus = (Feed[])Enum.GetValues(typeof(Feed));
            possibleMoodStatus = (Mood[])Enum.GetValues(typeof(Mood));

        }

        //Construtor que aceita o estado completo da instância
        public Cat(string name, int age, Feed feedStatus, Mood moodStatus) 
            : this()
        {
            Name = name;
            Age = age;
            FeedStatus = feedStatus;
            MoodStatus = moodStatus;
        }

        //Contrutor que aceita só o nome e define aleatóriamente o resto das
        //variáveis
        public Cat(string name) : this()
        {

            Name = name;

            FeedStatus = 
                possibleFeedStatus[rnd.Next(possibleFeedStatus.Length)];

            MoodStatus = 
                possibleMoodStatus[rnd.Next(possibleMoodStatus.Length)];

        }
        

    }
}