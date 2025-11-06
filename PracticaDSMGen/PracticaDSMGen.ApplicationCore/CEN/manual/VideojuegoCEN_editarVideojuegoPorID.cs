
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_editarVideojuegoPorID) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class VideojuegoCEN
{
public void EditarVideojuegoPorID (int p_Videojuego_OID, double p_precio)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_editarVideojuegoPorID_customized) ENABLED START*/

        VideojuegoEN videojuegoEN = null;

        if (p_Videojuego_OID <= 0)
                throw new ModelException ("El ID del videojuego debe ser mayor a 0");

        if (p_precio <= 0)
                throw new ModelException ("El precio debe ser mayor a 0");

        // Obtener el videojuego existente para validaciones
        VideojuegoEN videojuegoExistente = _IVideojuegoRepository.ObtenerVideojuegoPorID (p_Videojuego_OID);

        if (videojuegoExistente == null)
                throw new ModelException ("Videojuego no encontrado");

        // No permitir editar si tiene pedidos activos
        if (videojuegoExistente.Pedido != null && videojuegoExistente.Pedido.Count > 0) {
                throw new ModelException ("No se puede editar un videojuego con pedidos asociados");
        }

        // No permitir editar si tiene desafios activos
        if (videojuegoExistente.Desafio != null && videojuegoExistente.Desafio.Count > 0) {
                throw new ModelException ("No se puede editar un videojuego con desaf�os asociados");
        }

        videojuegoEN = new VideojuegoEN ();
        videojuegoEN.Id = p_Videojuego_OID;
        videojuegoEN.Precio = p_precio;

        _IVideojuegoRepository.EditarVideojuegoPorID (videojuegoEN);

        /*PROTECTED REGION END*/
}
}
}
