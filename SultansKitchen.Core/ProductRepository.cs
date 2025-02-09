using SultansKitchen.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SultansKitchen.Core
{
    public class ProductRepository : Connection
    {
        public int Add(Entity.Product Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into Product(Name,Price) values(@Name,@Price) ";
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                cmd.Parameters.AddWithValue("@Price", Entity.Price);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return ID;
            }
        }

        public bool Update(Entity.Product Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update Product set Name = @Name , Price = @Price where ID = @ID";

                cmd.Parameters.AddWithValue("@ID", Entity.ID);
                cmd.Parameters.AddWithValue("@Price", Entity.Price);
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;
            }
        }

        public List<Entity.Product> GetAll()
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Product";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Entity.Product> ProductList = new List<Entity.Product>();
                while (dr.Read())
                {
                    Entity.Product a = new Entity.Product();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.Name = Convert.ToString(dr["Name"]);
                    a.Price = Convert.ToDecimal(dr["Price"]);




                    ProductList.Add(a);


                }
                con.Close();
                return ProductList;
            }
        }

        public Entity.Product Get(int ID)
        {
            using (var con = GetConnection)
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Product where ID=@ID";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.Product Product = new Entity.Product();

                while (dr.Read())
                {
                    Product.ID = Convert.ToInt32(dr["ID"]);
                    Product.Name = Convert.ToString(dr["Name"]);
                    Product.Price = Convert.ToDecimal(dr["Price"]);
                }
                con.Close();
                return Product;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from Product where ID=@ID";

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.Connection = con;

                con.Open();


                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;


            }
        }
    }
}
