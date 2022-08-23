using ExceptionsIndexerTask.Models;
using System;

namespace ExceptionsIndexerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Room room1 = new Room("Sirius",50,4);
            Room room2 = new Room("Neptun", 100, 2);
            Room room3 = new Room("Kainat", 200, 5);


            //  room1.ShowInfo();
            //room2.ShowInfo();
            //room3.ShowInfo();
            //Hotel Kainat = new Hotel { Name = "Kainat",Rooms = new Room[] { room1, room2, room3 } };
            //Console.WriteLine(Kainat.Rooms[2]); 
            Hotel Kainat = new Hotel("Coders",15);
            Kainat.AddRoom(room1);
            Kainat.AddRoom(room2);
            Kainat.AddRoom(room3);
            Kainat[0].ShowInfo();
            Kainat[1].ShowInfo();
          
            

        }
    }
}
