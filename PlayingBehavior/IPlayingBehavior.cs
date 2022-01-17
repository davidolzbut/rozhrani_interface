using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlastnostiRozhrani1.PlayingBehavior
{
    interface IPlayingBehavior
    {
        string GameName { get; set; }
        void DisplayGame();
    }
}
