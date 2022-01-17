using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlastnostiRozhrani1.PlayingBehavior
{
    class CatPlayingBehavior : IPlayingBehavior
    {
        public string GameName { get; set; }
        public void DisplayGame()
        {
            Console.WriteLine("Meow! Meow! I am playing like cattie cat!");
        }
       
    }
}
