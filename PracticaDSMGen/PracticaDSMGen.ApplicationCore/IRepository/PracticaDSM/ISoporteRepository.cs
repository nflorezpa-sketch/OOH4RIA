
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface ISoporteRepository
{
void setSessionCP (GenericSessionCP session);

SoporteEN ReadOIDDefault (int id
                          );

void ModifyDefault (SoporteEN soporte);

System.Collections.Generic.IList<SoporteEN> ReadAllDefault (int first, int size);



System.Collections.Generic.IList<SoporteEN> ObtenerSoportes (int first, int size);


void EliminarSoporte (int id
                      );


SoporteEN ObtenerSoportePorID (int id
                               );



int NuevoSoporte (SoporteEN soporte);
}
}
