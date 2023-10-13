using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class BlockchainDto
    {
        public int Id { get; set; }
        public string HasGenerado { get; set; }
        public int IdHiloRespuestaNotificacion { get; set; }
        public int IdAuditoria { get; set; }
        public int IdTipoNotificacion { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public DateOnly FechaModificacion { get; set; }

    }
}