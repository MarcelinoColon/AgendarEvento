using System;

public class Cliente
{
    public int ClienteId { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Cedula { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string OtroContacto { get; set; }

    public Cliente() { }


    public Cliente(int clienteId, string nombre, string email, string cedula, string telefono, string direccion, string otroContacto)
    {
        this.ClienteId = clienteId;
        this.Nombre = nombre;
        this.Email = email;
        this.Cedula = cedula;
        this.Telefono = telefono;
        this.Direccion = direccion;
        this.OtroContacto = otroContacto;
    }
}
