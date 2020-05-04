using System;

namespace PS.Template.Domain.Entities
{
    public class Entidad
    {
        public int id;
        private DateTime fechaIncercion;

        public int Id { get => id; set => id = value; }
        public DateTime FechaIncercion { get => fechaIncercion; set => fechaIncercion = value; }
    }
}
