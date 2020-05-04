using ProyectoSoftware;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Entities
{
    public class Carrito_Producto : Entidad
    {
        ICollection<Producto> productos;

        public ICollection<Producto> Productos { get => productos; set => productos = value; }
    }
}
