using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bovelo
{
    class Item
    {
        public int quantity ;
        // public int quantity{ get => _quantity; set => _quantity=value;}
        public Bike bike;
        public Item(Bike bike, int quantity)
        {
            this.quantity = quantity;
            this.bike = bike;
        }
    }
}