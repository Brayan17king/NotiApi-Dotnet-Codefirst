using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class GenericovsSubmodulo : BaseEntity
{
    public int IdRol { get; set; }
    public Rol Roles { get; set; }
    public int IdPermisosGenericos { get; set; }
    public PermisosGenerico PermisosGenericos { get; set; }
    public int IdMaestrovsSubmodulo { get; set; }
    public MaestrovsSubmodulo MaestrovsSubmodulos { get; set; }
}
