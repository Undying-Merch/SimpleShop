using SimpleShopModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShopORM
{
    public class ORM_MsSql : IORM
    {

        private SqlConnection dbConn;
        private string host = "localhost";
        private string username = "sa";
        private string password = "Admin12345";
        private string database = "SimpleShopData";

        public ORM_MsSql()
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder()
            {
                InitialCatalog = database,
                UserID = username,
                Password = password,
                DataSource = host
            };

            dbConn = new SqlConnection(connString.ToString());
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = null;

            string query = "SELECT id, navn FROM kunde WHERE id = @val";
            SqlCommand cmd = new SqlCommand(query, dbConn);
            cmd.Parameters.AddWithValue("@val", id);

            if (dbConn.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    dbConn.Open();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

            return customer;
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
