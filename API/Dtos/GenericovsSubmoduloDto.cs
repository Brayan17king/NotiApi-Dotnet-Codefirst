using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class GenericovsSubmoduloDto
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public int IdPermisosGenericos { get; set; }
        public int IdMaestrovsSubmodulo { get; set; }
    }
}