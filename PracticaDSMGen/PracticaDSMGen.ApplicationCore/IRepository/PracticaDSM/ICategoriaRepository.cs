
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface ICategoriaRepository
{
void setSessionCP (GenericSessionCP session);

CategoriaEN ReadOIDDefault (int id
                            );

void ModifyDefault (CategoriaEN categoria);

System.Collections.Generic.IList<CategoriaEN> ReadAllDefault (int first, int size);



int NuevaCategoria (CategoriaEN categoria);

void ModificarCategoriaPorID (CategoriaEN categoria);


void EliminarCategoriaPorID (int id
                             );


CategoriaEN ActualizarCategoriaPorID (int id
                                      );


System.Collections.Generic.IList<CategoriaEN> ObtenerTodasCategorias (int first, int size);


System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN> ObtenerVideojuegoPorNombre (string arg0);
}
}
