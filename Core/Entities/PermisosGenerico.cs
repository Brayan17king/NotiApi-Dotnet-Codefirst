using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class PermisosGenerico : BaseEntity
{
    public string MyProperty { get; set; }
    public ICollection<GenericovsSubmodulo> GenericovsSubmodulos { get; set; }
}
