
using System;
using System.Text;

using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CEN.PracticaDSM;



/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CP.PracticaDSM_Pedido_nuevoPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CP.PracticaDSM
{
public partial class PedidoCP : GenericBasicCP
{
public PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN NuevoPedido (float p_total, int p_transaccion, int p_usuario)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CP.PracticaDSM_Pedido_nuevoPedido) ENABLED START*/

        PedidoCEN pedidoCEN = null;

        PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                pedidoCEN = new  PedidoCEN (CPSession.UnitRepo.PedidoRepository);




                int oid;
                //Initialized PedidoEN
                PedidoEN pedidoEN;
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



                oid = pedidoCEN.get_IPedidoRepository ().NuevoPedido (pedidoEN);

                result = pedidoCEN.get_IPedidoRepository ().ReadOIDDefault (oid);



                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
