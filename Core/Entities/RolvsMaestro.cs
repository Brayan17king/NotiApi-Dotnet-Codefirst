using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class RolvsMaestro : BaseEntity
{
    public int IdRol { get; set; }
    public Rol Roles { get; set; }
    public int IdModuloMaestro { get; set; }
    public ModuloMaestro ModuloMaestros { get; set; }

}
