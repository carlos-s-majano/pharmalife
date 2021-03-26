using MySql.Data.MySqlClient;
using Pharmalife.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife.Controllers
{
    class UserController
    {
        MySqlConnection mySqlConnection = new MySqlConnection();

        public Boolean loginVerify(String username, String password)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password LIMIT 1;", this.mySqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Prepare();
                if (command.IsPrepared)
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(MySqlException ex){
                MessageBox.Show("MySQLException: " + ex.Message);
                return false;
            }
            finally
            {
                this.mySqlConnection.Close();
            }
            return false;
        }
    }
}