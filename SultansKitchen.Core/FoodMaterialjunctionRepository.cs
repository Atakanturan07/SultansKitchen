using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
    public class FoodMaterialjunctionRepository : Connection
    {
        public int Add(Entity.FoodMaterialJunction Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into FoodMaterialJunction(FoodID,MaterialID,UnitID,Amount) values(@Name,@FoodID,@MaterialID,@UnitID,@Amount) select scope_identity()";
                cmd.Parameters.AddWithValue("@FoodID", Entity.FoodID);
                cmd.Parameters.AddWithValue("@MaterialID", Entity.MaterialID);
                cmd.Parameters.AddWithValue("@UnitID", Entity.UnitID);
                cmd.Parameters.AddWithValue("@Amount", Entity.Amount);

                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return ID;
            }
        }

        public bool Update(Entity.FoodMaterialJunction Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update FoodMaterialJunction set FoodID = @FoodID , MaterialID = @MaterialID , UnitID = @UnitID , Amount = @Amount  where ID = @ID";

                cmd.Parameters.AddWithValue("@ID", Entity.ID);
                cmd.Parameters.AddWithValue("@FoodID", Entity.FoodID);
                cmd.Parameters.AddWithValue("@MaterialID", Entity.MaterialID);
                cmd.Parameters.AddWithValue("@UnitID", Entity.UnitID);
                cmd.Parameters.AddWithValue("@Amount", Entity.Amount);
                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;
            }
        }

        public List<Entity.FoodMaterialJunction> GetAll()
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From FoodMaterialJunction";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Entity.FoodMaterialJunction> FoodMaterialJunctionList = new List<Entity.FoodMaterialJunction>();
                while (dr.Read())
                {
                    Entity.FoodMaterialJunction a = new Entity.FoodMaterialJunction();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.FoodID = Convert.ToInt32(dr["FoodID"]);
                    a.MaterialID = Convert.ToInt32(dr["MaterialID"]);
                    a.UnitID = Convert.ToInt32(dr["UnitID"]);
                    a.Amount = Convert.ToInt32(dr["Amount"]);



                    FoodMaterialJunctionList.Add(a);


                }
                con.Close();
                return FoodMaterialJunctionList;
            }
        }

        public Entity.FoodMaterialJunction Get(int ID)
        {
            using (var con = GetConnection)
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From FoodMaterialJunction where ID=@ID";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.FoodMaterialJunction FoodMaterialJunction = new Entity.FoodMaterialJunction();

                while (dr.Read())
                {
                    FoodMaterialJunction.ID = Convert.ToInt32(dr["ID"]);
                    FoodMaterialJunction.FoodID = Convert.ToInt32(dr["FoodID"]);
                    FoodMaterialJunction.MaterialID = Convert.ToInt32(dr["MaterialID"]);
                    FoodMaterialJunction.UnitID = Convert.ToInt32(dr["UnitID"]);
                    FoodMaterialJunction.Amount = Convert.ToInt32(dr["Amount"]);

                }
                con.Close();
                return FoodMaterialJunction;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from FoodMaterialJunction where ID=@ID";

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
