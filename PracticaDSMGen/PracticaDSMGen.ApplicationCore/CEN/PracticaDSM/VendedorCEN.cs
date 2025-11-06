

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class VendedorCEN
 *
 */
public partial class VendedorCEN
{
private IVendedorRepository _IVendedorRepository;

public VendedorCEN(IVendedorRepository _IVendedorRepository)
{
        this._IVendedorRepository = _IVendedorRepository;
}

public IVendedorRepository get_IVendedorRepository ()
{
        return this._IVendedorRepository;
}

public VendedorEN ObtenerVendedorPorID (int id
                                        )
{
        VendedorEN vendedorEN = null;

        vendedorEN = _IVendedorRepository.ObtenerVendedorPorID (id);
        return vendedorEN;
}
}
}
