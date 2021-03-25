using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife
{
   class ProductListController
    {
        MySqlConnection mySqlConnection = new MySqlConnection(); 
        public Node inicio; //cabeza de la lista

        //constructor por defecto
        public ProductListController()
        {
            inicio = null;
        }

        //metodo para insertar al final de la lista
        public void insertIntoEnd(Product productToInsert)
        {
            Node auxiliar = new Node(); //Node temporal que todavia no pertenece a la lista
            auxiliar.product = productToInsert; //almacena en el atributo dato el valor recibido en el parámetro
            auxiliar.siguiente = null; // hace que el apuntador señale a null

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

        public void save()
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
                Boolean rst = this.insertIntoDb(puntero);
                if(rst == true){ counter++; }
                rst = false;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    rst = this.insertIntoDb(puntero);
                    if (rst == true) { counter++; }
                }
                MessageBox.Show("Se insertaron [" + counter + "] productos", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Boolean insertIntoDb(Node nodeToSave)
        {
            try
            {
                this.mySqlConnection = Connection.connectToDb();
                this.mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO products(name, presentation) VALUES(@name, @presentation);", this.mySqlConnection);
                command.Parameters.AddWithValue("@name", nodeToSave.product.Name);
                command.Parameters.AddWithValue("@presentation", nodeToSave.product.Presentation);
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

        public void fillDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();
            if (inicio == null)
            {
                return;
            }
            else
            {
                int counter = 0;
                Node puntero;
                puntero = inicio;
                dgv.Rows.Add(puntero.product.Name, puntero.product.Presentation);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    dgv.Rows.Add(puntero.product.Name, puntero.product.Presentation);
                }
            }
        }

        /*

        public void InsertarI(int item)
        {
            Node auxiliar = new Node();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Node puntero;
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
            }

        }

        public void EliminarI()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacía no se puede eliminar el elemento");
            }

            else
            {
                inicio = inicio.siguiente;
            }
        }

        public void EliminarF()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacía no se puede eliminar el elemento");
            }
            else
            {
                Node punteroant, punteropost;
                punteroant = inicio;
                punteropost = inicio;

                while (punteropost.siguiente != null)
                {
                    punteroant = punteropost;
                    punteropost = punteropost.siguiente;
                }
                punteroant.siguiente = null;
            }
        }


        public void InsertarP(int item, int pos)
        {
            Node auxiliar = new Node();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                Console.WriteLine("Lista está vacía por la tanto se va a insertar en la 1ra posición");
                inicio = auxiliar;
            }
            else
            {
                Node puntero;
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                        {
                            Console.WriteLine("Posición no existe se agregará el valor al final");
                            break;
                        }
                    }

                    Node punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = auxiliar;
                    auxiliar.siguiente = punteronext;
                }
            }
        }

        public void mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Node puntero;
                puntero = inicio;
                Console.Write("{0} -> \t", puntero.dato);

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> \t", puntero.dato);
                }
            }

            Console.WriteLine();
        }

        

        public void listaAscendete()
        {
            Boolean bandera = false;
            Node puntero, nuevo;
            do
            {
                bandera = false;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    if (puntero.dato > puntero.siguiente.dato)
                    {
                        int temp;
                        nuevo = puntero.siguiente;
                        temp = puntero.dato;
                        puntero.dato = nuevo.dato;
                        nuevo.dato = temp;
                        bandera = true;
                    }
                    puntero = puntero.siguiente;
                }
                puntero = inicio;
            } while (bandera);

        }*/
    }
}
