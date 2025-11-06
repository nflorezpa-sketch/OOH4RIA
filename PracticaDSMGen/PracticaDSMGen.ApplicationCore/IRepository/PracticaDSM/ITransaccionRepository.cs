
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface ITransaccionRepository
{
void setSessionCP (GenericSessionCP session);

TransaccionEN ReadOIDDefault (int id
                              );

void ModifyDefault (TransaccionEN transaccion);

System.Collections.Generic.IList<TransaccionEN> ReadAllDefault (int first, int size);



int NuevaTransaccion (TransaccionEN transaccion);

void EditarTransaccionPorID (TransaccionEN transaccion);


void EliminarTransaccionPorID (int id
                               );


TransaccionEN ObtenerTransaccionPorID (int id
                                       );


System.Collections.Generic.IList<TransaccionEN> ObtenerTodasTransacciones (int first, int size);
}
}
