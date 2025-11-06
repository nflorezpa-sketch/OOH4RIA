
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IModeradorRepository
{
void setSessionCP (GenericSessionCP session);

ModeradorEN ReadOIDDefault (int id
                            );

void ModifyDefault (ModeradorEN moderador);

System.Collections.Generic.IList<ModeradorEN> ReadAllDefault (int first, int size);






int NuevoModerador (ModeradorEN moderador);
}
}
