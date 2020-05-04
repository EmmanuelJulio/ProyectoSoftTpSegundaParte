using ProyectoSoftware;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Entities
{
    public class Carrito : Entidad
    {
        public virtual Carrito_Producto CarritoNavigator { get; set; }
    }
}
