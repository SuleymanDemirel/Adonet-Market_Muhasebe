using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Ürün = reader["Ürün"].ToString(),
                    Adet = Convert.ToInt32(reader["Adet"]),
                    Fiyat = Convert.ToDouble(reader["Fiyat"]),
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }




        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }


        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@Ürün,@Adet,@Fiyat)", _connection);
            command.Parameters.AddWithValue("@Ürün", product.Ürün);
            command.Parameters.AddWithValue("@Adet", product.Adet);
            command.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Ürün=@Ürün, Fiyat=@Fiyat,Adet=@Adet where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ürün", product.Ürün);
            command.Parameters.AddWithValue("@Adet", product.Adet);
            command.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
          
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

    }
}
