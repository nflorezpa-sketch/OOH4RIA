
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_eliminarVideojuegoPorID) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class VideojuegoCEN
{
public void EliminarVideojuegoPorID (int id
                                     )
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_eliminarVideojuegoPorID_customized) ENABLED START*/

        // Verificar que el ID sea v�lido
        if (id <= 0)
                throw new ModelException ("El ID del videojuego debe ser mayor a 0");

        // Obtener el videojuego para validaciones adicionales
        VideojuegoEN videojuegoEN = _IVideojuegoRepository.ObtenerVideojuegoPorID (id);

        // Verificar que el videojuego existe
        if (videojuegoEN == null)
                throw new ModelException ("Videojuego no encontrado");

        // No permitir eliminar si tiene desafios asociados
        if (videojuegoEN.Desafio != null && videojuegoEN.Desafio.Count > 0) {
                throw new ModelException ("No se puede eliminar el videojuego porque tiene desaf�os asociados");
        }

        // No permitir eliminar si tiene pedidos asociados
        if (videojuegoEN.Pedido != null && videojuegoEN.Pedido.Count > 0) {
                throw new ModelException ("No se puede eliminar el videojuego porque tiene pedidos asociados");
        }

        _IVideojuegoRepository.EliminarVideojuegoPorID (id);

        /*PROTECTED REGION END*/
}
}
}
