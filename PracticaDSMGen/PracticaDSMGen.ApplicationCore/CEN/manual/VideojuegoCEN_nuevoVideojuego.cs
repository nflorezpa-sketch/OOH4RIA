
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_nuevoVideojuego) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class VideojuegoCEN
{
public int NuevoVideojuego (System.Collections.Generic.IList<int> p_pedido, double p_precio)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_nuevoVideojuego_customized) ENABLED START*/

        VideojuegoEN videojuegoEN = null;

        int oid;

        // Validaciones
        if (p_precio <= 0)
                throw new ModelException ("El precio debe ser mayor a 0");

        // Verificar que la lista de pedidos no sea null
        if (p_pedido == null)
                throw new ModelException ("La lista de pedidos no puede ser nula");

        // Verificar que todos los pedidos existan
        foreach (int pedidoId in p_pedido) {
                if (pedidoId <= 0)
                        throw new ModelException ("El ID del pedido debe ser mayor a 0");
        }

        //Initialized VideojuegoEN
        videojuegoEN = new VideojuegoEN ();

        videojuegoEN.Pedido = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN>();
        if (p_pedido != null && p_pedido.Count > 0) {
                foreach (int item in p_pedido) {
                        PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN en = new PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN ();
                        en.Id = item;
                        videojuegoEN.Pedido.Add (en);
                }
        }
        else{
                videojuegoEN.Pedido = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN>();
        }

        videojuegoEN.Precio = p_precio;

        oid = _IVideojuegoRepository.NuevoVideojuego (videojuegoEN);


        return oid;
        /*PROTECTED REGION END*/
}
}
}
