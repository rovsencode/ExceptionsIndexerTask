using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexerTask.Models
{
    class Room
    {
        private  static int id ;
        private int roomid;
        private string _name;
        private int _price;
        private int _personCapacity;
        private bool _isAvaliable = true;

        public string Name 
        {
            get{return _name;}
            set
            {
                if (value.Length>0)
                {
                    _name = value;
                }
                }
        }
        public int  Price
        {
            get{return _price;}
            set{
                if (value>0)
                {
                    _price = value;
                }
             
            }
        }
        public int PersonCapacity 
        {
            get { return _personCapacity; }
            set { _personCapacity = value; } 
            
        }
        public bool IsAvaliable
        {
            get { return _isAvaliable; }
            set { _isAvaliable = value; } 
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + Name + "\nPrice:" + Price + "\nPersonCapacity:" + PersonCapacity + "\nIsAvalibale:" + IsAvaliable + "\nID:"+roomid);
        }
        public override string ToString()
        {
            ShowInfo();
            return "";
        }
        public Room(string Name, int Price, int PersonCapacity)
        {
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
             roomid=++id;
              
        }
        public int Id { get { return roomid; } }

    }
}
