
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Pedido_eliminarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class PedidoCEN
{
public void EliminarPedido (int id
                            )
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Pedido_eliminarPedido_customized) ENABLED START*/

        PedidoEN pedidoExistente = _IPedidoRepository.ReadOIDDefault (id);

        if (pedidoExistente == null) {
                throw new ModelException ($ "El pedido con ID {id} no existe y no puede ser eliminado.");
        }

        // (Opcional) Si tiene transacci�n asociada, impedir eliminarlo
        if (pedidoExistente.Transaccion != null) {
                throw new ModelException ("No se puede eliminar un pedido asociado a una transacci�n.");
        }

        // Eliminar
        _IPedidoRepository.EliminarPedido (id);

        /*PROTECTED REGION END*/
}
}
}
