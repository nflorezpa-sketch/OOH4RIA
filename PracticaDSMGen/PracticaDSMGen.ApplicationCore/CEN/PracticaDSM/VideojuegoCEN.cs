

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class VideojuegoCEN
 *
 */
public partial class VideojuegoCEN
{
private IVideojuegoRepository _IVideojuegoRepository;

public VideojuegoCEN(IVideojuegoRepository _IVideojuegoRepository)
{
        this._IVideojuegoRepository = _IVideojuegoRepository;
}

public IVideojuegoRepository get_IVideojuegoRepository ()
{
        return this._IVideojuegoRepository;
}

public VideojuegoEN ObtenerVideojuegoPorID (int id
                                            )
{
        VideojuegoEN videojuegoEN = null;

        videojuegoEN = _IVideojuegoRepository.ObtenerVideojuegoPorID (id);
        return videojuegoEN;
}

public System.Collections.Generic.IList<VideojuegoEN> ObtenerTodosVideojuegos (int first, int size)
{
        System.Collections.Generic.IList<VideojuegoEN> list = null;

        list = _IVideojuegoRepository.ObtenerTodosVideojuegos (first, size);
        return list;
}
}
}
