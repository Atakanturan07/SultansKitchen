using SultansKitchen.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
    public class FoodRepository : Connection
    {
        public int Add(Entity.Food Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into Food(Name ,CategoryID ,Image ,Level ,Calory ,Capacity ,Description ,CookTime ,CookTypeID) values(@Name , @CategoryID , @Image , @Level , @Calory , @Capacity , @Description , @CookTime , @CookTypeID) select scope_identity()";
                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                cmd.Parameters.AddWithValue("@Image", Entity.Image);
                cmd.Parameters.AddWithValue("@CategoryID", Entity.CategoryID);
                cmd.Parameters.AddWithValue("@Level", Entity.Level);
                cmd.Parameters.AddWithValue("@Calory", Entity.Calory);
                cmd.Parameters.AddWithValue("@Capacity", Entity.Capacity);
                cmd.Parameters.AddWithValue("@Description", Entity.Description);
                cmd.Parameters.AddWithValue("@CookTime", Entity.CookTime);
                cmd.Parameters.AddWithValue("@CookTypeID", Entity.CookTypeID);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return ID;
            }
        }

        public bool Update(Entity.Food Entity)
        {
            using (var con = GetConnection)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update Food set Name = @Name ,CategoryID =@CategoryID , Image = @Image , Level=@Level , Calory=@Calory , Capacity=@Capacity , Description=@Description , CookTime=@CookTime , CookTypeID=@CookTypeID where ID = @ID";

                cmd.Parameters.AddWithValue("@ID", Entity.ID);

                cmd.Parameters.AddWithValue("@Name", Entity.Name);
                cmd.Parameters.AddWithValue("@Image", Entity.Image);
                cmd.Parameters.AddWithValue("@CategoryID", Entity.CategoryID);
                cmd.Parameters.AddWithValue("@Level", Entity.Level);
                cmd.Parameters.AddWithValue("@Calory", Entity.Calory);
                cmd.Parameters.AddWithValue("@Capacity", Entity.Capacity);
                cmd.Parameters.AddWithValue("@Description", Entity.Description);
                cmd.Parameters.AddWithValue("@CookTime", Entity.CookTime);
                cmd.Parameters.AddWithValue("@CookTypeID", Entity.CookTypeID);

                bool Control = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return Control;
            }
        }

        public List<Food> GetAll()
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"Select * From Food ";
                List<Food> FoodLİst = new List<Food>();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Food a = new Food();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.Name = Convert.ToString(dr["Name"]);
                    //a.Image = Convert.ToDecimal(dr["Image"]);
                    a.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                    a.Level = Convert.ToInt32(dr["Level"]);
                    a.Calory = Convert.ToDecimal(dr["Calory"]);
                    a.Capacity = Convert.ToInt32(dr["Capacity"]);
                    a.Description = Convert.ToString(dr["Description"]);
                    a.CookTime = Convert.ToInt32(dr["CookTime"]);
                    a.CookTypeID = Convert.ToInt32(dr["CookTypeID"]);




                    FoodLİst.Add(a);


                }
                con.Close();
                return FoodLİst;
            }
        }

        public Entity.Food Get(int ID)
        {
            using (var con = GetConnection)
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From Food where ID=@ID";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                Entity.Food Food= new Entity.Food();

                while (dr.Read())
                {
                    Food.ID = Convert.ToInt32(dr["ID"]);
                    Food.Name = Convert.ToString(dr["Name"]);
                    //Food.Image = Convert.ToByte[](dr["Image"]);
                    Food.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                    Food.Level = Convert.ToInt32(dr["Level"]);
                    Food.Calory = Convert.ToDecimal(dr["Calory"]);
                    Food.Capacity = Convert.ToInt32(dr["Capacity"]);
                    Food.Description = Convert.ToString(dr["Description"]);
                    Food.CookTime = Convert.ToInt32(dr["CookTime"]);
                    Food.CookTypeID = Convert.ToInt32(dr["CookTypeID"]);
                }
                con.Close();
                return Food;
            }
        }

        public bool Delete(int ID)
        {
            using (var con = GetConnection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"delete from Food where ID=@ID";

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
