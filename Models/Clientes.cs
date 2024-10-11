using Microsoft.EntityFrameworkCore;

namespace ApiNet8.Models;

[PrimaryKey(nameof(id_cliente))]
public class Clientes {
    
    public Int32? id_cliente {get; set;}

    public string? nombres {get; set;}

    public string? apellidos {get; set;}

    public string? direccion {get; set;}

    public string? telefono {get; set;}

    public DateTime? fecha_nacimiento {get; set;}

}