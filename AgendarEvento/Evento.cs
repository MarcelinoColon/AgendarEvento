using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendarEvento
{
    public class Evento
    {
        public int EventoId { get; set; }
        public int ClienteId { get; set; }
        public int ComboId { get; set; }
        public string TipoEvento { get; set; }
        public string FechaEvento { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin {  get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public string Paquete { get; set; }
        public string Animacion { get; set; }
        public string NotasAdicionales { get; set; }


        public Evento() { }

        public Evento(int eventoId, int clienteId, int comboId, string tipoEvento, string fechaEvento, string horaInicio, string horaFin, string direccion, string descripcion, string paquete, string animacion, string notasAdicionales)
        {
            this.EventoId = eventoId;
            this.ClienteId = clienteId;
            this.ComboId = comboId;
            this.TipoEvento = tipoEvento;
            this.FechaEvento = fechaEvento;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Direccion = direccion;
            this.Descripcion = descripcion;
            this.Paquete = paquete;
            this.Animacion = animacion;
            this.NotasAdicionales = notasAdicionales;
        }
    }
}
