using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public class Game_Logic
    {

        public int load_data { get; set; }
        public int spin_data { get; set; }
        public int shoot_data { get; set; }
        public int chances = 0;
        public int shoot_method()
        {
            if (load_data == spin_data)
            {
                return 1;
            }
            else if (spin_data == 6)
            {
                spin_data = 1;
                return 0;
            }
            else
            {
                spin_data++;
                return 0;
            }

        }
    }
}
      
      

