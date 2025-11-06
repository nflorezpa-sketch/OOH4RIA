
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IDesafioRepository
{
void setSessionCP (GenericSessionCP session);

DesafioEN ReadOIDDefault (int id
                          );

void ModifyDefault (DesafioEN desafio);

System.Collections.Generic.IList<DesafioEN> ReadAllDefault (int first, int size);



int CrearDesafio (DesafioEN desafio);

void EliminarDesafio (int id
                      );


DesafioEN ObtenerDesafioPorID (int id
                               );


System.Collections.Generic.IList<DesafioEN> ObtenerTodosDesafios (int first, int size);



System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> ObtenerDesafioPorVideojuego (int ? p_idVideojuego);
}
}
