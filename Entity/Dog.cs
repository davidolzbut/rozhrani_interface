using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vlastnostiRozhrani1.PlayingBehavior;

namespace vlastnostiRozhrani1.Entity
{
    class Dog : IAnimal
    {
        public IPlayingBehavior playingBehavior { get; set; } = new DogPlayingBehavior();
        public void Play()
        {
            playingBehavior.DisplayGame();
        }
        
        
        
        
        /*
        private string _name;        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //public string Name { get; set; }

        public string rasa { get; set; }
        public int pocetNohou { get; private set; }
        public int pocetUsi { get; }
        public string barvaOci { private get; set; }
    
        */
    }
}
