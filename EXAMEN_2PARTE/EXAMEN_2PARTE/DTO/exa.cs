using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_2PARTE.DTO
{
    class exa
    {

        public exa(string fecha, int dia, int mes, int codigo_Ver, string vendedor, int producto, string nombre_Producto,
            int linea, string nombre_Linea, string cliente, string precio, int cantidad)
        {
            Fecha = fecha;
            Dia = dia;
            Mes = mes;
            Codigo_Ver = codigo_Ver;
            Vendedor = vendedor;
            Producto = producto;
            Nombre_Producto = nombre_Producto;
            Linea = linea;
            Nombre_Linea = nombre_Linea;
            Cliente = cliente;
            Precio = precio;
            this.cantidad = cantidad;
        }

        public String Fecha { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Codigo_Ver { get; set; }
        public String Vendedor { set; get; }
        public int Producto { get; set;}
        public String Nombre_Producto { get; set; }
        public int Linea { get; set; }
        public String Nombre_Linea { get; set; }
        public String Cliente { get; set; }
        public String Precio { get; set; }
        public int cantidad { get; set; }
    }
}
