using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class MaestrovsSubmodulo : BaseEntity
{
    public int IdModuloMaestro { get; set; }
    public ModuloMaestro ModuloMaestros { get; set; }
    public ICollection<GenericovsSubmodulo> genericovsSubmodulos { get; set; }
    public int IdSubmodulo { get; set; }
    public Submodulo Submodulos { get; set; }
}
