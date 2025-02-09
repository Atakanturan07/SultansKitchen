using SultansKitchen.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
    public class CookTypeRepository : Connection
    {
        public int Add(Entity.CookType Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into CookType(Name) values(@Name) ";
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return ID;
            }
        }

        public bool Update(Entity.CookType Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update CookType set Name = @Name  where ID = @ID";

                cmd.Parameters.AddWithValue("@ID", Entity.ID);

                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;
            }
        }

        public List<Entity.CookType> GetAll()
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From CookType";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Entity.CookType> CookTypeList = new List<Entity.CookType>();
                while (dr.Read())
                {
                    Entity.CookType a = new Entity.CookType();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.Name = Convert.ToString(dr["Name"]);



                    CookTypeList.Add(a);


                }
                con.Close();
                return CookTypeList;
            }
        }

        public Entity.CookType Get(int ID)
        {
            using (var con = GetConnection)
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From CookType where ID=@ID";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.CookType CookType = new Entity.CookType();

                while (dr.Read())
                {
                    CookType.ID = Convert.ToInt32(dr["ID"]);
                    CookType.Name = Convert.ToString(dr["Name"]);
                }
                con.Close();
                return CookType;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from CookType where ID=@ID";

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
    

