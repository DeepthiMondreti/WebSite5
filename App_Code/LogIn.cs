using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for LogIn
/// </summary>
public class LogIn
{
    SqlConnection connect;
    public LogIn()
    {
        connect = new SqlConnection
            (ConfigurationManager.ConnectionStrings
            ["AutomartConnectionString"].ConnectionString);
    }
    public int Validate(string user, string pass)
    {
        int result = 0;
        PasswordHash ph = new PasswordHash();
        string sql = "Select PersonKey, CustomerPassCode, CustomerHashedPassword From Customer.RegisteredCustomer Where Email = @User";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.Add("@User", user);

        SqlDataReader reader;
        int passCode = 0;
        byte[] originalPassword = null;
        int personKey = 0;

        connect.Open();
        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                passCode = (int)reader["CustomerPasscode"];
                originalPassword = (byte[])reader["CustomerHashedPassword"];
                personKey = (int)reader["Personkey"];
            }

            byte[] newhash = ph.HashIt(pass, passCode.ToString());

            if (newhash.SequenceEqual(originalPassword))
            {
                result = personKey;
            }
        }
        connect.Close();
        return result;
    }
}