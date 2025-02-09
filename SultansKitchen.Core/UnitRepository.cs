using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
  public   class UnitRepository : Connection 
    {
        public int Add(Entity.Unit Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into Unit(Name) values(@Name) select scope_identity()";
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return ID;
            }
        }

        public bool Update(Entity.Unit Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update Unit set Name = @Name where ID = @ID";

                cmd.Parameters.AddWithValue("@ID", Entity.ID);

                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;
            }
        }

        public List<Entity.Unit> GetAll()
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Unit";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Entity.Unit> UnitList = new List<Entity.Unit>();
                while (dr.Read())
                {
                    Entity.Unit a = new Entity.Unit();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.Name = Convert.ToString(dr["Name"]);


                    UnitList.Add(a);


                }
                con.Close();
                return UnitList;
            }
        }

        public Entity.Unit Get(int ID)
        {
            using (var con = GetConnection)
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Unit where ID=@ID";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.Unit Unit = new Entity.Unit();

                while (dr.Read())
                {
                    Unit.ID = Convert.ToInt32(dr["ID"]);
                    Unit.Name = Convert.ToString(dr["Name"]);
                }
                con.Close();
                return Unit;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from Unit where ID=@ID";

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
