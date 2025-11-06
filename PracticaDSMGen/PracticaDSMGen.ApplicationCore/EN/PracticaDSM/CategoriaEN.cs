
using System;
// Definición clase CategoriaEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class CategoriaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo videojuego
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> Videojuego {
        get { return videojuego; } set { videojuego = value;  }
}





public CategoriaEN()
{
        videojuego = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN>();
}



public CategoriaEN(int id, string nombre, string descripcion, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego
                   )
{
        this.init (Id, nombre, descripcion, videojuego);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (categoria.Id, categoria.Nombre, categoria.Descripcion, categoria.Videojuego);
}

private void init (int id
                   , string nombre, string descripcion, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Videojuego = videojuego;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
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
