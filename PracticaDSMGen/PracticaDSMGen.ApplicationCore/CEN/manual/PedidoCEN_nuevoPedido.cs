
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Pedido_nuevoPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class PedidoCEN
{
public int NuevoPedido (float p_total, int p_transaccion, int p_usuario)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Pedido_nuevoPedido_customized) ENABLED START*/

        PedidoEN pedidoEN = null;
        int oid;

        if (p_total <= 0) {
                throw new ModelException ("El total del pedido debe ser mayor que 0.");
        }

        pedidoEN = new PedidoEN ();
        pedidoEN.Total = p_total;

        if (p_transaccion != -1) {
                pedidoEN.Transaccion = new PracticaDSMGen.ApplicationCore.EN.PracticaDSM.TransaccionEN ();
                pedidoEN.Transaccion.Id = p_transaccion;
        }

        if (p_usuario != -1) {
                pedidoEN.Usuario = new PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN ();
                pedidoEN.Usuario.Id = p_usuario;
        }

        oid = _IPedidoRepository.NuevoPedido (pedidoEN);
        return oid;

        /*PROTECTED REGION END*/
}
}
}
