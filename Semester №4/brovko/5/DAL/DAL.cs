using System;
using System.Collections.Generic;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class dal
    {
        public static string GetPassword(string user)
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString;
            string pass = "";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand com = new SqlCommand("[GetPassword]", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@user", user));
                con.Open();
                object obj = com.ExecuteScalar();
                con.Close();
                if (obj != null) pass = obj.ToString();
            }
            return pass;
        }

        public static void AddUser(string user, string password, string fullName)
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                
                SqlCommand com = new SqlCommand("[AddUser]", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@user", user));
                com.Parameters.Add(new SqlParameter("@password", password));
                com.Parameters.Add(new SqlParameter("@fullName", fullName));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void AddMessege(string from, string to, string sub, string body, DateTime date)
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand com = new SqlCommand("[AddMessege]", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@from", from));
                com.Parameters.Add(new SqlParameter("@to", to));
                com.Parameters.Add(new SqlParameter("@sub", sub));
                com.Parameters.Add(new SqlParameter("@body", body));
                com.Parameters.Add(new SqlParameter("@date", date));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        public static List<Messege> GetMesseges(string user)
        {
            List<Messege> messeges = new List<Messege>();
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DB1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand com = new SqlCommand("[GetMesseges]", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@user", user));
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Messege m = new Messege();
                    m.Id = (int)reader["MsgId"];
                    m.To = reader["MsgTo"].ToString();
                    m.From = reader["MsgFrom"].ToString();
                    m.Sub = reader["MsgSub"].ToString();
                    m.Body = reader["MsgBody"].ToString();
                    m.Date = (DateTime)reader["MsgDate"];
                    messeges.Add(m);
                }
                con.Close();
            }
            return messeges;
        }
    }
}
