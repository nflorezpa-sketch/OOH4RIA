

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class DesafioCEN
 *
 */
public partial class DesafioCEN
{
private IDesafioRepository _IDesafioRepository;

public DesafioCEN(IDesafioRepository _IDesafioRepository)
{
        this._IDesafioRepository = _IDesafioRepository;
}

public IDesafioRepository get_IDesafioRepository ()
{
        return this._IDesafioRepository;
}

public DesafioEN ObtenerDesafioPorID (int id
                                      )
{
        DesafioEN desafioEN = null;

        desafioEN = _IDesafioRepository.ObtenerDesafioPorID (id);
        return desafioEN;
}

public System.Collections.Generic.IList<DesafioEN> ObtenerTodosDesafios (int first, int size)
{
        System.Collections.Generic.IList<DesafioEN> list = null;

        list = _IDesafioRepository.ObtenerTodosDesafios (first, size);
        return list;
}
public System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> ObtenerDesafioPorVideojuego (int ? p_idVideojuego)
{
        return _IDesafioRepository.ObtenerDesafioPorVideojuego (p_idVideojuego);
}
}
}
