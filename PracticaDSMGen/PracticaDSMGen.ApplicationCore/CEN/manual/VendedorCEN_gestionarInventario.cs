
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Vendedor_gestionarInventario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class VendedorCEN
{
public void GestionarInventario (int p_oid)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Vendedor_gestionarInventario) ENABLED START*/

        // Validaciones b�sicas
        if (p_oid <= 0)
                throw new ModelException ("El ID del vendedor debe ser mayor a 0");

        // Obtener el vendedor
        VendedorEN vendedor = _IVendedorRepository.ObtenerVendedorPorID (p_oid);
        if (vendedor == null)
                throw new ModelException ("Vendedor no encontrado");

        // Verificar que el vendedor tiene videojuegos en su inventario
        if (vendedor.Videojuego == null || vendedor.Videojuego.Count == 0)
                throw new ModelException ("El vendedor no tiene videojuegos en su inventario");

        // Mostrar estad�sticas b�sicas
        int totalVideojuegos = vendedor.Videojuego.Count;
        double gananciasTotales = 0;

        // Calcular ganancias totales (suma de precios de todos sus videojuegos)
        foreach (VideojuegoEN videojuego in vendedor.Videojuego) {
                gananciasTotales += videojuego.Precio;
        }

        // Aqui normalmente se mostrar�an las estad�sticas
        // Por ahora solo las calculamos
        Console.WriteLine ($"Estadisticas del vendedor:");
        Console.WriteLine ($"Total de videojuegos: {totalVideojuegos}");
        Console.WriteLine ($"Ganancias totales estimadas: {gananciasTotales}");

        /*PROTECTED REGION END*/
}
}
}
