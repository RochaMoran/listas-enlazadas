using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos
{
    class Nodo
    {
        public Nodo siguiente { get; set; }
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public Nodo()
        {

        }
        public Nodo(string id, string nom, int cant, double total)
        {
            IdProducto = id;
            Nombre = nom;
            Cantidad = cant;
            Total = total;
        }
    }
}
