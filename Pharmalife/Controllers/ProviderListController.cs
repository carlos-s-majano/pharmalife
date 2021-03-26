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
    class ProviderListController
    {
        private MySqlConnection mySqlConnection = new MySqlConnection();
        private Node inicio; //cabeza de la lista

        //constructor por defecto
        public ProviderListController()
        {
            inicio = null;
        }

        //metodo para insertar al final de la lista
        public void InsertIntoEnd(Provider providerToInsert)
        {
            Node auxiliar = new Node
            {
                provider = providerToInsert, //almacena en el atributo dato el valor recibido en el parámetro
                siguiente = null // hace que el apuntador señale a null
            }; //Node temporal que todavia no pertenece a la lista

            if (inicio == null) //verifica si la lista está vacia
            {
                inicio = auxiliar; //hacemos que Node sea parte de la lista, lo hacemos la cabeza
            }
            else
            {
                Node puntero; //utilizamos este Node para rrecorrer la lista así no se mueve la cabeza
                puntero = inicio; //situamos a puntero señalando al mismo Node que inicio

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //se dezplaza por todos los elementos de la lista
                }
                puntero.siguiente = auxiliar; //hacemos que el ultimo Node señale a auxiliar
            }
        }

        public void Insert()
        {
            if (inicio == null)
            {
                MessageBox.Show("La lista está vacía, no existen para guardar", "LISTA VACÍA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int counter = 0;
                Node puntero;
                puntero = inicio;
                Boolean rst = this.InsertIntoDb(puntero);
                if (rst == true) { counter++; }
                rst = false;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    rst = this.InsertIntoDb(puntero);
                    if (rst == true) { counter++; }
                }
                MessageBox.Show("Se insertaron [" + counter + "] proveedores", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Update()
        {
            if (inicio == null)
            {
                MessageBox.Show("La lista está vacía, no existen para guardar", "LISTA VACÍA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int counter = 0;
                Node puntero;
                puntero = inicio;
                Boolean rst = this.UpdateIntoDb(puntero);
                if (rst == true) { counter++; }
                rst = false;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    rst = this.UpdateIntoDb(puntero);
                    if (rst == true) { counter++; }
                }
                MessageBox.Show("Se actualizó [" + counter + "] proveedor", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Delete()
        {
            if (inicio == null)
            {
                MessageBox.Show("La lista está vacía, no existen para guardar", "LISTA VACÍA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int counter = 0;
                Node puntero;
                puntero = inicio;
                puntero.provider.Status = false;
                Boolean rst = this.DeleteIntoDb(puntero);
                if (rst == true) { counter++; }
                rst = false;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    rst = this.DeleteIntoDb(puntero);
                    if (rst == true) { counter++; }
                }
                MessageBox.Show("Se eliminó [" + counter + "] proveedor", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean InsertIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO providers(name, address, phone) VALUES(@name, @address, @phone);", this.mySqlConnection);
                command.Parameters.AddWithValue("@name", nodeToSave.provider.Name);
                command.Parameters.AddWithValue("@address", nodeToSave.provider.Address);
                command.Parameters.AddWithValue("@phone", nodeToSave.provider.Phone);
                command.Prepare();
                if (command.IsPrepared)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLException: " + ex.Message);
                return false;
            }
            finally
            {
                this.mySqlConnection.Close();
            }
            return false;
        }

        public Boolean UpdateIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE providers SET name = @name, address=@address, phone=@phone WHERE id = @id;", this.mySqlConnection);
                command.Parameters.AddWithValue("@id", nodeToSave.provider.Id);
                command.Parameters.AddWithValue("@name", nodeToSave.provider.Name);
                command.Parameters.AddWithValue("@address", nodeToSave.provider.Address);
                command.Parameters.AddWithValue("@phone", nodeToSave.provider.Phone);
                command.Prepare();
                if (command.IsPrepared)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLException: " + ex.Message);
                return false;
            }
            finally
            {
                this.mySqlConnection.Close();
            }
            return false;
        }

        public Boolean DeleteIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE providers SET status = @status WHERE id = @id;", this.mySqlConnection);
                command.Parameters.AddWithValue("@id", nodeToSave.provider.Id);
                command.Parameters.AddWithValue("@status", nodeToSave.provider.Status);
                command.Prepare();
                if (command.IsPrepared)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLException: " + ex.Message);
                return false;
            }
            finally
            {
                this.mySqlConnection.Close();
            }
            return false;
        }

        public Provider GetProvider(String name)
        {
            Provider provider = new Provider();
            if (inicio == null)
            {
                return provider;
            }
            else
            {
                Node puntero;
                puntero = inicio;
                if (puntero.provider.Name == name)
                {
                    provider.Id = puntero.provider.Id;
                    provider.Name = puntero.provider.Name;
                    provider.Address = puntero.provider.Address;
                    provider.Phone = puntero.provider.Phone;
                    return provider;
                }

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    if (puntero.provider.Name == name)
                    {
                        provider.Id = puntero.provider.Id;
                        provider.Name = puntero.provider.Name;
                        provider.Address = puntero.provider.Address;
                        provider.Phone = puntero.provider.Phone;
                        return provider;
                    }
                }
            }
            return provider;
        }

        public void GetAllProviders()
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM providers WHERE status=1;", this.mySqlConnection);
                command.Prepare();
                if (command.IsPrepared)
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Provider provider = new Provider();
                            provider.Id = reader.GetString(reader.GetOrdinal("id"));
                            provider.Name = reader.GetString(reader.GetOrdinal("name"));
                            provider.Address = reader.GetString(reader.GetOrdinal("address"));
                            provider.Phone = reader.GetString(reader.GetOrdinal("phone"));
                            this.InsertIntoEnd(provider);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLException: " + ex.Message);
            }
            finally
            {
                this.mySqlConnection.Close();
            }
        }

        public void GetAllProviders(DataGridView dgv)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM providers WHERE status = 1;", this.mySqlConnection);
                command.Prepare();
                if (command.IsPrepared)
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        this.inicio = null;
                        while (reader.Read())
                        {
                            Provider provider = new Provider();
                            provider.Id = reader.GetString(reader.GetOrdinal("id"));
                            provider.Name = reader.GetString(reader.GetOrdinal("name"));
                            provider.Address = reader.GetString(reader.GetOrdinal("address"));
                            provider.Phone = reader.GetString(reader.GetOrdinal("phone"));
                            this.InsertIntoEnd(provider);
                        }
                        this.FillDataGridView(dgv);
                        this.inicio = null;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLException: " + ex.Message);
            }
            finally
            {
                this.mySqlConnection.Close();
            }
        }

        public void FillComboBox(ComboBox cbo)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM providers WHERE status = 1;", this.mySqlConnection);
                command.Prepare();
                if (command.IsPrepared)
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Provider provider = new Provider();
                            provider.Id = reader.GetString(reader.GetOrdinal("id"));
                            provider.Name = reader.GetString(reader.GetOrdinal("name"));
                            provider.Address = reader.GetString(reader.GetOrdinal("address"));
                            provider.Phone = reader.GetString(reader.GetOrdinal("phone"));
                            this.InsertIntoEnd(provider);
                            cbo.Items.Add(reader.GetString(reader.GetOrdinal("name")));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLException: " + ex.Message);
            }
            finally
            {
                this.mySqlConnection.Close();
            }
        }

        public void FillDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.DataSource = null;
            dgv.Refresh();
            if (inicio == null)
            {
                return;
            }
            else
            {
                Node puntero;
                puntero = inicio;
                dgv.Rows.Add(puntero.provider.Id, puntero.provider.Name, puntero.provider.Address, puntero.provider.Phone);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    dgv.Rows.Add(puntero.provider.Id, puntero.provider.Name, puntero.provider.Address, puntero.provider.Phone);
                }
            }
        }
    }
}
