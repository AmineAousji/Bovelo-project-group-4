using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    //maybe differenciate into 2 classes (bikeModel which is linked to BikePart(with totaltime,price,type)) and this class which is used only for the orders or be me more logical between app and bike...
    class Bike 
    {
         public DateTime TotalTime = DateTime.Now;
         public int Price = 0;
         public bool  isBuilt = false;

         private string _BikeType = " ";
         private string _BikeColor = " ";
         private int _BikeSize = 0;  
         //private BikePart[] Parts = new BikePart[]{};
         
        public string Type{ get => _BikeType; set => _BikeType = value;}
        public string Color{ get => _BikeColor; set => _BikeColor = value;}
        public int Size{ get => _BikeSize; set => _BikeSize = value;}

        public Bike(string Type,string Color,int Size,int price)
        {
            _BikeType = Type;
            _BikeColor = Color;
            _BikeSize = Size;
            this.Price = price;
        }

    }

}




