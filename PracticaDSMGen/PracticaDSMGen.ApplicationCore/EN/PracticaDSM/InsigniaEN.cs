
using System;
// Definición clase InsigniaEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class InsigniaEN
{
/**
 *	Atributo perfil
 */
private PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoInsigniaEnum perfil;



/**
 *	Atributo rutaDeImg
 */
private string rutaDeImg;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo desafio
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> desafio;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> usuario;






public virtual PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoInsigniaEnum Perfil {
        get { return perfil; } set { perfil = value;  }
}



public virtual string RutaDeImg {
        get { return rutaDeImg; } set { rutaDeImg = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> Desafio {
        get { return desafio; } set { desafio = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public InsigniaEN()
{
        desafio = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN>();
        usuario = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN>();
}



public InsigniaEN(int id, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoInsigniaEnum perfil, string rutaDeImg, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> desafio, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> usuario
                  )
{
        this.init (Id, perfil, rutaDeImg, desafio, usuario);
}


public InsigniaEN(InsigniaEN insignia)
{
        this.init (insignia.Id, insignia.Perfil, insignia.RutaDeImg, insignia.Desafio, insignia.Usuario);
}

private void init (int id
                   , PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoInsigniaEnum perfil, string rutaDeImg, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> desafio, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> usuario)
{
        this.Id = id;


        this.Perfil = perfil;

        this.RutaDeImg = rutaDeImg;

        this.Desafio = desafio;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InsigniaEN t = obj as InsigniaEN;
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
