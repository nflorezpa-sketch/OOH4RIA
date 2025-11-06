
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IUsuarioRepository
{
void setSessionCP (GenericSessionCP session);

UsuarioEN ReadOIDDefault (int id
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);



int Registrar (UsuarioEN usuario);

void EditarUsuario (UsuarioEN usuario);


void EliminarUsuario (int id
                      );




System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> FiltrarProductosPrecio (string arg0);






UsuarioEN ObtenerUsuarioPorID (int id
                               );


System.Collections.Generic.IList<UsuarioEN> ObtenerTodosUsuarios (int first, int size);



System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> ObtenerUsuariosPorInsignia (string arg0);
}
}
