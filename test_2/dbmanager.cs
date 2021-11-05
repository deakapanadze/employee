using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using test_2.Model;

namespace test_2
{
    

    public class dbmanager
    {
        public static string satestodea = ConfigurationManager.ConnectionStrings["satestodea"].ConnectionString;



        //წამოღება ბაზიდან

         public List<Class1> GetTable1()
         {
                List<Class1> list = new List<Class1>();

                SqlCommand cmd = new SqlCommand("[dbo].[GetEmployee]");

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlConnection conn = new SqlConnection(satestodea))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Class1 people = new Class1();
                       


                            people.Id = Convert.ToInt32(reader["Id"]);
                            people.Name = Convert.ToString(reader["Name"]);
                            people.Lastname = Convert.ToString(reader["Lastname"]);
                            people.Telephone = Convert.ToString(reader["Telephone"]);
                            people.Date = Convert.ToDateTime(reader["Date"]);
                   

                            list.Add(people);

                        }
                        reader.Close();
                    }
                    return list.ToList();
                 }
        }



        // დამატება ბაზაში


          public void insertEmp_sp (Class1 dea)
            {
                SqlCommand cmd = new SqlCommand("insertEmp_sp");

                cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.AddWithValue("@Name", dea.Name);
                 cmd.Parameters.AddWithValue("@Lastname", dea.Lastname);
                 cmd.Parameters.AddWithValue("@Telephone", dea.Telephone);
                 cmd.Parameters.AddWithValue("@Date", dea.Date);

                using (SqlConnection conn = new SqlConnection(satestodea))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteScalar();
                    conn.Close();
                }
            }

        public void Dlt_employee(int Id)
        {
            SqlCommand cmd = new SqlCommand("Dlt_employee");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", Id);

            using (SqlConnection conn = new SqlConnection(satestodea))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }



        }


        }

    }
