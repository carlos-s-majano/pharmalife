using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife
{
    class UserController
    {
        MySqlConnection mySqlConnection = new MySqlConnection();

        /**
         *  Method to verify if username and password are correct and exists in users table 
         */
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
                        /*while (reader.Read())
                        {
                            MessageBox.Show("Usuario: " + reader.GetString(reader.GetOrdinal("username")));
                            MessageBox.Show("Contraseña: " + reader.GetString(reader.GetOrdinal("password")));
                        }*/
                    }
                    else
                    {
                        //MessageBox.Show("Credenciales incorrectas");
                        
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