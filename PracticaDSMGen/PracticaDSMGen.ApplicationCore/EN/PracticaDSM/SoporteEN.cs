
using System;
// Definición clase SoporteEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class SoporteEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo estado
 */
private PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoSoporteEnum estado;



/**
 *	Atributo moderador
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> moderador;



/**
 *	Atributo usuario
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoSoporteEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> Moderador {
        get { return moderador; } set { moderador = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public SoporteEN()
{
        moderador = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN>();
}



public SoporteEN(int id, string descripcion, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoSoporteEnum estado, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> moderador, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario
                 )
{
        this.init (Id, descripcion, estado, moderador, usuario);
}


public SoporteEN(SoporteEN soporte)
{
        this.init (soporte.Id, soporte.Descripcion, soporte.Estado, soporte.Moderador, soporte.Usuario);
}

private void init (int id
                   , string descripcion, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoSoporteEnum estado, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> moderador, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.Estado = estado;

        this.Moderador = moderador;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SoporteEN t = obj as SoporteEN;
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
