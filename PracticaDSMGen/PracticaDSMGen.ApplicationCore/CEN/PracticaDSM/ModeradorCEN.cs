

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class ModeradorCEN
 *
 */
public partial class ModeradorCEN
{
private IModeradorRepository _IModeradorRepository;

public ModeradorCEN(IModeradorRepository _IModeradorRepository)
{
        this._IModeradorRepository = _IModeradorRepository;
}

public IModeradorRepository get_IModeradorRepository ()
{
        return this._IModeradorRepository;
}
}
}
