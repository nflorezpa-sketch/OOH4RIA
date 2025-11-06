
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IPedidoRepository
{
void setSessionCP (GenericSessionCP session);

PedidoEN ReadOIDDefault (int id
                         );

void ModifyDefault (PedidoEN pedido);

System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size);




void EliminarPedido (int id
                     );




int NuevoPedido (PedidoEN pedido);

PedidoEN ObtenerProductoPorID (int id
                               );


System.Collections.Generic.IList<PedidoEN> ObtenerTodosPedidos (int first, int size);
}
}
