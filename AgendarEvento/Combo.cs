using System;

namespace AgendarEvento
{
    public class Combo
    {
        public int Comboid { get; set; }
        public string Nombre { get; set; }    
        public string Descripcion { get; set; }

        public Combo() { }

        public Combo (int Comboid, string Nombre, string Descripcion)
        {
            this.Comboid = Comboid;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }


    }
}
