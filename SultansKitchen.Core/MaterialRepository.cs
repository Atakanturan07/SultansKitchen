using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
    public class MaterialRepository : Connection
    {
        public int Add(Entity.Material Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into Material(Name) values(@Name) select scope_identity()";
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return ID;
            }
        }

        public bool Update(Entity.Material Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update Material set Name = @Name  where ID = @ID";

                cmd.Parameters.AddWithValue("@ID", Entity.ID);

                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;
            }
        }

        public List<Entity.Material> GetAll()
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Material";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Entity.Material> MaterialList = new List<Entity.Material>();
                while (dr.Read())
                {
                    Entity.Material a = new Entity.Material();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.Name = Convert.ToString(dr["Name"]);



                    MaterialList.Add(a);


                }
                con.Close();
                return MaterialList;
            }
        }

        public Entity.Material Get(int ID)
        {
            using (var con = GetConnection)
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Material where ID=@ID";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.Material Material = new Entity.Material();

                while (dr.Read())
                {
                    Material.ID = Convert.ToInt32(dr["ID"]);
                    Material.Name = Convert.ToString(dr["Name"]);
                }
                con.Close();
                return Material;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from Material where ID=@ID";

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
