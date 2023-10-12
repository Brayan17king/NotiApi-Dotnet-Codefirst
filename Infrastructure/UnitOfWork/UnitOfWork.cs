using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NotiAppContext _context;
        public AuditoriaRepository _Auditorias { get; set; }
        public BlockchainRepository _Blockchains { get; set; }
        public EstadoNotificacionRepository _EstadoNotificaciones { get; set; }
        public FormatoRepository _Formatos { get; set; }
        public GenericovsSubmoduloRepository _GenericovsSubmodulos { get; set; }
        public HiloRespuestaNotificacionRepository _HiloRespuestaNotificaciones { get; set; }
        public MaestrovsSubmoduloRepository _MaestrovsSubmodulos { get; set; }
        public ModuloMaestroRepository _ModuloMaestros { get; set; }
        public ModuloNotificacionRepository _ModuloNotificaciones { get; set; }
        public PermisosGenericoRepository _PermisosGenericos { get; set; }
        public RadicadoRepository _Radicados { get; set; }
        public RolRepository _Roles { get; set; }
        public RolvsMaestroRepository _RolvsMaestros { get; set; }
        public SubmoduloRepository _Submodulos { get; set; }
        public TipoNotificacionRepository _TipoNotificaciones { get; set; }
        public TipoRequerimientoRepository _TipoRequerimientos { get; set; }

        public IAuditoria Auditorias
        {
            get
            {
                if (_Auditorias == null)
                {
                    _Auditorias = new AuditoriaRepository(_context);
                }
                return _Auditorias;
            }
        }

        public IBlockchain Blockchains
        {
            get
            {
                if (_Blockchains == null)
                {
                    _Blockchains = new BlockchainRepository(_context);
                }
                return _Blockchains;
            }
        }

        public IEstadoNotificacion EstadoNotificaciones
        {
            get
            {
                if (_EstadoNotificaciones == null)
                {
                    _EstadoNotificaciones = new EstadoNotificacionRepository(_context);
                }
                return _EstadoNotificaciones;
            }
        }

        public IFormato Formatos
        {
            get
            {
                if (_Formatos == null)
                {
                    _Formatos = new FormatoRepository(_context);
                }
                return _Formatos;
            }
        }

        public IGenericovsSubmodulo GenericovsSubmodulos
        {
            get
            {
                if (_GenericovsSubmodulos == null)
                {
                    _GenericovsSubmodulos = new GenericovsSubmoduloRepository(_context);
                }
                return _GenericovsSubmodulos;
            }
        }

        public IHiloRespuestaNotificacion HiloRespuestaNotificaciones
        {
            get
            {
                if (_HiloRespuestaNotificaciones == null)
                {
                    _HiloRespuestaNotificaciones = new HiloRespuestaNotificacionRepository(_context);
                }
                return _HiloRespuestaNotificaciones;
            }
        }

        public IMaestrovsSubmodulo MaestrovsSubmodulos
        {
            get
            {
                if (_MaestrovsSubmodulos == null)
                {
                    _MaestrovsSubmodulos = new MaestrovsSubmoduloRepository(_context);
                }
                return _MaestrovsSubmodulos;
            }
        }

        public IModuloMaestro ModuloMaestros
        {
            get
            {
                if (_ModuloMaestros == null)
                {
                    _ModuloMaestros = new ModuloMaestroRepository(_context);
                }
                return _ModuloMaestros;
            }
        }

        public IModuloNotificacion ModuloNotificaciones
        {
            get
            {
                if (_ModuloNotificaciones == null)
                {
                    _ModuloNotificaciones = new ModuloNotificacionRepository(_context);
                }
                return _ModuloNotificaciones;
            }
        }

        public IPermisosGenerico PermisosGenericos
        {
            get
            {
                if (_PermisosGenericos == null)
                {
                    _PermisosGenericos = new PermisosGenericoRepository(_context);
                }
                return _PermisosGenericos;
            }
        }

        public IRadicado Radicados
        {
            get
            {
                if (_Radicados == null)
                {
                    _Radicados = new RadicadoRepository(_context);
                }
                return _Radicados;
            }
        }

        public IRol Roles
        {
            get
            {
                if (_Roles == null)
                {
                    _Roles = new RolRepository(_context);
                }
                return _Roles;
            }
        }

        public IRolvsMaestro RolvsMaestros
        {
            get
            {
                if (_RolvsMaestros == null)
                {
                    _RolvsMaestros = new RolvsMaestroRepository(_context);
                }
                return _RolvsMaestros;
            }
        }

        public ISubmodulo Submodulos
        {
            get
            {
                if (_Submodulos == null)
                {
                    _Submodulos = new SubmoduloRepository(_context);
                }
                return _Submodulos;
            }
        }

        public ITipoNotificacion TipoNotificaciones
        {
            get
            {
                if (_TipoNotificaciones == null)
                {
                    _TipoNotificaciones = new TipoNotificacionRepository(_context);
                }
                return _TipoNotificaciones;
            }
        }

        public ITipoRequerimiento TipoRequerimientos
        {
            get
            {
                if (_TipoRequerimientos == null)
                {
                    _TipoRequerimientos = new TipoRequerimientoRepository(_context);
                }
                return _TipoRequerimientos;
            }
        }

        public UnitOfWork(NotiAppContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}