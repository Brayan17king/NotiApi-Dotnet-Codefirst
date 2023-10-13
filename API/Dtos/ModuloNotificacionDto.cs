using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ModuloNotificacionDto
    {
        public int Id { get; set; }
        public string AsuntoNotificacion { get; set; }
        public string TextoNotificacion { get; set; }
        public int IdRadicados { get; set; }
        public int IdFormato { get; set; }
        public int IdHiloRespuestaNotificacion { get; set; }
        public int IdTipoNotificacion { get; set; }
        public int IdEstadoNotificacion { get; set; }
        public int IdTipoRequerimiento { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public DateOnly FechaModificacion { get; set; }
    }
}