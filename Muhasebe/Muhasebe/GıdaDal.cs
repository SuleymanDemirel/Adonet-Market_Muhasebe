using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    public class GıdaDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Gıda> GetAllGıda()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Gıdas", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Gıda> gıdas = new List<Gıda>();
            while (reader.Read())
            {
                Gıda gıda = new Gıda
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Ürün = reader["Ürün"].ToString(),
                    Adet = Convert.ToInt32(reader["Adet"]),
                    Fiyat = Convert.ToDouble(reader["Fiyat"]),
                };
                gıdas.Add(gıda);
            }
            reader.Close();
            _connection.Close();
            return gıdas;
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Gıda gıda)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Gıdas values(@Ürün,@Adet,@Fiyat)", _connection);
            command.Parameters.AddWithValue("@Ürün", gıda.Ürün);
            command.Parameters.AddWithValue("@Adet", gıda.Adet);
            command.Parameters.AddWithValue("@Fiyat", gıda.Fiyat);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Gıda gıda)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Gıdas set Ürün=@Ürün, Fiyat=@Fiyat,Adet=@Adet where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ürün", gıda.Ürün);
            command.Parameters.AddWithValue("@Adet", gıda.Adet);
            command.Parameters.AddWithValue("@Fiyat", gıda.Fiyat);
            command.Parameters.AddWithValue("@Id", gıda.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Gıdas where Id=@id", _connection);

            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }


    }
}
