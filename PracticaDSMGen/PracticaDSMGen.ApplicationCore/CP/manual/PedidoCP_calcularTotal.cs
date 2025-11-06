
using System;
using System.Text;

using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CEN.PracticaDSM;



/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CP.PracticaDSM_Pedido_calcularTotal) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CP.PracticaDSM
{
public partial class PedidoCP : GenericBasicCP
{
public double CalcularTotal (int p_oid)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CP.PracticaDSM_Pedido_calcularTotal) ENABLED START*/

        PedidoCEN pedidoCEN = null;

        double result = 0.0;


        try
        {
                CPSession.SessionInitializeTransaction ();
                pedidoCEN = new PedidoCEN (CPSession.UnitRepo.PedidoRepository);



                PedidoEN pedido = pedidoCEN.get_IPedidoRepository ().ReadOIDDefault (p_oid);
                double total = 0;
                foreach (VideojuegoEN video in pedido.Videojuego) {
                        //sumar los videojuegos pedidos por un usuario
                        total += video.Precio;
                }
                result = total;


                CPSession.Commit ();
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
