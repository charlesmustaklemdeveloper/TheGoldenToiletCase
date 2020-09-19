using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleGame0326.Character1;

namespace ConsoleGame0326
{
    public class Character1
    {
        public string name;
        public bool sword = false;
        public bool gun = false;
        public bool ammo = false;
        public bool shield = false;
        public bool readyToFight = false;
        public bool readyToEscape = false;
        

        
        public Dictionary<string, int> inventory = new Dictionary<string, int>();
        

        public void character(string _name)
        {
            name = _name;
        }

       
        
      
    }
}

