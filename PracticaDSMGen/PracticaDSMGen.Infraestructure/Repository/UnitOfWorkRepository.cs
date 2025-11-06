

using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;
using PracticaDSMGen.Infraestructure.Repository.PracticaDSM;
using PracticaDSMGen.Infraestructure.CP;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDSMGen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
SessionCPNHibernate session;


public UnitOfWorkRepository(SessionCPNHibernate session)
{
        this.session = session;
}

public override IReporteRepository ReporteRepository {
        get
        {
                this.reporterepository = new ReporteRepository ();
                this.reporterepository.setSessionCP (session);
                return this.reporterepository;
        }
}

public override IUsuarioRepository UsuarioRepository {
        get
        {
                this.usuariorepository = new UsuarioRepository ();
                this.usuariorepository.setSessionCP (session);
                return this.usuariorepository;
        }
}

public override IModeradorRepository ModeradorRepository {
        get
        {
                this.moderadorrepository = new ModeradorRepository ();
                this.moderadorrepository.setSessionCP (session);
                return this.moderadorrepository;
        }
}

public override ISoporteRepository SoporteRepository {
        get
        {
                this.soporterepository = new SoporteRepository ();
                this.soporterepository.setSessionCP (session);
                return this.soporterepository;
        }
}

public override IPedidoRepository PedidoRepository {
        get
        {
                this.pedidorepository = new PedidoRepository ();
                this.pedidorepository.setSessionCP (session);
                return this.pedidorepository;
        }
}

public override ITransaccionRepository TransaccionRepository {
        get
        {
                this.transaccionrepository = new TransaccionRepository ();
                this.transaccionrepository.setSessionCP (session);
                return this.transaccionrepository;
        }
}

public override IVendedorRepository VendedorRepository {
        get
        {
                this.vendedorrepository = new VendedorRepository ();
                this.vendedorrepository.setSessionCP (session);
                return this.vendedorrepository;
        }
}

public override IDesafioRepository DesafioRepository {
        get
        {
                this.desafiorepository = new DesafioRepository ();
                this.desafiorepository.setSessionCP (session);
                return this.desafiorepository;
        }
}

public override IInsigniaRepository InsigniaRepository {
        get
        {
                this.insigniarepository = new InsigniaRepository ();
                this.insigniarepository.setSessionCP (session);
                return this.insigniarepository;
        }
}

public override IVideojuegoRepository VideojuegoRepository {
        get
        {
                this.videojuegorepository = new VideojuegoRepository ();
                this.videojuegorepository.setSessionCP (session);
                return this.videojuegorepository;
        }
}

public override ICategoriaRepository CategoriaRepository {
        get
        {
                this.categoriarepository = new CategoriaRepository ();
                this.categoriarepository.setSessionCP (session);
                return this.categoriarepository;
        }
}
}
}

