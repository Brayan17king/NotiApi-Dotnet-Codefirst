using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Core.Entities;

public class Auditoria : BaseEntity
{
    public string NombreUsuario { get; set; }
    public int DesAccion { get; set; }
    public ICollection<Blockchain> Blockchains { get; set; }
}
