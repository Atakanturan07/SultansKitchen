using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
    public class LoginRepository :Connection
    {
        public Entity.Users Login(String Username,String Password)
        {
            using(var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"select * from Users where UserName = @UserName and Password = @Password";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@UserName", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.Users user = new Entity.Users();
                while (dr.Read())
                {
                    user.ID = Convert.ToInt32(dr["ID"]);
                    user.Name = dr["Name"].ToString();
                    user.UserName = dr["UserName"].ToString();
                    user.Password = dr["Password"].ToString();
                }
                con.Close();
                return user;
            }

        }
    }
}
