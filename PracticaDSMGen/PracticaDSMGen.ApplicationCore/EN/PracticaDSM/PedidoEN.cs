
using System;
// Definición clase PedidoEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo total
 */
private float total;



/**
 *	Atributo transaccion
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.TransaccionEN transaccion;



/**
 *	Atributo videojuego
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego;



/**
 *	Atributo usuario
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Total {
        get { return total; } set { total = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.TransaccionEN Transaccion {
        get { return transaccion; } set { transaccion = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> Videojuego {
        get { return videojuego; } set { videojuego = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public PedidoEN()
{
        videojuego = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN>();
}



public PedidoEN(int id, float total, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.TransaccionEN transaccion, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario
                )
{
        this.init (Id, total, transaccion, videojuego, usuario);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (pedido.Id, pedido.Total, pedido.Transaccion, pedido.Videojuego, pedido.Usuario);
}

private void init (int id
                   , float total, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.TransaccionEN transaccion, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario)
{
        this.Id = id;


        this.Total = total;

        this.Transaccion = transaccion;

        this.Videojuego = videojuego;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
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
