using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
   
    public class DBManager
    {
        public static String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shital\source\repos\YouFrame\YouFrame\App_Data\Images.mdf;Integrated Security=True";



        public static bool insert(String image)
        {
            // Console.WriteLine("In insert method");
            bool status = false;
            String sqlQuery = "INSERT INTO imagedb(image)" +
                "values(@image)";

            IDbConnection con = new SqlConnection();
            con.ConnectionString = constring;

            IDbCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlQuery;

            // set parameters 
            cmd.Parameters.Add(new SqlParameter("@image", image));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;

            }
            catch (SqlException exp)
            {

                throw exp;
            }
            finally
            {
                con.Close();
            }

            return status;
        }

        //get all image
        public static List<Imagedb> getAllImage()
        {

            List<Imagedb> img = new List<Imagedb>();



            string sqlQuery = "SELECT * FROM imagedb";

            IDbConnection con = new SqlConnection();

            con.ConnectionString = constring;

            IDbCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlQuery;

            IDataReader reader = null;

            try
            {

                con.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())//Read--->same as HasNext check next valuy
                {
                    Imagedb imagedb = new Imagedb();

                    imagedb.id = int.Parse(reader["Id"].ToString());
                    imagedb.image = reader["image"].ToString();

                    img.Add(imagedb);

                }
            }
            catch (SqlException exp)
            {
                throw exp;
            }
            finally
            {
                con.Close();
            }
            return img;
        }




    



    }
}
