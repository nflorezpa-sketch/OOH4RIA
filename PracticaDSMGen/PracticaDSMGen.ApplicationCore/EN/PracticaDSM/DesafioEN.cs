
using System;
// Definición clase DesafioEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class DesafioEN
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
 *	Atributo insignia
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia;



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



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> Insignia {
        get { return insignia; } set { insignia = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> Videojuego {
        get { return videojuego; } set { videojuego = value;  }
}





public DesafioEN()
{
        insignia = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN>();
        videojuego = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN>();
}



public DesafioEN(int id, string nombre, string descripcion, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego
                 )
{
        this.init (Id, nombre, descripcion, insignia, videojuego);
}


public DesafioEN(DesafioEN desafio)
{
        this.init (desafio.Id, desafio.Nombre, desafio.Descripcion, desafio.Insignia, desafio.Videojuego);
}

private void init (int id
                   , string nombre, string descripcion, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.InsigniaEN> insignia, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.VideojuegoEN> videojuego)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Insignia = insignia;

        this.Videojuego = videojuego;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DesafioEN t = obj as DesafioEN;
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
