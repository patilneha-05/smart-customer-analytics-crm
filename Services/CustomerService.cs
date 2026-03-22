using MySql.Data.MySqlClient;
using SmartCRM.Models;

namespace SmartCRM.Services
{
    public class CustomerService
    {
        private readonly string connectionString =
            "Server=localhost;Database=smartcrm;Uid=root;Pwd=root;";

        public List<Customer> GetAll()
        {
            var list = new List<Customer>();

            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                var cmd = new MySqlCommand("SELECT * FROM customers", conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Customer
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Email = reader.GetString("email"),
                        Phone = reader.GetString("phone")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        public void Add(Customer c)
        {
            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                var cmd = new MySqlCommand(
                    "INSERT INTO customers(name,email,phone) VALUES(@n,@e,@p)", conn);

                cmd.Parameters.AddWithValue("@n", c.Name);
                cmd.Parameters.AddWithValue("@e", c.Email);
                cmd.Parameters.AddWithValue("@p", c.Phone);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Customer c)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            var cmd = new MySqlCommand(
                "UPDATE customers SET name=@n,email=@e,phone=@p WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@n", c.Name);
            cmd.Parameters.AddWithValue("@e", c.Email);
            cmd.Parameters.AddWithValue("@p", c.Phone);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            var cmd = new MySqlCommand("DELETE FROM customers WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}