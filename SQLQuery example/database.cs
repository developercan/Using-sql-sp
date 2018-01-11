using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQLQuery_example
{
    class database
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        #region Md5 Hash
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
#endregion

        public database()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-V56QKFA\sqlexpress;Initial Catalog=query-example;Integrated Security=True";
            comm.Connection = conn;
            conn.Open();
            comm.CommandType = CommandType.StoredProcedure;
        }

       public void Login(string username,string password)
        {
            password = CreateMD5(password);
            comm.CommandText = "sp_user_login";
            comm.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
            comm.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            comm.Parameters.Add("@id", SqlDbType.Int);
            comm.Parameters["@id"].Direction = ParameterDirection.Output;

            comm.ExecuteNonQuery();
            try
            {
                string id = comm.Parameters["@id"].Value.ToString();
                if (id != null && id != "")
                {
                    MessageBox.Show("User id: " + id,"Idendtity Number",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add_user(string Name,string Surname,string Username,string Password)
        {
            Password = CreateMD5(Password);
            try
            {
                comm.CommandText = "Add_user";
                comm.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
                comm.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = Surname;
                comm.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
                comm.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
                comm.ExecuteNonQuery();
                MessageBox.Show("Registration Successful", "Successful", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred while recording:" + Ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
