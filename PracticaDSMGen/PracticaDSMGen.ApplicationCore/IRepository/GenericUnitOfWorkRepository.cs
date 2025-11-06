
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public abstract class GenericUnitOfWorkRepository
{
protected IReporteRepository reporterepository;
protected IUsuarioRepository usuariorepository;
protected IModeradorRepository moderadorrepository;
protected ISoporteRepository soporterepository;
protected IPedidoRepository pedidorepository;
protected ITransaccionRepository transaccionrepository;
protected IVendedorRepository vendedorrepository;
protected IDesafioRepository desafiorepository;
protected IInsigniaRepository insigniarepository;
protected IVideojuegoRepository videojuegorepository;
protected ICategoriaRepository categoriarepository;


public abstract IReporteRepository ReporteRepository {
        get;
}
public abstract IUsuarioRepository UsuarioRepository {
        get;
}
public abstract IModeradorRepository ModeradorRepository {
        get;
}
public abstract ISoporteRepository SoporteRepository {
        get;
}
public abstract IPedidoRepository PedidoRepository {
        get;
}
public abstract ITransaccionRepository TransaccionRepository {
        get;
}
public abstract IVendedorRepository VendedorRepository {
        get;
}
public abstract IDesafioRepository DesafioRepository {
        get;
}
public abstract IInsigniaRepository InsigniaRepository {
        get;
}
public abstract IVideojuegoRepository VideojuegoRepository {
        get;
}
public abstract ICategoriaRepository CategoriaRepository {
        get;
}
}
}
