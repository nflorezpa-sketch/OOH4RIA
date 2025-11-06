
using System;
// Definición clase VendedorEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class VendedorEN                                                                     : PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN


{
public VendedorEN() : base ()
{
}



public VendedorEN(int id,
                  string nombreUsuario, string correo, string telefono, string apodo, String contraseña, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido
                  )
{
        this.init (Id, nombreUsuario, correo, telefono, apodo, contraseña, insignia, videojuego, reporte, soporte, pedido);
}


public VendedorEN(VendedorEN vendedor)
{
        this.init (vendedor.Id, vendedor.NombreUsuario, vendedor.Correo, vendedor.Telefono, vendedor.Apodo, vendedor.Contraseña, vendedor.Insignia, vendedor.Videojuego, vendedor.Reporte, vendedor.Soporte, vendedor.Pedido);
}

private void init (int id
                   , string nombreUsuario, string correo, string telefono, string apodo, String contraseña, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido)
{
        this.Id = id;


        this.NombreUsuario = nombreUsuario;

        this.Correo = correo;

        this.Telefono = telefono;

        this.Apodo = apodo;

        this.Contraseña = contraseña;

        this.Insignia = insignia;

        this.Videojuego = videojuego;

        this.Reporte = reporte;

        this.Soporte = soporte;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VendedorEN t = obj as VendedorEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
