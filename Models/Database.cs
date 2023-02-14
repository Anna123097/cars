using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace cars.Models
{
    public class Database
    {
        string path = "server=46.101.172.75;user=bogdanius00102;database=cars;password=Starik_H0tabuch;";
        public List<Car> GetCar()
        {
            List<Car> Cars = new List<Car>();
            MySqlConnection connection = new MySqlConnection(path);
            connection.Open();
            string request = "SELECT id, marka, model, year, toplivo,color,price,image FROM car;";
            MySqlCommand command = new MySqlCommand(request, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Car p = new Car();
                p.id = (int)reader[0];
                p.marka = (string)reader[1];
                p.model = (string)reader[2];
                p.year = (int)reader[3];
                p.toplivo = (string)reader[4];
                p.color = (string)reader[5];
                p.price = (int)reader[6];
                p.image = (string)reader[7];
                Cars.Add(p);
            }
            return Cars;
        }


        public List<Car> GetCarByToplevo(string toplevo)
        {
            List<Car> Cars = new List<Car>();
            MySqlConnection connection = new MySqlConnection(path);
            connection.Open();
            string request = "SELECT id, marka, model, year, toplivo,color,price,image FROM car WHERE toplivo = '"+toplevo+"'";
            MySqlCommand command = new MySqlCommand(request, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Car p = new Car();
                p.id = (int)reader[0];
                p.marka = (string)reader[1];
                p.model = (string)reader[2];
                p.year = (int)reader[3];
                p.toplivo = (string)reader[4];
                p.color = (string)reader[5];
                p.price = (int)reader[6];
                p.image = (string)reader[7];
                Cars.Add(p);
            }
            return Cars;
        }

        public Car GetCarById(int id)
        {
            Car auto = new Car();
            MySqlConnection connection = new MySqlConnection(path);
            connection.Open();
            string request = "SELECT id, marka, model, year, toplivo,color,price,image FROM car WHERE id = '"+id+"'";
            MySqlCommand command = new MySqlCommand(request, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Car p = new Car();
                p.id = (int)reader[0];
                p.marka = (string)reader[1];
                p.model = (string)reader[2];
                p.year = (int)reader[3];
                p.toplivo = (string)reader[4];
                p.color = (string)reader[5];
                p.price = (int)reader[6];
                p.image = (string)reader[7];
                auto = p;
            }
            return auto;
        }

    }
}
