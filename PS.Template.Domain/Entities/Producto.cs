using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Entities
{
    public class Producto 
    {
        int id;
        DateTime fechadeactualizaion;
        string codigo;
        string marca;
        string nombre;
        decimal precio;

      
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Fechadeactualizaion { get => fechadeactualizaion; set => fechadeactualizaion = value; }
    }
}
