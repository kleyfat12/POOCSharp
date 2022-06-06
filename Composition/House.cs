using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class House
    {
        private Room room;
        private string name;

        public House(string name, string roomName)
        {
            this.name = name;
            room = new Room(roomName); 
        }

        public void Show()
        {
            Console.WriteLine($"House {name}");
            room.Show();
        }
    }
}
