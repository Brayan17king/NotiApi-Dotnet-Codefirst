using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {

        IAuditoria Auditorias { get;}
        IBlockchain Blockchains { get;}
        IEstadoNotificacion EstadoNotificaciones { get;}
        IFormato Formatos { get;}
        IGenericovsSubmodulo GenericovsSubmodulos { get;}
        IHiloRespuestaNotificacion HiloRespuestaNotificaciones { get;}
        IMaestrovsSubmodulo MaestrovsSubmodulos { get;}
        IModuloMaestro ModuloMaestros { get;}
        IPermisosGenerico PermisosGenericos { get;}
        IRadicado Radicados { get;}
        IRol Roles { get;}
        IRolvsMaestro RolvsMaestros { get;}
        ISubmodulo Submodulos { get;}
        ITipoNotificacion TipoNotificaciones { get;}
        ITipoRequerimiento TipoRequerimientos { get;}
        Task<int> SaveAsync();
    }
}