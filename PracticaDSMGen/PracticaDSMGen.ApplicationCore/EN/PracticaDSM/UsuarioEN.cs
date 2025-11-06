
using System;
// Definición clase UsuarioEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class UsuarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombreUsuario
 */
private string nombreUsuario;



/**
 *	Atributo correo
 */
private string correo;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo apodo
 */
private string apodo;



/**
 *	Atributo contraseña
 */
private String contraseña;



/**
 *	Atributo insignia
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia;



/**
 *	Atributo videojuego
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte;



/**
 *	Atributo soporte
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string NombreUsuario {
        get { return nombreUsuario; } set { nombreUsuario = value;  }
}



public virtual string Correo {
        get { return correo; } set { correo = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual string Apodo {
        get { return apodo; } set { apodo = value;  }
}



public virtual String Contraseña {
        get { return contraseña; } set { contraseña = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> Insignia {
        get { return insignia; } set { insignia = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> Videojuego {
        get { return videojuego; } set { videojuego = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> Soporte {
        get { return soporte; } set { soporte = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public UsuarioEN()
{
        insignia = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN>();
        videojuego = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN>();
        reporte = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN>();
        soporte = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN>();
        pedido = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN>();
}



public UsuarioEN(int id, string nombreUsuario, string correo, string telefono, string apodo, String contraseña, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido
                 )
{
        this.init (Id, nombreUsuario, correo, telefono, apodo, contraseña, insignia, videojuego, reporte, soporte, pedido);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Id, usuario.NombreUsuario, usuario.Correo, usuario.Telefono, usuario.Apodo, usuario.Contraseña, usuario.Insignia, usuario.Videojuego, usuario.Reporte, usuario.Soporte, usuario.Pedido);
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
        UsuarioEN t = obj as UsuarioEN;
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
