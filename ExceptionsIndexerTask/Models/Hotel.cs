using ExceptionsIndexerTask.Utilites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexerTask.Models
{
    class Hotel
    {

        private string _name;
        private Room[] _rooms;
        private int count;

        public string Name { get { return _name; } set { _name = value; } }
        public Room this[int index] {
            get
            {
                if (index<_rooms.Length)
                {
                    return _rooms[index];
                }
                throw new Exception();
            }
            set
            {
                if (index<_rooms.Length)
                {
                    _rooms[index] = value;
                }
                throw new Exception();
            }
            
        }

        public  void AddRoom(Room room)
        { 
         
              if(_rooms.Length>count)
            
            {
                _rooms[count] = room;
                count++;
            }
        }
        public Hotel(string Name,int length)
        {
            this.Name = Name;
            _rooms = new Room[length];
        }

        public void Reserve(int? roomid)
        {
            foreach (Room item in _rooms)
            {
                if (item.Id==roomid)
                {
                    if (item.IsAvaliable)
                    {
                        item.IsAvaliable = false;
                        Console.WriteLine("it is reserved");
                        return;
                    }
                    throw new NotAvaliableException("it is not avaliable room");
                }
            }
            throw new NotFoundException("Room is  not found ");
           
            

            
        }
    }
}
