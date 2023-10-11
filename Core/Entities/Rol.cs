using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Rol : BaseEntity
{
    public string NombreRol { get; set; }
    public ICollection<RolvsMaestro> RolvsMaestros { get; set; }
    public ICollection<GenericovsSubmodulo> GenericovsSubmodulos { get; set; }
    
}
