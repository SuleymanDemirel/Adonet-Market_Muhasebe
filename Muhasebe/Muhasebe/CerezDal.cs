using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
   public class CerezDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Cerez> GetAllCerez()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Cerezs", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Cerez> cerezs = new List<Cerez>();
            while (reader.Read())
            {
                Cerez cerez = new Cerez
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Ürün = reader["Ürün"].ToString(),
                    Adet = Convert.ToInt32(reader["Adet"]),
                    Fiyat = Convert.ToDouble(reader["Fiyat"]),
                };
                cerezs.Add(cerez);
            }
            reader.Close();
            _connection.Close();
            return cerezs;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Cerez cerez)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Cerezs values(@Ürün,@Adet,@Fiyat)", _connection);
            command.Parameters.AddWithValue("@Ürün", cerez.Ürün);
            command.Parameters.AddWithValue("@Adet", cerez.Adet);
            command.Parameters.AddWithValue("@Fiyat", cerez.Fiyat);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Cerez cerez)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Cerezs set Ürün=@Ürün, Fiyat=@Fiyat,Adet=@Adet where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ürün", cerez.Ürün);
            command.Parameters.AddWithValue("@Adet", cerez.Adet);
            command.Parameters.AddWithValue("@Fiyat", cerez.Fiyat);
            command.Parameters.AddWithValue("@Id", cerez.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Cerezs where Id=@id", _connection);

            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }


    }
}
