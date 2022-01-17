using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlastnostiRozhrani1.PlayingBehavior
{
    class DogPlayingBehavior : IPlayingBehavior
    {
        public string GameName { get; set; }
        public void DisplayGame()
        {
            Console.WriteLine("Hoof! Hoof! I am playing like a doggie dog!");
        }
    }
}
