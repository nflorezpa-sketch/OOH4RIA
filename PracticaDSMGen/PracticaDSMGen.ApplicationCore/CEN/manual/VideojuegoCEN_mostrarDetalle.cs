
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_mostrarDetalle) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
    public partial class VideojuegoCEN
    {
        public void MostrarDetalle(int p_oid)
        {
            /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Videojuego_mostrarDetalle) ENABLED START*/

            // Validaciones básicas
            if (p_oid <= 0)
                throw new ModelException("El ID del videojuego debe ser mayor a 0");

            // Obtener el videojuego
            VideojuegoEN videojuego = _IVideojuegoRepository.ObtenerVideojuegoPorID(p_oid);
            if (videojuego == null)
                throw new ModelException("Videojuego no encontrado");

            // Mostrar detalles del videojuego
            Console.WriteLine($"Detalles del videojuego:");
            Console.WriteLine($"ID: {videojuego.Id}");
            Console.WriteLine($"Precio: {videojuego.Precio}");

            
            if (videojuego.Categoria != null)
            {
                Console.WriteLine($"Categoría: {videojuego.Categoria.Nombre}");
            }

            // Mostrar informacion del vendedor si existe
            if (videojuego.Usuario != null)
            {
                Console.WriteLine($"Vendedor: {videojuego.Usuario.NombreUsuario}");
            }

            // Mostrar numero de pedidos asociados
            if (videojuego.Pedido != null)
            {
                Console.WriteLine($"Número de pedidos: {videojuego.Pedido.Count}");
            }

            // Mostrar numero de desafios asociados
            if (videojuego.Desafio != null)
            {
                Console.WriteLine($"Número de desafíos: {videojuego.Desafio.Count}");
            }

            /*PROTECTED REGION END*/
        }
    }
}
