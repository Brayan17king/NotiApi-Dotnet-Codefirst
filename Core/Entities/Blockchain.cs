using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Blockchain : BaseEntity
{
    public string HasGenerado { get; set; }
    public int IdHiloRespuestaNotificacion { get; set; }
    public HiloRespuestaNotificacion HiloRespuestaNotificaciones { get; set; }
   public int IdAuditoria { get; set; }
   public Auditoria Auditorias { get; set; } 
   public int IdTipoNotificacion { get; set; }
   public TipoNotificacion TipoNotificaciones { get; set; }
}
