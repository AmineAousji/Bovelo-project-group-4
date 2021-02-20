using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    class App 
    {
        public List<User> userList;
        public List<Bike> BikeModel = new List<Bike>();

        public void InitializeBikeModel()
        {
            int i = 0;
            string connStr = "server=193.191.240.67;user=USER2;database=Bovelo;port=63304;password=USER2";
            MySqlConnection conn = new MySqlConnection(connStr);
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            string sql = "SELECT * FROM Bikes;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Bike myBike = new Bike((Convert.ToString(rdr[1]),Convert.ToInt32(rdr[2]));
                string Types = Convert.ToString(rdr[1]);
                int Prices = Convert.ToInt32(rdr[2]);

                Bike myBike = new Bike(Types, Prices);
                BikeModel.Add(myBike);

                Console.WriteLine(BikeModel[i].Type + " " + BikeModel[i].Price);
                i++;

                /*
                Console.WriteLine("TYPE: " + rdr[1]);
                Console.WriteLine("PRICE: " + rdr[2] + " �");
                Console.WriteLine("TIME TO BUILD: " + rdr[3]);*/
            }
            rdr.Close();
            conn.Close();
        }

        public App()
        {
            this.userList = new List<User>();
        }
        public void addNewUser(User user)
        {
            userList.Add(user);
        }
        public void addNewAdmin(User user)
        {
            user.isAdmin = true;
            userList.Add(user);
        }

    }
}