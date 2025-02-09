using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
    public class CategoryRepository : Connection
    {
        public int ID = 0;


        public int Add(Entity.Category Entity)
        {
            
            {
                using (var con = GetConnection)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into Category (Name, Image) values (@Name, @Image) select scope_identity()";
                    cmd.Parameters.AddWithValue("@Name", Entity.Name);
                    cmd.Parameters.AddWithValue("@Image", Entity.Image);

                    con.Open();

                    int ID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return ID;
                }
            }
            
          } 


        public bool Update(Entity.Category Entity)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Category Set Name=@Name, Image=@Image where ID=@ID";
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                cmd.Parameters.AddWithValue("@Image", Entity.Image);
                cmd.Parameters.AddWithValue("@ID", Entity.ID);

                con.Open();

                // sorguyu çalıştır ve etkilenen satır sayısını al..
                int affectedRowsCount = cmd.ExecuteNonQuery();

                con.Close();

                // etkilenen satır sayısı 0'dan büyükse, işlem başarılıdır, true olarak dönülür..
                return affectedRowsCount > 0;
            }
        }
        public bool Update2(Entity.Category entity)
        {

            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Category Set Name=@Name where ID=@ID";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@ID", entity.ID);


                con.Open();

                int affectedRowsCount = cmd.ExecuteNonQuery();
                con.Close();

                return affectedRowsCount > 0;
            }
        }

        public List<Entity.Category> GetAll()
        {
            using (SqlCommand cmd = GetConnection.CreateCommand())
            {

                cmd.CommandText = "select * from Category";
                List<Entity.Category> CategoryList = new List<Entity.Category>();

                GetConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entity.Category Category = new Entity.Category();
                    Category.ID = Convert.ToInt32(dr["ID"]);
                    Category.Name = dr["Name"].ToString();
                    Category.Image = (byte[])dr["Image"];

                    CategoryList.Add(Category);
                }
                GetConnection.Close();

                return CategoryList;
            }
        }

        public Entity.Category Get(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Category where ID=@ID";
                cmd.Parameters.AddWithValue("@ID", ID);

                Entity.Category Category = new Entity.Category();

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category.ID = Convert.ToInt32(dr["ID"]);
                    Category.Name = dr["Name"].ToString();
                    Category.Image = (byte[])dr["Image"];
                }

                con.Close();
                return Category;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Category where ID=@ID";
                cmd.Parameters.AddWithValue("@ID", ID);

                con.Open();
                // sorguyu çalıştır ve etkilnen satır sayısını al..
                int affectedRowsCount = cmd.ExecuteNonQuery();
                con.Close();

                // etkilenen satır sayısı 0'dan büyükse, işlem başarılıdır, true olarak dönülür..
                return affectedRowsCount > 0;
            }
        }
    }
}

    

