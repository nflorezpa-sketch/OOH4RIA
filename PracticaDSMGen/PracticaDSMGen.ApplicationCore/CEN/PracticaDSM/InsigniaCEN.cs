

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class InsigniaCEN
 *
 */
public partial class InsigniaCEN
{
private IInsigniaRepository _IInsigniaRepository;

public InsigniaCEN(IInsigniaRepository _IInsigniaRepository)
{
        this._IInsigniaRepository = _IInsigniaRepository;
}

public IInsigniaRepository get_IInsigniaRepository ()
{
        return this._IInsigniaRepository;
}

public InsigniaEN ObtenerInsigniaPorID (int id
                                        )
{
        InsigniaEN insigniaEN = null;

        insigniaEN = _IInsigniaRepository.ObtenerInsigniaPorID (id);
        return insigniaEN;
}

public System.Collections.Generic.IList<InsigniaEN> ObtenerTodasInsignias (int first, int size)
{
        System.Collections.Generic.IList<InsigniaEN> list = null;

        list = _IInsigniaRepository.ObtenerTodasInsignias (first, size);
        return list;
}
}
}
