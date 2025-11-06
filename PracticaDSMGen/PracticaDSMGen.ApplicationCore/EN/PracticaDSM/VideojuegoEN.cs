
using System;
// Definición clase VideojuegoEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class VideojuegoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo categoria
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN categoria;



/**
 *	Atributo usuario
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido;



/**
 *	Atributo desafio
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> desafio;



/**
 *	Atributo precio
 */
private double precio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> Desafio {
        get { return desafio; } set { desafio = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}





public VideojuegoEN()
{
        pedido = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN>();
        desafio = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN>();
}



public VideojuegoEN(int id, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN categoria, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> desafio, double precio
                    )
{
        this.init (Id, categoria, usuario, pedido, desafio, precio);
}


public VideojuegoEN(VideojuegoEN videojuego)
{
        this.init (videojuego.Id, videojuego.Categoria, videojuego.Usuario, videojuego.Pedido, videojuego.Desafio, videojuego.Precio);
}

private void init (int id
                   , PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN categoria, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN> pedido, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> desafio, double precio)
{
        this.Id = id;


        this.Categoria = categoria;

        this.Usuario = usuario;

        this.Pedido = pedido;

        this.Desafio = desafio;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VideojuegoEN t = obj as VideojuegoEN;
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
