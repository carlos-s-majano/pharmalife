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
    class LotListController
    {
        private MySqlConnection mySqlConnection = new MySqlConnection();
        private Node inicio; //cabeza de la lista

        public LotListController()
        {
            inicio = null;
        }

        public void InsertIntoEnd(Lot lotToInsert)
        {
            Node auxiliar = new Node
            {
                lot = lotToInsert, //almacena en el atributo dato el valor recibido en el parámetro
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
                MessageBox.Show("Se insertaron [" + counter + "] lotes", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean InsertIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO lots(lot_code, datamatrix, price, expiration_date, product_id) VALUES(@lot_code, @datamatrix, @price, @expiration_date, @product_id);", this.mySqlConnection);
                command.Parameters.AddWithValue("@lot_code", nodeToSave.lot.LotCode);
                command.Parameters.AddWithValue("@datamatrix", nodeToSave.lot.Datamatrix);
                command.Parameters.AddWithValue("@price", nodeToSave.lot.Price);
                command.Parameters.AddWithValue("@expiration_date", nodeToSave.lot.ExpirationDate);
                command.Parameters.AddWithValue("@product_id", nodeToSave.lot.Product.Id);
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
                MessageBox.Show("Se actualizó [" + counter + "] lote", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean UpdateIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE lots SET lot_code = @lot_code, datamatrix = @datamatrix, price = @price, expiration_date = @expiration_date, product_id = @product_id WHERE id = @id;", this.mySqlConnection);
                command.Parameters.AddWithValue("@id", nodeToSave.lot.Id);
                command.Parameters.AddWithValue("@lot_code", nodeToSave.lot.LotCode);
                command.Parameters.AddWithValue("@datamatrix", nodeToSave.lot.Datamatrix);
                command.Parameters.AddWithValue("@price", nodeToSave.lot.Price);
                command.Parameters.AddWithValue("@expiration_date", nodeToSave.lot.ExpirationDate);
                command.Parameters.AddWithValue("@product_id", nodeToSave.lot.Product.Id);
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
                puntero.lot.Status = false;
                Boolean rst = this.DeleteIntoDb(puntero);
                if (rst == true) { counter++; }
                rst = false;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    rst = this.DeleteIntoDb(puntero);
                    if (rst == true) { counter++; }
                }
                MessageBox.Show("Se eliminó [" + counter + "] lote", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean DeleteIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE lots SET status = @status WHERE id = @id;", this.mySqlConnection);
                command.Parameters.AddWithValue("@id", nodeToSave.lot.Id);
                command.Parameters.AddWithValue("@status", nodeToSave.lot.Status);
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

        public void GetAllLots(DataGridView dgv)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT l.*, p.id AS p_id, p.name AS p_name, p.presentation AS p_presentation, p.provider_id AS p_provider_id, p.status AS p_status, pr.id AS pr_id, pr.name AS pr_name, pr.address AS pr_address, pr.phone AS pr_phone, pr.status AS pr_status FROM lots AS l LEFT JOIN products AS p ON p.id = l.product_id LEFT JOIN  providers AS pr ON pr.id = p.provider_id WHERE l.status = 1 ORDER BY l.lot_code ASC;", this.mySqlConnection);
                command.Prepare();
                if (command.IsPrepared)
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        this.inicio = null;
                        while (reader.Read())
                        {
                            Product product = new Product();
                            Provider provider = new Provider();
                            Lot lot = new Lot();

                            provider.Id = reader.GetString(reader.GetOrdinal("pr_id"));
                            provider.Name = reader.GetString(reader.GetOrdinal("pr_name"));
                            provider.Address = reader.GetString(reader.GetOrdinal("pr_address"));
                            provider.Phone = reader.GetString(reader.GetOrdinal("pr_phone"));
                            
                            product.Status = reader.GetBoolean(reader.GetOrdinal("pr_status"));
                            product.Id = reader.GetString(reader.GetOrdinal("p_id"));
                            product.Name = reader.GetString(reader.GetOrdinal("p_name"));
                            product.Presentation = reader.GetString(reader.GetOrdinal("p_presentation"));
                            product.Provider = provider;
                            product.Status = reader.GetBoolean(reader.GetOrdinal("p_status"));
                            
                            lot.Id = reader.GetString(reader.GetOrdinal("id"));
                            lot.LotCode = reader.GetString(reader.GetOrdinal("lot_code"));
                            lot.Datamatrix = reader.GetString(reader.GetOrdinal("datamatrix"));
                            lot.Price = reader.GetFloat(reader.GetOrdinal("price"));
                            lot.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("expiration_date"));
                            lot.Product = product;
                            lot.Status = reader.GetBoolean(reader.GetOrdinal("status"));

                            this.InsertIntoEnd(lot);
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
                dgv.Rows.Add(puntero.lot.Id, puntero.lot.LotCode, puntero.lot.Datamatrix, puntero.lot.Price, puntero.lot.ExpirationDate, puntero.lot.Product.Name);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    dgv.Rows.Add(puntero.lot.Id, puntero.lot.LotCode, puntero.lot.Datamatrix, puntero.lot.Price, puntero.lot.ExpirationDate, puntero.lot.Product.Name);
                }
            }
        }
    }
}
