
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Usuario_verDetallesCuenta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class UsuarioCEN
{
public void VerDetallesCuenta (int p_oid)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Usuario_verDetallesCuenta) ENABLED START*/

        // Validaciones b�sicas
        if (p_oid <= 0)
                throw new ModelException ("El ID del usuario debe ser mayor a 0");

        // Obtener el usuario
        UsuarioEN usuario = _IUsuarioRepository.ObtenerUsuarioPorID (p_oid);
        if (usuario == null)
                throw new ModelException ("Usuario no encontrado");

        // Mostrar detalles de la cuenta
        Console.WriteLine ($ "Detalles de la cuenta:");
        Console.WriteLine ($ "ID: {usuario.Id}");
        Console.WriteLine ($ "Nombre de usuario: {usuario.NombreUsuario}");
        Console.WriteLine ($ "Correo: {usuario.Correo}");
        Console.WriteLine ($ "Tel�fono: {usuario.Telefono}");
        Console.WriteLine ($ "Apodo: {usuario.Apodo}");

        // Mostrar estad�sticas de la cuenta
        if (usuario.Videojuego != null) {
                Console.WriteLine ($ "Videojuegos comprados: {usuario.Videojuego.Count}");
        }

        if (usuario.Pedido != null) {
                Console.WriteLine ($ "Pedidos realizados: {usuario.Pedido.Count}");
        }

        if (usuario.Insignia != null) {
                Console.WriteLine ($ "Insignias obtenidas: {usuario.Insignia.Count}");
        }

        if (usuario.Reporte != null) {
                Console.WriteLine ($ "Reportes realizados: {usuario.Reporte.Count}");
        }

        if (usuario.Soporte != null) {
                Console.WriteLine ($ "Tickets de soporte: {usuario.Soporte.Count}");
        }

        /*PROTECTED REGION END*/
}
}
}
