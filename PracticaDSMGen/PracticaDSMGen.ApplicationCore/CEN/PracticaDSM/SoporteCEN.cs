

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class SoporteCEN
 *
 */
public partial class SoporteCEN
{
private ISoporteRepository _ISoporteRepository;

public SoporteCEN(ISoporteRepository _ISoporteRepository)
{
        this._ISoporteRepository = _ISoporteRepository;
}

public ISoporteRepository get_ISoporteRepository ()
{
        return this._ISoporteRepository;
}

public System.Collections.Generic.IList<SoporteEN> ObtenerSoportes (int first, int size)
{
        System.Collections.Generic.IList<SoporteEN> list = null;

        list = _ISoporteRepository.ObtenerSoportes (first, size);
        return list;
}
public void EliminarSoporte (int id
                             )
{
        _ISoporteRepository.EliminarSoporte (id);
}

public SoporteEN ObtenerSoportePorID (int id
                                      )
{
        SoporteEN soporteEN = null;

        soporteEN = _ISoporteRepository.ObtenerSoportePorID (id);
        return soporteEN;
}
}
}
