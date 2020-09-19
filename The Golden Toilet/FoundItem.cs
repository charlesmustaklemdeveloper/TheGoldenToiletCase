using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleGame0326.Character1;

namespace ConsoleGame0326
{
    public class FoundItem
    {
        public void Items(Rooms room, Character1 character)
        {
            Console.WriteLine($"You have found a {Convert.ToString(room)}");
            Console.WriteLine($"The {room} has been added to your inventory");
            character.inventory.Add(Convert.ToString(room), Convert.ToInt32(room));
        }
    }
}
