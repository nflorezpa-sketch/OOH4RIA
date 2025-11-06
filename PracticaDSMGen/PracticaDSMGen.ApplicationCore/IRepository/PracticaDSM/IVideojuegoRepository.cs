
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IVideojuegoRepository
{
void setSessionCP (GenericSessionCP session);

VideojuegoEN ReadOIDDefault (int id
                             );

void ModifyDefault (VideojuegoEN videojuego);

System.Collections.Generic.IList<VideojuegoEN> ReadAllDefault (int first, int size);



int NuevoVideojuego (VideojuegoEN videojuego);

void EditarVideojuegoPorID (VideojuegoEN videojuego);


void EliminarVideojuegoPorID (int id
                              );


VideojuegoEN ObtenerVideojuegoPorID (int id
                                     );


System.Collections.Generic.IList<VideojuegoEN> ObtenerTodosVideojuegos (int first, int size);
}
}
