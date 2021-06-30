using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    class Lista
    {
        public Nodo primero, ultimo, anterior, T;
        int bandera;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        #region Inserciones
        public void InsertarInicio(string id, string nom, int cant, double total, DataGridView dgv)
        {
            Nodo q = new Nodo();

            q.IdProducto = id;
            q.Nombre = nom;
            q.Cantidad = cant;
            q.Total = total;

            q.siguiente = primero;
            primero = q;

            MessageBox.Show($"Se han insertado correctamente los datos del producto con id {id} al inicio", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void InsertarFinal(string id, string nom, int cant, double total, DataGridView dgv)
        {
            Nodo q = new Nodo();
            T = primero;

            q.IdProducto = id;
            q.Nombre = nom;
            q.Cantidad = cant;
            q.Total = total;

            if (primero == null)
            {
                q.siguiente = primero;
                primero = q;
                ultimo = q;
            }
            else
            {
                while (T.siguiente != null)
                {
                    T = T.siguiente;
                }
                q.siguiente = null;
                T.siguiente = q;
            }
            MessageBox.Show($"Se han insertado correctamente los datos del producto con id {id} al final", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void InsertarAntesX(string id, string nom, int cant, double total, string x)
        {
            Nodo q = primero;
            bandera = 1;
            Nodo T = new Nodo();


            while (q.IdProducto != x && bandera == 1)
            {
                if (q.siguiente != null)
                {
                    T = q;
                    q = q.siguiente;
                }
                else
                {
                    bandera = 0;
                }
            }
            if (bandera == 1)
            {
                Nodo k = new Nodo(id, nom, cant, total);

                if (primero == q)
                {
                    k.siguiente = primero;
                    primero = k;
                }
                else
                {
                    T.siguiente = k;
                    k.siguiente = q;
                }
                MessageBox.Show($"Nodo insertado correctamente antes de {x}");
            }
            else
            {
                MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InsertarDespuesX(string id, string nom, int cant, double total, string x)
        {
            Nodo q = primero;
            bandera = 1;

            while (q.IdProducto != x && bandera == 1)
            {
                if (q.siguiente != null)
                {
                    q = q.siguiente;
                }
                else
                {
                    bandera = 0;
                }
            }
            if (bandera == 1)
            {
                Nodo T = new Nodo(id, nom, cant, total);

                T.siguiente = q.siguiente;
                q.siguiente = T;
                MessageBox.Show($"Nodo insertado correctamente despues de {x}");
            }
            else
            {
                MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eliminacion
        public void EliminarInicio()
        {
            if (primero != null)
            {
                Nodo q = primero;
                MessageBox.Show($"Ha salido el nodo con id {primero.IdProducto}");
                primero = q.siguiente;
                q = null;
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void EliminarFinal()
        {
            Nodo q = primero;

            if (primero == null)
            {
                MessageBox.Show("La lista esta vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (primero.siguiente == null)
                {
                    primero = null;
                }
                else
                {
                    while (q.siguiente != null)
                    {
                        T = q;
                        q = q.siguiente;
                    }
                    MessageBox.Show($"Se ha eliminado el nodo con id {q.IdProducto}");
                    T.siguiente = null;
                }
            }
        }
        public void EliminarX(string x)
        {
            Nodo q = primero;
            bandera = 1;

            while (q.IdProducto != x && bandera == 1)
            {
                if (q.siguiente != null)
                {
                    T = q;
                    q = q.siguiente;
                }
                else
                {
                    bandera = 0;
                }
            }
            if (bandera == 1)
            {
                if (primero == q)
                {
                    primero = q.siguiente;
                }
                else
                {
                    T.siguiente = q.siguiente;
                }
                MessageBox.Show($"Ha salido el nodo con id {x}");
            }
            else
            {
                MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            q = null;
        }
        public void EliminarAntesX(string x)
        {
            if (primero.IdProducto == x)
            {
                MessageBox.Show($"No existe un nodo que preceda a {x}");
            }
            else
            {
                Nodo q = primero;
                bandera = 1;
                T = primero;

                while (q.IdProducto != x && bandera == 1)
                {
                    if (q.siguiente != null)
                    {
                        anterior = T;
                        T = q;
                        q = q.siguiente;
                    }
                    else
                    {
                        bandera = 0;
                    }
                }
                if (bandera == 1)
                {
                    if (primero.siguiente == q)
                    {
                        primero = q;
                    }
                    else
                    {
                        anterior.siguiente = q;
                    }
                    anterior = null;
                    MessageBox.Show($"Ha salido el nodo que precede a {x}");
                }
                else
                {
                    MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void EliminarDespuesX(string x)
        {
            if (primero.IdProducto == x && primero.siguiente == null)
            {
                MessageBox.Show("Solo hay un nodo, no hay ninguno posterior a él");
            }
            else
            {
                Nodo q = primero;
                bandera = 1;

                while (q.IdProducto != x && bandera == 1)
                {
                    if (q.siguiente != null)
                    {
                        q = q.siguiente;
                        anterior = q;
                        T = anterior.siguiente;
                    }
                    else
                    {
                        bandera = 0;
                    }
                }
                if (bandera == 1)
                {
                    if (primero.IdProducto == x)
                    {
                        T = q.siguiente;
                        primero.siguiente = T.siguiente;
                    }
                    else
                    {
                        if (T == null)
                        {
                            MessageBox.Show("No puedes establecer el ultimo nodo como referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            anterior.siguiente = T.siguiente;
                        }
                        T = null;
                        MessageBox.Show($"Se ha eliminado el nodo que se encuentra posterior a {x}");
                    }
                }
                else
                {
                    MessageBox.Show("El nodo no se encuentra en la lista");
                }
            }
        }
        #endregion

        #region Busquedas
        public void BusquedaDesordenada(string x)
        {
            Nodo q = primero;

            while (q != null && q.IdProducto != x)
            {
                q = q.siguiente;
            }
            if (q == null)
            {
                MessageBox.Show("El elemento no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"El producto se encuentra en la lista, su informacion es la siguiente \nId:{q.IdProducto} \nNombre:{q.Nombre}\nCantidad:{q.Cantidad}\nTotal:{q.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void BusquedaOrdenada(string x)
        {
            Nodo q = primero;

            while ((q != null) && (q.IdProducto != x))
            {
                q = q.siguiente;
            }
            if ((q == null) || (q.IdProducto != x))
            {
                MessageBox.Show($"El elemento {x} no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"El producto se encuentra en la lista, su informacion es la siguiente \nId:{q.IdProducto} \nNombre:{q.Nombre}\nCantidad:{q.Cantidad}\nTotal:{q.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void BusquedaRecursiva(Nodo q, string x)
        {
            if (q != null)
            {
                if (q.IdProducto == x)
                {
                    MessageBox.Show($"El producto se encuentra en la lista, su informacion es la siguiente \nId:{q.IdProducto} \nNombre:{q.Nombre}\nCantidad:{q.Cantidad}\nTotal:{q.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BusquedaRecursiva(q.siguiente, x);
                }
            }
            else
            {
                MessageBox.Show("El elemento no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Recorridos
        public void RecorridoIterativo(DataGridView dgv)
        {
            Nodo q = new Nodo();
             q = primero;

            if (primero != null)
            {
                while (q != null)
                {
                    MessageBox.Show($"Id:{q.IdProducto} \nNombre:{q.Nombre}\nCantidad:{q.Cantidad}\nTotal:{q.Total}");
                    q = q.siguiente;
                }
            }
            else
            {
                MessageBox.Show($"La lista se encuentra vacia");
            }
        }
        public void RecorridoRecursivo(Nodo q)
        {
            if (q == null)
            {
                MessageBox.Show("La lista esta vacia");
            }
            if (q != null)
            {
                MessageBox.Show($"Id:{q.IdProducto} \nNombre:{q.Nombre}\nCantidad:{q.Cantidad}\nTotal:{q.Total}");
                RecorridoRecursivo(q.siguiente);
            }
            else
            {
                MessageBox.Show("Esta es toda la lista");
            }       
        }
        #endregion

        #region Mostrar
        public void Mostrar(DataGridView dgv)
        {
            Nodo q = new Nodo();
            q = primero;
            dgv.Rows.Clear();

            if (primero != null)
            {
                while (q != null)
                {
                    dgv.Rows.Add(q.IdProducto, q.Nombre, q.Cantidad, q.Total);
                    q = q.siguiente;
                }
            }
            else
            {
                MessageBox.Show($"La lista se encuentra vacia");
            }
        }
        #endregion
    }
}
