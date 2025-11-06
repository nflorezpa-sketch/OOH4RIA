
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IInsigniaRepository
{
void setSessionCP (GenericSessionCP session);

InsigniaEN ReadOIDDefault (int id
                           );

void ModifyDefault (InsigniaEN insignia);

System.Collections.Generic.IList<InsigniaEN> ReadAllDefault (int first, int size);



InsigniaEN ObtenerInsigniaPorID (int id
                                 );


System.Collections.Generic.IList<InsigniaEN> ObtenerTodasInsignias (int first, int size);



int NuevaInsignia (InsigniaEN insignia);
}
}
